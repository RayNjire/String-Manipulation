Module Module1

    Sub Main()
        Dim Val1 As Integer = 7
        Dim Name As String = "John Doe"
        Dim Num1 As Double = 45.06

        Dim NewSTR As String = String.Format("Days Left: {0}. CurrentTime: {1}." &
                                             vbNewLine & "Customer Name: {2}, Amount Due: ${3}", Val1, DateTime.Now, Name, Num1)
        Console.WriteLine(NewSTR)

        Console.ReadLine()
    End Sub

End Module
