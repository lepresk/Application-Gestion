Imports MySql.Data.MySqlClient

Public Class ListeFactures

    Private Sub LoadDatas(Optional dateDu As Date? = Nothing, Optional dateAu As Date? = Nothing, Optional num As String = Nothing)
        Try

            ListViewFactures.Items.Clear()

            Dim sql As String = String.Empty
            Dim cmd As MySqlCommand = Nothing

            If IsNothing(dateDu) And IsNothing(dateAu) And IsNothing(num) Then
                sql = "SELECT factures.id, factures.numero, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, CONCAT_WS(' ', employes.nom, employes.prenom) AS employe, factures.date_creation, SUM(t.pu * t.qte) AS total FROM factures INNER JOIN clients ON factures.client_id = clients.id INNER JOIN employes ON factures.employe_id = employes.id INNER JOIN transition_fac_produits t ON factures.id = t.facture_id GROUP BY factures.id"
                cmd = BaseDeDonnes.GetCommand(sql)
            ElseIf IsNothing(num) Then
                sql = "SELECT factures.id, factures.numero, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, CONCAT_WS(' ', employes.nom, employes.prenom) AS employe, factures.date_creation, SUM(t.pu * t.qte) AS total FROM factures INNER JOIN clients ON factures.client_id = clients.id INNER JOIN employes ON factures.employe_id = employes.id INNER JOIN transition_fac_produits t ON factures.id = t.facture_id WHERE DATE(factures.date_creation) BETWEEN @date_du AND @date_au GROUP BY factures.id"

                Dim d1 As String = dateDu.Value.Year & "-" & dateDu.Value.Month & "-" & dateDu.Value.Day
                Dim d2 As String = String.Format("{0}-{1}-{2}", dateAu.Value.Year, dateAu.Value.Month, dateAu.Value.Day)

                cmd = BaseDeDonnes.GetCommand(sql)
                cmd.Parameters.AddWithValue("@date_du", d1)
                cmd.Parameters.AddWithValue("@date_au", d2)

            Else
                sql = "SELECT factures.id, factures.numero, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, CONCAT_WS(' ', employes.nom, employes.prenom) AS employe, factures.date_creation, SUM(t.pu * t.qte) AS total FROM factures INNER JOIN clients ON factures.client_id = clients.id INNER JOIN employes ON factures.employe_id = employes.id INNER JOIN transition_fac_produits t ON factures.id = t.facture_id WHERE factures.numero LIKE '" & num & "%' GROUP BY factures.id"

                cmd = BaseDeDonnes.GetCommand(sql)
            End If

            Dim result = cmd.ExecuteReader()
            Dim total As Decimal = 0
            Dim index As Integer = 0

            While result.Read
                Dim item As New ListViewItem(result.GetString("id"))
                item.SubItems.Add(result.GetString("numero"))
                item.SubItems.Add(result.GetString("client"))
                item.SubItems.Add(result.GetString("employe"))
                item.SubItems.Add(result.GetString("date_creation"))

                Dim t As Decimal = result.GetDecimal("total")
                total += t

                item.SubItems.Add(FormatNumber(t, 0))

                If Math.IEEERemainder(index, 2) <> 0 Then
                    item.BackColor = Color.AliceBlue
                End If

                ListViewFactures.Items.Add(item)

                index += 1
            End While

            result.Close()
            cmd.Connection.Close()

            lblTotal.Text = FormatNumber(total, 0)

        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Private Sub ListeFactures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dateDu As Date = New Date(Now.Year, Now.Month, Now.Day)
        Dim dateAu As Date = New Date(Now.Year, Now.Month, Now.Day)
        LoadDatas(dateDu, dateAu)
    End Sub

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Close()
    End Sub

    Private Sub btnRecu_Click(sender As Object, e As EventArgs) Handles btnRecu.Click
        Try
            Dim id As String = ListViewFactures.SelectedItems(0).Text
            Dim form As New RapportRecu
            form.FactureId = id
            form.ShowDialog()
        Catch ex As Exception
            MsgBox("Veuillez selectionner une ligne")
        End Try
    End Sub

    Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
        Dim num As String = txtNumero.Text
        If num.Trim().Length() > 0 Then
            LoadDatas(dateDebut.Value, dateFin.Value, num)
        Else
            LoadDatas(dateDebut.Value, dateFin.Value)
        End If

    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        Dim num As String = txtNumero.Text
        If num.Trim().Length() > 0 Then
            LoadDatas(dateDebut.Value, dateFin.Value, num)
        Else
            LoadDatas()
        End If
    End Sub

    Private Sub btnRapport_Click(sender As Object, e As EventArgs) Handles btnRapport.Click
        Dim form As New RapportFactures
        form.ListViewFactures = ListViewFactures
        form.ShowDialog()
    End Sub
End Class