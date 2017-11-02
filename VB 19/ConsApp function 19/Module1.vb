Module Module1

    'funtions must return a value and you must specify that value 
    Dim icounter = 0
    Sub Main()
        Console.WriteLine(GetName("bob", "smith"))


        Console.WriteLine(counter)
        Console.WriteLine(counter)
        Console.WriteLine(counter)


        Console.ReadLine()
    End Sub

    Function counter() As Integer
        icounter += 1
        Return icounter
    End Function

    Function GetName(ByVal first As String, ByVal last As String) As String
        Return first & "  " & last

    End Function

End Module
