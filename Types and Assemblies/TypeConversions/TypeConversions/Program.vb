'Option Strict On 'When set to On, restricts implicit data conversions to ONLY widening conversions (prevents data loss)
'Option Strict On can be set at project level -- right click on project file, go to properties, and on compile tab you can select Option Strict
Imports System


Module Program
    Sub Main(args As String())

        Dim x As Integer = 10
        Dim y As Double = 3.14
        Dim s1 As String = "10.5"
        Dim s2 As String = "Foo"
        Dim d As Date = #5/13/1964#

        Console.WriteLine(x)
        Console.WriteLine(y)

        'Widening Conversion --
        '   No chance for data loss
        y = x

        Console.WriteLine(y)

        y = 3.14

        Console.WriteLine(y)

        'Narrowing Conversion --
        '   Data can be lost (here, 3.14 cannot be expressed as an integer)

        x = y

        Console.WriteLine(x)

        y = x + y '(adding an integer and a double, getting result as double)

        Console.WriteLine(y)

        x = x + y '(adding an integer and a double, getting result as integer)

        Console.WriteLine(x)

        x = x + s1 '("10.5" is converted to integer, and added to x)

        Console.WriteLine(x)

        'x = x + s2 (will break program -- "Foo" can't be converted to number)

        x = True 'Boolean values are converted to numbers by VB (when appropriate)

        Console.WriteLine(x)

        'CInt, CChar, etc are conversion functions built into VB -- specifies user wants a conversion to take place (and will allow conversions when Option Strict On is enabled)
        'Can also use Convert.ToInt32() etc
        'CInt maps to Convert.ToInt32() in framework class library (essentially it is VB's reference to .NET's Convert.ToInt32())
        'Integer.Parse() will also attempt to parse an integer, but will fail if string supplied is not an integer (eg will fail on "10.5", since it represents a double)

        'Sometimes you need to convert a value from one type to another
        '   Eg: convert "100" or 3.14 to an Integer

        'By default, Visual Basic will do these conversions for you
        '   This can sometimes lead to data loss or unexpected results

        'You can set Option Strict On to limit automatic type conversions
        '   Option Strict can be set at the file or the project level
        '   Widening conversions (those that will not result in data loss) remain automatic
        '       Eg: 100 can be converted to Double, but 3.14 could not be converted to Integer
        '   For other conversions, you need to use conversion functions

        'Conversion functions:
        '   Native Visual Basic: CInt(), CBool(), CDbl(), CType()
        '   .NET Framework: Convert.ToInt32(), Convert.ToBoolean(), Convert.ToDouble()
        '   String Parsing: Integer.Parse(), Boolean.Parse(), Double.Parse()

    End Sub
End Module
