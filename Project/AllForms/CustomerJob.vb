
Imports AllClasses

Namespace AllForms
    Partial Public Class CustomerJob
        Friend Sub New()
            InitializeComponent()
        End Sub

        Private ReadOnly _con As New DbConnect()
        Private _ds As New DataSet()

        Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
            Dim bill As New frmBill()
            bill.Show()
        End Sub

        Private Sub CustomerJob_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            cbJobType.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Fill_ComboBox()
            NewCustomerID()
            Fill_dataGridView()
        End Sub

        Private Function Validation() As Boolean
            If _
                cbCusID.Text <> "" AndAlso cbCusName.Text <> "" AndAlso cbJobType.SelectedIndex <> - 1 AndAlso
                nudCount.Value <> 0 AndAlso nudHeight.Value <> 0 AndAlso txtJobID.Text <> "" AndAlso
                txtjobtitle.Text <> "" AndAlso nudPrice.Value <> 0 AndAlso nudWidth.Value <> 0 AndAlso
                cbStatus.SelectedIndex <> - 1 Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub Fill_dataGridView()

            ' ReSharper disable once RedundantAssignment
            Dim ds As New DataSet()

            Dim sql As String =
                    "SELECT Orders.Job_Id, Orders.Job_Name, Orders.Job_Class, Orders.Job_Num, Orders.Job_Size, Orders.Job_Price, Orders.Job_Date, Orders.Job_Sent, Orders.Job_Script, Customer.Cus_Name, Employee.Emp_Name,"
            If Not CheckBox1.Checked And cbCusID.SelectedIndex <> - 1 Then
                sql &= " Orders.Job_Status "
                sql &= "FROM ((Orders INNER JOIN "
                sql &= " Employee ON Orders.Emp_Id = Employee.Emp_Id) INNER JOIN "
                sql &= "Customer ON Orders.Cus_Id = Customer.Cus_Id) ORDER BY Orders.Job_Id"
            Else
                sql &= " Orders.Job_Status "
                sql &= "FROM ((Orders INNER JOIN "
                sql &= " Employee ON Orders.Emp_Id = Employee.Emp_Id) INNER JOIN "
                sql &= "Customer ON Orders.Cus_Id = Customer.Cus_Id) WHERE Customer.Cus_Id=" &
                       Convert.ToInt32(cbCusID.SelectedValue) & " ORDER BY Orders.Job_Id"
            End If
            Try

                dgv.Refresh()
                ds = _con.Getdata(sql)
                dgv.DataSource = ds.Tables(0)

                For i As Integer = 0 To dgv.ColumnCount - 1
                    If i <> 0 Then
                        dgv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Else
                        dgv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End If
                Next i
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            Dim header() As String =
                    {"รหัสงาน", "ชื่อ", "ประเภท", "จำนวน", "ขนาด", "ราคา", "วันรับงาน", "วันส่งงาน", "หมายเหตุ",
                     "ชื่อลูกค้า", "ชื่อพนักงาน", "สถานะ"}
            For i As Integer = 0 To dgv.ColumnCount - 1
                dgv.Columns(i).HeaderText = header(i)
                dgv.Columns(i).Width = 80
            Next i
        End Sub

        Private Sub Fill_ComboBox()
            _ds = _con.getdata("SELECT Cus_Id, Cus_Name FROM  Customer ORDER BY Cus_ID ASC")

            cbCusName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbCusName.AutoCompleteSource = AutoCompleteSource.ListItems

            cbCusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cbCusID.AutoCompleteSource = AutoCompleteSource.ListItems
            '------------------------------------------

            cbCusName.DataSource = _ds.Tables(0)
            cbCusName.ValueMember = "Cus_Id"
            cbCusName.DisplayMember = "Cus_Name"

            cbCusID.DataSource = _ds.Tables(0)
            cbCusID.ValueMember = "Cus_Id"
            cbCusID.DisplayMember = "Cus_Id"
        End Sub

        Private Sub NewCustomerId()
            ' ReSharper disable once RedundantAssignment
            Dim id As New DataSet()
            id = _con.getdata("SELECT MAX(Job_Id)+1 FROM Orders")
            If id.Tables(0).Rows(0)(0).ToString() <> "" Then
                txtJobID.Text = id.Tables(0).Rows(0)(0).ToString()
            Else
                ' ReSharper disable once LocalizableElement
                txtJobID.Text = "1"
            End If
        End Sub

        Private Sub CheckPrice()

            If _
                cbJobType.SelectedIndex <> - 1 And nudWidth.Value <> 0 And nudHeight.Value <> 0 And
                SimulateIsNumeric.IsNumeric(nudWidth.Value) And SimulateIsNumeric.IsNumeric(nudHeight.Value) And
                SimulateIsNumeric.IsNumeric(nudCount.Value) And nudCount.Value <> 0 Then

                If cbJobType.SelectedIndex = 0 Then
                    nudPrice.Value = (((nudWidth.Value*nudHeight.Value)*200)*nudCount.Value)

                ElseIf cbJobType.SelectedIndex >= 1 AndAlso cbJobType.SelectedIndex <= 3 Then
                    nudPrice.Value = (((nudWidth.Value*nudHeight.Value)*550)*nudCount.Value)

                ElseIf cbJobType.SelectedIndex = 4 Then
                    nudPrice.Value = (((nudWidth.Value*nudHeight.Value)*800)*nudCount.Value)

                ElseIf cbJobType.SelectedIndex = 5 Then
                    nudPrice.Value = (((nudWidth.Value*nudHeight.Value)*550)*nudCount.Value)

                ElseIf cbJobType.SelectedIndex = 6 Then
                    nudPrice.Value = (((nudWidth.Value*nudHeight.Value)*750)*nudCount.Value)
                End If

            Else
                nudPrice.Value = 0
            End If
            _def = nudPrice.Value
        End Sub

        Private Sub cbCusName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
            Handles cbCusName.SelectedIndexChanged
            If cbCusName.SelectedIndex > - 1 Then
                Fill_dataGridView()
            End If
        End Sub

        Private Sub GroupBox1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox1.Enter
        End Sub

        Private Sub cbJobType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
            Handles cbJobType.SelectedIndexChanged
            CheckPrice()
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

            If Validation() <> False Then
                If _con.Query("SELECT * FROM Orders WHERE Job_ID=" & Convert.ToInt32(txtJobID.Text) & "") = 0 Then

                    Dim sql As String = "insert into orders values("
                    sql &= "" & Convert.ToInt32(txtJobID.Text) & ","
                    sql &= "'" & txtjobtitle.Text & "',"
                    sql &= "'" & cbJobType.Text & "',"
                    sql &= "" & Convert.ToInt32(nudCount.Value) & ","
                    sql &= "'" & nudWidth.Value & "x" & nudHeight.Value & "',"
                    sql &= "" & Convert.ToDouble(nudPrice.Value) & ","
                    sql &= "'" & dtRDate.Value & "',"
                    sql &= "'" & dtSdate.Value & "',"
                    sql &= "'" & txtScript.Text & "',"
                    sql &= "" & Convert.ToInt32(cbCusID.SelectedValue) & ","
                    sql &= "" & Convert.ToInt32(DbConnect.LogId) & ", "
                    sql &= "'" & cbStatus.Text & "')"

                    If CInt(_con.Query(sql)) >= 1 Then
                        ' ReSharper disable once LocalizableElement
                        MessageBox.Show("เพิ่มข้อมูลสำร็จ")
                        ClearText()
                    Else
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้")
                    End If
                Else
                    MessageBox.Show("ตรวจพบข้อมูลซ้ำซ้อน กรุณากรอกข้อมูลใหม่")
                    ClearText()
                End If
            Else
                MessageBox.Show(Me, "กรุณากรอกข้อมูลให้ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Fill_dataGridView()
            NewCustomerId()
        End Sub

        Private Sub ClearText()
            nudCount.Value = 0
            nudHeight.Value = 0
            txtJobID.Text = ""
            txtjobtitle.Text = ""
            nudPrice.Value = 0
            txtScript.Text = ""
            nudWidth.Value = 0
            cbStatus.SelectedIndex = 0
            CheckBox2.Checked = False
        End Sub

        Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
            If dgv.SelectedRows.Count <> - 1 Then
                ' ReSharper disable once LocalizableElement
                If _
                    MessageBox.Show(Me,
                                    "คุณต้องการลบ '" & dgv.SelectedRows(0).Cells(1).Value.ToString() &
                                    "' ออกจากฐานข้อมูลใช่หรือไม่?", "ลบข้อมูล", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) = DialogResult.Yes Then
                    If _
                        CInt(
                            _con.Query(
                                "DELETE FROM Orders WHERE Job_Id=" & dgv.SelectedRows(0).Cells(0).Value.ToString() & "")) >=
                        1 Then
                        ' ReSharper disable once LocalizableElement
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
                    Else
                        ' ReSharper disable once LocalizableElement
                        MessageBox.Show("ไม่สามารถลบข้อมูลเรียบได้")
                    End If
                End If
                Fill_dataGridView()
                NewCustomerId()
            End If
        End Sub

        Private Sub nudCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudCount.ValueChanged
            CheckPrice()
            CheckPrice()
        End Sub

        Private Sub nudHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudHeight.ValueChanged
            CheckPrice()
        End Sub

        Private Sub nudWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudWidth.ValueChanged
            CheckPrice()
        End Sub

        Private Sub nudPrice_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudPrice.ValueChanged
        End Sub

        Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
            If dgv.SelectedRows.Count > - 1 Then
                txtJobID.Text = dgv.SelectedCells(0).Value.ToString()
                cbJobType.Text = dgv.SelectedCells(2).Value.ToString()
                nudWidth.Value = Convert.ToDecimal(SplitSize(dgv.SelectedCells(4).Value.ToString())(0))
                nudHeight.Value = Convert.ToDecimal(SplitSize(dgv.SelectedCells(4).Value.ToString())(1))
                nudCount.Value = CDec(dgv.SelectedCells(3).Value.ToString())
                txtjobtitle.Text = dgv.SelectedCells(1).Value.ToString()
                nudPrice.Value = Convert.ToDecimal(dgv.SelectedCells(5).Value.ToString())
                cbStatus.Text = dgv.SelectedCells(11).Value.ToString()
                If cbStatus.SelectedIndex = 2 Then
                    _bypass = True
                    CheckBox2.Checked = True
                End If
                cbCusName.Text = dgv.SelectedCells(9).Value.ToString()
                txtScript.Text = dgv.SelectedCells(8).Value.ToString()
                dtRDate.Value = Convert.ToDateTime(dgv.SelectedCells(6).Value.ToString())
                dtSdate.Value = Convert.ToDateTime(dgv.SelectedCells(7).Value.ToString())
            End If
        End Sub

        ' ReSharper disable once ParameterHidesMember
        Private Function SplitSize(ByVal size As String) As String()
            Return size.Split(New String() {"x"}, StringSplitOptions.None)
        End Function

        Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
            Dim sql As String = "SELECT * FROM Orders WHERE Job_Id=" & Convert.ToInt32(txtJobID.Text) & ""
            ' ReSharper disable once RedundantAssignment
            Dim ds As New DataSet()
            ds = _con.Getdata(sql)
            If ds.Tables(0).Rows.Count >= 1 Then
                sql = "UPDATE Orders SET "
                sql &= "Job_Name='" & txtjobtitle.Text & "',"
                sql &= "Job_Class='" & cbJobType.Text & "',"
                sql &= "Job_Num=" & Convert.ToInt32(nudCount.Value) & ","
                sql &= "Job_Size='" & nudWidth.Value.ToString() & "x" & nudHeight.Value.ToString() & "',"
                sql &= "Job_Price=" & nudPrice.Value & ","
                sql &= "Job_Date='" & dtRDate.Value & "',"
                sql &= "Job_Sent='" & dtSdate.Value & "',"
                sql &= "Job_Script='" & txtScript.Text & "',"
                sql &= "Cus_Id=" & Convert.ToInt32(cbCusID.Text) & ","
                sql &= "Job_Status='" & cbStatus.Text & "'"
                sql &= " WHERE Job_ID=" & Convert.ToInt32(txtJobID.Text) & ""


                If _con.Query(sql) = 1 Then
                    ' ReSharper disable once LocalizableElement
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ")
                    ClearText()
                    Fill_dataGridView()
                    NewCustomerId()
                Else
                    ' ReSharper disable once LocalizableElement
                    MessageBox.Show("บันทึกข้อมูลล้มเหลว")
                End If
            Else
                ' ReSharper disable once LocalizableElement
                MessageBox.Show("ไม่มีข้อมูลดังกล่าวอยู่ในฐานข้อมูล")
            End If
        End Sub

        Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
            If dgv.SelectedRows.Count >= 1 Then
                FrmOrder.JobId = Convert.ToInt32(dgv.SelectedRows(0).Cells(0).Value)
                Dim order As New FrmOrder()
                order.Show()
            End If
        End Sub

        Private Sub dgv_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) _
            Handles dgv.CellContentClick
        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
            Fill_dataGridView()
        End Sub

        Dim _def As Decimal
        Dim _bypass As Boolean = False

        Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
            If nudPrice.Value <> 0 And _bypass = False Then
                If CheckBox2.Checked Then
                    nudPrice.Value = nudPrice.Value/2
                    cbStatus.SelectedIndex = 2
                Else
                    nudPrice.Value = _def
                    CheckBox2.Checked = False
                    cbStatus.SelectedIndex = 1
                End If


            Else
                If _bypass = True Then
                    CheckBox2.Checked = True
                    _bypass = False
                Else
                    cbStatus.SelectedIndex = 1
                    CheckBox2.Checked = False
                End If
            End If
        End Sub


        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If cbStatus.SelectedIndex = 2 Then
                CheckBox2.Checked = True
            End If
        End Sub
    End Class
End NameSpace