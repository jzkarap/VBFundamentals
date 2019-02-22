'Derived class
Public Class Square
    Inherits Shape

    'Not used -- demo purposes only
    Private _side As Integer

    Public Sub New(side As Integer)
        _side = side
    End Sub

    Public Overrides Function GetXml() As String
        Dim element As New XElement("Square",
        New XAttribute("Name", Name),
        New XAttribute("Side", _side))
        Return (element.ToString())
    End Function
End Class
