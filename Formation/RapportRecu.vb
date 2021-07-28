Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class RapportRecu

    Public Property FactureId As String

    Private Sub Initialize()

        reportViewer.LocalReport.ReportPath = Environment.CurrentDirectory & "\rptRecu.rdlc"

        Dim sql As String = "SELECT p.description AS produit, t.qte, t.pu, (t.qte * t.pu) AS total FROM transition_fac_produits t INNER JOIN produits p ON t.produit_id = p.id WHERE facture_id = @id"
        Dim cmd = BaseDeDonnes.GetCommand(sql)

        cmd.Parameters.AddWithValue("@id", FactureId)
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim ds As FormationDataSet = New FormationDataSet
        adapter.Fill(ds.FactureProduits)

        reportViewer.LocalReport.DataSources.Add(New ReportDataSource("factureProduits", CType(ds.FactureProduits, DataTable)))

        Dim sql2 As String = "SELECT CONCAT_WS(' ', clients.nom, clients.prenom) AS client, clients.tel_contact FROM factures INNER JOIN clients ON factures.client_id = clients.id WHERE factures.id = @id"
        Dim cmd2 = BaseDeDonnes.GetCommand(sql2)
        cmd2.Parameters.AddWithValue("@id", FactureId)
        Dim result = cmd2.ExecuteReader()

        If result.HasRows Then
            result.Read()

            Dim paramNom As ReportParameter = New ReportParameter("nom_client", result.GetString("client"))
            Dim paramTel As ReportParameter = New ReportParameter("tel_client", result.GetString("tel_contact"))

            reportViewer.LocalReport.SetParameters(paramNom)
            reportViewer.LocalReport.SetParameters(paramTel)
        End If

        result.Close()
        cmd.Connection.Close()

        reportViewer.RefreshReport()

    End Sub

    Private Sub RapportRecu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub
End Class