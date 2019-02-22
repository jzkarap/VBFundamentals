Class MainWindow

    Private Sub Window_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        For i = 1 To 50
            Dim s As New Square(DrawingCanvas, 10)
            s.Draw()
        Next

        For i = 1 To 50
            Dim c As New Circle(DrawingCanvas, 5)
            c.Draw()
        Next

        'Can create classes to extend other classes
        '   Classes inherit from System.Object by default
        '   Gain all state and behavior of base class

        'Access Modifiers -- Part II
        '   Review of access modifiers -- now with inheritance in mind
        '       Public: member can be used internally and externally
        '       Private: member can be used interally in the declaring type
        '       Protected: member can only be used internally in the declaring type and its derived types
        '   Examples:
        '       A private member declared in Shape could only be used inside Shape
        '       A protected member in Shape could be used inside Shape or its derived types -- Square and Circle

        'Shared Members
        '   Shared members are members of the type
        '   Public shared members can be used without creating an instance
        '   The value of shared fields are shared across all instances of the type
        '   All members of a Module are shared
        '       Cannot instantiate a Module

        For index = 1 To 100
            Dim shape As Shape
            If (index Mod 2 = 0) Then
                shape = New Square(DrawingCanvas, 6)
            Else
                shape = New Circle(DrawingCanvas, 15)
            End If
            shape.Draw()
        Next

        'Abstract Classes and Members
        '   The MustInherit keyword
        '       Apply to classes
        '   The MustOverride keyword
        '       Apply to members (methods, properties, indexers, events)
        '   Abstract classes cannot be instantiated
        '       Abstract class is designed as a base class
        '       Must implement abstract members to make a concrete class

        'Virtual Members have an implementation in base class, but that implementation can be overriden in derived class
        '   The Overridable keyword creates a virtual member
        '   The Overrides keyword allows member in derived class to override behavior of implementation in base class
        '   Use MyBase to call implementation from base class


        'Constructors in derived types
        '   Constuction is done "inside out"
        '       That is, the base class is constructed first, and then we bubble up through derived classes
        '   Constructors in derived types call base class constructor
        '       Passing required parameters as needed
        '   If a base class has a constructor with no parameters, VB.NET will build it into derived classes automatically
        '       A constructor that takes no parameters is called a default constructor for this reason

        'Interfaces
        '   An interface defines a group of related methods and properties
        '       Classes can implement interfaces
        '           They must implement the complete set of methods and properties -- cannot pick and choose; all or nothing
        '           Classes can implement more than one interface
        '   Interfaces are about defining something an object CAN DO
        '       Types are about defining what an object IS
    End Sub

End Class
