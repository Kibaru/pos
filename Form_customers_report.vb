Public Class Form_customers_report
    Private Sub Form_customers_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As New CustomerCrystalReport
        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class