Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer = 3
        Dim y As Integer = 11
        Dim z As Integer = 26

        Dim arr As Array = {x, y, z}

        Dim result = y * x
        Console.WriteLine(result)

        'VB recognizes when a result differs from data type of operands
        Dim newResult = y / x
        Console.WriteLine(newResult)
        'NOTE: this WILL NOT WORK if re-assigning to a variable already declared
        result = y / x
        Console.WriteLine(result)
        '(here, result remains an integer and the calculation is rounded)

        'INTEGER DIVISION --
        'Discards floating decimal points
        Dim newerResult = y \ x
        Console.WriteLine(newerResult)

        'Modulo is stated as so:
        Dim newestResult = y Mod x
        Console.WriteLine(newestResult)

        'Equality is represented by a single =
        Dim boolResult = x = y
        Console.WriteLine(boolResult)

        'Inequality is represented by double angle brackets <>
        Dim boolNew = x <> y
        Console.WriteLine(boolNew)

        'Incrementing
        x += 3
        'Decrementing
        x -= 3

        'Equality of boolean
        Dim check = (x = x + 3) = (x = x + 3)
        Console.WriteLine(check)

        'Or -- if either side of expression is true, will evaluate to true
        Dim checkThis = x <> y Or x > 15
        'And -- if both sides of expression are true, will evaluate to true
        Dim checkThisToo = x <> y And x > 15

        'Or and And evaluate all statements before comparing them -- 
        'it is often more efficient to use AndAlso or OrElse
        '(AndAlso and OrElse short-circuit the operation and end it prematurely if it finds enough data to conclude expression)

        'AndAlso -- here, if arr was nothing, the expression would stop evaluating instantly
        Dim checkThisNow = arr IsNot Nothing AndAlso x > 15
        Console.WriteLine(checkThisNow)

        'OrElse -- if lefthand side is true, expression will always be true, 
        'so it returns true as soon as it finds a true statement (left to right)
        Dim orElseCheck = x <> y OrElse x > 15
        Console.WriteLine(orElseCheck)

        Dim firstName As String = "Mr."
        Dim lastName As String = "Guy"

        'String concatenation
        Dim fullName = firstName & " " & lastName
        Console.WriteLine(fullName)
        'Can also use +
        Dim fullerName = firstName + " " + fullName
        Console.WriteLine(fullerName)
        'BUT!
        '+ can introduce problems when there is ambiguity
        Dim ambiguousResult = "10" + x
        Console.WriteLine(ambiguousResult)
        'Here, VB converted the string "10" to a number and added it to x to get a result
        Dim unambiguousResult = "10" & x
        Console.WriteLine(unambiguousResult)
        '& forces string concatenation (does not convert types)


    End Sub
End Module
