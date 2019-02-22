Public Class Employee
    Implements IXmlExport
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

    Public Sub New()
        Name = "<empty>"
        Salaried = False
    End Sub

    Public Function GetXml() As String Implements IXmlExport.GetXml
        Dim element As New XElement("Employee",
        New XAttribute("Name", Name),
        New XAttribute("Age", Age))
        Return element.ToString()
    End Function

End Class
