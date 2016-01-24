Imports AllClasses
Imports MySql.Data.MySqlClient

Namespace AllForms
    Public Class FrmBillList
        ReadOnly _dbconnect As New DbConnect
        Dim _conn As mysqlconnection

        Private Sub frmBillList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Fill_Combobox()
        End Sub

        Private Sub fill_dgv()
            Try
                _conn = _dbconnect.Con
                If _conn.State <> ConnectionState.Closed Then
                    _conn.Close()
                End If
                _conn.Open()

                If ComboBox1.SelectedValue.ToString() <> "System.Data.DataRowView" Then


                    Dim sql As String = "SELECT Job_Id, Job_Class, Job_Num, Job_Price FROM Orders WHERE Cus_Id=" &
                                        Convert.ToInt32(ComboBox1.SelectedValue.ToString()) &
                                        " AND (Job_Status='ค้างชำระ' OR Job_Status='มัดจำ 50%')"
                    Dim ds As New DataSet()
                    Dim adapter As Mysqldataadapter = New Mysqldataadapter(sql, _conn)
                    adapter.Fill(ds)
                    adapter.Dispose()
                    _conn.Close()
                    DataGridView1.DataSource = ds.Tables(0)

                    Dim header() As String = {"", "รหัสงาน", "ประเภท", "จำนวน", "ราคา"}
                    For i As Integer = 0 To DataGridView1.ColumnCount - 1
                        DataGridView1.Columns(i).HeaderText = header(i)
                        DataGridView1.Columns(i).Width = 80
                    Next i
                    For i As Integer = 0 To DataGridView1.ColumnCount - 1
                        If i <> 0 Then
                            DataGridView1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        Else
                            DataGridView1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        End If
                    Next i

                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub Fill_Combobox()
            _conn = _dbconnect.Con
            If _conn.State <> ConnectionState.Closed Then
                _conn.Close()
            End If
            _conn.Open()
            Const sql As String = "SELECT Cus_Id,Cus_Name From Customer ORDER BY Cus_Id ASC"
            Dim ds As New DataSet()
            Dim adapter As Mysqldataadapter = New Mysqldataadapter(sql, _conn)
            adapter.Fill(ds)
            adapter.Dispose()
            _conn.Close()
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.DisplayMember = "Cus_Name"
            ComboBox1.ValueMember = "Cus_Id"
            ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        End Sub

        Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
            Handles ComboBox1.SelectedIndexChanged
            fill_dgv()
        End Sub

        Private Sub FrmBillList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim sql As String = "SELECT Job_Id, Job_Class, Job_Num, Job_Price,Job_Name FROM(Orders) WHERE 0"
            Dim sql2 As String = "SELECT Job_Price FROM(Orders) WHERE 0"
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If (CBool(DataGridView1.Rows(i).Cells(0).Value) = True) Then
                    sql &= " OR Job_Id=" & Convert.ToInt32(DataGridView1.Rows(i).Cells(1).Value) & ""
                    sql2 &= " OR Job_Id=" & Convert.ToInt32(DataGridView1.Rows(i).Cells(1).Value) & ""
                End If
            Next
            FrmBill.CusId = Convert.ToInt32(ComboBox1.SelectedValue)
            FrmBill.Query = sql
            FrmBill.queryb = sql2

            Close()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Close()
        End Sub
    End Class
End NameSpace