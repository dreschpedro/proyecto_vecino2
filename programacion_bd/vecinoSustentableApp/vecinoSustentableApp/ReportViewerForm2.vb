Public Class ReportViewerForm2

    'Private Sub ReportViewerForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.ReportViewer1.RefreshReport()
    'End Sub



    Private Sub ReporteGrilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Reporte As New Report3


        ReportViewer1.Report = Reporte

        ReportViewer1.RefreshReport()

    End Sub









End Class
