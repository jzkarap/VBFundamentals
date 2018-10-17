Imports System

Module Program
    Sub Main(args As String())
        'Procedures enable you to:
        ' - Divide large sections of code into a series of smaller ones
        '       - (making code easier to read and understand)
        ' - Define commonly needed functionality in a single place
        '       - (can be called from multiple places)
        ' - Performing these tasks is called modularizing your code
        'There are two types of procedures:
        ' - Subroutines: do not return a value
        ' - Functions: return a value
        'Procedures may have parameters (arguments) passed to them
        Dim value As String = "Visual Basic"
        DisplayReversedString(value)
        value = "Visual Studio"
        DisplayReversedString(value)

        Dim flipOrder As String = BuildReversedString(value)
        Console.WriteLine(flipOrder)

    End Sub

    Sub DisplayReversedString(text As String)
        For index As Integer = text.Length - 1 To 0 Step -1
            Console.Write(text(index))
        Next
        Console.WriteLine()
    End Sub

    'Functions must declare what type of value to return
    Function BuildReversedString(text As String) As String
        Dim result As String = ""

        For index As Integer = text.Length - 1 To 0 Step -1
            result += text(index)
        Next

        Return result

    End Function

    'Overloading --
    '       Having multiple functions or subroutines with the same name,
    '       but different sets of parameters
    '       (compiler will find best match of number and type of parameters)
    'eg:
    Sub Post(ByVal customerName As String, ByVal amount As Single)
        ' Insert code to access customer record by customer name
    End Sub

    Sub Post(ByVal customerID As Integer, ByVal amount As Single)
        ' Insert code to access customer record by account number
    End Sub

End Module
