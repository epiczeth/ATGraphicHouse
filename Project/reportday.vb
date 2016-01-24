Imports System.Runtime.Remoting.Messaging
Imports Microsoft.Reporting.WinForms

Public Class Reportday
    Public Shared dd, mm, yyyy As Integer
    Private Sub reportday_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim dbconnect As New DbConnect
        Dim sql As String
        sql = "SELECT Orders.Job_Id, Customer.Cus_Name, Orders.Job_Name, Orders.Job_Date, Orders.Job_Sent, Orders.Job_Price FROM (Orders INNER JOIN Customer ON Orders.Cus_Id = Customer.Cus_Id) WHERE day(Orders.Job_Date)=" & dd & " and month(Orders.Job_Date)=" & mm & " and year(Orders.Job_Date)=" & yyyy & " AND (Orders.Job_Status = 'ชำระแล้ว') "
        System.Diagnostics.Debug.WriteLine(sql)
        Dim dss As New ReportDataSource("DataSet1", dbconnect.Getdata(sql).Tables(0))
        If dbconnect.REdate <> "" Then
            ReportViewer1.LocalReport.ReportPath = "Reports\repReDay.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(dss)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 25
            ReportViewer1.RefreshReport()
        End If
    End Sub
End Class