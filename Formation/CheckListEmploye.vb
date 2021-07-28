Imports System.Linq

Public Class CheckListEmploye

    Private lstEmployes As List(Of Employe) = New List(Of Employe)

    Private Sub CheckListEmploye_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckedListBox1.Items.Clear()

        Dim sql = "SELECT id, nom, prenom, poste, bureau, salaire, date_embauche, permanence FROM employes"
        Dim cmd = BaseDeDonnes.GetCommand(sql)
        Dim resultat = cmd.ExecuteReader()
        While resultat.Read
            Dim emp As Employe = New Employe()
            emp.Id = resultat.GetInt32("id")
            emp.Nom = resultat.GetString("nom")
            emp.Prenom = resultat.GetString("prenom")

            lstEmployes.Add(emp)
        End While

        CheckedListBox1.DataSource = lstEmployes
        CheckedListBox1.DisplayMember = "NomComplet"
        CheckedListBox1.ValueMember = "Id"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item In CheckedListBox1.CheckedItems
            Dim emp = CType(item, Employe)
            If emp IsNot Nothing Then
                MsgBox(emp.Id)
            End If
        Next
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck

        Dim emp = TryCast(CheckedListBox1.Items.Item(e.Index), Employe)

        If emp Is Nothing Then
            MsgBox("Element invalide, ne peut etre covertis en employer")
            Exit Sub
        End If

        If e.NewValue = CheckState.Checked Then
            MsgBox("L'employer " & emp.NomComplet & " id : " & emp.Id & " a ete cocher")
        ElseIf e.NewValue = CheckState.Unchecked Then
            MsgBox("L'employer " & emp.NomComplet & " id : " & emp.Id & " a ete decocher")
        End If

    End Sub

End Class