<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class XmlExampleForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCle = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btNew = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.tbSearchId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbSearchNom = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbCle)
        Me.GroupBox1.Controls.Add(Me.tbPrenom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbNom)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 311)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulaire"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd MMMM yyyy HH:mm"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "DateFin", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(23, 237)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'bindingSource
        '
        Me.bindingSource.DataSource = GetType(Formation.Client)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(88, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prenom"
        '
        'tbCle
        '
        Me.tbCle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Cle", True))
        Me.tbCle.Location = New System.Drawing.Point(23, 191)
        Me.tbCle.Name = "tbCle"
        Me.tbCle.Size = New System.Drawing.Size(255, 20)
        Me.tbCle.TabIndex = 3
        '
        'tbPrenom
        '
        Me.tbPrenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Prenom", True))
        Me.tbPrenom.Location = New System.Drawing.Point(23, 141)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(255, 20)
        Me.tbPrenom.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Id"
        '
        'tbId
        '
        Me.tbId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Id", True))
        Me.tbId.Location = New System.Drawing.Point(23, 35)
        Me.tbId.Name = "tbId"
        Me.tbId.ReadOnly = True
        Me.tbId.Size = New System.Drawing.Size(255, 20)
        Me.tbId.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'tbNom
        '
        Me.tbNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Nom", True))
        Me.tbNom.Location = New System.Drawing.Point(23, 86)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(255, 20)
        Me.tbNom.TabIndex = 1
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(344, 79)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(444, 322)
        Me.dataGridView.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Charger"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btNew
        '
        Me.btNew.Location = New System.Drawing.Point(425, 407)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(75, 23)
        Me.btNew.TabIndex = 5
        Me.btNew.Text = "Nouveau"
        Me.btNew.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(507, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Editer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(589, 408)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 12
        Me.btDelete.Text = "Supprimer"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'tbSearchId
        '
        Me.tbSearchId.Location = New System.Drawing.Point(444, 22)
        Me.tbSearchId.Name = "tbSearchId"
        Me.tbSearchId.Size = New System.Drawing.Size(138, 20)
        Me.tbSearchId.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Recherche par Id"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(588, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "R"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tbSearchNom
        '
        Me.tbSearchNom.Location = New System.Drawing.Point(444, 47)
        Me.tbSearchNom.Name = "tbSearchNom"
        Me.tbSearchNom.Size = New System.Drawing.Size(138, 20)
        Me.tbSearchNom.TabIndex = 3
        '
        'XmlExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btNew)
        Me.Controls.Add(Me.tbSearchNom)
        Me.Controls.Add(Me.tbSearchId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "XmlExampleForm"
        Me.Text = "XmlExampleForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCle As TextBox
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents bindingSource As BindingSource
    Friend WithEvents btNew As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents tbSearchId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents tbSearchNom As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
