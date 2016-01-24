Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Partial Public Class FrmBill
    Inherits Form
    Private _conn As New OleDbConnection()
    Public Shared Query, queryb As String
    Private ReadOnly _dbconnect As New DbConnect()
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Shared Cus_id As Integer = 0
    Private Sub frmBill_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        FillCusName()
    End Sub

    Private Sub FillCusName()
        _conn = _dbconnect.Con
        If _conn.State <> ConnectionState.Closed Then
            _conn.Close()
        End If
        _conn.Open()
        Const sql As String = "SELECT Cus_Id,Cus_Name From Customer ORDER BY Cus_Id ASC"
        Dim ds As New DataSet()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, _conn)
        adapter.Fill(ds)
        adapter.Dispose()
        _conn.Close()
        cbCusname.DataSource = ds.Tables(0)
        cbCusname.DisplayMember = "Cus_Name"
        cbCusname.ValueMember = "Cus_Id"
        cbCusname.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbCusname.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If IsValidated() Then
            If (Not CheckBox1.Checked) Then

                Query = "SELECT Job_Id, Job_Class, Job_Num, Job_Price,Job_Name FROM(Orders) WHERE Cus_Id=" & Convert.ToInt32(cbCusname.SelectedValue) & " AND Job_Status='ค้างชำระ'"
                Fill_Report(cbCusname.Text, _dbconnect.GetAddress(cbCusname.SelectedValue), DateTime.Now.ToString("dd/MM/yyyy"), _dbconnect.GetSumBill(Convert.ToInt32(cbCusname.SelectedValue)), _dbconnect.GetEmployeeName())

            Else

                Query = "SELECT Job_Id, Job_Class, Job_Num, Job_Price,Job_Name FROM(Orders) WHERE Cus_Id=" & Convert.ToInt32(cbCusname.SelectedValue) & " AND Job_Date LIKE '%" & DateTimePicker1.Value.ToString("dd/MM/yyyy") & "%' AND Job_Status='ค้างชำระ'"
                Fill_Report(cbCusname.Text, _dbconnect.GetAddress(cbCusname.SelectedValue), DateTime.Now.ToString("dd/MM/yyyy"), _dbconnect.GetSumBill(Convert.ToInt32(cbCusname.SelectedValue), DateTimePicker1.Value.ToString("dd/MM/yyyy")), _dbconnect.GetEmployeeName())
            End If
        End If

    End Sub

    Private Sub Fill_Report(ByVal cusName As String, ByVal address As String, ByVal rdate As String, ByVal thatbaht As String, ByVal employee As String)
        Dim param(4) As ReportParameter
        param(0) = New ReportParameter("cus", cusName)
        param(1) = New ReportParameter("address", address)
        param(2) = New ReportParameter("emp", employee)
        param(3) = New ReportParameter("date", rdate)
        param(4) = New ReportParameter("thaibaht", DbConnect.ThaiBaht(thatbaht))
        Dim dss As New ReportDataSource("DataSet1", _dbconnect.Getdata(query).Tables(0))
        ReportViewer1.LocalReport.ReportPath = "Reports\repBilling.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(dss)
        ReportViewer1.LocalReport.SetParameters(param)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 25
        ReportViewer1.RefreshReport()
    End Sub
    Private Function IsValidated() As Boolean
        If cbCusname.Text <> "" AndAlso cbCusname.SelectedIndex >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (CheckBox1.Checked) Then
            DateTimePicker1.Enabled = True
        Else
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmBillList.ShowDialog(Me)
    End Sub

    Private Sub FrmBill_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Not Cus_id = 0 And Query <> "" Then
            cbCusname.SelectedValue = Cus_id
            Fill_Report(cbCusname.Text, _dbconnect.GetAddress(cbCusname.SelectedValue), DateTime.Now.ToString("dd/MM/yyyy"), _dbconnect.GetSumBill(queryb), _dbconnect.GetEmployeeName())
        End If
    End Sub
End Class