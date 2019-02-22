Imports System.IO

Module Module1

    Sub Main()
        'Reference Types
        '   Objects are created using the New operator
        '   Variables store a reference to an object
        '   Reference is stored on the Stack, object is stored on the Heap
        '   Assignment copies the reference
        '   Multiple variables can point to the same object
        '   Variables may not have a referencce (be set to Nothing)

        'Garbage Collection
        '   Garbage collector cleans up unused objects from the Heap
        '       Only when application is running low on memory
        '       Objects live on even after they are no longer being used
        '   Garbage collection mechanism can be a problem if objects are using unmanaged resources
        '       These are generally resources provided by the operating system, not Common Language Runtime (CLR)
        '           Memory, file handles, database connections, etc
        '       The resources remain in use until the object is garbage collected

        OpenFile()
        Console.ReadKey()
    End Sub

    Sub OpenFile()
        Dim fs As FileStream = Nothing
        Try
            fs = New FileStream("C:\Users\JohnKaraplis\Desktop\Training\VB Fundamentals\filestreamDemo.txt", FileMode.Open)
        Finally
            If fs IsNot Nothing Then
                'Dispose() automatically calls Close() -- it is preferable in all cases where both are available
                'Remove this dispose() and try to open the file when program is running --
                '   you'll find yourself unable to do so (connection to file has not been released by operating system)
                fs.Dispose()
            End If
        End Try

        Using fs2 As New FileStream("C:\Users\JohnKaraplis\Desktop\Training\VB Fundamentals\filestreamDemo.txt", FileMode.Open)
            'Using automatically runs dispose(), essentially builds out the code used for fs above
        End Using
    End Sub

    'Dispose
    '   Objects that use unmanaged resources implement a Dispose method
    '       Frees up unmanaged resources
    '       Users of the object call Dispose when they are finished with the object

End Module
