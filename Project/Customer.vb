


Partial Public Class Customer
    Friend Sub New()
        InitializeComponent()
    End Sub
    Private ReadOnly _con As New DbConnect()
    Private _status As String
    Private _sql As String
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
        Search()
    End Sub

    Private Sub Customer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Showdata()
        FillCombobox()

    End Sub

    Public Sub Showdata()

        Dim ds As New DataSet()
        ds = _con.Getdata("select * from Customer")

        dgv.DataSource = ds.Tables(0)
        dgv.Columns("cus_id").HeaderText = "รหัสพนักงาน"
        dgv.Columns("cus_name").HeaderText = "ชื่อ"
        dgv.Columns("cus_Address").HeaderText = "ที่อยู่"
        dgv.Columns("cus_Gov").HeaderText = "หน่วยงานสังกัด"
        dgv.Columns("cus_Tel").HeaderText = "เบอร์โทรศัพท์"
        dgv.Columns("cus_Email").HeaderText = "อีเมลล์"

        dgv.Columns("cus_id").Width = 80
        dgv.Columns("cus_name").Width = 100
        dgv.Columns("cus_Address").Width = 100
        dgv.Columns("cus_Gov").Width = 100
        dgv.Columns("cus_Tel").Width = 100
        dgv.Columns("cus_Email").Width = 100
        For i As Integer = 0 To dgv.ColumnCount - 1
            If i <> 0 Then
                dgv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                dgv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Next i
        ClearTxt()

    End Sub
    Public Sub Add()
        ClearTxt()
        _sql = "select MAX(cus_id)+1 from customer"
        Dim ds As New DataSet()
        ds = _con.getdata(_sql)
        If ds.Tables(0).Rows(0)(0).ToString() <> "" Then
            cbCusID.Text = ds.Tables(0).Rows(0)(0).ToString()
        Else
            cbCusID.Text = "1"
        End If
        cbCusName.Focus()
        btnSave.Enabled = True
    End Sub
    Public Sub ClearTxt()
        cbCusName.Text = ""
        txtCusAdd.Text = ""
        txtCusGov.Text = ""
        txtCusTel.Text = ""
        txtCusEmail.Text = ""
    End Sub
    Public Sub Edit()
        For Each dgvs As DataGridViewRow In dgv.SelectedRows
            cbCusID.Text = dgvs.Cells("cus_id").Value.ToString()
            cbCusName.Text = dgvs.Cells("cus_name").Value.ToString()
            txtCusAdd.Text = dgvs.Cells("cus_address").Value.ToString()
            txtCusGov.Text = dgvs.Cells("cus_gov").Value.ToString()
            txtCusTel.Text = dgvs.Cells("cus_tel").Value.ToString()
            txtCusEmail.Text = dgvs.Cells("cus_email").Value.ToString()
        Next dgvs
    End Sub
    Public Sub Search()
        _sql = "SELECT * FROM Customer WHERE Cus_Id=" & Convert.ToInt32(cbCusID.SelectedValue) & ""

        Dim ds As New DataSet()
        ds = _con.getdata(_sql)

        dgv.DataSource = ds.Tables(0)
        dgv.Columns("cus_id").HeaderText = "รหัสพนักงาน"
        dgv.Columns("cus_name").HeaderText = "ชื่อ"
        dgv.Columns("cus_Address").HeaderText = "ที่อยู่"
        dgv.Columns("cus_Gov").HeaderText = "หน่วยงานสังกัด"
        dgv.Columns("cus_Tel").HeaderText = "เบอร์โทรศัพท์"
        dgv.Columns("cus_Email").HeaderText = "อีเมลล์"

        dgv.Columns("cus_id").Width = 80
        dgv.Columns("cus_name").Width = 100
        dgv.Columns("cus_Address").Width = 100
        dgv.Columns("cus_Gov").Width = 100
        dgv.Columns("cus_Tel").Width = 100
        dgv.Columns("cus_Email").Width = 100
        clearTxt()
    End Sub

    Private Sub FillCombobox()
        Dim ds As New DataSet
        ds = _con.Getdata("SELECT Cus_Id, Cus_Name FROM Customer ORDER BY Cus_Id ASC")
        cbCusID.DataSource = ds.Tables(0)
        cbCusID.DisplayMember = "Cus_Id"
        cbCusID.ValueMember = "Cus_Id"

        cbCusName.DataSource = ds.Tables(0)
        cbCusName.DisplayMember = "Cus_Name"
        cbCusName.ValueMember = "Cus_Id"

        cbCusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbCusID.AutoCompleteSource = AutoCompleteSource.ListItems

        cbCusName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbCusName.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Public Sub Save()
        If Validation() Then

            _sql = "select * from customer where cus_id =" & cbCusID.Text & ""
            Dim ds As New DataSet()
            ds = _con.getdata(_sql)
            If ds.Tables(0).Rows.Count > 0 Then
                _sql = "update customer set cus_name ='" & cbCusName.Text & "', cus_address='" & txtCusAdd.Text & "', cus_gov='" & txtCusGov.Text & "',cus_tel='" & txtCusTel.Text & "',cus_email='" & txtCusEmail.Text & "' where cus_id=" & cbCusID.Text & ""
            Else
                _sql = "insert into customer (cus_name, cus_address, cus_tel, cus_gov, cus_email)  "
                _sql &= "values ('" & cbCusName.Text & "','" & txtCusAdd.Text & "','" & txtCusTel.Text & "','" & txtCusGov.Text & "','" & txtCusEmail.Text & "')"
            End If
            Dim i As Integer = Convert.ToInt32(_con.query(_sql))
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

        If cbCusName.Text = "" Then
            Return False
        End If
        If txtCusAdd.Text = "" Then
            Return False
        End If
        If txtCusTel.Text = "" Then
            Return False
        End If
        If txtCusGov.Text = "" Then
            Return False
        End If
        If txtCusEmail.Text = "" Then
            Return False
        End If
        Return True
    End Function
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        add()

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        edit()
    End Sub
    Private Sub dgv_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgv.SelectionChanged
        For Each dgvs As DataGridViewRow In dgv.SelectedRows
            _status = dgvs.Cells("cus_id").Value.ToString()
        Next dgvs
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("คุณต้องการลบ '" & dgv.SelectedRows(0).Cells(1).Value.ToString() & "' ออกจากฐานข้อมูลใช่หรือไม่?", "กดยืนยันเพื่อลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            _sql = "delete from customer where cus_id =" & _status
            Dim i As Integer = Convert.ToInt32(_con.query(_sql))
            If i > 0 Then
                MessageBox.Show("ลบข้อมูลเรียบร้อย")
                Showdata()
            Else
                MessageBox.Show("ผิดพลาดในการลบข้อมูล ")
            End If
        End If
    End Sub
End Class