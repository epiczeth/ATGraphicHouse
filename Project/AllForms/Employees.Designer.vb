'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace AllForms

    <DesignerGenerated()> _
    Partial Public Class Employees
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employees))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtEmpID = New System.Windows.Forms.TextBox()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbPosition = New System.Windows.Forms.ComboBox()
            Me.txtTel = New System.Windows.Forms.MaskedTextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtSalary = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtEmpAdd = New System.Windows.Forms.TextBox()
            Me.txtEmpName = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgv = New System.Windows.Forms.DataGridView()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnEdit = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(22, 42)
            Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "รหัสพนักงาน"
            '
            'txtEmpID
            '
            Me.txtEmpID.Location = New System.Drawing.Point(95, 39)
            Me.txtEmpID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.txtEmpID.Name = "txtEmpID"
            Me.txtEmpID.Size = New System.Drawing.Size(141, 20)
            Me.txtEmpID.TabIndex = 1
            '
            'btnSearch
            '
            Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
            Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSearch.Location = New System.Drawing.Point(251, 39)
            Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(83, 56)
            Me.btnSearch.TabIndex = 2
            Me.btnSearch.Text = "ค้นหาพนักงาน"
            Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnSearch.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.PowderBlue
            Me.GroupBox1.Controls.Add(Me.cmbPosition)
            Me.GroupBox1.Controls.Add(Me.txtTel)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.txtSalary)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtEmpAdd)
            Me.GroupBox1.Controls.Add(Me.txtEmpName)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtEmpID)
            Me.GroupBox1.Controls.Add(Me.btnSearch)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
            Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.GroupBox1.Size = New System.Drawing.Size(360, 243)
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "จัดการข้อมูลพนักงาน"
            '
            'cmbPosition
            '
            Me.cmbPosition.FormattingEnabled = True
            Me.cmbPosition.Items.AddRange(New Object() {"พนักงานออกแบบ", "เจ้าของกิจการ", "ผู้ดูแลระบบ", "ช่างเครื่อง", "ผู้ดูแลบัญชี"})
            Me.cmbPosition.Location = New System.Drawing.Point(95, 156)
            Me.cmbPosition.Name = "cmbPosition"
            Me.cmbPosition.Size = New System.Drawing.Size(141, 21)
            Me.cmbPosition.TabIndex = 14
            '
            'txtTel
            '
            Me.txtTel.Location = New System.Drawing.Point(95, 125)
            Me.txtTel.Mask = "00-00000000"
            Me.txtTel.Name = "txtTel"
            Me.txtTel.Size = New System.Drawing.Size(141, 20)
            Me.txtTel.TabIndex = 10
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(216, 189)
            Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(26, 13)
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "บาท"
            '
            'txtSalary
            '
            Me.txtSalary.Location = New System.Drawing.Point(95, 186)
            Me.txtSalary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.txtSalary.Name = "txtSalary"
            Me.txtSalary.Size = New System.Drawing.Size(111, 20)
            Me.txtSalary.TabIndex = 11
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(62, 73)
            Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 13)
            Me.Label6.TabIndex = 11
            Me.Label6.Text = "ชื่อ"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(36, 189)
            Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(51, 13)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "เงินเดือน"
            '
            'txtEmpAdd
            '
            Me.txtEmpAdd.Location = New System.Drawing.Point(95, 99)
            Me.txtEmpAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.txtEmpAdd.Name = "txtEmpAdd"
            Me.txtEmpAdd.Size = New System.Drawing.Size(141, 20)
            Me.txtEmpAdd.TabIndex = 7
            '
            'txtEmpName
            '
            Me.txtEmpName.Location = New System.Drawing.Point(95, 70)
            Me.txtEmpName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.txtEmpName.Name = "txtEmpName"
            Me.txtEmpName.Size = New System.Drawing.Size(141, 20)
            Me.txtEmpName.TabIndex = 6
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(40, 158)
            Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(47, 13)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "ตำแหน่ง"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(40, 128)
            Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(49, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "เบอร์โทร"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(62, 102)
            Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(27, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "ที่อยู่"
            '
            'btnAdd
            '
            Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAdd.Location = New System.Drawing.Point(54, 26)
            Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(101, 44)
            Me.btnAdd.TabIndex = 3
            Me.btnAdd.Text = "เพิ่มพนักงานใหม่"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAdd.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.PowderBlue
            Me.GroupBox2.Controls.Add(Me.dgv)
            Me.GroupBox2.Location = New System.Drawing.Point(389, 24)
            Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.GroupBox2.Size = New System.Drawing.Size(383, 243)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "รายการข้อมูลพนักงาน"
            '
            'dgv
            '
            Me.dgv.AllowUserToAddRows = False
            Me.dgv.AllowUserToDeleteRows = False
            Me.dgv.AllowUserToOrderColumns = True
            Me.dgv.AllowUserToResizeRows = False
            Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgv.Location = New System.Drawing.Point(12, 19)
            Me.dgv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.dgv.MultiSelect = False
            Me.dgv.Name = "dgv"
            Me.dgv.ReadOnly = True
            Me.dgv.RowHeadersVisible = False
            Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgv.Size = New System.Drawing.Size(360, 218)
            Me.dgv.TabIndex = 0
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.PowderBlue
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnEdit)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnAdd)
            Me.GroupBox3.Location = New System.Drawing.Point(159, 287)
            Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.GroupBox3.Size = New System.Drawing.Size(491, 87)
            Me.GroupBox3.TabIndex = 5
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Controls"
            '
            'btnSave
            '
            Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSave.Location = New System.Drawing.Point(369, 26)
            Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(74, 46)
            Me.btnSave.TabIndex = 6
            Me.btnSave.Text = "บันทึก"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnEdit
            '
            Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
            Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEdit.Location = New System.Drawing.Point(276, 26)
            Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(74, 46)
            Me.btnEdit.TabIndex = 5
            Me.btnEdit.Text = "แก้ไข"
            Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEdit.UseVisualStyleBackColor = True
            '
            'btnDelete
            '
            Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDelete.Location = New System.Drawing.Point(178, 26)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(74, 46)
            Me.btnDelete.TabIndex = 4
            Me.btnDelete.Text = "ลบ"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'Employees
            '
            Me.BackColor = System.Drawing.Color.LightBlue
            Me.ClientSize = New System.Drawing.Size(783, 386)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.Name = "Employees"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "จัดการข้อมูลพนักงาน"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend Label1 As Label
        Friend WithEvents txtEmpID As TextBox
        Friend WithEvents btnSearch As Button
        Friend GroupBox1 As GroupBox
        Friend GroupBox2 As GroupBox
        Friend GroupBox3 As GroupBox
        Friend WithEvents btnSave As Button
        Friend WithEvents btnEdit As Button
        Friend WithEvents btnDelete As Button
        Friend WithEvents btnAdd As Button
        Friend WithEvents dgv As DataGridView
        Friend txtEmpAdd As TextBox
        Friend txtEmpName As TextBox
        Friend Label4 As Label
        Friend Label3 As Label
        Friend Label2 As Label
        Friend Label5 As Label
        Friend Label7 As Label
        Friend WithEvents txtSalary As TextBox
        Friend Label6 As Label
        Friend txtTel As MaskedTextBox
        Friend cmbPosition As ComboBox
    End Class
End NameSpace