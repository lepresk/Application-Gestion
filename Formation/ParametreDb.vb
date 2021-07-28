Imports MySql.Data.MySqlClient

Public Class ParametreDb
    Private Sub ParametreDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServeur.Text = My.Settings.db_serveur
        txtBd.Text = My.Settings.db_nom
        txtUser.Text = My.Settings.db_user
        txtPass.Text = My.Settings.db_pass
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.db_serveur = txtServeur.Text
        My.Settings.db_nom = txtBd.Text
        My.Settings.db_user = txtUser.Text
        My.Settings.db_pass = txtPass.Text
        My.Settings.Save()
        'My.Settings.Upgrade()
        My.Settings.Reload()
        MsgBox("Enregistrement effectuer avec success!", MsgBoxStyle.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim chaineConnection As String = String.Format("Datasource={0};Database={1};User id={2};password={3}", txtServeur.Text, txtBd.Text, txtUser.Text, txtPass.Text)
            Dim cnx As MySqlConnection = New MySqlConnection(chaineConnection)
            cnx.Open()
            cnx.Close()
            MsgBox("Bon parametres !")
        Catch ex As MySqlException
            MsgBox("Impossible de se connecter : " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Erreur inconnu : " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class