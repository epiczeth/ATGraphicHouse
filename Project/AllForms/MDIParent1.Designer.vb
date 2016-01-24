'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace AllForms

    <DesignerGenerated()> _
    Partial Public Class MdiParent1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiParent1))
            Me.ToolStrip = New System.Windows.Forms.ToolStrip()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
            Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
            Me.StatusStrip = New System.Windows.Forms.StatusStrip()
            Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lbluserstatus = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
            Me.ToolStrip.SuspendLayout()
            Me.StatusStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'ToolStrip
            '
            Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.ToolStripLabel2, Me.ToolStripLabel6, Me.ToolStripLabel1})
            Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip.Name = "ToolStrip"
            Me.ToolStrip.Size = New System.Drawing.Size(884, 25)
            Me.ToolStrip.TabIndex = 6
            Me.ToolStrip.Text = "ToolStrip"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripLabel3
            '
            Me.ToolStripLabel3.Image = CType(resources.GetObject("ToolStripLabel3.Image"), System.Drawing.Image)
            Me.ToolStripLabel3.Name = "ToolStripLabel3"
            Me.ToolStripLabel3.Size = New System.Drawing.Size(105, 22)
            Me.ToolStripLabel3.Text = "จัดการข้อมูลลูกค้า"
            '
            'ToolStripLabel4
            '
            Me.ToolStripLabel4.Image = CType(resources.GetObject("ToolStripLabel4.Image"), System.Drawing.Image)
            Me.ToolStripLabel4.Name = "ToolStripLabel4"
            Me.ToolStripLabel4.Size = New System.Drawing.Size(97, 22)
            Me.ToolStripLabel4.Text = "จัดการงานลูกค้า"
            '
            'ToolStripLabel5
            '
            Me.ToolStripLabel5.Image = CType(resources.GetObject("ToolStripLabel5.Image"), System.Drawing.Image)
            Me.ToolStripLabel5.Name = "ToolStripLabel5"
            Me.ToolStripLabel5.Size = New System.Drawing.Size(59, 22)
            Me.ToolStripLabel5.Text = "รายงาน"
            '
            'ToolStripLabel2
            '
            Me.ToolStripLabel2.Image = Global.Project.My.Resources.Resources.User_Group_icon
            Me.ToolStripLabel2.Name = "ToolStripLabel2"
            Me.ToolStripLabel2.Size = New System.Drawing.Size(121, 22)
            Me.ToolStripLabel2.Text = "จัดการข้อมูลพนักงาน"
            '
            'ToolStripLabel6
            '
            Me.ToolStripLabel6.Image = CType(resources.GetObject("ToolStripLabel6.Image"), System.Drawing.Image)
            Me.ToolStripLabel6.Name = "ToolStripLabel6"
            Me.ToolStripLabel6.Size = New System.Drawing.Size(143, 22)
            Me.ToolStripLabel6.Text = "จัดการข้อมูลผู้ใช้งานระบบ"
            '
            'ToolStripLabel1
            '
            Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
            Me.ToolStripLabel1.Name = "ToolStripLabel1"
            Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 22)
            Me.ToolStripLabel1.Text = "ล๊อคเอ้า"
            '
            'StatusStrip
            '
            Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.lbluserstatus})
            Me.StatusStrip.Location = New System.Drawing.Point(0, 640)
            Me.StatusStrip.Name = "StatusStrip"
            Me.StatusStrip.Size = New System.Drawing.Size(884, 22)
            Me.StatusStrip.TabIndex = 7
            Me.StatusStrip.Text = "StatusStrip"
            '
            'ToolStripStatusLabel
            '
            Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
            Me.ToolStripStatusLabel.Size = New System.Drawing.Size(45, 17)
            Me.ToolStripStatusLabel.Text = "Status :"
            '
            'lbluserstatus
            '
            Me.lbluserstatus.Name = "lbluserstatus"
            Me.lbluserstatus.Size = New System.Drawing.Size(0, 17)
            '
            'MdiParent1
            '
            Me.ClientSize = New System.Drawing.Size(884, 662)
            Me.Controls.Add(Me.ToolStrip)
            Me.Controls.Add(Me.StatusStrip)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "MdiParent1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "เมนูหลัก"
            Me.ToolStrip.ResumeLayout(False)
            Me.ToolStrip.PerformLayout()
            Me.StatusStrip.ResumeLayout(False)
            Me.StatusStrip.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend ToolStripSeparator2 As ToolStripSeparator
        Friend ToolTip As ToolTip
        Friend ToolStripStatusLabel As ToolStripStatusLabel
        Friend StatusStrip As StatusStrip
        Friend ToolStrip As ToolStrip
        Friend ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents ToolStripLabel1 As ToolStripLabel
        Friend WithEvents ToolStripLabel2 As ToolStripLabel
        Friend WithEvents ToolStripLabel3 As ToolStripLabel
        Friend WithEvents ToolStripLabel4 As ToolStripLabel
        Friend WithEvents ToolStripLabel5 As ToolStripLabel
        Friend WithEvents ToolStripLabel6 As ToolStripLabel
        Friend lbluserstatus As ToolStripStatusLabel


        Private Shared _DefaultInstance As MDIParent1
        Public Shared ReadOnly Property DefaultInstance() As MDIParent1
            Get
                If _DefaultInstance Is Nothing Then
                    _DefaultInstance = New MDIParent1()
                End If

                Return _DefaultInstance
            End Get
        End Property
    End Class
End NameSpace