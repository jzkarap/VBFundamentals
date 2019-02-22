Public Class Circle
    Inherits Shape

    Private _radius As Integer

    Public Sub New(radius As Integer)
        _radius = radius
    End Sub

    Public Overrides Function GetXml() As String
        Dim element As New XElement("Circle",
        New XAttribute("Name", Name),
        New XAttribute("Side", _radius))
        Return (element.ToString())
    End Function
End Class
