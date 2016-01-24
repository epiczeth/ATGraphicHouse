Partial Public Class Login
    Friend Sub New()
        InitializeComponent()
    End Sub
    Private _ds As New DataSet()
    Private ReadOnly _con As New DbConnect()

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        login()
    End Sub


    Private Sub login()
        Dim user As String = txtuser.Text.Trim()
        Dim pass As String = txtpass.Text.Trim()

        Dim sql As String = String.Format("select * from Usertable where userName ='{0}' and password ='{1}'", user, pass)
        _ds = _con.Getdata(sql)
        If _ds.Tables(0).Rows.Count > 0 Then
            Try
                DbConnect.UserLever = _ds.Tables(0).Rows(0)("UserLevel").ToString()
                sql = String.Format("select * from employee where emp_id={0}", _ds.Tables(0).Rows(0)("emp_id").ToString())
                _ds = _con.Getdata(sql)
                DbConnect.LogId = _ds.Tables(0).Rows(0)("emp_id").ToString() 

            Catch
            End Try
            MdiParent1.DefaultInstance.Show()
            Hide()
        Else
            MessageBox.Show(Me, "รหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpass.SelectAll()
        End If

    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtpass.Text = String.Empty
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class