Imports MySql.Data.MySqlClient
Imports System.IO

Module Util

    Public Sub ManageError(ex As Exception)
        MsgBox("Echec de connexion à la base de données : " & ex.ToString)
    End Sub

    ''' <summary>
    ''' Permet de remplir un combobox
    ''' </summary>
    ''' <param name="cmb">Le combobox a remplir</param>
    ''' <param name="sql">La requete sql a executer</param>
    ''' <param name="displayMember">Le champ qui va etre utiliser pour afficher le text</param>
    ''' <param name="valueMember">Le champ qui va contenir la valeur du combobox</param>
    Public Sub PopulateCombo(cmb As ComboBox, sql As String, displayMember As String, valueMember As String)
        Try
            Dim cmd As MySqlCommand = BaseDeDonnes.GetCommand(sql)
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim datatTable As DataTable = New DataTable()
            adapter.Fill(datatTable)

            Dim row = datatTable.NewRow()
            row(valueMember) = 0
            row(displayMember) = "..."

            datatTable.Rows.InsertAt(row, 0)

            cmb.DataSource = datatTable
            cmb.DisplayMember = displayMember
            cmb.ValueMember = valueMember
            adapter.Dispose()
            cmd.Connection.Close()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Recupere un tableau de bytes depuis un fichier
    ''' stocker sur le disque
    ''' </summary>
    ''' <param name="path">le chemin du fichier</param>
    ''' <returns></returns>
    Public Function GetBytesFromFile(path As String) As Byte()
        Try
            Dim fstream As FileStream = File.OpenRead(path)
            Dim content(fstream.Length) As Byte
            fstream.Read(content, 0, fstream.Length)
            Return content
        Catch ex As Exception
            MsgBox("Impossible de lire le fichier", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function

End Module
