Module Module1
    'Dan C. Sitoianu

    Dim thro(4) As Integer
    Dim thro2(4) As Integer
    Dim location As Integer

    Sub Main()

        arrc()
        menu()

    End Sub
    Sub menu()
        Dim choice As Integer

        Console.WriteLine("0: To exit the program")
        Console.WriteLine("1: Print results of dice throws")
        Console.WriteLine("2: Display highest throw")
        Console.WriteLine("3: Check if a six has been thrown")
        Console.WriteLine()
        Console.WriteLine("Choose on of the above")

        choice = CInt(Console.ReadLine())

        Do While choice <> 0
            If choice = 1 Then
                show()
            End If
            If choice = 2 Then
                highest()
            End If
            If choice = 3 Then
                check()
            End If
            Console.WriteLine()
            Console.WriteLine("Choose on of the above")

            choice = CInt(Console.ReadLine())
            Console.WriteLine()
        Loop

    End Sub
    Sub arrc()
        Dim random As New Random

        For location = 0 To 4
            thro(location) = random.Next(6) + 1
            Console.WriteLine(thro(location))
        Next
        Console.WriteLine()


    End Sub
    Sub highest()
        Dim high As Integer
        high = thro(1)
        For location = 0 To 4
            If high < thro(location) Then
                high = thro(location)
            End If
        Next

        Console.WriteLine("The highest throw is: " & high)
    End Sub
    Sub show()

        For location = 0 To 4
            Console.WriteLine(thro(location))
        Next

    End Sub
    Sub check()
        For location = 0 To 4
            If thro(location) = 6 Then
                Console.WriteLine("You have a six at location " & location)
            End If
        Next
    End Sub

End Module
