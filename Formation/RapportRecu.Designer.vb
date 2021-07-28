<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportRecu
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
        Me.reportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'reportViewer
        '
        Me.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportViewer.LocalReport.ReportEmbeddedResource = "Formation.rptRecu.rdlc"
        Me.reportViewer.Location = New System.Drawing.Point(0, 0)
        Me.reportViewer.Name = "reportViewer"
        Me.reportViewer.ServerReport.BearerToken = Nothing
        Me.reportViewer.Size = New System.Drawing.Size(795, 535)
        Me.reportViewer.TabIndex = 0
        '
        'RapportRecu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 535)
        Me.Controls.Add(Me.reportViewer)
        Me.Name = "RapportRecu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RapportRecu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
