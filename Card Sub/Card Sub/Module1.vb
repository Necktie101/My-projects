Module Module1

    'Dan C. Sitoianu

    Dim name As String

    Sub Main()

        Dim choice As Integer = 0

        Console.WriteLine("What is your name? ")
        name = Console.ReadLine
        Console.WriteLine("Welcome to the game " & name)

        Do While choice <> 2
            Console.WriteLine()
            Console.WriteLine(" Enter '1' to play")
            Console.WriteLine(" Enter '2' to exit")
            choice = Console.ReadLine()

            If choice = 1 Then
                game()
            End If
        Loop

    End Sub

    Sub game()
        Console.WriteLine("You have entered the game")
        Console.WriteLine()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer

        Dim suit1 As Integer
        Dim suit2 As Integer
        Dim suit3 As Integer

        Dim rdn As New Random

        num1 = rdn.Next(13) + 1
        num2 = rdn.Next(13) + 1
        num3 = rdn.Next(13) + 1

        suit1 = rdn.Next(4) + 1
        suit2 = rdn.Next(4) + 1
        suit3 = rdn.Next(4) + 1


        Console.WriteLine("Suit Key: 1(Clubs), 2(Spades), 3(Diamonds), 4(Hearts)")
        Console.WriteLine()
        Console.WriteLine("Card Key : 1(Ace), 2-10(numbers), 11(Jack), 12(Queen), 13(King)")
        Console.WriteLine()

        Console.WriteLine("Your 1st card is a " & num1 & " of " & suit1)
        Console.WriteLine("Your 2nd card is a " & num2 & " of " & suit2)
        Console.WriteLine("Your 3rd card is a " & num3 & " of " & suit3)

        Console.WriteLine()

        If num1 > num2 Then
            If num1 > num3 Then
                Console.WriteLine("The largest card is " & num1 & " of " & suit1)
            Else
                Console.WriteLine("The largest card is " & num3 & " of " & suit3)
            End If
        Else
            If num2 > num3 Then
                Console.WriteLine("The largest card is " & num2 & " of " & suit2)
            Else
                Console.WriteLine("The largest card is " & num3 & " of " & suit3)
            End If
        End If

        Console.WriteLine()

        Console.WriteLine("Press Enter to continue")
        Console.ReadLine()
    End Sub

End Module
