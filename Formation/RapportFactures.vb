Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class RapportFactures

    Property ListViewFactures As ListView

    Private Sub Initialize()

        Dim ds As FormationDataSet = New FormationDataSet

        For Each item As ListViewItem In ListViewFactures.Items
            Dim r = ds.factures.NewRow()
            r.Item("id") = item.SubItems(0).Text
            r.Item("numero") = item.SubItems(1).Text
            r.Item("client") = item.SubItems(2).Text
            r.Item("employe") = item.SubItems(3).Text
            r.Item("date_creation") = item.SubItems(4).Text
            r.Item("total") = item.SubItems(5).Text

            ds.factures.Rows.Add(r)
        Next

        reportViewer.LocalReport.ReportPath = Environment.CurrentDirectory & "\rptFactures.rdlc"

        'Dim sql As String = "SELECT factures.id, factures.numero, CONCAT_WS(' ', clients.nom, clients.prenom) AS client, CONCAT_WS(' ', employes.nom, employes.prenom) AS employe, factures.date_creation, SUM(t.pu * t.qte) AS total FROM factures INNER JOIN clients ON factures.client_id = clients.id INNER JOIN employes ON factures.employe_id = employes.id INNER JOIN transition_fac_produits t ON factures.id = t.facture_id GROUP BY factures.id"
        'Dim cmd = BaseDeDonnes.GetCommand(sql)

        'Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        'Dim ds As FormationDataSet = New FormationDataSet
        'adapter.Fill(ds.factures)

        Dim sql As String = "SELECT nom_societe, tel_societe, photo, type_photo FROM parametrages"
        Dim cmd = BaseDeDonnes.GetCommand(sql)
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        adapter.Fill(ds.Parametrages)

        reportViewer.LocalReport.DataSources.Clear()

        reportViewer.LocalReport.DataSources.Add(New ReportDataSource("factures", CType(ds.factures, DataTable)))
        reportViewer.LocalReport.DataSources.Add(New ReportDataSource("parametres", CType(ds.Parametrages, DataTable)))

        'cmd.Connection.Close()

        reportViewer.RefreshReport()

    End Sub


    Private Sub RapportFactures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

End Class