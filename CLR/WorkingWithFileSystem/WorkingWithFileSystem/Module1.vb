Module Module1

    Sub Main()
        Dim fileSystem = My.Computer.FileSystem

        Dim docsFilePath = fileSystem.SpecialDirectories.MyDocuments
        Dim docsFolder = fileSystem.GetDirectoryInfo(docsFilePath)

        For Each folder In docsFolder.GetDirectories()
            Console.WriteLine(folder.Name)
        Next

        Dim demoFilePath = docsFilePath & "\TestFolder\test.txt"

        If fileSystem.FileExists(demoFilePath) Then
            Dim contents = fileSystem.ReadAllText(demoFilePath)
            Console.WriteLine()
            Console.WriteLine(contents)
        End If

        'Working With the FileSystem
        '   Use properties and methods from My.Computer.FileSystem
        '       Equivalent FCL types are in System.IO namespace
        '   Commonly used methods:
        '       FileExists: check to see if a file exists
        '       ReadAllText: read all the text in a file
        '       GetDirectoryInfo: get a DirectoryInfo object for a specific folder
        '           Folders property gets information about child folders
        '           Files property gets information about files in folders
        '       GetFileInfo: get a FileInfo object for a specific file

    End Sub

End Module
