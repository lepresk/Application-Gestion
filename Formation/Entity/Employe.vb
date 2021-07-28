Public Class Employe
    Public Property Id As Integer
    Public Property Nom As String
    Public Property Prenom As String

    Public ReadOnly Property NomComplet As String
        Get
            Return Nom & " " & Prenom
        End Get
    End Property

    'Public Overrides Function ToString() As String
    '    Return NomComplet
    'End Function
End Class
