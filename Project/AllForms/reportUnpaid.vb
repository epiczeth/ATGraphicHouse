Imports AllClasses
Imports Microsoft.Reporting.WinForms

Namespace AllForms
    Public Class ReportUnpaid
        Private Sub reportDay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim dbconnect As New DbConnect
            Dim _
                dataSource As _
                    New ReportDataSource("DataSet1",
                                         dbconnect.Getdata(
                                             "SELECT Orders.Job_Id, Customer.Cus_Name, Orders.Job_Name, Orders.Job_Date, Orders.Job_Sent, Orders.Job_Price FROM (Orders INNER JOIN Customer ON Orders.Cus_Id = Customer.Cus_Id) WHERE (Orders.Job_Status = 'ค้างชำระ') OR (Orders.Job_Status = 'มัดจำ 50%')") _
                                            .Tables(0))

            ReportViewer1.LocalReport.ReportPath = "Reports\repUnpaid.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(dataSource)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 25
            ReportViewer1.RefreshReport()
        End Sub
    End Class
End NameSpace