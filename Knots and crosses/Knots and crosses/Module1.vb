Module Module1

    Dim grid(3, 3) As String
    Dim winner As Boolean

    Sub Main()
        initialise()
        printgrid()

        Do While winner = False
            determineturn()
        Loop

        Console.WriteLine()
        Console.ReadLine()
    End Sub
    Sub initialise()

        Dim cols As Integer
        Dim row As Integer

        grid(0, 0) = "\"

        For col = 1 To 3
            grid(col, 0) = "" & col & ""
        Next

        For row = 1 To 3
            grid(0, row) = row & ""
        Next

        For col = 1 To 3
            For row = 1 To 3
                grid(col, row) = ""
            Next
        Next
    End Sub

    Sub printgrid()

        Dim c As Integer
        Dim r As Integer

        For c = 0 To 3
            For r = 0 To 3
                Console.Write(grid(c, r))
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub determineturn()

        Dim turnx As Integer
        Dim turno As Integer
        Dim counter As Integer

        If turnx = turno Then
            px()
            turnx = turnx + 1
            counter = counter + 1

        ElseIf turnx > turno Then
            po()
            turno = turno + 1
            counter = counter + 1
        End If
    End Sub

    Sub px()
        Dim x As String
        Dim y As String

        Console.WriteLine()
        Console.WriteLine("Input the column you want to put the X in => ")
        x = Console.ReadLine())
        Console.WriteLine()
        Console.WriteLine("Input the row you want to put the X in => ")
        y = Console.ReadLine())

        grid(y, x) =  & "X"


        printgrid()

    End Sub

    Sub po()

    End Sub

End Module
