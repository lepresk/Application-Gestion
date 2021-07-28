Imports MySql.Data.MySqlClient

Public Class Factures

    ''' <summary>
    ''' Id de la facture en cours d'edition
    ''' </summary>
    ''' <returns></returns>
    Private Property FactureId As Integer = 0

    ''' <summary>
    ''' La connexion utilise pour les requetes sql
    ''' </summary>
    ''' <returns></returns>
    Private Property Connection As MySqlConnection

    ''' <summary>
    ''' La transaction globalle
    ''' </summary>
    ''' <returns></returns>
    Private Property Transaction As MySqlTransaction

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="e"></param>
    Public Sub Form_Load(source As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connection = BaseDeDonnes.GetConnection()
            Transaction = Connection.BeginTransaction()

            Dim cmd = Connection.CreateCommand()
            cmd.CommandText = "INSERT INTO factures (date_creation) VALUE (@dt)"
            cmd.Parameters.AddWithValue("@dt", Now)
            cmd.ExecuteNonQuery()
            FactureId = cmd.LastInsertedId()

            cmd.CommandText = "SELECT numero FROM factures WHERE id = @id"
            cmd.Parameters.AddWithValue("@id", FactureId)
            Dim result = cmd.ExecuteReader()
            result.Read()
            txtNumero.Text = result.GetString("numero")
            result.Close()

            cmd.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try


        PopulateComboProduit()

        Util.PopulateCombo(cmbClients, "SELECT id, CONCAT_WS(' ', nom, prenom) AS nom FROM clients", "nom", "id")

        Util.PopulateCombo(cmbEmployes, "SELECT id, CONCAT_WS(' ', nom, prenom) AS nom FROM employes", "nom", "id")
    End Sub

    ''' <summary>
    ''' Remplissage du combobox des produits
    ''' </summary>
    Public Sub PopulateComboProduit()
        Try
            Dim sql As String = "SELECT id, description, qte_disponible, prix_unitaire FROM produits"
            Dim cmd As MySqlCommand = Connection.CreateCommand()
            cmd.Transaction = Transaction
            cmd.CommandText = sql
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim datatTable As DataTable = New DataTable()
            adapter.Fill(datatTable)

            Dim row = datatTable.NewRow()
            row("id") = 0
            row("description") = "..."
            row("qte_disponible") = 0
            row("prix_unitaire") = 0

            datatTable.Rows.InsertAt(row, 0)

            cmbProduits.DataSource = datatTable
            cmbProduits.DisplayMember = "description"
            cmbProduits.ValueMember = "id"

            cmbPu.DataSource = datatTable
            cmbPu.DisplayMember = "prix_unitaire"
            cmbPu.ValueMember = "id"

            cmbQte.DataSource = datatTable
            cmbQte.DisplayMember = "qte_disponible"
            cmbQte.ValueMember = "id"

            adapter.Dispose()
            cmd.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub


    Private Sub cmbPu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPu.SelectedIndexChanged
        If IsNumeric(cmbPu.SelectedValue) Then
            txtPu.Text = cmbPu.Text
        End If
    End Sub

    ''' <summary>
    ''' Ajout d'une nouvelle ligne dans le tableau
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        If Not IsNumeric(txtQte.Text) OrElse CInt(txtQte.Text) <= 0 Then
            MsgBox("Veuillez entrer la quantite !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        If Not IsNumeric(cmbProduits.SelectedValue) OrElse cmbProduits.SelectedValue = "0" Then
            MsgBox("Veuillez selectionner le produit !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim qteStock = CInt(cmbQte.Text)
        Dim qteSaie = CInt(txtQte.Text)

        If qteSaie > qteStock Then
            MsgBox("La quantie trop elever !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try

            Dim sql As String = "UPDATE produits SET qte_disponible = @qte WHERE id = @id"
            Dim cmd = Connection.CreateCommand()
            cmd.CommandText = sql
            cmd.Transaction = Transaction

            cmd.Parameters.AddWithValue("@qte", qteStock - qteSaie)
            cmd.Parameters.AddWithValue("@id", cmbProduits.SelectedValue)

            cmd.ExecuteNonQuery()

            sql = "INSERT INTO transition_fac_produits (facture_id, produit_id, qte, pu) VALUE (@fid, @pid, @qte, @pu)"

            cmd = Connection.CreateCommand()
            cmd.CommandText = sql
            cmd.Transaction = Transaction

            cmd.Parameters.AddWithValue("@fid", FactureId)
            cmd.Parameters.AddWithValue("@pid", cmbProduits.SelectedValue)
            cmd.Parameters.AddWithValue("@qte", qteSaie)
            cmd.Parameters.AddWithValue("@pu", cmbPu.Text)
            cmd.ExecuteNonQuery()

            Dim transition_fac_produit_id = cmd.LastInsertedId()
            cmd.Dispose()

            Dim total As Integer = CInt(txtPu.Text) * qteSaie
            Dim item As New ListViewItem(cmbProduits.SelectedValue.ToString())
            item.SubItems.Add(cmbProduits.Text)
            item.SubItems.Add(FormatNumber(qteSaie, 0))
            item.SubItems.Add(FormatNumber(cmbPu.Text, 0))
            item.SubItems.Add(FormatNumber(total, 0))
            item.SubItems.Add(transition_fac_produit_id)

            ListViewPanier.Items.Add(item)
            txtQte.Text = "0"

            PopulateComboProduit()

        Catch ex As Exception
            ManageError(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Suppression d'une ligne du tableau
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            Dim selectedItem = ListViewPanier.SelectedItems(0)

            Dim produit_id = selectedItem.Text
            Dim qte = selectedItem.SubItems(2).Text
            Dim idTransFacProduit = selectedItem.SubItems(5).Text


            Dim sql As String = "UPDATE produits SET qte_disponible = qte_disponible + @qte WHERE id = @id"
            Dim cmd = Connection.CreateCommand()
            cmd.CommandText = sql
            cmd.Transaction = Transaction

            cmd.Parameters.AddWithValue("@qte", qte)
            cmd.Parameters.AddWithValue("@id", produit_id)
            cmd.ExecuteNonQuery()

            cmd = Connection.CreateCommand()
            cmd.CommandText = "DELETE FROM transition_fac_produits WHERE id = @id"
            cmd.Parameters.AddWithValue("@id", idTransFacProduit)
            cmd.Transaction = Transaction
            cmd.ExecuteNonQuery()

            ListViewPanier.Items.Remove(selectedItem)

            PopulateComboProduit()

        Catch ex As Exception
            MsgBox("Veuillez selectionner un element!", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' Enregistrement de la facture
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click

        If cmbClients.SelectedValue <= 0 OrElse cmbEmployes.SelectedValue <= 0 Then
            MsgBox("Veuillez selectionner le client ou l'employe !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim sql As String = "UPDATE factures SET date_creation = @dt, client_id = @cid, employe_id = @eid, numero = @num WHERE id = @id"
            Dim cmd = Connection.CreateCommand()
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@dt", txtDateCreation.Value)
            cmd.Parameters.AddWithValue("@cid", cmbClients.SelectedValue)
            cmd.Parameters.AddWithValue("@eid", cmbEmployes.SelectedValue)
            cmd.Parameters.AddWithValue("@num", txtNumero.Text)
            cmd.Parameters.AddWithValue("@id", FactureId)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            ' validation des changements
            Transaction.Commit()

            Connection.Close()
            MsgBox("Facture enregistré avec succès!", MsgBoxStyle.Information)
            Close()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Close()
    End Sub
End Class