Imports System

Module Program
    Sub Main(args As String())

        Dim y As Integer = 5

        Foo(y)

        'Will print 5 -- value associated to variable y is copied into x; value of y itself not affected by Foo subroutine
        Console.WriteLine(y)

        'Create reference type
        Dim emp As New Employee("Rob", False)
        Console.WriteLine(emp.Name)
        'Pass reference type to subroutine
        Bar(emp)
        Console.WriteLine(emp.Name)
        FooBar(emp)
        Console.WriteLine(emp.Name)

        Foo2(y)
        Console.WriteLine(y)

        Bar2(emp)
        Console.WriteLine(emp.Name)

        FooBar2(emp)
        Console.WriteLine(emp.Name)

    End Sub

    'Default passing behavior takes variable By Value, but you can also declare this explicitly
    'Here we are passing value type to subroutine, by value
    Sub Foo(ByVal x As Integer)

        x += 5

    End Sub

    'Reference type as parameter continues to reference same object (so the object's name will be updated)
    'Passing parameter by reference here means to passing the reference (the value of a reference type is the object it references -- the value can be thought of as the memeory location where object exists)
    Sub Bar(emp As Employee)
        'This change will be reflected
        emp.Name = "Scott"

    End Sub

    'When passed through as parameter, emp will continue to refer to original reference...
    Sub FooBar(emp As Employee)
        '... but when New operator is used, emp now refers to a new object, so the changes will not apply to original object
        emp = New Employee("Todd", True)
        '(this occurs because emp within the subroutine is merely a copy of the emp that is passed in)
    End Sub

    'Specifying passing By Reference will allow original variable to be updated
    '   (will now reference the exact same place in memory)
    Sub Foo2(ByRef x As Integer)
        x += 5
    End Sub

    'Behaves in same way as the pass By Value in Bar()
    '   (that is, will update the name)
    Sub Bar2(ByRef emp As Employee)
        emp.Name = "Bob"
    End Sub

    'This now updates the value of original emp --
    '   it assigns to emp the new reference that is given within the subroutine
    Sub FooBar2(ByRef emp As Employee)
        emp = New Employee("Katie", False)
    End Sub

    'Passing parameters by value (ByVal)
    '   Reference types pass a copy of their reference
    '   Value types pass a copy of their value
    '       Changes to value don't propogate to caller

    'Passing parameters by reference (ByRef)
    '   Changes to the parameter are propagated to the caller

End Module
