Module Module1

    Sub Main()
        Dim eyes As String
        Dim fur As String
        Dim legs As Integer
        Dim tail As String
        Dim repeat As String


        repeat = "yes"

        While repeat = "yes"
            Console.WriteLine("What Is your eye colour?")
            eyes = Console.ReadLine()

            If eyes = "green" Or eyes = "violet" Then
                Console.WriteLine("What colour is your fur?")
                fur = Console.ReadLine()
                If fur = "red" Then
                    Console.WriteLine("You are going to Saturn")
                Else
                    Console.WriteLine("You are going to Mars")
                End If
            Else
                Console.WriteLine("What colour is your fur")
                fur = Console.ReadLine()
                If fur = "black" Then
                    Console.WriteLine("How many legs do you have?")
                    legs = CInt(Console.ReadLine())
                    If legs = 2 Then
                        Console.WriteLine("You are going to Jupiter")
                    Else
                        Console.WriteLine("Do you have a tail?")
                        tail = Console.ReadLine()
                        If tail = "yes" Then
                            Console.WriteLine("You are goin to Mercury")
                        Else
                            Console.WriteLine("You are going to Apha Centauri")
                        End If
                    End If
                Else
                    Console.WriteLine("You are going to Neptune")
                End If
            End If

            Console.WriteLine("Do you want to go again?")
            repeat = Console.ReadLine()
        End While




    End Sub

End Module
