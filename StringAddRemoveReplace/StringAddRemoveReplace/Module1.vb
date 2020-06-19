Module Module1

    Sub Main()
        Dim str1 As String = "DREAMWEAVER"
        Console.WriteLine("Original Word: " & str1)
        Console.WriteLine("")

        'Inserting
        Dim InsertString As String = str1.Insert(2, "inserted")
        Console.WriteLine("Inserted Word 'insert' at index 2: " & InsertString)
        Console.WriteLine("")

        'Replacing
        'is case sensitive
        Dim ReplaceString As String = str1.Replace("E", "x")
        Console.WriteLine("Replaced all e's with x's: " & ReplaceString)
        Console.WriteLine("")

        'Removing
        Dim RemoveString As String = str1.Remove(5, 4)
        Console.WriteLine("From Index 5, remove 4 characters: " & RemoveString)
        Console.WriteLine("")

        Console.ReadLine()
    End Sub

End Module
