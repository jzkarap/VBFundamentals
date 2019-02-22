Public Class Employee
    'Keyword 'Implements' used for interfaces

    Private _name As String
    Private _birthDate As DateTime

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If Not String.IsNullOrEmpty(value) Then
                _name = value
            End If
        End Set
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Dim diff = DateTime.Now - _birthDate
            Return diff.Days \ 365
        End Get
    End Property

    Public Property ID As Integer
    Public Property Salaried As Boolean

    Public Sub New(ByVal name As String,
                   ByVal salaried As Boolean,
                   ByVal birthDate As DateTime)

        Me.Name = name
        Me.Salaried = salaried
        _birthDate = birthDate
    End Sub

    Public Function GetDescription()
        Return String.Format(
            "{0} is{1} a salaried employee and is {2} years old",
            Name, If(Salaried, "", " not"), Age)
    End Function

End Class
