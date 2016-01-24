Imports System.Data.OleDb

Partial Public Class ReportJob

    Friend Sub New()
        InitializeComponent()
    End Sub
    Private _sql As String = ""

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex >= 0 AndAlso ComboBox1.Text <> "" Then
            Select Case ComboBox1.SelectedIndex
                Case 0
                    
                    DbConnect.REdate = DateTimePicker1.Value.ToString("dd/MM/yyy")
                    Dim rday As New reportUnpaid
                    rday.Show()
                Case 1
                    Reportday.dd = DateTimePicker1.Value.Day
                    Reportday.mm = DateTimePicker1.Value.Month
                    Reportday.yyyy = DateTimePicker1.Value.Year
                    DbConnect.REdate = DateTimePicker1.Value.ToString("dd/MM/yyy")
                    Dim rday As New Reportday
                    rday.Show()
                Case 2
                    ReportMonth.mm = DateTimePicker1.Value.Month
                    ReportMonth.yy = DateTimePicker1.Value.Year
                    reportMonth.sdate = DateTimePicker1.Value.Month.ToString() & "/" & (DateTimePicker1.Value.Year + 543).ToString()
                    Dim rday As New reportMonth
                    rday.Show()
                Case 3
                    reportYear.syear = (DateTimePicker1.Value.Year + 543).ToString()
                    Dim rday As New reportYear
                    rday.Show()
            End Select
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click

        Dim conn As New OleDbConnection()
        conn = (New DbConnect()).Con
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        End If

        conn.Open()
        Dim cmd As New OleDbCommand()
        Dim adapter = New OleDbDataAdapter()
        If ComboBox1.SelectedIndex >= 0 AndAlso ComboBox1.Text <> "" Then
            Select Case ComboBox1.SelectedIndex
                Case 0
                    _sql = "SELECT Orders.Job_Id, Customer.Cus_Name, Orders.Job_Name, Orders.Job_Date, Orders.Job_Sent, Job_Price "
                    _sql &= "FROM (Orders INNER JOIN "
                    _sql &= "Customer ON Orders.Cus_Id = Customer.Cus_Id) "
                    _sql &= " WHERE Job_Status='ค้างชำระ' OR Job_Status='มัดจำ 50%' ORDER BY Orders.Job_Id"
                    cmd = New OleDbCommand(_sql, conn)
                Case 1
                    _sql = "SELECT Orders.Job_Id, Customer.Cus_Name, Orders.Job_Name, Orders.Job_Date, Orders.Job_Sent, Job_Price "
                    _sql &= "FROM (Orders INNER JOIN "
                    _sql &= "Customer ON Orders.Cus_Id = Customer.Cus_Id) "
                    _sql &= " WHERE DAY(Orders.Job_Date)=" & DateTimePicker1.Value.Day & " AND Month(Orders.Job_Date)=" & DateTimePicker1.Value.Month & " AND Year(Orders.Job_Date)=" & DateTimePicker1.Value.Year & " AND Orders.Job_Status='ชำระแล้ว' ORDER BY Orders.Job_Id"
                    cmd = New OleDbCommand(_sql, conn)
                Case 2
                    _sql = "SELECT Orders.Job_Id, Customer.Cus_Name, Orders.Job_Name, Orders.Job_Date, Orders.Job_Sent, Job_Price "
                    _sql &= "FROM (Orders INNER JOIN "
                    _sql &= "Customer ON Orders.Cus_Id = Customer.Cus_Id) "
                    _sql &= " WHERE Month(Orders.Job_Date)=" & DateTimePicker1.Value.Month & " AND Year(Orders.Job_Date)=" & DateTimePicker1.Value.Year & " AND Job_Status='ชำระแล้ว' ORDER BY Orders.Job_Id"
                    cmd = New OleDbCommand(_sql, conn)
                Case 3
                    GoTo lb1
            End Select

            Try
                adapter = New OleDbDataAdapter(cmd)
                Dim ds As New DataSet()
                adapter.Fill(ds)

                dgv.DataSource = ds.Tables(0)
                Dim header() As String = {"รหัสงาน", "ลูกค้า", "ชื่องาน", "วันที่รับงาน", "วันที่ส่งงาน", "ยอดเงิน"}
                For i As Integer = 0 To dgv.ColumnCount - 1
                    dgv.Columns(i).HeaderText = header(i)
                Next i
                For i As Integer = 0 To dgv.ColumnCount - 1
                    If i <> 0 Then
                        dgv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Else
                        dgv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End If
                Next i
                GoTo endsub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                GoTo endsub
            End Try
lb1:
            Dim cm As New OleDbCommand()
            cm.CommandType = CommandType.Text
            cm.CommandText = "SELECT Cstr(month(Orders.Job_Date)) AS เดือน ,SUM(Orders.Job_Price) AS รายรับทั้งหมด FROM Orders  WHERE Orders.Job_Status='ชำระแล้ว' GROUP BY month(Orders.Job_Date)"
            cm.Connection = conn
            adapter = New OleDbDataAdapter(cm)
            Dim dss As New DataSet()
            adapter.Fill(dss)
            dgv.DataSource = dss.Tables(0)

            For i As Integer = 0 To dgv.RowCount - 1
                dgv.Rows(i).Cells(0).Value = getMonthName(Convert.ToInt32(dgv.Rows(i).Cells(0).Value).ToString())
            Next
endsub:




        End If
    End Sub
    Private Function getMonthName(ByVal monthInt As String) As String
        Dim result As String = ""
        Select Case monthInt
            Case "1"
                result = "มกราคม"
            Case "2"
                result = "กุมภาพันธ์"
            Case "3"
                result = "มีนาคม"
            Case "4"
                result = "เมษายน"
            Case "5"
                result = "พฤษภาคม"
            Case "6"
                result = "มิถุนายน"
            Case "7"
                result = "กรกฎาคม"
            Case "8"
                result = "สิงหาคม"
            Case "9"
                result = "กันยายน"
            Case "10"
                result = "ตุลาคม"
            Case "11"
                result = "พฤศจิกายน"
            Case "12"
                result = "ธันวาคม"
        End Select
        Return result
    End Function

    Private Sub ReportJob_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        If DbConnect.UserLever = "พนักงาน" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("รายงานยอดค้างจ่าย")
            ComboBox1.Items.Add("รายงานสรุปยอดเงินประจำวัน")
        End If
    End Sub
End Class