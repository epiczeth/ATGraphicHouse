Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class DbConnect
    Public Shared LogId As String
    Public Shared REdate As String

    Public Con As New MySqlConnection(String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}\Database\Database5.accdb", Environment.CurrentDirectory)) 'สร้าง Object การเชื่อมต่อฐานข้อมูล
    Public Shared UserLever As String
    Public Function Getdata(ByVal sql As String) As DataSet
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open()
        Dim ds As New DataSet()
        Dim da As New OleDbDataAdapter(sql, Con)
        ds.Clear()
        da.Fill(ds)
        Return ds
    End Function
    Public Overloads Function GetSumBill(ByVal cusId As Integer) As String
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open()
        Dim dt As New DataTable
        Dim result As Decimal = 0
        Dim sql As String = "SELECT Job_Price FROM Orders WHERE Cus_Id=" & cusId & " AND Job_Status='ค้างชำระ' Or Job_Status='มัดจำ 50%'"
        Try
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
        Return result
    End Function
    Public Overloads Function GetAddress(ByVal cusId As Integer) As String
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open()
        Dim sql As String = "SELECT Cus_Address FROM Customer WHERE Cus_Id=" & cusId & ""
        Dim result As String = ""
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand = New MySqlCommand(sql, Con)
        reader = cmd.ExecuteReader()
        While reader.Read()
            result = reader(0).ToString()
        End While
        Return result
    End Function
    Public Overloads Function GetSumBill(ByVal cusId As Integer, ByVal rdate As String) As String
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open()
        Dim dt As New DataTable
        Dim result As Decimal = 0
        Dim sql As String = "SELECT Job_Price FROM Orders WHERE Cus_Id=" & cusId & " AND Job_Date='" + rdate + "' AND Job_Status='ค้างชำระ'"
        Try
            Dim adapter As New OleDbDataAdapter(sql, Con)
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
        Return result
    End Function
    Public Overloads Function GetSumBill(ByVal query As String) As String
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open() 
        Dim dt As New DataTable
        Dim result As Decimal = 0
        Try
            Dim adapter As New OleDbDataAdapter(query, Con)
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
        Return result
    End Function
    Public Function GetEmployeeName() As String
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open()
        Dim result As String = ""
        Dim reader As OleDbDataReader
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT Emp_Name From Employee WHERE Emp_Id=" & Convert.ToInt32(LogId) & "", Con)
        reader = cmd.ExecuteReader()
        While reader.Read()
            result = reader(0).ToString()
        End While
        Return result
    End Function
    Public Function Query(ByVal sql As String) As Integer
        If Con.State <> ConnectionState.Closed Then
            Con.Close()
        End If
        Con.Open()
        Dim com As New OleDbCommand()
        com.CommandType = CommandType.Text
        com.CommandText = sql
        com.Connection = Con
        Dim i As Integer = com.ExecuteNonQuery()
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