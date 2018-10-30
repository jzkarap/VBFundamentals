Imports System

Module Program
    Sub Main(args As String())
        'Classes enable us to combine variables (state) and procedures (behavior)
        'to represent things important to our application
        'Eg: a customer, a playing card, an invoice, a project, etc

        'The infrastructure of our application is also represented by classes
        'Eg: forms in a client application, pages in a web application, data/schema in database, etc.

        'All code must be written inside a class
        'A Module is a special case of a class

        'Classes contain:
        ' Fields - variables that are specific to the class
        ' Methods and Properties - functions that operate on the data stored in the variables
        ' Constructors - Special functions that run when an object is created

        'Members - 
        ' Fields, methods, and properties are collectively called members of a class

        'Objects are instances of a class
        'Classes define types:
        ' Fields, properties, methods

        'Objects are instances of a type
        ' Use New keyword to create instance
        ' You can create multiple instances
        ' Each instance holds different state
        ' Each instance has same behavior

        'Create new instance of object
        Dim emp As New Employee
        'Access fields by dot notation
        emp.Name = "Jack"

        Dim emp2 As New Employee
        emp2.Name = "Scott"

        'Fields represent variables for a class
        ' Might also be expressed as data or state for class
        '   Each instance of class gets its own state

        Console.WriteLine(emp.Name)

        'This line should not change value of name, because of the check within the class property
        '(empty strings not allowed)
        emp.Name = ""
        Console.WriteLine(emp.Name)
        Console.WriteLine(emp.Age)

        emp.Salaried = True

        Console.WriteLine(emp.GetDescription())

        Dim empty As New Employee
        Console.WriteLine(empty.GetDescription())

        'Demonstrate an overloaded constructor (notice parameters)
        Dim newEmp As New Employee("Rob", False)
        Console.WriteLine(newEmp.GetDescription())

    End Sub
End Module
