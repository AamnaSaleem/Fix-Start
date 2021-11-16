Module Module1

    Sub Main()

        Dim Str1 As String
        Dim FirstChar As Char
        Dim ThisChar As Char

        Console.Write("Enter string to be processed: ")
        Str1 = Console.ReadLine
        FirstChar = Left(Str1, 1)
        Console.Write(FirstChar)
        For COUNT = 1 To Len(Str1) - 1
            ThisChar = Mid(Str1, (COUNT + 1), 1)
            If ThisChar = FirstChar Then
                ThisChar = "*"
            End If
            Console.Write(ThisChar)
        Next
        Console.ReadKey()

    End Sub

End Module
