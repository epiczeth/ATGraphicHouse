
Imports AllClasses

Namespace AllForms
    Partial Public Class MdiParent1
        Friend Sub New()
            InitializeComponent()
        End Sub


        Private Sub MDIParent1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            SetUser()
        End Sub

        Private Sub SetUser()

            Select Case CStr(DbConnect.UserLever)
                Case "พนักงาน"
                    lbluserstatus.Text = "พนักงาน"
                    ToolStripLabel2.Visible = False
                    ToolStripLabel6.Visible = False
                Case "ผู้ดูแลระบบ"
                    lbluserstatus.Text = "ผู้ดูแลระบบ"
                    ToolStripLabel5.Visible = False
                    ToolStripLabel3.Visible = False
                    ToolStripLabel4.Visible = False
                Case "เจ้าของกิจการ"
                    lbluserstatus.Text = "เจ้าของกิจการ"
                    ToolStripLabel3.Visible = False
                    ToolStripLabel4.Visible = False
                    ToolStripLabel6.Visible = False
            End Select
        End Sub

        Private Sub ClearForm()
            For Each fm As Form In MdiChildren
                fm.Close()
            Next fm
        End Sub

        Private Sub ToolStripLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel1.Click
            If _
                MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", "ออกจากระบบ?", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Restart()
            End If
        End Sub

        Private Sub ToolStripLabel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel2.Click
            ClearForm()
            Dim fm As New Employees()
            fm.MdiParent = Me
            fm.Show()
        End Sub

        Private Sub ToolStripLabel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel3.Click
            ClearForm()
            Dim fm As New Customer()
            fm.MdiParent = Me
            fm.Show()
        End Sub

        Private Sub ToolStripLabel4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel4.Click
            ClearForm()
            Dim fm As New CustomerJob()
            fm.MdiParent = Me
            fm.Show()
        End Sub

        Private Sub ToolStripLabel5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel5.Click
            ClearForm()
            Dim fm As New ReportJob()
            fm.MdiParent = Me
            fm.Show()
        End Sub

        Private Sub ToolStripLabel6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripLabel6.Click
            ClearForm()
            Dim fm As New UserForm()
            fm.MdiParent = Me
            fm.Show()
        End Sub

        Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) _
            Handles MyBase.FormClosing
            Application.Exit()
        End Sub
    End Class
End NameSpace