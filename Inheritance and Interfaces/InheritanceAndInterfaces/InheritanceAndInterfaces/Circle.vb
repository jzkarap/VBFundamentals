Public Class Circle
    Inherits Shape

    'Not used
    Private _radius As Integer

    Public Sub New(canvas As Canvas, radius As Integer)
        MyBase.New(canvas)
        Dim ellipse = New Ellipse()
        ellipse.Width = radius
        ellipse.Height = radius
        SetColors(ellipse)

        _element = ellipse
    End Sub

    Public Overrides ReadOnly Property Area As Double
        Get
            Return Math.PI * _element.Width ^ 2
        End Get
    End Property

    Protected Overrides Sub SetColors(shape As Shapes.Shape)
        MyBase.SetColors(shape)
        'Override base class behavior
        shape.Fill = New SolidColorBrush(Colors.Red)
    End Sub

    Public Overrides Function GetXml() As String
        Dim element As New XElement("Circle",
        New XAttribute("Name", Name),
        New XAttribute("Side", _radius))
        Return (element.ToString())
    End Function
End Class
