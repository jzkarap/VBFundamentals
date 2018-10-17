Imports System

Module Program
    Sub Main(args As String())

        Dim age As Integer = 24
        Dim name As String = "Xerxes"

        'Case always checks value of one specific variable
        Select Case age
            Case Is <= 2
                Console.WriteLine("Serve milk")
            Case 24
                Console.WriteLine("Get outta here man you had too much")
            Case Is >= 21
                Console.WriteLine("Serve Maker's Mark on the rocks")
            Case Else
                Console.WriteLine("Serve RC Cola")
        End Select

        Console.WriteLine("Done")
        Console.ReadKey()

    End Sub
End Module
