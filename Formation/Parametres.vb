Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Parametres

    Private ImageChanged As Boolean = False

    Private Sub LoadData()
        Try
            Dim sql As String = "SELECT nom_societe, tel_societe, photo, type_photo FROM parametrages"
            Dim cmd As MySqlCommand = BaseDeDonnes.GetCommand(sql)
            Dim result = cmd.ExecuteReader()

            Dim photo As Byte()

            If result.HasRows Then
                result.Read()
                txtSociete.Text = result.Item("nom_societe")
                txtTel.Text = result.Item("tel_societe")
                txtType.Text = If(result("type_photo") Is DBNull.Value, "", result("type_photo"))

                photo = If(result("photo") Is DBNull.Value, New Byte() {}, result("photo"))
                If photo.Length > 0 Then
                    imgLogo.Image = Image.FromStream(New MemoryStream(photo))
                End If
            End If
            result.Close()
            cmd.Connection.Close()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Parametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fdialog As OpenFileDialog = New OpenFileDialog()
        fdialog.Filter = "Fichier image|*.jpg;*.png"
        If fdialog.ShowDialog() = DialogResult.OK Then
            Dim content = Util.GetBytesFromFile(fdialog.FileName)
            If content.Length > ((1024 * 1024) * 2) Then
                MsgBox("Le fichier ne peut pas depasser 2Mo !", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            imgLogo.ImageLocation = fdialog.FileName

            Dim extension As String = Path.GetExtension(fdialog.FileName)
            If extension = ".jpg" Then
                txtType.Text = "image/jpeg"
            Else
                txtType.Text = "image/png"
            End If

            ImageChanged = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sql As String = "UPDATE parametrages SET nom_societe = @soc, tel_societe = @tel, type_photo = @type"
            Dim cmd = BaseDeDonnes.GetConnection.CreateCommand()
            cmd.Parameters.AddWithValue("@soc", txtSociete.Text)
            cmd.Parameters.AddWithValue("@tel", txtTel.Text)
            cmd.Parameters.AddWithValue("@type", txtType.Text)

            If ImageChanged = True Then
                sql &= ", photo = @photo "
                Dim content = Util.GetBytesFromFile(imgLogo.ImageLocation)
                cmd.Parameters.AddWithValue("@photo", content)
            End If

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("Enregistrement effectuer !", MsgBoxStyle.Information)
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub
End Class