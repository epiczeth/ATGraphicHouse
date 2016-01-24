
Imports MySql.Data.MySqlClient
Imports Zeth

Namespace AllClasses
    Public Class DbConnect
        Public Shared LogId As String
        Public Shared REdate As String
        Public Con As MySqlConnection 'สร้าง Object การเชื่อมต่อฐานข้อมูล
        Public Shared UserLever As String

        Friend Sub New()
            Try
                Dim host, user, password, database, port As String

                host = IniUtil.GetConfig("mysql", "host", Environment.CurrentDirectory & "\Config\config.ini")
                user = IniUtil.GetConfig("mysql", "user", Environment.CurrentDirectory & "\Config\config.ini")
                password = Security.Decrypt(IniUtil.GetConfig("mysql", "password",
                                                              Environment.CurrentDirectory & "\Config\config.ini"))
                database = IniUtil.GetConfig("mysql", "database", Environment.CurrentDirectory & "\Config\config.ini")
                port = IniUtil.GetConfig("mysql", "port", Environment.CurrentDirectory & "\Config\config.ini")
                Con = New MySqlConnection(String.Format("Server={0};Port=" & port & ";Database={1};Uid={2};Pwd={3};",
                                                        host, database, user, password))
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End Sub

        Public Function Getdata(ByVal sql As String) As DataSet
            Dim ds As New DataSet()
            Try
                If Con.State <> ConnectionState.Closed Then
                    Con.Close()
                End If
                Con.Open()

                Dim da As New MySqlDataAdapter(sql, Con)
                ds.Clear()
                da.Fill(ds)

            Catch ex As Exception

            End Try
            Return ds
        End Function

        Public Overloads Function GetSumBill(ByVal cusId As Integer) As String

            If Con.State <> ConnectionState.Closed Then
                Con.Close()
            End If

            ' ReSharper disable once RedundantAssignment
            Dim dt As New DataTable
            Dim result As Decimal = 0
            Dim sql As String = "SELECT Job_Price FROM Orders WHERE Cus_Id=" & cusId &
                                " AND Job_Status='ค้างชำระ' Or Job_Status='มัดจำ 50%'"
            Try
                Con.Open()
                Dim adapter As New MySqlDataAdapter(sql, Con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dt = ds.Tables(0)
                For i As Integer = 0 To dt.Rows.Count
                    result += CDec(dt.Rows(i)(0))
                Next
                adapter.Dispose()
                Con.Close()
            Catch ex As Exception
                Debug.WriteLine(ex)
            End Try
            Return CStr(result)
        End Function

        Public Overloads Function GetAddress(ByVal cusId As Integer) As String

            If Con.State <> ConnectionState.Closed Then
                Con.Close()
            End If

            Dim sql As String = "SELECT Cus_Address FROM Customer WHERE Cus_Id=" & cusId & ""
            Dim result As String = ""
            Dim reader As MySqlDataReader
            Try
                Con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sql, Con)
                reader = cmd.ExecuteReader()
                While reader.Read()
                    result = reader(0).ToString()
                End While
            Catch ex As Exception

            End Try


            Return result
        End Function

        Public Overloads Function GetSumBill(ByVal cusId As Integer, ByVal rdate As String) As String

            If Con.State <> ConnectionState.Closed Then
                Con.Close()
            End If

            ' ReSharper disable once RedundantAssignment
            Dim dt As New DataTable
            Dim result As Decimal = 0
            Dim sql As String = "SELECT Job_Price FROM Orders WHERE Cus_Id=" & cusId &
                                " AND Job_Date='" + rdate + "' AND Job_Status='ค้างชำระ'"
            Try
                Con.Open()
                Dim adapter As New MySqlDataAdapter(sql, Con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dt = ds.Tables(0)
                For i As Integer = 0 To dt.Rows.Count
                    result += CDec(dt.Rows(i)(0))
                Next
                adapter.Dispose()
                Con.Close()
            Catch ex As Exception

                Debug.WriteLine(result)
            End Try
            Return CStr(result)
        End Function

        Public Overloads Function GetSumBill(ByVal query As String) As String

            If Con.State <> ConnectionState.Closed Then
                Con.Close()
            End If

            ' ReSharper disable once RedundantAssignment
            Dim dt As New DataTable
            Dim result As Decimal = 0
            Try
                Con.Open()
                Dim adapter As New MySqlDataAdapter(query, Con)
                Dim ds As New DataSet
                adapter.Fill(ds)
                dt = ds.Tables(0)
                For i As Integer = 0 To dt.Rows.Count
                    result += CDec(dt.Rows(i)(0))
                Next
                adapter.Dispose()
                Con.Close()
            Catch ex As Exception

                Debug.WriteLine(result)
            End Try
            Return CStr(result)
        End Function

        Public Function GetEmployeeName() As String

            If Con.State <> ConnectionState.Closed Then
                Con.Close()
            End If

            Dim result As String = ""
            Try
                Con.Open()
                Dim reader As MySqlDataReader
                Dim cmd As MySqlCommand =
                        New MySqlCommand("SELECT Emp_Name From Employee WHERE Emp_Id=" & Convert.ToInt32(LogId) & "",
                                         Con)
                reader = cmd.ExecuteReader()
                While reader.Read()
                    result = reader(0).ToString()
                End While
            Catch ex As Exception

            End Try

            Return result
        End Function

        Public Function Query(ByVal sql As String) As Integer

            If Con.State <> ConnectionState.Closed Then
                Con.Close()
            End If
            Dim i As Integer
            Try
                Con.Open()
                Dim com As New MySqlCommand()
                com.CommandType = CommandType.Text
                com.CommandText = sql
                com.Connection = Con
                i = com.ExecuteNonQuery()
            Catch ex As Exception

            End Try
            Return i
        End Function

        Public Shared Function ThaiBaht(ByVal txt As String) As String
            Dim bahtTxt As String, n As String, bahtTh As String = ""
            Dim amount As Double
            Try
                amount = Convert.ToDouble(txt)
            Catch
                amount = 0
            End Try
            bahtTxt = amount.ToString("####.00")
            Dim num() As String = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ"}
            Dim rank() As String = {"", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน"}
            Dim temp() As String = bahtTxt.Split("."c)
            Dim intVal As String = temp(0)
            Dim decVal As String = temp(1)
            ' ReSharper disable once CompareOfFloatsByEqualityOperator
            If Convert.ToDouble(bahtTxt) = 0 Then
                bahtTh = "ศูนย์บาทถ้วน"
            Else
                For i As Integer = 0 To intVal.Length - 1
                    n = intVal.Substring(i, 1)
                    If n <> "0" Then
                        If (i = (intVal.Length - 1)) AndAlso (n = "1") Then
                            bahtTh &= "เอ็ด"
                        ElseIf (i = (intVal.Length - 2)) AndAlso (n = "2") Then
                            bahtTh &= "ยี่"
                        ElseIf (i = (intVal.Length - 2)) AndAlso (n = "1") Then
                            bahtTh &= ""
                        Else
                            bahtTh &= num(Convert.ToInt32(n))
                        End If
                        bahtTh &= rank((intVal.Length - i) - 1)
                    End If
                Next i
                bahtTh &= "บาท"
                If decVal = "00" Then
                    bahtTh &= "ถ้วน"
                Else
                    For i As Integer = 0 To decVal.Length - 1
                        n = decVal.Substring(i, 1)
                        If n <> "0" Then
                            If (i = decVal.Length - 1) AndAlso (n = "1") Then
                                bahtTh &= "เอ็ด"
                            ElseIf (i = (decVal.Length - 2)) AndAlso (n = "2") Then
                                bahtTh &= "ยี่"
                            ElseIf (i = (decVal.Length - 2)) AndAlso (n = "1") Then
                                bahtTh &= ""
                            Else
                                bahtTh &= num(Convert.ToInt32(n))
                            End If
                            bahtTh &= rank((decVal.Length - i) - 1)
                        End If
                    Next i
                    bahtTh &= "สตางค์"
                End If
            End If
            Return bahtTh
        End Function
    End Class
End Namespace