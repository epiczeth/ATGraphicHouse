Namespace AllForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MySqlSetting
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MySqlSetting))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtdb = New System.Windows.Forms.TextBox()
            Me.txtpass = New System.Windows.Forms.TextBox()
            Me.txtuid = New System.Windows.Forms.TextBox()
            Me.txtport = New System.Windows.Forms.TextBox()
            Me.txthost = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtdb)
            Me.GroupBox1.Controls.Add(Me.txtpass)
            Me.GroupBox1.Controls.Add(Me.txtuid)
            Me.GroupBox1.Controls.Add(Me.txtport)
            Me.GroupBox1.Controls.Add(Me.txthost)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(468, 116)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "MySQL"
            '
            'txtdb
            '
            Me.txtdb.Location = New System.Drawing.Point(103, 77)
            Me.txtdb.Name = "txtdb"
            Me.txtdb.Size = New System.Drawing.Size(107, 20)
            Me.txtdb.TabIndex = 9
            Me.txtdb.Text = "cdth"
            Me.txtdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtdb.Visible = False
            '
            'txtpass
            '
            Me.txtpass.Location = New System.Drawing.Point(325, 51)
            Me.txtpass.Name = "txtpass"
            Me.txtpass.Size = New System.Drawing.Size(127, 20)
            Me.txtpass.TabIndex = 8
            Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtpass.UseSystemPasswordChar = True
            '
            'txtuid
            '
            Me.txtuid.Location = New System.Drawing.Point(103, 51)
            Me.txtuid.Name = "txtuid"
            Me.txtuid.Size = New System.Drawing.Size(154, 20)
            Me.txtuid.TabIndex = 7
            Me.txtuid.Text = "root"
            Me.txtuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtport
            '
            Me.txtport.Location = New System.Drawing.Point(325, 25)
            Me.txtport.Name = "txtport"
            Me.txtport.Size = New System.Drawing.Size(78, 20)
            Me.txtport.TabIndex = 6
            Me.txtport.Text = "3306"
            Me.txtport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txthost
            '
            Me.txthost.Location = New System.Drawing.Point(103, 25)
            Me.txthost.Name = "txthost"
            Me.txthost.Size = New System.Drawing.Size(154, 20)
            Me.txthost.TabIndex = 5
            Me.txthost.Text = "localhost"
            Me.txthost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(21, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(56, 13)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Database:"
            Me.Label5.Visible = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(263, 54)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(56, 13)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Password:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(21, 58)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "User name:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(263, 28)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(29, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Port:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(21, 28)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(76, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Host name/IP:"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(12, 134)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(126, 31)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "ทดสอบการเชื่อมต่อ"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Enabled = False
            Me.Button2.Location = New System.Drawing.Point(327, 134)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(70, 31)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "บันทึก"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(403, 134)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(77, 31)
            Me.Button3.TabIndex = 3
            Me.Button3.Text = "ยกเลิก"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'Button4
            '
            Me.Button4.Enabled = False
            Me.Button4.Location = New System.Drawing.Point(223, 134)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(98, 31)
            Me.Button4.TabIndex = 4
            Me.Button4.Text = "สร้างฐานข้อมูล"
            Me.Button4.UseVisualStyleBackColor = True
            Me.Button4.Visible = False
            '
            'MySqlSetting
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(494, 173)
            Me.Controls.Add(Me.Button4)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MySqlSetting"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "ตั้งค่า MySQL"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtdb As System.Windows.Forms.TextBox
        Friend WithEvents txtpass As System.Windows.Forms.TextBox
        Friend WithEvents txtuid As System.Windows.Forms.TextBox
        Friend WithEvents txtport As System.Windows.Forms.TextBox
        Friend WithEvents txthost As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents Button4 As System.Windows.Forms.Button
    End Class
End Namespace