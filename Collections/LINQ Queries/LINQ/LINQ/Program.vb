Imports System

Module Program

    Private _rand As New Random()

    Sub Main(args As String())
        Dim employees = MakeList()

        For Each emp In employees
            Console.WriteLine(emp.GetDescription())
        Next

        Console.WriteLine()

        Dim salariedEmployees As New List(Of Employee)

        For Each emp In employees
            If emp.Salaried AndAlso emp.Age > 35 Then
                salariedEmployees.Add(emp)
            End If
        Next

        For Each emp In salariedEmployees
            Console.WriteLine(emp.GetDescription)
        Next

        Dim olderSalariedEmployees = From emp In employees
                                     Where emp.Salaried AndAlso emp.Age > 60
                                     Select emp

        Console.WriteLine()

        For Each emp In olderSalariedEmployees
            Console.WriteLine(emp.GetDescription)
        Next

        Console.WriteLine()

        'Underlying LINQ queries are lambda expressions
        Dim unsalariedEmployees = employees.Where(
            Function(emp) Not emp.Salaried)

        For Each emp In unsalariedEmployees
            Console.WriteLine(emp.GetDescription)
        Next

        'LINQ Query Expressions
        '   LINQ = Language Integrated Query
        '   Looks like a SQL query
        '   Begins with a From clause, ends with a Select or Group
        '       Can use From, Where, Order By, Join, etc
        '   We saw LINQ to Objects
        '       Query objects in memory: collections and arrays
        '       Many other variants: LINQ to XML, LINQ to SQL, etc
        '       Query expressions are similar regardless of variant

        'Lambda Expressions
        '   Takes a functional view of the world
        '       Anonymous functions (function as parameter)
        '   Concise syntax for defining an anonymous function
        '       Doesn't require the Delegate keyword
        '       Doesn't require the Return keyword
        '       Compiler uses type inference whenever possible

    End Sub

    Private Function MakeList() As List(Of Employee)
        Dim employees As New List(Of Employee)

        For i = 1 To 100
            Dim day = _rand.Next(1, 28)
            Dim month = _rand.Next(1, 12)
            Dim year = _rand.Next(1950, 1990)
            Dim birthDate = New DateTime(year, month, day)

            'i Mod 2 = 0 indicates evenly placed employees are not salaried (will insert 0 as parameter for boolean)
            Dim emp As New Employee("Employee" & i, i Mod 2 = 0, birthDate)
            employees.Add(emp)
        Next
        Return employees
    End Function
End Module
