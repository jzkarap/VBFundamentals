Imports System

Module Program
    Sub Main(args As String())
        'Value Types are less complicated than Reference Types

        'Values are allocated on the Stack
        '   Memory released when variable goes out of scope

        'Many built-in primitives are value types
        '   All numeric data types, boolean, date, enumerations

        'Assignment copies the VALUE of the variable

        Dim x As Integer = 5
        Dim y As Integer
        y = x
        x = 10
        Console.WriteLine(x) ' 10
        Console.WriteLine(y) ' 5 

        Dim b As Integer

        If 1 = 2 Then
            Dim a As Integer = 5
            b = 10
        End If

        'a = 10  -- "a is not declared" > a cannot be accessed because it is out of scope (and will have been cleared from memory by the time this line is reached)
        b = 5 'b can still be accessed because it was declared outside of the If

    End Sub
End Module
