Public Class EmployeEntity
    Public Property Id As Integer
    Public Property Nom As String
    Public Property Prenom As String
    Public Property Poste As String
    Public Property Bureau As String
    Public Property Salaire As Decimal
    Public Property DateEmbauche As Date
    Public Property Permanence As Boolean
    Public Property Commentaire As String
    Public Property Photo As Byte()

    Public Shared Function Save(entity As EmployeEntity) As Integer
        Dim sql As String = "INSERT INTO employes (nom, prenom, photo) VALUE (@nom, @prenom, @photo)"
        Dim cmd = BaseDeDonnes.GetCommand(sql)

        Return 0
    End Function

    Public Shared Function ReadAll() As List(Of EmployeEntity)
        Return Nothing
    End Function

    Public Shared Function Find(id As Integer) As EmployeEntity

    End Function

End Class
