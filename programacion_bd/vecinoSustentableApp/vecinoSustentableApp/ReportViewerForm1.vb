Public Class ReportViewerForm1

    'Private Sub ReportViewerForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.ReportViewer1.RefreshReport()
    'End Sub


    Private Sub ReporteGrilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Reporte As New reporte_principal


        ReportViewer1.Report = Reporte

        ReportViewer1.RefreshReport()

    End Sub
End Class
