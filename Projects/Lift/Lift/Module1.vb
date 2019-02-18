Module Module1
    'Dan Cristian Sitoianu
    Sub Main()

        Dim Floor0 As Integer
        Dim Floor1 As Integer
        Dim Floor2 As Integer
        Dim Floor3 As Integer
        Dim liftOnFloor As Integer
        Dim ans As String
        Dim ans1 As Integer
        Dim ans2 As Integer

        Floor0 = 0
        Floor1 = 1
        Floor2 = 2
        Floor3 = 3
        liftOnFloor = Floor0

        Console.WriteLine("Lift is on floor " & liftOnFloor)

        Console.WriteLine("Do you want to use the lift? ")
        ans = Console.ReadLine()

        While ans = "yes"
            Console.WriteLine("What floor are you on?")
            ans1 = CInt(Console.ReadLine)

            If ans1 = liftOnFloor Then
                Console.WriteLine("Opening doors. Please get on.")
                Console.WriteLine("What floor do you want to go to?")
                ans2 = CInt(Console.ReadLine())
                liftOnFloor = ans2
                Console.WriteLine("We have arrived to floor " & ans2 & " Opening doors")
            End If

            If ans1 > liftOnFloor Then
                Console.WriteLine("Lift coming up")
                Console.WriteLine("Opening doors. Please get on")
                Console.WriteLine("What floor do you want to go to?")
                ans2 = CInt(Console.ReadLine())
                liftOnFloor = ans2
                Console.WriteLine("We have arrived to floor " & ans2 & " Opening doors")
            End If

            If ans1 < liftOnFloor Then
                Console.WriteLine("Lift coming down")
                Console.WriteLine("Opening doors. Please get on")
                Console.WriteLine("What floor do you want to go to?")
                ans2 = CInt(Console.ReadLine())
                liftOnFloor = ans2
                Console.WriteLine("We have arrived to floor " & ans2 & " Opening doors")
            End If

            Console.WriteLine("Do you want to use the lift again? ")
            ans = Console.ReadLine()

        End While

        Console.WriteLine()
        Console.ReadLine()

    End Sub

End Module
