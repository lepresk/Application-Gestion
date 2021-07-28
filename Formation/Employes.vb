Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.Win32
Imports Formation

Public Class Employes

    ''' <summary>
    ''' L'id de l'element a modifier
    ''' </summary>
    ''' <returns></returns>
    Public Property Id As Integer = 0

    Private Property ImageChanged As Boolean = False

    Private Sub btnFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim sql As String = String.Empty
            Dim cmd As MySqlCommand = BaseDeDonnes.GetConnection.CreateCommand

            If Id = 0 Then
                sql = "INSERT INTO employes SET nom = @nom, prenom = @prenom, poste = @poste, bureau = @bureau, salaire = @salaire, date_embauche = @date_embauche, permanence = @permanence, commentaire = @commentaire "
            Else
                sql = "UPDATE employes SET nom = @nom, prenom = @prenom, poste = @poste, bureau = @bureau, salaire = @salaire, date_embauche = @date_embauche, permanence = @permanence, commentaire = @commentaire "
            End If

            cmd.Parameters.AddWithValue("@nom", txtNom.Text)
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text)
            cmd.Parameters.AddWithValue("@poste", cmbPoste.Text)
            cmd.Parameters.AddWithValue("@bureau", txtBureau.Text)
            cmd.Parameters.AddWithValue("@salaire", txtSalaire.Text)
            cmd.Parameters.AddWithValue("@date_embauche", txtDateEmbauche.Value)
            cmd.Parameters.AddWithValue("@permanence", ckPermanent.Checked)
            cmd.Parameters.AddWithValue("@commentaire", txtCommentaire.Text)

            If ImageChanged = True Then

                sql &= ", photo = @photo "
                Dim content = Util.GetBytesFromFile(picPhoto.ImageLocation)
                cmd.Parameters.AddWithValue("@photo", content)
            End If

            If Id > 0 Then
                sql &= " WHERE id = @id "
                cmd.Parameters.AddWithValue("@id", Id)
            End If

            cmd.CommandText = sql

            Dim affectedRows = cmd.ExecuteNonQuery()

            If affectedRows > 0 Then

                cmd.Connection.Close()
                MsgBox("Enregistrement effectuer avec success", MsgBoxStyle.Information)
                Close()
            Else
                MsgBox("Une erreur est survenue !", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub



    Private Sub Employes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Id > 0 Then
            Try
                Dim sql As String = "SELECT id, nom, prenom, poste, bureau, salaire, date_embauche, permanence, commentaire, photo FROM employes WHERE id = @id"
                Dim cmd As MySqlCommand = BaseDeDonnes.GetCommand(sql)
                cmd.Parameters.AddWithValue("@id", Id)
                Dim resultat = cmd.ExecuteReader()

                Dim photo As Byte() = Nothing

                If resultat.HasRows Then
                    resultat.Read()
                    txtNom.Text = resultat.GetString("nom")
                    txtPrenom.Text = resultat.GetString("prenom")
                    cmbPoste.Text = resultat.GetString("poste")
                    txtBureau.Text = resultat.GetString("bureau")
                    txtSalaire.Text = resultat.GetString("salaire")
                    txtDateEmbauche.Value = resultat.GetDateTime("date_embauche")
                    ckPermanent.Checked = resultat.GetBoolean("permanence")
                    txtCommentaire.Text = resultat.GetString("commentaire")
                    photo = resultat("photo")
                End If


                If photo.Length > 0 Then
                    Dim mem As MemoryStream = New MemoryStream(photo)
                    Dim img As Image = Image.FromStream(mem)
                    picPhoto.Image = img
                End If

                resultat.Close()
                cmd.Connection.Close()
            Catch ex As Exception
                ManageError(ex)
            End Try
            btnAdd.Text = "Modifier"
            labelTitre.Text = "Modification employee"
        End If
    End Sub

    Private Sub btnParcourir_Click(sender As Object, e As EventArgs) Handles btnParcourir.Click
        Try
            Dim fd As OpenFileDialog = New OpenFileDialog()
            fd.Filter = "Image PNG(*png)|*.png|Image JPG|*.jpg|Image GIF|*.gif"
            If fd.ShowDialog() = DialogResult.OK Then

                Dim content = Util.GetBytesFromFile(fd.FileName)

                If content.Length > ((1024 * 1024) * 2) Then
                    MsgBox("Le fichier ne peut pas depasser 2Mo !", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                picPhoto.ImageLocation = fd.FileName
                ImageChanged = True
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

End Class