Imports System

Module Program
    Sub Main(args As String())
        'Can declare variable on line it is instantiated
        Dim name As String = "Rob"
        'Or instantiate first, and then assign
        Dim name2 As String
        name2 = "Rob"
        'Variables can be updated
        name2 = "Scott"

        'WHOLE-NUMBER TYPES:
        'Byte is smallest whole-number type -- 8bit, unsigned integer
        '(can hold only positive values)
        Dim x As Byte = 10
        'Short is a 16bit number
        'Can get MaxValue/MinValue with built-in function (for all number types)
        Dim y As Short = Short.MaxValue
        'Integer is 32bit signed integer
        Dim z As Integer = Integer.MaxValue
        'Long is 64bit
        Dim a As Long = Long.MaxValue

        'FLOATING-POINT TYPES:
        'Single is a 16bit floating point number
        Dim b As Single = Single.MaxValue
        'Double is a 32bit floating point number
        Dim c As Double = Double.MinValue
        'Decimal is a 64bit floatnig point number
        Dim d As Decimal = Decimal.MaxValue 'Frequently used for dollar/cent values (greatest precision)

        'Boolean represents true/false
        Dim isGood As Boolean = True
        Dim isBad As Boolean = False

        'DATE
        Dim age As Date = "5/13/1964"

        'TYPE INFERENCE
        Dim p = 10 'Assumes data type from value defined (only works if variable is given value at same time it is declared) --
        '(otherwise, assumes variable is an object)

        'Each line of code is a statement
        Dim f = 2 + 3 + 3
        'Underscore character can be used to continue a line
        Dim g =
            f + 1212 + 3434.33 _
             + 443 * 2
        'When values are separated by an operator, they represent an expression

        Console.WriteLine(g)

        'For each data type name in VB, there is a Framework Class Library (FCL) name
        'eg:
        'Integer = Int32
        'Long = Int64
        'Date = DateTime

    End Sub
End Module
