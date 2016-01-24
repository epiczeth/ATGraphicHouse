Imports System.IO
Imports MySql.Data.MySqlClient
Imports Zeth

Namespace AllForms
    Public Class MySqlSetting
        Private Sub mySqlSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        End Sub

        Private Function TestConnect(ByVal host As String, ByVal user As String, ByVal pass As String,
                                     ByVal port As String) As Boolean
            Try
                Dim _
                    conn As _
                        New MySqlConnection(String.Format("Server={0};Port=" & port & ";Uid={1};Pwd={2};", host, user,
                                                          pass))
                conn.Open()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            If TestConnect(txthost.Text, txtuid.Text, txtpass.Text, txtport.Text) = True Then
                MessageBox.Show("การเชื่อมต่อสำเร็จ")
                Button2.Enabled = True
                Button4.Enabled = True
            Else
                MessageBox.Show("การเชื่อมต่อล้มเหลว")
                Button2.Enabled = False
                Button4.Enabled = False
            End If
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Try
                File.Delete(Environment.CurrentDirectory & "\Config\config.ini")
                Directory.Delete(Environment.CurrentDirectory & "\Config")
            Catch ex As Exception

            End Try

            Application.Exit()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            IniUtil.WriteConfig("mysql", "host", txthost.Text, Environment.CurrentDirectory & "\Config\config.ini")
            IniUtil.WriteConfig("mysql", "port", txtport.Text, Environment.CurrentDirectory & "\Config\config.ini")
            IniUtil.WriteConfig("mysql", "user", txtuid.Text, Environment.CurrentDirectory & "\Config\config.ini")
            IniUtil.WriteConfig("mysql", "password", Security.Encrypt(txtpass.Text),
                                Environment.CurrentDirectory & "\Config\config.ini")
            IniUtil.WriteConfig("mysql", "database", txtdb.Text, Environment.CurrentDirectory & "\Config\config.ini")


            Application.Restart()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            If _
                MessageBox.Show(Me,
                                "ถ้าสร้างฐานข้อมูลใหม่ฐานข้อมูลเก่าที่มีอยู่จะถูกลบทิ้งทั้งหมด คุณต้องการดำเนินการต่อหรือไม่?",
                                "สร้างฐานข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes _
                Then
                Try
                    Dim _
                        script As _
                            New MySqlScript(
                                New MySqlConnection(String.Format("Server={0};Port={1};Uid={2};Pwd={3};", txthost.Text,
                                                                  txtport.Text, txtuid.Text, txtpass.Text)),
                                File.ReadAllText(Environment.CurrentDirectory & "\SQL\portedAccess.sql"))
                    script.Execute()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End Sub
    End Class
End Namespace