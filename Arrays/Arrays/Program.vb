Imports System

Module Program
    Sub Main(args As String())
        'Upper bound can be placed in parenthesis when declaring array
        Dim nums(2) As Integer
        'The length is 1+upper bound
        nums(0) = 10
        nums(1) = 20
        nums(2) = 30

        'Can also be declared in single line
        Dim newNums() As Integer = {10, 20, 30}

        'Multi-dimensional arrays
        Dim grid = {{1, 2}, {3, 4}}
        Console.WriteLine(grid(1, 0))

        Console.WriteLine(grid.Length)

        Console.WriteLine(grid.GetUpperBound(1))
    End Sub
End Module
