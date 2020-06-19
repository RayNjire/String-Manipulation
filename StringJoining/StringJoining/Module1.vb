Module Module1

    Sub Main()
        Dim str1 As String = "Bill", str2 = "John", str3 = "Kamau"
        Dim allStr() As String = New String() {str1, str2, str3}
        Dim strResult As String = String.Join(", ", allStr)

        Console.WriteLine("Join Results: " + strResult)

        Console.ReadLine()
    End Sub

End Module
