Module Module1
    Sub Main()
        Dim ans As String
        Console.WriteLine("Square or RNG")
        If ans = "square" Then
            Call m1.Main()
        ElseIf ans = "RNG" Then
            Call module2.Main()
        End If
        Console.WriteLine()
        Console.ReadLine()
    End Sub

End Module
Module m1
    'square'
    Sub Main()
        Dim count As Integer
        Dim count1 As Integer
        Dim count3 As Integer
        Dim count2 As Integer
        Dim square As String

        count = 1
        count3 = 1
        count2 = 1
        count1 = 1
        Console.WriteLine("Do you want to mage a square out of '*'? ")
        square = Console.ReadLine

        While count <= 30 And square = "yes"
            While count2 <= 30
                Console.Write("*")
                count2 = count2 + 1
            End While
            While count1 <= 28
                Console.WriteLine("*                            *")
                count1 = count1 + 1
            End While
            While count3 <= 30
                Console.Write("*")
                count3 = count3 + 1
            End While
            count = count + 1
        End While
        Console.WriteLine()
        Console.ReadLine()
    End Sub
End Module
Module module2
    'RNG'
    Sub Main()

        Dim rand As New Random
        Dim counter, nuber As Integer
        counter = 1

        While counter <= 10
            nuber = rand.Next(70) + 69

        End While
    End Sub

End Module
