Module Module1
    Public Function incomplete(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer, ByVal num4 As Integer, ByVal num5 As Integer, ByVal num6 As Integer, ByVal num7 As Integer, ByVal num8 As Integer, ByVal num9 As Integer)
        Return num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9
    End Function

    Public Function prelims(ByVal num1 As Integer, num2 As Integer, num3 As Integer)
        Return num1 + num2 + num3 / 150
    End Function

    Public Function pweight(ByVal num1 As Integer)
        Return num1 * 0.5
    End Function

    Public Function midterms(ByVal num1 As Integer, num2 As Integer, num3 As Integer)
        Return num1 + num2 + num3 / 150
    End Function

    Public Function mweight(ByVal num1 As Integer)
        Return num1 * 0.25
    End Function

    Public Function finals(ByVal num1 As Integer, num2 As Integer, num3 As Integer)
        Return num1 + num2 + num3 / 150
    End Function

    Public Function fweight(ByVal num1 As Integer)
        Return num1 * 0.25
    End Function

    Public Function grade(ByVal num1 As Integer, num2 As Integer, num3 As Integer)
        Return num1 + num2 + num3
    End Function
End Module
