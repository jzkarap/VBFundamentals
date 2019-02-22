'Base class
'New operator cannot be used on a class marked MustInherit -- class is considered abstract
Public MustInherit Class Shape
    Implements IXmlExport

    'Protected fields can be used by the class in which it is declared
    'OR any derived class that inherits from that class
    Protected _element As FrameworkElement
    'Why FrameworkElement?
    '   Can't use _rect in Circle or _ellipse in Square
    '   Rectangle and Circle both inherit from FrameworkElement,
    '   so we can assign an instance of derived type to a variable of a base type
    Private Shared _rand As New Random()

    Private _canvas As Canvas

    Public Property Name As String

    'Constructor
    Public Sub New(canvas As Canvas)
        _canvas = canvas
    End Sub

    'MustOverride makes a property abstract
    'Every type that derives from Shape HAS TO override this property
    Public MustOverride ReadOnly Property Area As Double

    Public Sub Draw()
        Dim left = _canvas.ActualWidth * _rand.NextDouble
        Dim top = _canvas.ActualHeight * _rand.NextDouble
        _element.SetValue(Canvas.LeftProperty, left)
        _element.SetValue(Canvas.TopProperty, top)

        _canvas.Children.Add(_element)
    End Sub

    'Virtual Member
    Protected Overridable Sub SetColors(shape As System.Windows.Shapes.Shape)
        shape.Fill = New SolidColorBrush(Colors.Green)
        shape.Stroke = New SolidColorBrush(Colors.Black)
    End Sub

    Public MustOverride Function GetXml() As String Implements IXmlExport.GetXml

End Class
