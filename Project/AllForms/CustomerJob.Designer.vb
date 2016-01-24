'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace AllForms

    <DesignerGenerated()> _
    Partial Public Class CustomerJob
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerJob))
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.cbCusID = New System.Windows.Forms.ComboBox()
            Me.cbCusName = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.CheckBox2 = New System.Windows.Forms.CheckBox()
            Me.cbStatus = New System.Windows.Forms.ComboBox()
            Me.label13 = New System.Windows.Forms.Label()
            Me.nudPrice = New System.Windows.Forms.NumericUpDown()
            Me.nudHeight = New System.Windows.Forms.NumericUpDown()
            Me.nudWidth = New System.Windows.Forms.NumericUpDown()
            Me.nudCount = New System.Windows.Forms.NumericUpDown()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.cbJobType = New System.Windows.Forms.ComboBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtjobtitle = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtJobID = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtScript = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.dtSdate = New System.Windows.Forms.DateTimePicker()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.dtRDate = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.dgv = New System.Windows.Forms.DataGridView()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.Button8 = New System.Windows.Forms.Button()
            Me.Button7 = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudCount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.CheckBox1)
            Me.GroupBox1.Controls.Add(Me.cbCusID)
            Me.GroupBox1.Controls.Add(Me.cbCusName)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.GroupBox1, "GroupBox1")
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.TabStop = False
            '
            'CheckBox1
            '
            resources.ApplyResources(Me.CheckBox1, "CheckBox1")
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'cbCusID
            '
            Me.cbCusID.FormattingEnabled = True
            resources.ApplyResources(Me.cbCusID, "cbCusID")
            Me.cbCusID.Name = "cbCusID"
            '
            'cbCusName
            '
            Me.cbCusName.FormattingEnabled = True
            resources.ApplyResources(Me.cbCusName, "cbCusName")
            Me.cbCusName.Name = "cbCusName"
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.Name = "Label2"
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Name = "Label1"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.CheckBox2)
            Me.GroupBox2.Controls.Add(Me.cbStatus)
            Me.GroupBox2.Controls.Add(Me.label13)
            Me.GroupBox2.Controls.Add(Me.nudPrice)
            Me.GroupBox2.Controls.Add(Me.nudHeight)
            Me.GroupBox2.Controls.Add(Me.nudWidth)
            Me.GroupBox2.Controls.Add(Me.nudCount)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.cbJobType)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.txtjobtitle)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtJobID)
            Me.GroupBox2.Controls.Add(Me.Label3)
            resources.ApplyResources(Me.GroupBox2, "GroupBox2")
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.TabStop = False
            '
            'CheckBox2
            '
            resources.ApplyResources(Me.CheckBox2, "CheckBox2")
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.UseVisualStyleBackColor = True
            '
            'cbStatus
            '
            Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbStatus.FormattingEnabled = True
            Me.cbStatus.Items.AddRange(New Object() {resources.GetString("cbStatus.Items"), resources.GetString("cbStatus.Items1"), resources.GetString("cbStatus.Items2")})
            resources.ApplyResources(Me.cbStatus, "cbStatus")
            Me.cbStatus.Name = "cbStatus"
            '
            'label13
            '
            resources.ApplyResources(Me.label13, "label13")
            Me.label13.Name = "label13"
            '
            'nudPrice
            '
            Me.nudPrice.DecimalPlaces = 2
            resources.ApplyResources(Me.nudPrice, "nudPrice")
            Me.nudPrice.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.nudPrice.Name = "nudPrice"
            '
            'nudHeight
            '
            Me.nudHeight.DecimalPlaces = 2
            resources.ApplyResources(Me.nudHeight, "nudHeight")
            Me.nudHeight.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.nudHeight.Name = "nudHeight"
            '
            'nudWidth
            '
            Me.nudWidth.DecimalPlaces = 2
            resources.ApplyResources(Me.nudWidth, "nudWidth")
            Me.nudWidth.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.nudWidth.Name = "nudWidth"
            '
            'nudCount
            '
            resources.ApplyResources(Me.nudCount, "nudCount")
            Me.nudCount.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.nudCount.Name = "nudCount"
            '
            'Label12
            '
            resources.ApplyResources(Me.Label12, "Label12")
            Me.Label12.Name = "Label12"
            '
            'cbJobType
            '
            Me.cbJobType.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("cbJobType.AutoCompleteCustomSource"), resources.GetString("cbJobType.AutoCompleteCustomSource1"), resources.GetString("cbJobType.AutoCompleteCustomSource2"), resources.GetString("cbJobType.AutoCompleteCustomSource3"), resources.GetString("cbJobType.AutoCompleteCustomSource4"), resources.GetString("cbJobType.AutoCompleteCustomSource5"), resources.GetString("cbJobType.AutoCompleteCustomSource6")})
            Me.cbJobType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cbJobType.FormattingEnabled = True
            Me.cbJobType.Items.AddRange(New Object() {resources.GetString("cbJobType.Items"), resources.GetString("cbJobType.Items1"), resources.GetString("cbJobType.Items2"), resources.GetString("cbJobType.Items3"), resources.GetString("cbJobType.Items4"), resources.GetString("cbJobType.Items5"), resources.GetString("cbJobType.Items6")})
            resources.ApplyResources(Me.cbJobType, "cbJobType")
            Me.cbJobType.Name = "cbJobType"
            '
            'Label8
            '
            resources.ApplyResources(Me.Label8, "Label8")
            Me.Label8.Name = "Label8"
            '
            'Label7
            '
            resources.ApplyResources(Me.Label7, "Label7")
            Me.Label7.Name = "Label7"
            '
            'Label6
            '
            resources.ApplyResources(Me.Label6, "Label6")
            Me.Label6.Name = "Label6"
            '
            'txtjobtitle
            '
            resources.ApplyResources(Me.txtjobtitle, "txtjobtitle")
            Me.txtjobtitle.Name = "txtjobtitle"
            '
            'Label5
            '
            resources.ApplyResources(Me.Label5, "Label5")
            Me.Label5.Name = "Label5"
            '
            'Label4
            '
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.Name = "Label4"
            '
            'txtJobID
            '
            resources.ApplyResources(Me.txtJobID, "txtJobID")
            Me.txtJobID.Name = "txtJobID"
            Me.txtJobID.ReadOnly = True
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.Name = "Label3"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.txtScript)
            Me.GroupBox3.Controls.Add(Me.Label11)
            Me.GroupBox3.Controls.Add(Me.dtSdate)
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.Label9)
            Me.GroupBox3.Controls.Add(Me.dtRDate)
            resources.ApplyResources(Me.GroupBox3, "GroupBox3")
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.TabStop = False
            '
            'txtScript
            '
            resources.ApplyResources(Me.txtScript, "txtScript")
            Me.txtScript.Name = "txtScript"
            '
            'Label11
            '
            resources.ApplyResources(Me.Label11, "Label11")
            Me.Label11.Name = "Label11"
            '
            'dtSdate
            '
            resources.ApplyResources(Me.dtSdate, "dtSdate")
            Me.dtSdate.Name = "dtSdate"
            '
            'Label10
            '
            resources.ApplyResources(Me.Label10, "Label10")
            Me.Label10.Name = "Label10"
            '
            'Label9
            '
            resources.ApplyResources(Me.Label9, "Label9")
            Me.Label9.Name = "Label9"
            '
            'dtRDate
            '
            resources.ApplyResources(Me.dtRDate, "dtRDate")
            Me.dtRDate.Name = "dtRDate"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.dgv)
            resources.ApplyResources(Me.GroupBox4, "GroupBox4")
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.TabStop = False
            '
            'dgv
            '
            Me.dgv.AllowUserToAddRows = False
            Me.dgv.AllowUserToDeleteRows = False
            Me.dgv.AllowUserToResizeRows = False
            Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            resources.ApplyResources(Me.dgv, "dgv")
            Me.dgv.MultiSelect = False
            Me.dgv.Name = "dgv"
            Me.dgv.ReadOnly = True
            Me.dgv.RowHeadersVisible = False
            Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.Button5)
            Me.GroupBox5.Controls.Add(Me.Button4)
            Me.GroupBox5.Controls.Add(Me.Button3)
            Me.GroupBox5.Controls.Add(Me.Button2)
            resources.ApplyResources(Me.GroupBox5, "GroupBox5")
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.TabStop = False
            '
            'Button5
            '
            Me.Button5.Image = Global.Project.My.Resources.Resources.disk_icon
            resources.ApplyResources(Me.Button5, "Button5")
            Me.Button5.Name = "Button5"
            Me.Button5.UseVisualStyleBackColor = True
            '
            'Button4
            '
            Me.Button4.Image = Global.Project.My.Resources.Resources.Document_Write_icon
            resources.ApplyResources(Me.Button4, "Button4")
            Me.Button4.Name = "Button4"
            Me.Button4.UseVisualStyleBackColor = True
            '
            'Button3
            '
            Me.Button3.Image = Global.Project.My.Resources.Resources.Button_Delete_icon
            resources.ApplyResources(Me.Button3, "Button3")
            Me.Button3.Name = "Button3"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Image = Global.Project.My.Resources.Resources.Button_Add_icon
            resources.ApplyResources(Me.Button2, "Button2")
            Me.Button2.Name = "Button2"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.Button8)
            Me.GroupBox6.Controls.Add(Me.Button7)
            resources.ApplyResources(Me.GroupBox6, "GroupBox6")
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.TabStop = False
            '
            'Button8
            '
            resources.ApplyResources(Me.Button8, "Button8")
            Me.Button8.Name = "Button8"
            Me.Button8.UseVisualStyleBackColor = True
            '
            'Button7
            '
            resources.ApplyResources(Me.Button7, "Button7")
            Me.Button7.Name = "Button7"
            Me.Button7.UseVisualStyleBackColor = True
            '
            'Timer1
            '
            Me.Timer1.Enabled = True
            '
            'CustomerJob
            '
            Me.BackColor = System.Drawing.Color.PowderBlue
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GroupBox6)
            Me.Controls.Add(Me.GroupBox5)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "CustomerJob"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudCount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As GroupBox
        Friend Label2 As Label
        Friend Label1 As Label
        Friend GroupBox2 As GroupBox
        Friend WithEvents cbJobType As ComboBox
        Friend Label8 As Label
        Friend Label7 As Label
        Friend Label6 As Label
        Friend txtjobtitle As TextBox
        Friend Label5 As Label
        Friend Label4 As Label
        Friend txtJobID As TextBox
        Friend WithEvents Label3 As Label
        Friend GroupBox3 As GroupBox
        Friend txtScript As TextBox
        Friend Label11 As Label
        Friend dtSdate As DateTimePicker
        Friend Label10 As Label
        Friend Label9 As Label
        Friend dtRDate As DateTimePicker
        Friend GroupBox4 As GroupBox
        Friend GroupBox5 As GroupBox
        Friend GroupBox6 As GroupBox
        Friend WithEvents dgv As DataGridView
        Friend WithEvents Button5 As Button
        Friend WithEvents Button4 As Button
        Friend WithEvents Button3 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents Button8 As Button
        Friend WithEvents Button7 As Button
        Friend WithEvents cbCusName As ComboBox
        Friend cbCusID As ComboBox
        Friend Label12 As Label
        Private WithEvents nudHeight As NumericUpDown
        Private WithEvents nudWidth As NumericUpDown
        Private WithEvents nudCount As NumericUpDown
        Private WithEvents nudPrice As NumericUpDown
        Private cbStatus As ComboBox
        Friend label13 As Label
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
    End Class
End NameSpace