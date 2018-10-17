Imports System

Module Program
    Sub Main(args As String())
        Dim nums() As Double = {10.5, 20.5, 30.5, 40.5, 50.5}

        For index As Integer = 0 To nums.Length - 1
            Dim value As Double = nums(index)
            Console.WriteLine(value)
        Next

        Console.WriteLine("Done For")
        Console.WriteLine()

        'For Each designed specifically to iterate over collection or array
        For Each value As Double In nums
            Console.WriteLine(value)
        Next

        Console.WriteLine("Done For Each")
        Console.WriteLine()


    End Sub
End Module
