'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace AllForms

    <DesignerGenerated()> _
    Partial Public Class Login
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtuser = New System.Windows.Forms.TextBox()
            Me.txtpass = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(200, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(207, 24)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "ระบบจัดเก็บข้อมูลการขาย"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(189, 40)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(237, 24)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "สำหรับร้านแอท กราฟฟิคเฮาส์"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(170, 84)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(58, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "ชื่อผู้ใช้งาน"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(182, 113)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(46, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "รหัสผ่าน"
            '
            'txtuser
            '
            Me.txtuser.Location = New System.Drawing.Point(234, 81)
            Me.txtuser.Name = "txtuser"
            Me.txtuser.Size = New System.Drawing.Size(156, 20)
            Me.txtuser.TabIndex = 5
            Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtpass
            '
            Me.txtpass.Location = New System.Drawing.Point(234, 109)
            Me.txtpass.Name = "txtpass"
            Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtpass.Size = New System.Drawing.Size(156, 20)
            Me.txtpass.TabIndex = 6
            Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(234, 135)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 7
            Me.Button1.Text = "เข้าสู่ระบบ"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Button2.Location = New System.Drawing.Point(315, 135)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 8
            Me.Button2.Text = "ยกเลิก"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.BackgroundImage = Global.Project.My.Resources.Resources.administrative_tools
            Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button3.Location = New System.Drawing.Point(442, 6)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(30, 28)
            Me.Button3.TabIndex = 9
            Me.Button3.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.ErrorImage = Nothing
            Me.PictureBox1.Image = Global.Project.My.Resources.Resources.ModernXP_07_Keys_icon
            Me.PictureBox1.InitialImage = Nothing
            Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(143, 157)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'Login
            '
            Me.AcceptButton = Me.Button1
            Me.CancelButton = Me.Button2
            Me.ClientSize = New System.Drawing.Size(479, 183)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.txtpass)
            Me.Controls.Add(Me.txtuser)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Label2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Login"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PictureBox1 As PictureBox
        Friend Label1 As Label
        Friend Label2 As Label
        Friend Label3 As Label
        Friend Label4 As Label
        Friend txtuser As TextBox
        Friend txtpass As TextBox
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button

        Private Shared _DefaultInstance As Login
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Public Shared ReadOnly Property DefaultInstance() As Login
            Get
                If _DefaultInstance Is Nothing Then
                    _DefaultInstance = New Login()
                End If

                Return _DefaultInstance
            End Get
        End Property
    End Class
End NameSpace