<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewerForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim UriReportSource1 As Telerik.Reporting.UriReportSource = New Telerik.Reporting.UriReportSource()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AccessibilityKeyMap = Nothing
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        UriReportSource1.Uri = "Reports/SampleReport.trdp"
        Me.ReportViewer1.ReportSource = UriReportSource1
        Me.ReportViewer1.Size = New System.Drawing.Size(900, 700)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewerForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 1.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportViewerForm1"
        Me.Text = "Report Viewer Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer

End Class
