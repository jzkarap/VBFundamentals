Imports System

Module Program
    Sub Main(args As String())
        'Objects are created using the New operator
        'Variables store a reference to an object
        'Reference is stored on the Stack, object is stored on the Heap
        'Assignment copies the reference
        'Multiple variables can point to the same object
        'Variables may not have a reference (can be set to Nothing)

        'New employee
        Dim e1 As New Employee()
        'Set to same employee as e1 (any changes to e1 or e2 will affect the same object; e1 and e2 refer to the same object)
        'e2 is not distinct from e1; e2 was not declared using New operator
        Dim e2 As Employee = e1
        'New employee distinct
        Dim e3 As New Employee()
        Dim e4 As Employee =
            Nothing

        'Strings are a special case
        '   String is a reference type that behave like a value type

        'Notice there is no New operator
        Dim s1 As String = "Scott"
        Dim s2 As String = s1

        Console.WriteLine(s1)
        Console.WriteLine(s2)

        s2 = "Jake"

        'Value of s1 not affected by change to s2
        Console.WriteLine(s1)
        Console.WriteLine(s2)

        Dim s3 As String = Nothing

        Console.WriteLine(s3)

        'To Review
        '   Strings are reference types
        '       But behave like value types
        '       Immutable
        '           That is, changing the value of a variable creates a new String object that replaces the old one;
        '           the original value itself is not changed

    End Sub
End Module
