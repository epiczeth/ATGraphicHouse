
Imports AllClasses
Imports Microsoft.Reporting.WinForms

Namespace AllForms
    Partial Public Class FrmOrder
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private ReadOnly _dbconnect As New DbConnect
        Public Shared JobId As Integer

        Private Sub frmOrder_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim sql As String
            sql =
                "SELECT Customer.Cus_Id, Orders.Job_Date, Customer.Cus_Name, Customer.Cus_Gov, Customer.Cus_Address, Customer.Cus_Tel, Customer.Cus_Email, Orders.Job_Id, Orders.Job_Class, Orders.Job_Size,"
            sql += "Orders.Job_Num, Orders.Job_Price, Orders.Job_Status, Orders.Job_Script, Orders.Job_Sent "
            sql += "FROM (Orders INNER JOIN "
            sql += "Customer ON Orders.Cus_Id = Customer.Cus_Id) "
            sql += "WHERE (Orders.Job_Id =" & Convert.ToInt32(JobId) & ")"
            Dim dss As New ReportDataSource("DataSet1", _dbconnect.Getdata(sql).Tables(0))
            ReportViewer2.LocalReport.ReportPath = "Reports\repOrder.rdlc"
            ReportViewer2.LocalReport.DataSources.Clear()
            ReportViewer2.LocalReport.DataSources.Add(dss)
            ReportViewer2.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer2.ZoomMode = ZoomMode.Percent
            ReportViewer2.ZoomPercent = 25
            ReportViewer2.RefreshReport()
        End Sub
    End Class
End NameSpace