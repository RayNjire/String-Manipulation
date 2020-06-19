Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim str3 As String

        Dim res As Int16 'int16 is short (4bytes), int32 is integer (8bytes), int64 is long (64bytes)

        Console.WriteLine("Write your first string:")
        str1 = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Write your second string:")
        str2 = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Write your third string:")
        str3 = Console.ReadLine()
        Console.WriteLine("")

        '0 means the strings have the same letters, 1 means the first string has more letters than the second
        '-1 means the first string has less letters than the second
        Console.WriteLine("Comparing first and second:")
        res = String.Compare(str1, str2)
        Console.WriteLine(res)
        Console.WriteLine("Comparing first and third:")
        res = String.Compare(str1, str3)
        Console.WriteLine(res)
        Console.WriteLine("Comparing second and third:")
        res = String.Compare(str1, str2)
        Console.WriteLine(res)

        Console.ReadLine()
    End Sub

End Module
