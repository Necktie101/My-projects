Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim total As Integer
        Dim ans As String

        Console.WriteLine("Input one whole number: ")
        num1 = CInt(Console.ReadLine())

        Console.WriteLine("Input another whole number")
        num2 = CInt(Console.ReadLine())

        Console.WriteLine("What would you like to do with the numbers? ")
        ans = CStr(Console.ReadLine())

        Console.WriteLine("You have chosen to:")
        Console.WriteLine(ans)
        Console.WriteLine(num1)
        Console.WriteLine("AND")
        Console.WriteLine(num2)

        Console.WriteLine("Press any key to continue")
        Console.ReadLine()

        If ans = "add" Then
            total = num1 + num2
            Console.WriteLine(total)

        ElseIf ans = "subtract" Then
            total = num1 - num2
            Console.WriteLine(total)

        Else
            Console.WriteLine("Can only add and subtract")
        End If

        Console.WriteLine("Press any key to close ")
        Console.ReadLine()
    End Sub

End Module
