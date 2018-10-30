Imports System

Module Program
    Sub Main(args As String())
        Dim nums() As Integer = {10, 20, 30}

        Try
            ShowNumbers(nums)
            'Can have multiple catch blocks
        Catch ex1 As IndexOutOfRangeException
            Console.WriteLine(ex1.Message)
        Catch ex2 As ArithmeticException
            Console.WriteLine(ex2.Message)
        Catch ex3 As Exception
            Console.WriteLine(ex3.Message)
        End Try
        'Exception is most general type of exception
        'Can also check by category of exception or a specific exception
        'Like a case statement, most specific must be checked first (or may never be reached)

        'Exceptions bubble up to nearest try/catch

        Console.WriteLine("Done")
        Console.ReadKey()

        Try
            BuyDrinks(14)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub ShowNumbers(nums() As Integer)
        For index As Integer = 0 To nums.Length
            Dim value As Integer = nums(index)
            Console.WriteLine(value)
        Next
    End Sub

    Sub BuyDrinks(age As Integer)
        If age < 21 Then
            'Throw new exception if some condition unmet
            Throw New ArgumentException("Must be 21 or older!")
        End If
    End Sub
End Module
