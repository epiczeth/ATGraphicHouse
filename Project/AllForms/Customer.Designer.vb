'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace AllForms

    <DesignerGenerated()> _
    Partial Public Class Customer
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbCusName = New System.Windows.Forms.ComboBox()
            Me.cbCusID = New System.Windows.Forms.ComboBox()
            Me.txtCusTel = New System.Windows.Forms.MaskedTextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCusEmail = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtCusGov = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtCusAdd = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dgv = New System.Windows.Forms.DataGridView()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnEdit = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbCusName)
            Me.GroupBox1.Controls.Add(Me.cbCusID)
            Me.GroupBox1.Controls.Add(Me.txtCusTel)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtCusEmail)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtCusGov)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtCusAdd)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(689, 113)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "จัดการข้อมูลลูกค้า"
            '
            'cbCusName
            '
            Me.cbCusName.FormattingEnabled = True
            Me.cbCusName.Location = New System.Drawing.Point(131, 50)
            Me.cbCusName.Name = "cbCusName"
            Me.cbCusName.Size = New System.Drawing.Size(169, 21)
            Me.cbCusName.TabIndex = 15
            '
            'cbCusID
            '
            Me.cbCusID.FormattingEnabled = True
            Me.cbCusID.Location = New System.Drawing.Point(131, 23)
            Me.cbCusID.Name = "cbCusID"
            Me.cbCusID.Size = New System.Drawing.Size(169, 21)
            Me.cbCusID.TabIndex = 14
            '
            'txtCusTel
            '
            Me.txtCusTel.Location = New System.Drawing.Point(393, 45)
            Me.txtCusTel.Mask = "00-00000000"
            Me.txtCusTel.Name = "txtCusTel"
            Me.txtCusTel.Size = New System.Drawing.Size(169, 20)
            Me.txtCusTel.TabIndex = 13
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(350, 78)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 13)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "อีเมลล์"
            '
            'txtCusEmail
            '
            Me.txtCusEmail.Location = New System.Drawing.Point(393, 71)
            Me.txtCusEmail.Name = "txtCusEmail"
            Me.txtCusEmail.Size = New System.Drawing.Size(169, 20)
            Me.txtCusEmail.TabIndex = 10
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(315, 52)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 13)
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "เบอร์โทรศัพท์"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(311, 25)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(78, 13)
            Me.Label6.TabIndex = 8
            Me.Label6.Text = "หน่วยงานสังกัด"
            '
            'txtCusGov
            '
            Me.txtCusGov.Location = New System.Drawing.Point(393, 19)
            Me.txtCusGov.Name = "txtCusGov"
            Me.txtCusGov.Size = New System.Drawing.Size(169, 20)
            Me.txtCusGov.TabIndex = 6
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(98, 79)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(27, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "ที่อยู่"
            '
            'txtCusAdd
            '
            Me.txtCusAdd.Location = New System.Drawing.Point(131, 76)
            Me.txtCusAdd.Name = "txtCusAdd"
            Me.txtCusAdd.Size = New System.Drawing.Size(169, 20)
            Me.txtCusAdd.TabIndex = 4
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(80, 53)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(45, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "ชื่อลูกค้า"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(74, 26)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(51, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "รหัสลูกค้า"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dgv)
            Me.GroupBox2.Location = New System.Drawing.Point(25, 131)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(689, 231)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "รายการลูกค้า"
            '
            'dgv
            '
            Me.dgv.AllowUserToAddRows = False
            Me.dgv.AllowUserToDeleteRows = False
            Me.dgv.AllowUserToOrderColumns = True
            Me.dgv.AllowUserToResizeRows = False
            Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgv.Location = New System.Drawing.Point(12, 22)
            Me.dgv.Name = "dgv"
            Me.dgv.ReadOnly = True
            Me.dgv.RowHeadersVisible = False
            Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgv.Size = New System.Drawing.Size(667, 193)
            Me.dgv.TabIndex = 0
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnEdit)
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnAdd)
            Me.GroupBox3.Location = New System.Drawing.Point(163, 368)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(421, 82)
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Control"
            '
            'btnSave
            '
            Me.btnSave.Image = Global.Project.My.Resources.Resources.disk_icon
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnSave.Location = New System.Drawing.Point(316, 19)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 51)
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "บันทึก"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnEdit
            '
            Me.btnEdit.Image = Global.Project.My.Resources.Resources.Document_Write_icon
            Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnEdit.Location = New System.Drawing.Point(223, 19)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(75, 51)
            Me.btnEdit.TabIndex = 2
            Me.btnEdit.Text = "แก้ไขลูกค้า"
            Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnEdit.UseVisualStyleBackColor = True
            '
            'btnDelete
            '
            Me.btnDelete.Image = Global.Project.My.Resources.Resources.Button_Delete_icon
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDelete.Location = New System.Drawing.Point(133, 19)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(75, 51)
            Me.btnDelete.TabIndex = 1
            Me.btnDelete.Text = "ลบลูกค้า"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnDelete.UseVisualStyleBackColor = True
            '
            'btnAdd
            '
            Me.btnAdd.Image = Global.Project.My.Resources.Resources.Button_Add_icon
            Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnAdd.Location = New System.Drawing.Point(24, 19)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(96, 51)
            Me.btnAdd.TabIndex = 0
            Me.btnAdd.Text = "เพิ่มลูกค้าใหม่"
            Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAdd.UseVisualStyleBackColor = True
            '
            'Customer
            '
            Me.BackColor = System.Drawing.Color.LightBlue
            Me.ClientSize = New System.Drawing.Size(747, 462)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Customer"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "จัดการข้อมูลลูกค้า"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend GroupBox1 As GroupBox
        Friend Label4 As Label
        Friend txtCusEmail As TextBox
        Friend Label5 As Label
        Friend Label6 As Label
        Friend txtCusGov As TextBox
        Friend Label3 As Label
        Friend txtCusAdd As TextBox
        Friend Label2 As Label
        Friend Label1 As Label
        Friend GroupBox2 As GroupBox
        Friend WithEvents dgv As DataGridView
        Friend GroupBox3 As GroupBox
        Friend WithEvents btnSave As Button
        Friend WithEvents btnEdit As Button
        Friend WithEvents btnDelete As Button
        Friend WithEvents btnAdd As Button
        Friend txtCusTel As MaskedTextBox
        Friend WithEvents cbCusName As System.Windows.Forms.ComboBox
        Friend WithEvents cbCusID As System.Windows.Forms.ComboBox
    End Class
End NameSpace