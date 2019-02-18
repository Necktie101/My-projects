Module Module1

    Sub Main()
        Dim choice As Integer
        Do While choice <> 3
            menu()
            If choice = 1 Then
                vertical()
            End If
            If choice = 2 Then
                horizontal()
            End If
        Loop
        Console.ReadLine()
    End Sub

    Sub menu()
        Console.WriteLine("Enter choice")
        Console.WriteLine("1. Vertical Stars")
        Console.WriteLine("2. Horizontal Stars")
        Console.WriteLine("3. Exit")
    End Sub

    Sub vertical()
        Dim numstars As Integer = 1
        Do While numstars < 20
            Console.WriteLine("*")
            numstars = numstars + 1
        Loop
    End Sub

    Sub horizontal()
        Dim numstars As Integer = 1
        Do While numstars < 20
            Console.Write("*")
            numstars = numstars + 1
        Loop
    End Sub

End Module
