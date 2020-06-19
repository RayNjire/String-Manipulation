Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String

        Dim result As String

        Console.WriteLine("Write your first string:")
        str1 = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Write your second string:")
        str2 = Console.ReadLine()
        Console.WriteLine("")

        If (str1 = str2) Then
            result = "First statement matches the second statement"
            Console.WriteLine(result)

        Else
            result = "First statement does not match the second statement"
            Console.WriteLine(result)
        End If

        Console.ReadLine()
    End Sub

End Module
