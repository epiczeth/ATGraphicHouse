Partial Public Class Employees
    Friend Sub New()
        InitializeComponent()
    End Sub
    Private ReadOnly _con As New DbConnect()
    Private _status As String
    Private _sql As String
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Search()

    End Sub

    Private Sub Employees_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Showdata()
    End Sub

    Public Sub Showdata()
        _sql = "select * from employee"
        Dim ds As New DataSet()
        ds = _con.Getdata(_sql)

        dgv.DataSource = ds.Tables(0)
        dgv.Columns("emp_id").HeaderText = "รหัสพนักงาน"
        dgv.Columns("emp_name").HeaderText = "ชื่อ"
        dgv.Columns("emp_Address").HeaderText = "ที่อยู่"
        dgv.Columns("emp_tel").HeaderText = "เบอร์โทรศัพท์"
        dgv.Columns("emp_position").HeaderText = "ตำแหน่ง"
        dgv.Columns("emp_salary").HeaderText = "เงินเดือน"

        dgv.Columns("emp_id").Width = 40
        dgv.Columns("emp_name").Width = 60
        dgv.Columns("emp_Address").Width = 60
        dgv.Columns("emp_tel").Width = 60
        dgv.Columns("emp_position").Width = 60
        dgv.Columns("emp_salary").Width = 60
        ClearTxt()

    End Sub

    Public Sub Add()
        ClearTxt()
        _sql = "select MAX(emp_id)+1 from employee "
        Dim ds As New DataSet()
        ds = _con.Getdata(_sql)

        If ds.Tables(0).Rows(0)(0).ToString() <> "" Then
            txtEmpID.Text = ds.Tables(0).Rows(0)(0).ToString()
        Else
            txtEmpID.Text = "1"
        End If

        txtEmpName.Focus()
        btnSave.Enabled = True
    End Sub

    Public Sub ClearTxt()
        txtEmpID.Text = ""
        txtEmpName.Text = ""
        txtEmpAdd.Text = ""
        txtTel.Text = ""
        txtSalary.Text = ""
    End Sub

    Public Sub Edit()
        For Each dgvs As DataGridViewRow In dgv.SelectedRows
            txtEmpID.Text = dgvs.Cells("emp_id").Value.ToString()
            txtEmpName.Text = dgvs.Cells("emp_name").Value.ToString()
            txtEmpAdd.Text = dgvs.Cells("emp_address").Value.ToString()
            txtTel.Text = dgvs.Cells("emp_tel").Value.ToString()
            txtSalary.Text = dgvs.Cells("emp_salary").Value.ToString()
            cmbPosition.SelectedText = dgvs.Cells("emp_position").Value.ToString()
        Next dgvs

    End Sub

    Public Sub Search()
        _sql = "select * from employee where 1=1 "
        If Not (txtEmpID.Text = "") Then
            _sql &= " and emp_ID like '%" & txtEmpID.Text & "%'"
        End If
        If Not (txtEmpName.Text = "") Then
            _sql &= " and emp_name like '%" & txtEmpName.Text & "%'"
        End If
        If Not (txtEmpAdd.Text = "") Then
            _sql &= " and emp_address like '%" & txtEmpAdd.Text & "%'"
        End If
        If Not (txtTel.Text.Trim() = "-") Then
            _sql &= " and emp_tel like '%" & txtTel.Text & "%'"
        End If
        If Not (txtSalary.Text = "") Then
            _sql &= " and emp_salary like '%" & txtSalary.Text & "%'"
        End If
        If cmbPosition.SelectedIndex <> -1 And cmbPosition.Text <> "" Then
            _sql &= " and emp_position ='" & cmbPosition.Text & "'"
        End If

        Dim ds As New DataSet()
        ds = _con.Getdata(_sql)

        dgv.DataSource = ds.Tables(0)
        dgv.Columns("emp_id").HeaderText = "รหัสพนักงาน"
        dgv.Columns("emp_name").HeaderText = "ชื่อ"
        dgv.Columns("emp_Address").HeaderText = "ที่อยู่"
        dgv.Columns("emp_tel").HeaderText = "เบอร์โทรศัพท์"
        dgv.Columns("emp_position").HeaderText = "ตำแหน่ง"
        dgv.Columns("emp_salary").HeaderText = "เงินเดือน"

        dgv.Columns("emp_id").Width = 40
        dgv.Columns("emp_name").Width = 60
        dgv.Columns("emp_Address").Width = 60
        dgv.Columns("emp_tel").Width = 60
        dgv.Columns("emp_position").Width = 60
        dgv.Columns("emp_salary").Width = 60

    End Sub

    Public Sub Delete()
    End Sub

    Public Sub Save()
        If Validation() Then

            _sql = "select * from employee where emp_id =" & txtEmpID.Text & ""
            Dim ds As New DataSet()
            ds = _con.Getdata(_sql)
            If ds.Tables(0).Rows.Count > 0 Then
                _sql = "update employee set emp_name ='" & txtEmpName.Text & "', emp_address='" & txtEmpAdd.Text & "', emp_position='" & cmbPosition.Text & "',emp_salary=" & txtSalary.Text & " where emp_id =" & txtEmpID.Text & " "

            Else
                _sql = "insert into employee (emp_name, emp_address, emp_tel, emp_position, emp_salary)  "
                _sql &= "values ('" & txtEmpName.Text & "','" & txtEmpAdd.Text & "','" & txtTel.Text & "','" & cmbPosition.Text & "'," & txtSalary.Text & ")"
            End If
            Dim i As Integer = _con.Query(_sql)
            If i >= 1 Then
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย")
                Showdata()
            Else
                MessageBox.Show("ผิดพลาดในการบันทึกข้อมูล ")
            End If
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง")
        End If

    End Sub

    Private Function Validation() As Boolean

        If txtEmpName.Text = "" Then
            Return False
        End If
        If txtEmpAdd.Text = "" Then
            Return False
        End If
        If txtTel.Text = "" Then
            Return False
        End If
        If txtSalary.Text = "" Then
            Return False
        End If
        If cmbPosition.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Add()

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Edit()
    End Sub

    Private Sub dgv_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgv.SelectionChanged
        For Each dgvs As DataGridViewRow In dgv.SelectedRows
            _status = dgvs.Cells("emp_id").Value.ToString()
        Next dgvs
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("คุณต้องการลบ '" & dgv.SelectedRows(0).Cells(1).Value.ToString() & "' ใช่หรือไม่?", "กดยืนยันเพื่อลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _sql = "delete from employee where emp_id =" & _status
            Dim i As Integer = _con.Query(_sql)
            If i > 0 Then
                MessageBox.Show("ลบข้อมูลเรียบร้อย")
                Showdata()
            Else
                MessageBox.Show("ผิดพลาดในการลบข้อมูล ")
            End If
        End If
    End Sub


    Private Sub txtSalary_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If Convert.ToInt32(e.KeyChar) >= 48 AndAlso Convert.ToInt32(e.KeyChar) <= 57 Then
            e.Handled = False
        ElseIf (Convert.ToInt32(e.KeyChar) = 8) OrElse (Convert.ToInt32(e.KeyChar) = 13) OrElse (Convert.ToInt32(e.KeyChar) = 46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmpID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtEmpID.TextChanged

    End Sub
End Class