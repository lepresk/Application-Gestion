<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factures
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbQte = New System.Windows.Forms.ComboBox()
        Me.cmbPu = New System.Windows.Forms.ComboBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cmbEmployes = New System.Windows.Forms.ComboBox()
        Me.cmbClients = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDateCreation = New System.Windows.Forms.DateTimePicker()
        Me.cmbProduits = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPu = New System.Windows.Forms.TextBox()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ListViewPanier = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbQte)
        Me.GroupBox1.Controls.Add(Me.cmbPu)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.cmbEmployes)
        Me.GroupBox1.Controls.Add(Me.cmbClients)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDateCreation)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(958, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations de la facture"
        '
        'cmbQte
        '
        Me.cmbQte.FormattingEnabled = True
        Me.cmbQte.Location = New System.Drawing.Point(697, 20)
        Me.cmbQte.Name = "cmbQte"
        Me.cmbQte.Size = New System.Drawing.Size(40, 29)
        Me.cmbQte.TabIndex = 4
        Me.cmbQte.Visible = False
        '
        'cmbPu
        '
        Me.cmbPu.FormattingEnabled = True
        Me.cmbPu.Location = New System.Drawing.Point(615, 20)
        Me.cmbPu.Name = "cmbPu"
        Me.cmbPu.Size = New System.Drawing.Size(58, 29)
        Me.cmbPu.TabIndex = 4
        Me.cmbPu.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(765, 56)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(177, 27)
        Me.txtNumero.TabIndex = 3
        '
        'cmbEmployes
        '
        Me.cmbEmployes.FormattingEnabled = True
        Me.cmbEmployes.Location = New System.Drawing.Point(533, 55)
        Me.cmbEmployes.Name = "cmbEmployes"
        Me.cmbEmployes.Size = New System.Drawing.Size(204, 29)
        Me.cmbEmployes.TabIndex = 2
        '
        'cmbClients
        '
        Me.cmbClients.FormattingEnabled = True
        Me.cmbClients.Location = New System.Drawing.Point(260, 55)
        Me.cmbClients.Name = "cmbClients"
        Me.cmbClients.Size = New System.Drawing.Size(248, 29)
        Me.cmbClients.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(765, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Numéro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(533, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Employé"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'txtDateCreation
        '
        Me.txtDateCreation.Location = New System.Drawing.Point(16, 56)
        Me.txtDateCreation.Name = "txtDateCreation"
        Me.txtDateCreation.Size = New System.Drawing.Size(227, 27)
        Me.txtDateCreation.TabIndex = 0
        '
        'cmbProduits
        '
        Me.cmbProduits.FormattingEnabled = True
        Me.cmbProduits.Location = New System.Drawing.Point(83, 123)
        Me.cmbProduits.Name = "cmbProduits"
        Me.cmbProduits.Size = New System.Drawing.Size(305, 29)
        Me.cmbProduits.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Produit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Qte"
        '
        'txtQte
        '
        Me.txtQte.Location = New System.Drawing.Point(453, 124)
        Me.txtQte.Name = "txtQte"
        Me.txtQte.Size = New System.Drawing.Size(80, 27)
        Me.txtQte.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(554, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Prix unitaire"
        '
        'txtPu
        '
        Me.txtPu.Enabled = False
        Me.txtPu.Location = New System.Drawing.Point(662, 124)
        Me.txtPu.Name = "txtPu"
        Me.txtPu.Size = New System.Drawing.Size(162, 27)
        Me.txtPu.TabIndex = 3
        '
        'btnAjout
        '
        Me.btnAjout.Location = New System.Drawing.Point(851, 123)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(40, 29)
        Me.btnAjout.TabIndex = 4
        Me.btnAjout.Text = "+"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(897, 123)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 29)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "-"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ListViewPanier
        '
        Me.ListViewPanier.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.ListViewPanier.FullRowSelect = True
        Me.ListViewPanier.GridLines = True
        Me.ListViewPanier.Location = New System.Drawing.Point(12, 174)
        Me.ListViewPanier.Name = "ListViewPanier"
        Me.ListViewPanier.Size = New System.Drawing.Size(958, 311)
        Me.ListViewPanier.TabIndex = 5
        Me.ListViewPanier.UseCompatibleStateImageBehavior = False
        Me.ListViewPanier.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "id"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Désignation"
        Me.ColumnHeader1.Width = 437
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Qte"
        Me.ColumnHeader2.Width = 144
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prix unitaire"
        Me.ColumnHeader3.Width = 205
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.Width = 161
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "id_transition_fa_produit"
        Me.ColumnHeader6.Width = 0
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(358, 498)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(126, 33)
        Me.btnEnregistrer.TabIndex = 6
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(499, 498)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(126, 33)
        Me.btnFermer.TabIndex = 6
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Factures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 548)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.ListViewPanier)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAjout)
        Me.Controls.Add(Me.txtPu)
        Me.Controls.Add(Me.txtQte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbProduits)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Factures"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enregistrement d'une facture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents cmbEmployes As ComboBox
    Friend WithEvents cmbClients As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateCreation As DateTimePicker
    Friend WithEvents cmbProduits As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPu As TextBox
    Friend WithEvents btnAjout As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ListViewPanier As ListView
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents btnFermer As Button
    Friend WithEvents cmbPu As ComboBox
    Friend WithEvents cmbQte As ComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
