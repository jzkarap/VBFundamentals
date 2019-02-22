'Derived class
Public Class Square
    Inherits Shape

    'Not used -- demo purposes only
    Private _side As Integer

    'Overrides the MustOverride property in base class
    Public Overrides ReadOnly Property Area As Double
        Get
            Return _element.Width ^ 2
        End Get
    End Property

    Public Sub New(canvas As Canvas, side As Integer)
        'First step in derived class constructor must be to call base class constructor (if base class has constructor)
        MyBase.New(canvas)
        Dim rect = New Rectangle()
        rect.Height = side
        rect.Width = side
        SetColors(rect)

        _element = rect
    End Sub

    Public Overrides Function GetXml() As String
        Dim element As New XElement("Square",
        New XAttribute("Name", Name),
        New XAttribute("Side", _side))
        Return (element.ToString())
    End Function
End Class
