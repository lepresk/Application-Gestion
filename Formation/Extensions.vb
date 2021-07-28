
Module Extensions

    <System.Runtime.CompilerServices.Extension>
    Public Sub ConvertTextBox(tb As TextBox)
        MessageBox.Show(tb.Text.ToLower())
    End Sub

    <System.Runtime.CompilerServices.Extension>
    Public Sub PopulateCombo(cmb As ComboBox, sql As String, displayMember As String, valueMember As String)
        Util.PopulateCombo(cmb, sql, displayMember, valueMember)
    End Sub
End Module
