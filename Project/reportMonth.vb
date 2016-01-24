Imports Microsoft.Reporting.WinForms

Public Class ReportMonth
    Public Shared Sdate As String = ""
    Public Shared mm, yy As Integer
    Private Sub reportMonth_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "SELECT Orders.Job_Id, Customer.Cus_Name, Orders.Job_Name, Orders.Job_Date, Orders.Job_Sent, Orders.Job_Price FROM (Customer INNER JOIN Orders ON Customer.Cus_Id = Orders.Cus_Id) WHERE  month(Orders.Job_Date)=" & mm & " AND year(Orders.Job_Date)=" & yy & " AND Orders.Job_Status='ชำระแล้ว'"
        Dim dbconnect As New DbConnect
        Dim dss As New ReportDataSource("DataSet1", dbconnect.Getdata(sql).Tables(0))

        Dim param(0) As ReportParameter
        param(0) = New ReportParameter("dMonth", Sdate)
        ReportViewer1.LocalReport.ReportPath = "Reports\repReMonth.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(dss)
        ReportViewer1.LocalReport.SetParameters(param)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 25
        ReportViewer1.RefreshReport()
       
        Debug.WriteLine(dbconnect.REdate)
    End Sub
End Class