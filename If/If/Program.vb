Imports System

Module Program
    Sub Main(args As String())
        Dim age As Integer = 1
        Dim name As String = "Bob"

        If age <= 2 Then
            Console.WriteLine("Serve milk")
        ElseIf age >= 21 AndAlso name <> "Bob" Then
            Console.WriteLine("Serve Maker's Mark on the rocks")
        Else
            Console.WriteLine("Serve RC Cola")
        End If

        Console.WriteLine("Done")
        Console.ReadKey()

    End Sub
End Module
