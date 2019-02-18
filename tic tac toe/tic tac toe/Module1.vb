Module Module1

    Dim win As Boolean = False
    Dim gridfull As Boolean = False
    Dim counter As Integer = 1

    Dim winner As String
    Dim wintype As String
    Dim grid(3, 3) As String

    Sub Main()
        Dim ans As String

        ans = "y"

        initialise()
        printgrid()

        Do While ans = "y" And counter < 3

            If counter = 1 Then
                turnx()
                printgrid()
                counter = counter + 1

            ElseIf counter = 2 Then
                turno()
                printgrid()
                counter = counter - 1

            End If

            gridcheck()

            If gridfull = True Then

                xvictory()
                ovictory()
            End If

            endgame()

            Console.WriteLine("Do you want to play again? y/n")
            ans = Console.ReadLine()

            If ans = "y" Then
                counter = 1
            End If

        Loop



        Console.WriteLine()
        Console.ReadLine()
    End Sub

    Sub initialise()

        Dim col As Integer
        Dim row As Integer

        grid(0, 0) = "0"

        For col = 1 To 3
            grid(0, col) = "" & col & ""
        Next

        For row = 1 To 3
            grid(row, 0) = row & ""
        Next

        For row = 1 To 3
            For col = 1 To 3
                grid(row, col) = ""
            Next
        Next
    End Sub

    Sub printgrid()

        Dim r As Integer
        Dim c As Integer

        For r = 0 To 3
            For c = 0 To 3
                Console.Write("{0}", grid(c, r))
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub turnx()
        Dim r1 As Integer
        Dim c1 As Integer

        Console.WriteLine("Input a x coordinate from 1 to 3")
        r1 = CInt(Console.ReadLine())
        Console.WriteLine("iput a y coordinate between 1 and 3")
        c1 = CInt(Console.ReadLine())

        grid(c1, r1) = "X"

    End Sub

    Sub turno()
        Dim r2 As Integer
        Dim c2 As Integer

        Console.WriteLine("Input a x coordinate from 1 to 3")
        r2 = CInt(Console.ReadLine())
        Console.WriteLine("iput a y coordinate between 1 and 3")
        c2 = CInt(Console.ReadLine())

        grid(r2, c2) = "O"

    End Sub

    Sub xvictory()

        Do While win = False

            'diagonal win conditions

            If grid(1, 1) = "X" And grid(2, 2) = "X" And grid(3, 3) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Diagonal win"

            ElseIf grid(3, 1) = "X" And grid(2, 2) = "X" And grid(1, 3) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Diagonal win"

                'horizontal win conditions

            ElseIf grid(1, 1) = "X" And grid(2, 1) = "X" And grid(3, 1) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Horizontal Win"

            ElseIf grid(1, 2) = "X" And grid(2, 2) = "X" And grid(3, 2) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Horizontal Win"

            ElseIf grid(1, 3) = "X" And grid(2, 3) = "X" And grid(3, 3) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Horizontal Win"

                'vertical win conditions

            ElseIf grid(1, 1) = "X" And grid(1, 2) = "X" And grid(1, 3) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Vertical win"

            ElseIf grid(2, 1) = "X" And grid(2, 2) = "X" And grid(2, 3) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Vertical win"


            ElseIf grid(3, 1) = "X" And grid(3, 2) = "X" And grid(3, 3) = "X" Then
                win = True
                winner = "X-Player"
                wintype = "Vertical win"

            End If

        Loop
    End Sub
    Sub ovictory()

        Do While win = False

            'diagonal win conditions

            If grid(1, 1) = "O" And grid(2, 2) = "O" And grid(3, 3) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Diagonal win"

            ElseIf grid(3, 1) = "O" And grid(2, 2) = "O" And grid(1, 3) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Diagonal win"

                'horizontal win conditions

            ElseIf grid(1, 1) = "O" And grid(2, 1) = "O" And grid(3, 1) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Horizontal Win"

            ElseIf grid(1, 2) = "O" And grid(2, 2) = "O" And grid(3, 2) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Horizontal Win"

            ElseIf grid(1, 3) = "O" And grid(2, 3) = "O" And grid(3, 3) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Horizontal Win"

                'vertical win conditions

            ElseIf grid(1, 1) = "O" And grid(1, 2) = "O" And grid(1, 3) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Vertical win"

            ElseIf grid(2, 1) = "O" And grid(2, 2) = "O" And grid(2, 3) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Vertical win"


            ElseIf grid(3, 1) = "O" And grid(3, 2) = "O" And grid(3, 3) = "O" Then
                win = True
                winner = "O-Player"
                wintype = "Vertical win"

            End If

        Loop


    End Sub
    Sub endgame()

        If win = True Then
            Console.WriteLine("The winner is " & winner & " by a " & wintype)
        Else
            Console.WriteLine("No winner")
        End If

    End Sub

    Sub gridcheck()

        Dim boxcheck As Boolean = True
        Dim c As Integer
        Dim r As Integer

        For r = 0 To 3
            For c = 0 To 3
                If grid(c, r) = "" Then
                    boxcheck = True
                Else
                    boxcheck = False
                End If
            Next
        Next

        If boxcheck = False Then
            gridfull = True
        End If

    End Sub
End Module
