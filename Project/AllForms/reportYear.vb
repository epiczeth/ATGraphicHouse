
Imports AllClasses
Imports Microsoft.Reporting.WinForms

Namespace AllForms
    Public Class ReportYear
        Public Shared Syear As String

        Private Sub reportYear_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim dbconnect As New DbConnect
            Dim sql As String
            sql =
                "SELECT month(Orders.Job_Date) AS job_month ,SUM(Orders.Job_Price) AS job_sum FROM Orders  WHERE Orders.Job_Status='ชำระแล้ว' GROUP BY month(Orders.Job_Date)"
            Dim dss As New ReportDataSource("DataSet1", dbconnect.Getdata(sql).Tables(0))
            Dim param(0) As ReportParameter
            param(0) = New ReportParameter("syear", Syear)
            ReportViewer1.LocalReport.ReportPath = "Reports\repReYear.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(dss)
            ReportViewer1.LocalReport.SetParameters(param)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 25
            ReportViewer1.RefreshReport()
        End Sub
    End Class
End NameSpace