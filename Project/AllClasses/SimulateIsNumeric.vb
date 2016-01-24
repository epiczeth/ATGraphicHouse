Namespace AllClasses
    Public NotInheritable Class SimulateIsNumeric
        Private Sub New()
        End Sub

        Public Shared Function IsNumeric(ByVal expression As Object) As Boolean
            If expression Is Nothing Then
                Return False
            End If

            Dim testDouble As Double
            If Double.TryParse(expression.ToString(), testDouble) Then
                Return True
            End If

            Dim testBool As Boolean
            If Boolean.TryParse(expression.ToString(), testBool) Then
                Return True
            End If

            Return False
        End Function
    End Class
End NameSpace