Public Class ListeEmployes

    Private Sub RemplirListe()
        Try
            ListViewEmployes.Items.Clear()
            Dim sql = "SELECT id, nom, prenom, poste, bureau, salaire, date_embauche, permanence FROM employes"
            Dim cmd = BaseDeDonnes.GetCommand(sql)
            Dim resultat = cmd.ExecuteReader()
            While resultat.Read
                Dim item As New ListViewItem(resultat.GetInt32("id"))
                item.SubItems.Add(resultat.GetString("nom"))
                item.SubItems.Add(resultat.GetString("prenom"))
                item.SubItems.Add(resultat.GetString("poste"))
                item.SubItems.Add(resultat.GetString("bureau"))
                item.SubItems.Add(resultat.GetString("salaire"))
                item.SubItems.Add(resultat.GetString("date_embauche"))

                Dim permanent As Boolean = resultat.GetBoolean("permanence")

                If permanent = True Then
                    item.SubItems.Add("Oui")
                Else
                    item.SubItems.Add("Nom")
                End If
                ListViewEmployes.Items.Add(item)
            End While
            resultat.Close()
            cmd.Connection.Close()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Private Sub btnActualiser_Click(sender As Object, e As EventArgs) Handles btnActualiser.Click
        RemplirListe()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim form As New Employes
        form.ShowDialog()
        RemplirListe()
    End Sub

    Private Sub ListeEmployes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirListe()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Try
            Dim selectedId = ListViewEmployes.SelectedItems(0).Text
            Dim form As New Employes
            form.Id = selectedId
            form.ShowDialog()
            RemplirListe()
        Catch ex As Exception
            MsgBox("Veuillez selectionner un element sur la liste", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try
            Dim selectedId = ListViewEmployes.SelectedItems(0).Text
            Dim sql As String = "DELETE FROM employes WHERE id = @id"
            Dim cmd = BaseDeDonnes.GetCommand(sql)
            cmd.Parameters.AddWithValue("@id", selectedId)
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            RemplirListe()
            MsgBox("Suppression effectuer avec success !", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Veuillez selectionner un element sur la liste", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ListViewEmployes_ItemActivate(sender As Object, e As EventArgs) Handles ListViewEmployes.ItemActivate
        Try
            Dim selectedId = ListViewEmployes.SelectedItems(0).Text
            Dim form As New Employes
            form.Id = selectedId
            form.ShowDialog()
            RemplirListe()
        Catch ex As Exception
            MsgBox("Veuillez selectionner un element sur la liste", MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub ListViewEmployes_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListViewEmployes.ItemSelectionChanged
        If e.IsSelected Then
            TextBox1.Text = e.Item.SubItems(1).Text
        End If
    End Sub
End Class
