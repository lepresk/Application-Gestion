Imports System.ComponentModel
Imports System.Globalization

Public Class TestForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR")
        'System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("fr-FR")
        ChangeLanguage("fr-FR")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-EN")
        'System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-EN")
        ChangeLanguage("en-EN")
    End Sub

    Private Sub ChangeLanguage(lang As String)

        For Each c As Control In Me.Controls
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(TestForm))
            resources.ApplyResources(c, c.Name, New CultureInfo(lang))
        Next

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each item In CheckedListBox1.CheckedItems
            MsgBox(item.ToString())
        Next
    End Sub

End Class