   Sub Main()
        Dim i As Integer = 0
        Dim x As Integer = 0
        Dim y As Integer = 0

        For i = 1 To 100
            x = i Mod 3
            y = i Mod 5
            If x = 0 And y = 0 Then
                Console.WriteLine("FizzBizz")
            ElseIf x = 0 Then
                Console.WriteLine("Fizz")
            ElseIf y = 0 Then
                Console.WriteLine("Bizz")
            Else
                Console.WriteLine(i)
            End If
        Next
    End Sub