<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesEmployesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesFacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDonneesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParametresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployesToolStripMenuItem, Me.FacturesToolStripMenuItem, Me.ParametresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployesToolStripMenuItem
        '
        Me.EmployesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesEmployesToolStripMenuItem, Me.NouveauToolStripMenuItem})
        Me.EmployesToolStripMenuItem.Name = "EmployesToolStripMenuItem"
        Me.EmployesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.EmployesToolStripMenuItem.Text = "Employes"
        '
        'ListeDesEmployesToolStripMenuItem
        '
        Me.ListeDesEmployesToolStripMenuItem.Name = "ListeDesEmployesToolStripMenuItem"
        Me.ListeDesEmployesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ListeDesEmployesToolStripMenuItem.Text = "Liste des employes"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'FacturesToolStripMenuItem
        '
        Me.FacturesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesFacturesToolStripMenuItem, Me.NouveauToolStripMenuItem1})
        Me.FacturesToolStripMenuItem.Name = "FacturesToolStripMenuItem"
        Me.FacturesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturesToolStripMenuItem.Text = "Factures"
        '
        'ListeDesFacturesToolStripMenuItem
        '
        Me.ListeDesFacturesToolStripMenuItem.Name = "ListeDesFacturesToolStripMenuItem"
        Me.ListeDesFacturesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ListeDesFacturesToolStripMenuItem.Text = "Liste des factures"
        '
        'NouveauToolStripMenuItem1
        '
        Me.NouveauToolStripMenuItem1.Name = "NouveauToolStripMenuItem1"
        Me.NouveauToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.NouveauToolStripMenuItem1.Text = "Nouveau"
        '
        'ParametresToolStripMenuItem
        '
        Me.ParametresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseDeDonneesToolStripMenuItem, Me.ToolStripSeparator1, Me.ParametresToolStripMenuItem1})
        Me.ParametresToolStripMenuItem.Name = "ParametresToolStripMenuItem"
        Me.ParametresToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ParametresToolStripMenuItem.Text = "Parametres"
        '
        'BaseDeDonneesToolStripMenuItem
        '
        Me.BaseDeDonneesToolStripMenuItem.Name = "BaseDeDonneesToolStripMenuItem"
        Me.BaseDeDonneesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BaseDeDonneesToolStripMenuItem.Text = "Base de donnees"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'ParametresToolStripMenuItem1
        '
        Me.ParametresToolStripMenuItem1.Name = "ParametresToolStripMenuItem1"
        Me.ParametresToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ParametresToolStripMenuItem1.Text = "Parametres"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 498)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesEmployesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesFacturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ParametresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDonneesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ParametresToolStripMenuItem1 As ToolStripMenuItem
End Class
