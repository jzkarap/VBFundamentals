Imports System

Module Program
    Sub Main(args As String())

        Dim nums() As Integer = {10, 25, 30, 45, 50, 65}

        'Default is to increment by 1
        For index As Integer = 0 To nums.Length - 1
            Console.WriteLine(nums(index))
        Next

        Console.WriteLine()

        'Incrementing value can be specified with Step
        For index As Integer = 0 To nums.Length - 1 Step 2
            Console.WriteLine(nums(index))
        Next

        Console.WriteLine()

        'Can decrement
        For index As Integer = nums.Length - 1 To 0 Step -1
            Console.WriteLine(nums(index))
        Next

        Console.WriteLine()

        Console.WriteLine("Done For")

        Console.WriteLine()

        Dim index2 As Integer = 0
        Dim value As Integer = nums(index2)

        While value < 50
            If value Mod 2 = 1 Then
                Exit While
                'Can also Continue While
            End If
            Console.WriteLine(value)
            index2 += 1
            value = nums(index2)
        End While

        Console.WriteLine()

        'Exit is used to end loop early
        'Continue is used to progress to next iteration

        'While is used to test a condition, eg when exact number of iterations is not known

    End Sub
End Module
