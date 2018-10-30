Public Class Employee
    'Convention is to store each class in its own file

    'Private fields are available internally --
    'Belongs to the class, but cannot be accessed outside
    '(it cannot even be accessed by dot notation on an instance of the class)
    Private _salaried As Boolean
    'Private fields use cameCase and underscored
    'Public fields use PascalCase

    'To control what is an acceptable input, or to have a readonly field,
    'use a property

    'Properties enable us to wrap access to fields in code
    'End-user experience is the same -- properties are accessed as if they are public fields

    Private _name As String

    Public Property Name As String
        'First, get a value
        Get
            'Return whatever is stored in _name
            Return _name
        End Get
        'Then, set the value
        Set(value As String)
            'Only set if value is not empty
            If Not String.IsNullOrEmpty(value) Then
                _name = value
            End If
        End Set
    End Property

    '# denotes DateTime (maybe? confirm this)
    Private _birthDate As DateTime = #5/13/1964#

    'This property cannot be set outside class -- it is declared readonly
    Public ReadOnly Property Age As Integer
        Get
            Dim diff = DateTime.Now - _birthDate
            Return diff.Days \ 365
        End Get
    End Property

    'Auto-properties can be used (as a shorthand)
    Public Property Retired As Boolean
    'The get and set blocks are implicit in this case

    Public Property Salaried As Boolean
        Get
            Return _salaried
        End Get
        Set(value As Boolean)
            _salaried = value
        End Set
    End Property

    'This method will not be exposed externally, but will be available anywhere within the class
    Private Sub Foo()

    End Sub

    Public Function GetDescription()
        Return String.Format("{0} is{1} a salaried employee",
        Name, If(_salaried, "", " not"))
        'Here, Name goes to {0} and the If calculates {1}
    End Function

    'Constructor
    '   When first declaring an employee object, this code will run
    Public Sub New()
        _name = "<empty>"
        Salaried = False
    End Sub

    'Multiple constructors are allowed
    ' Overloaded methods must take different arguments!

    'VB.NET is NOT case sensitive,
    'so simply setting Name = name would be ambiguous;
    'Using Me.Name directs it to the Name property
    '('Me' is akin to 'this' in C# -- the current instance)
    Public Sub New(name As String, salaried As Boolean)
        Me.Name = name
        Me.Salaried = salaried
    End Sub

End Class

