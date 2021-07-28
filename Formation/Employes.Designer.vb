<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBureau = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSalaire = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCommentaire = New System.Windows.Forms.TextBox()
        Me.cmbPoste = New System.Windows.Forms.ComboBox()
        Me.txtDateEmbauche = New System.Windows.Forms.DateTimePicker()
        Me.ckPermanent = New System.Windows.Forms.CheckBox()
        Me.labelTitre = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnParcourir = New System.Windows.Forms.Button()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom : "
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(201, 89)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(333, 27)
        Me.txtNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Prenom"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(201, 128)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(333, 27)
        Me.txtPrenom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Poste : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bureau : "
        '
        'txtBureau
        '
        Me.txtBureau.Location = New System.Drawing.Point(201, 207)
        Me.txtBureau.Name = "txtBureau"
        Me.txtBureau.Size = New System.Drawing.Size(333, 27)
        Me.txtBureau.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Salaire : "
        '
        'txtSalaire
        '
        Me.txtSalaire.Location = New System.Drawing.Point(201, 241)
        Me.txtSalaire.Name = "txtSalaire"
        Me.txtSalaire.Size = New System.Drawing.Size(333, 27)
        Me.txtSalaire.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Date embauche : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Commentaire : "
        '
        'txtCommentaire
        '
        Me.txtCommentaire.Location = New System.Drawing.Point(202, 347)
        Me.txtCommentaire.Multiline = True
        Me.txtCommentaire.Name = "txtCommentaire"
        Me.txtCommentaire.Size = New System.Drawing.Size(333, 72)
        Me.txtCommentaire.TabIndex = 8
        '
        'cmbPoste
        '
        Me.cmbPoste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPoste.FormattingEnabled = True
        Me.cmbPoste.Items.AddRange(New Object() {"Directeur", "Secretaire", "Vendeur", "Gerant", "Caissiere"})
        Me.cmbPoste.Location = New System.Drawing.Point(201, 166)
        Me.cmbPoste.Name = "cmbPoste"
        Me.cmbPoste.Size = New System.Drawing.Size(333, 29)
        Me.cmbPoste.TabIndex = 3
        '
        'txtDateEmbauche
        '
        Me.txtDateEmbauche.Location = New System.Drawing.Point(201, 276)
        Me.txtDateEmbauche.Name = "txtDateEmbauche"
        Me.txtDateEmbauche.Size = New System.Drawing.Size(333, 27)
        Me.txtDateEmbauche.TabIndex = 6
        '
        'ckPermanent
        '
        Me.ckPermanent.AutoSize = True
        Me.ckPermanent.Location = New System.Drawing.Point(201, 313)
        Me.ckPermanent.Name = "ckPermanent"
        Me.ckPermanent.Size = New System.Drawing.Size(116, 25)
        Me.ckPermanent.TabIndex = 7
        Me.ckPermanent.Text = "Permanent"
        Me.ckPermanent.UseVisualStyleBackColor = True
        '
        'labelTitre
        '
        Me.labelTitre.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitre.Location = New System.Drawing.Point(1, 16)
        Me.labelTitre.Name = "labelTitre"
        Me.labelTitre.Size = New System.Drawing.Size(771, 44)
        Me.labelTitre.TabIndex = 0
        Me.labelTitre.Text = "Nouvel Employé"
        Me.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(391, 437)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(118, 35)
        Me.btnFermer.TabIndex = 10
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(263, 437)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 35)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Enregistrer"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'picPhoto
        '
        Me.picPhoto.Location = New System.Drawing.Point(562, 87)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(168, 147)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 11
        Me.picPhoto.TabStop = False
        '
        'btnParcourir
        '
        Me.btnParcourir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParcourir.Location = New System.Drawing.Point(602, 241)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(74, 25)
        Me.btnParcourir.TabIndex = 12
        Me.btnParcourir.Text = "Parcourir..."
        Me.btnParcourir.UseVisualStyleBackColor = True
        '
        'Employes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 495)
        Me.Controls.Add(Me.btnParcourir)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.ckPermanent)
        Me.Controls.Add(Me.txtDateEmbauche)
        Me.Controls.Add(Me.cmbPoste)
        Me.Controls.Add(Me.txtCommentaire)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSalaire)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBureau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.labelTitre)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Employes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau | Modification employe"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBureau As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSalaire As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCommentaire As TextBox
    Friend WithEvents cmbPoste As ComboBox
    Friend WithEvents txtDateEmbauche As DateTimePicker
    Friend WithEvents ckPermanent As CheckBox
    Friend WithEvents labelTitre As Label
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents picPhoto As PictureBox
    Friend WithEvents btnParcourir As Button
End Class
