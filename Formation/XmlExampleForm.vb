Imports System.IO
Imports System.Xml
Imports System.Linq
Imports System.Xml.Serialization

Public Class XmlExampleForm

    Property FilePath As String
    Private ListClient As List(Of Client) = New List(Of Client)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        InitFile()

        bindingSource.DataSource = ListClient
        dataGridView.DataSource = bindingSource
    End Sub

    Private Sub InitFile()
        Dim desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim fichierClient As String = "list_client.xml"
        FilePath = Path.Combine(desktopPath, fichierClient)
        If Not File.Exists(FilePath) Then
            File.Create(FilePath)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bindingSource.EndEdit()
        Dim client As Client = CType(bindingSource.Current, Client)
        If client.Id = 0 Then
            client.Id = ListClient.Count
        End If

        Save()
        GroupBox1.Enabled = False
    End Sub

    Private Sub LoadData()
        Try
            Dim serializer As XmlSerializer = New XmlSerializer(GetType(List(Of Client)))
            Using filestream As FileStream = File.OpenRead(FilePath)
                ListClient = serializer.Deserialize(filestream)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Save()
        Try
            'RecreateFile()
            Dim serializer As XmlSerializer = New XmlSerializer(GetType(List(Of Client)))
            Using fileStram As FileStream = File.OpenWrite(FilePath)
                fileStram.SetLength(0)
                fileStram.Flush()
                serializer.Serialize(fileStram, ListClient)
                fileStram.Flush()
                MessageBox.Show("Bien enregistrer")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub RecreateFile()
        If File.Exists(FilePath) Then
            File.Delete(FilePath)
        End If
        InitFile()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
        bindingSource.DataSource = ListClient

        'dataGridView.DataSource = ListClient
    End Sub

    Private Sub btNew_Click(sender As Object, e As EventArgs) Handles btNew.Click
        bindingSource.AddNew()
        bindingSource.MoveLast()
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Enabled = True
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim client = CType(bindingSource.Current, Client)
        If client IsNot Nothing Then
            'ListClient.Remove(client)
            bindingSource.Remove(client)
        End If
        Save()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tbSearchId.Text.Trim().Length <= 0 Then
            MessageBox.Show("Veuillez saisir l'ID")
            Exit Sub
        End If

        Dim id = CInt(tbSearchId.Text)
        Dim subList = ListClient.Where(Function(x) x.Id = id).ToList()

        'Dim nom = tbSearchId.Text
        'Dim prenom = tbSearchNom.Text

        'Dim items = (From c In ListClient Where c.Nom.StartsWith(nom) Or c.Prenom.StartsWith(prenom)
        '             Select New With {c.Id, c.Cle}).ToList()


        'Dim subList = ListClient.
        '    Where(Function(x) x.Nom.StartsWith(nom) Or x.Prenom.StartsWith(prenom)).
        '    Select(Function(x) New With {x.Id, x.Cle}).
        '    ToList()

        bindingSource.DataSource = subList
    End Sub

    Private Sub dataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellEndEdit
        Save()
    End Sub

    'Private Sub dataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick
    '    Dim client As Client = ListClient.Item(e.RowIndex)
    '    tbId.Text = client.Id
    '    tbNom.Text = client.Nom
    '    tbPrenom.Text = client.Prenom
    '    tbCle.Text = client.Cle
    'End Sub
End Class