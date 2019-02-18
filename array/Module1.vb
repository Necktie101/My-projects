Module Module1

    Sub Main()

        Dim cards(13) As Integer
        Dim rnd As New Random
        Dim location As Integer

        For location = 0 To 13
            cards(location) = rnd.Next(14) + 1
            Console.WriteLine(cards(location))

        Next
        Console.WriteLine()

        menu()
    End Sub

    Sub menu()

    End Sub

End Module
