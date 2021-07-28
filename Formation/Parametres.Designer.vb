<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametres
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
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSociete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(122, 135)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(288, 27)
        Me.txtType.TabIndex = 5
        Me.txtType.Visible = False
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(122, 98)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(288, 27)
        Me.txtTel.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tel :"
        '
        'txtSociete
        '
        Me.txtSociete.Location = New System.Drawing.Point(122, 56)
        Me.txtSociete.Name = "txtSociete"
        Me.txtSociete.Size = New System.Drawing.Size(288, 27)
        Me.txtSociete.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Societe : "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(108, 327)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 33)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Fermer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 25)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.Location = New System.Drawing.Point(122, 167)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(150, 132)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 8
        Me.imgLogo.TabStop = False
        '
        'Parametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 387)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSociete)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MaximizeBox = False
        Me.Name = "Parametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametres"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtType As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSociete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
