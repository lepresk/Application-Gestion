Imports MySql.Data.MySqlClient

Public Class ComboLoop

    Private Sub Envoyer()

        Dim cmb As ComboBox = New ComboBox

        Dim sql As String = "SELECT id, libelle FROM groups"

        Util.PopulateCombo(cmb, sql, "libelle", "id")

        Dim cmbAccess As ComboBox = New ComboBox
        Dim cmdForm As ComboBox = New ComboBox

        Try
            Dim ds = CType(cmb.DataSource, DataTable)

            For Each row As DataRow In ds.Rows

                Dim id = CInt(row("id").ToString)

                Dim sql1 As String = "INSERT INTO privilleges (id_group, access, page) VALUE(@idg, @a, @p)"
                Dim cmd = GetCommand(sql1)
                cmd.Parameters.AddWithValue("@idg", id)
                cmd.Parameters.AddWithValue("@a", cmbAccess.Text)
                cmd.Parameters.AddWithValue("@p", cmdForm.Text)

                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox("Erreur de conversion")
        End Try



    End Sub

End Class

Module Personne

End Module