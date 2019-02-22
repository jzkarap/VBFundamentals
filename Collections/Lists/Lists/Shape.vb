Public MustInherit Class Shape
    Implements IXmlExport

    Public Property Name As String
    Public Property ID As Integer

    Public MustOverride Function GetXml() As String Implements IXmlExport.GetXml

End Class
