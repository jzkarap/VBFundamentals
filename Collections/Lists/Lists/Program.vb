Imports System

Module Program
    Sub Main(args As String())

        Dim squares As New List(Of Square)

        For i = 1 To 10
            Dim square = New Square(10)
            square.Name = "Square" & i
            squares.Add(square)
        Next

        For Each Square In squares
            Console.WriteLine(Square.Name)
        Next

        Dim shapes As New List(Of Shape)

        For i = 1 To 10
            Dim shape As Shape
            If i Mod 2 = 0 Then
                shape = New Square(10)
            Else
                shape = New Circle(10)
            End If
            shape.Name = "Shape" & i
            shapes.Add(shape)
        Next

        For Each shape In shapes
            Console.WriteLine(shape.Name)
        Next

        'ArrayList is a List-like object that can hold many different types at once
        Dim things As New ArrayList()

        For i = 1 To 10
            Dim thing As Object
            If i Mod 2 = 0 Then
                Dim emp As New Employee()
                emp.Name = "Employee" & i
                thing = emp
            Else
                Dim square As New Square(10)
                square.Name = "Square" & i
                thing = square
            End If
            things.Add(thing)
        Next

        For Each thing In things
            'Late binding -- Visual Studio can't guarantee that the object referenced here has a name property,
            'since it is in an ArrayList that has no specified type,
            'but it trusts us when we tell it what property to access
            '(Option Strict On disallows late binding)
            'With Option Strict On, the code would look like:

            '   If TypeOf thing Is Employee Then
            '       Dim emp = CType(thing, Employee)
            '       Console.WriteLine(emp.Name)
            '   ElseIf TypeOf thing Is Square Then
            '       Dim square = CType(thing, Square)
            '       Console.WriteLine(square.Name)
            '   End If
            Console.WriteLine(thing.Name)
        Next

        'Lists
        '   Like arrays, except you don't need to know size at declaration
        '   Have methods to add and remove items
        '   Use when you plan to iterate items in collection
        '   Commonly used collections of this type:
        '       Generic: List(Of T)
        '       "Legacy": ArrayList

        Dim dictSquares As New Dictionary(Of Integer, Square)

        For i = 1 To 10
            Dim id = i * i
            Dim item As New Square(10)
            item.ID = id
            item.Name = "Square" & i

            If Not dictSquares.ContainsKey(id) Then
                dictSquares.Add(id, item)
            End If
        Next

        Dim key = _rand.Next(1, 10)
        key = key * key

        If dictSquares.ContainsKey(key) Then
            Dim square = dictSquares(key)
            Console.WriteLine("The item with key {0} is {1}", key, square.Name)
        End If

        Dim dictShapes As New Dictionary(Of Integer, Shape)

        For i = 1 To 10
            Dim id As Integer = i * i
            Dim item As Shape
            If i Mod 2 = 0 Then
                item = New Square(10)
                item.Name = "Square" & i
            Else
                item = New Circle(10)
                item.Name = "Circle" & i
            End If

            item.ID = id
            If Not dictShapes.ContainsKey(id) Then
                dictShapes.Add(id, item)
            End If
        Next

        Dim key2 = _rand.Next(1, 10)
        key2 = key2 ^ 2
        If dictShapes.ContainsKey(key2) Then
            Dim shape = dictShapes(key2)
            Console.WriteLine("The item with key {0} is {1}", key2, shape.Name)
        End If

        Dim dictThings As New Hashtable()
        For i = 1 To 10
            Dim id As Integer = i * i
            Dim thing As Object
            If i Mod 2 = 0 Then
                Dim emp As New Employee()
                emp.ID = id
                emp.Name = "Employee" & i
                thing = emp
            Else
                Dim square As New Square(10)
                square.ID = id
                square.Name = "Square" & i
                thing = square
            End If
            If Not dictThings.ContainsKey(id) Then
                dictThings.Add(id, thing)
            End If
        Next

        Dim key3 = _rand.Next(1, 10)
        key3 = key3 ^ 2

        If dictThings.ContainsKey(key3) Then
            Dim thing = dictThings(key3)

            'Option Strict Off -- Late Binding
            'Console.WriteLine("The item with key {0} is {1}", key3, thing.Name)

            'Option Strict On -- Early Binding
            If TypeOf thing Is Employee Then
                Dim emp = CType(thing, Employee)
                Console.WriteLine("The item with key {0} is {1}", key3, emp.Name)
            ElseIf TypeOf thing Is Square Then
                Dim square = CType(thing, Square)
                Console.WriteLine("The item with key {0} is {1}", key3, square.Name)
            End If
        End If

        'Dictionaries 
        '   Each item in a dictionary is associated with a unique key
        '   Key can be used to retrieve item
        '       Can use ContainsKey to check if key exists
        '   Commonly used collections of this type:
        '       Generic: Dictionary(Of TKey, TValue) -- (strictly typed)
        '       "Legacy": Hashtable -- (allows multiple types)

    End Sub

    Private _rand As New Random()

End Module
