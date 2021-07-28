Public Class Main

    Private Sub NouveauToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem1.Click
        Dim form As New Factures
        form.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        Dim form As New Employes
        form.ShowDialog()
    End Sub

    Private Sub ListeDesEmployesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesEmployesToolStripMenuItem.Click
        Dim form As New ListeEmployes
        form.ShowDialog()
    End Sub

    Private Sub ListeDesFacturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesFacturesToolStripMenuItem.Click
        Dim form As New ListeFactures
        form.ShowDialog()
    End Sub

    Private Sub BaseDeDonneesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseDeDonneesToolStripMenuItem.Click
        Dim form As New ParametreDb()
        form.ShowDialog()
    End Sub

    Private Sub ParametresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParametresToolStripMenuItem1.Click
        Dim form As New Parametres
        form.ShowDialog()
    End Sub
End Class