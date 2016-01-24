
Imports System.Data.OleDb

Partial Public Class UserForm
    Friend Sub New()
        InitializeComponent()
    End Sub
    Private ReadOnly _con As New DbConnect()
    Private _ds As New DataSet()

    Private Sub UserForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Fill_dgv()
        Fill_combobox()
        NewUserId()
    End Sub
    Private Sub NewUserId()
        _ds = _con.Getdata("SELECT MAX(User_Id)+1 FROM Usertable")
        If _ds.Tables(0).Rows.Count = 1 Then
            txtuserid.Text = _ds.Tables(0).Rows(0)(0).ToString()
        Else
            txtuserid.Text = "1"
        End If
    End Sub
    Private Sub Fill_combobox()
        Dim ds As New DataSet
        ds = _con.Getdata("SELECT Emp_Id FROM Usertable ORDER BY User_Id ASC")

        Dim sql As String = "SELECT Emp_Id,Emp_Name FROM Employee WHERE 1=1 "
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            sql &= " AND Emp_Id <>" & Convert.ToInt32(ds.Tables(0).Rows(i)(0)) & " "
        Next
        sql &= " ORDER BY Emp_ID ASC"
        _ds = _con.Getdata(sql)
        Dim strId As New List(Of String)()
        For Each row As DataRow In _ds.Tables(0).Rows
            strId.Add(row("Emp_Id").ToString())
        Next row
        If _ds.Tables(0).Rows.Count = 0 Then
            cbEmpID.Enabled = False
            cbEmpName.Enabled = False
            cbuserlevel.Enabled = False
            txtusername.Enabled = False
            txtPassword.Enabled = False
            Button2.Enabled = False
            ClearText()
        Else
            cbEmpID.Enabled = True
            cbEmpName.Enabled = True
            cbuserlevel.Enabled = True
            txtusername.Enabled = True
            txtPassword.Enabled = True
            Button2.Enabled = True
        End If
        cbEmpID.DataSource = _ds.Tables(0)
        cbEmpID.DisplayMember = "Emp_Id"
        cbEmpID.ValueMember = "Emp_Id"
        cbEmpID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbEmpID.AutoCompleteSource = AutoCompleteSource.ListItems


        cbEmpName.DataSource = _ds.Tables(0)
        cbEmpName.DisplayMember = "Emp_Name"
        cbEmpName.ValueMember = "Emp_Id"
        cbEmpName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbEmpName.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub
    Private Sub Fill_dgv()
        Dim sql As String = "SELECT Usertable.User_Id, Usertable.UserName, Usertable.[Password], Usertable.UserLevel, Employee.Emp_Name "
        sql &= "FROM (Usertable INNER JOIN"
        sql &= " Employee ON Usertable.Emp_Id = Employee.Emp_Id)"
        _ds = _con.Getdata(sql)
        dgv.DataSource = _ds.Tables(0)

        Dim header() As String = {"รหัสผู้ใช้งาน", "ชื่อผู้ใช้งาน", "รหัสผ่าน", "ระดับผู้ใช้งาน", "ชื่อพนักงาน"}

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
    End Sub
    Private Function IsValidated() As Boolean
        If cbEmpID.Text <> "" AndAlso cbEmpName.Text <> "" AndAlso txtusername.Text <> "" AndAlso txtuserid.Text <> "" AndAlso txtPassword.Text <> "" AndAlso cbuserlevel.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If IsValidated() Then
            _ds = _con.Getdata("SELECT * FROM Usertable WHERE User_Id=" & txtuserid.Text & " OR UserName='" & txtusername.Text.Trim() & "'")
            If _ds.Tables(0).Rows.Count <= 0 Then

                Dim sql As String = String.Format("insert into Usertable values({0},'{1}','{2}','{3}',{4})", Convert.ToInt32(txtuserid.Text), txtusername.Text, txtPassword.Text, cbuserlevel.Text, Convert.ToInt32(cbEmpID.Text))
                If _con.Query(sql) >= 1 Then
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ")
                Else

                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลลงฐานข้อมูลได้")
                End If
            Else
                MessageBox.Show("พบข้อมูลซ้ำซ้อนอาจเป็นชื่อผู้ใช้หรือรหัสผู้ใช้ซ้ำกัน กรุณากรอกข้อมูลใหม่")
            End If
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")

        End If

        ClearText()
        NewUserId()
        Fill_dgv()
        Fill_combobox()

    End Sub
    Private Sub ClearText()
        txtPassword.Text = ""
        txtuserid.Text = ""
        txtusername.Text = ""
        cbEmpID.Text = ""
        cbEmpName.Text = ""
        cbuserlevel.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        If dgv.SelectedRows.Count >= 0 Then
            Dim conn As New OleDbConnection()
            conn = _con.Con
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If

            conn.Open()
            Dim reader As OleDbDataReader = (New OleDbCommand("SELECT * FROM Usertable WHERE User_Id=" & dgv.SelectedRows(0).Cells(0).Value.ToString() & " ORDER BY User_Id", conn)).ExecuteReader() 'อ่านข้อมูลจากฐานข้อมูล
            Do While reader.Read()

                txtuserid.Text = reader(0).ToString()
                txtusername.Text = reader(1).ToString()
                txtPassword.Text = reader(2).ToString()
                cbuserlevel.Text = reader(3).ToString()
                cbEmpID.Text = reader(4).ToString()
            Loop
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        _ds = _con.Getdata("SELECT * FROM Usertable WHERE User_Id=" & Convert.ToInt32(dgv.SelectedRows(0).Cells(0).Value) & " ORDER BY User_Id")
        If _ds.Tables(0).Rows.Count >= 1 Then
            If MessageBox.Show(Me, "คุณต้องการลบ '" & dgv.SelectedRows(0).Cells(1).Value.ToString() & "' ออกจากฐานข้อมูลใช่หรือไม่", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If _con.Query("DELETE FROM Usertable WHERE User_ID=" & Convert.ToInt32(dgv.SelectedRows(0).Cells(0).Value.ToString()) & "") >= 1 Then
                    MessageBox.Show("ลบข้อมูลสำเร็จ")
                Else
                    MessageBox.Show("ไม่สามารถลบข้อมูลได้")
                End If
            End If
        Else
            MessageBox.Show("ไม่สามารถลบข้อมูลที่ไม่มีอยู่จริงได้")
        End If
        Fill_dgv()
        Fill_combobox()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        If IsValidated() Then
            _ds = _con.Getdata("SELECT * FROM Usertable WHERE User_Id=" & Convert.ToInt32(txtuserid.Text) & "")
            If _ds.Tables(0).Rows.Count = 1 Then
                Dim sql As String = "UPDATE Usertable SET "
                sql &= "UserName='" & txtusername.Text & "', "
                sql &= "[Password]='" & txtPassword.Text & "', "
                sql &= "UserLevel='" & cbuserlevel.Text & "', "
                sql &= "Emp_Id=" & Convert.ToInt32(cbEmpID.Text) & " WHERE User_Id=" & Convert.ToInt32(txtuserid.Text) & ""
                If _con.Query(sql) = 1 Then
                    MessageBox.Show("บันทึกสำเร็จ")
                Else
                    MessageBox.Show("บันทึกล้มเหลว อาจเป็นเพราะชื่อผู้ใช้ซ้ำกับรายชื่ออื่น")
                End If
            Else
                MessageBox.Show("ไม่สามารถแก้ไขข้อมูลที่ไม่มีอยู่จริงได้")
            End If
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
        End If
        ClearText()
        Fill_dgv()
        Fill_combobox()
    End Sub
End Class