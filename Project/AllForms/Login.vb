Imports System.IO
Imports AllClasses

Namespace AllForms
    Partial Public Class Login
        Friend Sub New()

            InitializeComponent()
            Dim str As String = "[MySql]" & Environment.NewLine
            str &= "host = localhost" & Environment.NewLine
            str &= "port = 3306" & Environment.NewLine
            str &= "user = root" & Environment.NewLine
            str &= "password =" & Environment.NewLine
            str &= "database = cdth" & Environment.NewLine

            If Directory.Exists(Environment.CurrentDirectory & "\Config") <> True Then
                Directory.CreateDirectory(Environment.CurrentDirectory & "\Config")
                Dim fi = File.Create(Environment.CurrentDirectory & "\Config\config.ini")
                fi.Close()
                File.WriteAllText(Environment.CurrentDirectory & "\Config\config.ini", str)
                mySqlSetting.ShowDialog()
            End If
        End Sub

        Private _ds As New DataSet()
        Private ReadOnly _con As New DbConnect()

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
            login()
        End Sub


        ' ReSharper disable once InconsistentNaming
        Private Sub login()

            Try
                Dim user As String = txtuser.Text.Trim()
                Dim pass As String = txtpass.Text.Trim()

                Dim sql As String = String.Format("select * from Usertable where userName ='{0}' and password ='{1}'",
                                                  user, pass)
                _ds = _con.Getdata(sql)
                If _ds.Tables(0).Rows.Count > 0 Then
                    Try
                        DbConnect.UserLever = _ds.Tables(0).Rows(0)("UserLevel").ToString()
                        sql = String.Format("select * from employee where emp_id={0}",
                                            _ds.Tables(0).Rows(0)("emp_id").ToString())
                        _ds = _con.Getdata(sql)
                        DbConnect.LogId = _ds.Tables(0).Rows(0)("emp_id").ToString()

                    Catch
                    End Try
                    MdiParent1.DefaultInstance.Show()
                    Hide()
                Else
                    MessageBox.Show(Me, "รหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                    txtpass.SelectAll()
                End If
            Catch ex As Exception
                MessageBox.Show("MySql connection error!!!")
            End Try
        End Sub

        Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


            txtpass.Text = String.Empty
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
            Application.Exit()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            MySqlSetting.ShowDialog()
        End Sub
    End Class
End Namespace