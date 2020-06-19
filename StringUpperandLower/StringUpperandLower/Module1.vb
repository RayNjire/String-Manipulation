Module Module1

    Sub Main()
        Dim str1 As String = "Ray Njire"
        Console.WriteLine("Original String: " & str1)
        Console.WriteLine("")

        str1 = str1.ToUpper
        Console.WriteLine("Uppercase of String: " & str1)
        Console.WriteLine("")

        str1 = str1.ToLower
        Console.WriteLine("Lowercase of String: " & str1)
        Console.WriteLine("")

        Console.ReadLine()
    End Sub

End Module
