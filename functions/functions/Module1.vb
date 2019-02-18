Module Module1

    Functi
    Sub Main()
        Dim cout As Integer = 0
        Dim nam1 As String
        Dim nam2 As String
        Dim nam3 As String
        Dim ans As String

        Do While cout >= 2
            Console.WriteLine("Which name slot would you like to record the name on? (1-3)")
            ans = CInt(Console.ReadLine())

            If ans = 1 Then
                namecall()
                nam1 = namecall(name As Object) As String
                Console.WriteLine(nam1)
            End If
            cout = cout + 1
        Loop

        Console.WriteLine()
        Console.ReadLine()
    End Sub
    On namecall(ByVal name As String) As String
        Dim name As String

        Console.WriteLine("input a name: ")
        name = Console.ReadLine()
    End Function

End Module
