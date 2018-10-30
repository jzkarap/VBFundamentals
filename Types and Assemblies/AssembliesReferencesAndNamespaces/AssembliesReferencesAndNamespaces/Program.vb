Imports System
Imports System.IO
Imports System.Net 'Namespace

Module Program
    Sub Main(args As String())
        'The result of building an application in .NET is an assembly
        '   (for the most parts, .dll and .exe files)

        'To add an assembly reference, right click on project and select Add > Reference
        'Then, at top of VB.NET file, use an Imports {assembly}

        'Once an assembly reference is made, types belonging to that assembly can be used

        Dim request = WebRequest.Create("https://www.pluralsight.com")

        'Can also specify namespaces by right clicking on project, going to properties > references and checking at bottom of menu

        'Root namespace is found in properties > application

        Dim response = request.GetResponse()
        Dim reader As New StreamReader(response.GetResponseStream())
        'Will show html etc for pluralsight homepage
        Console.WriteLine(reader.ReadToEnd())

        'Assemblies
        '   Fundamental Building Blocks
        '       Implemented as .exe or .dll files
        '       Contain metadata about version and all types inside
        '   Global Assembly Cache
        '       A central location to store assemblies for a machine

        'References
        '   Must load assembly into a process before using types inside
        '       Easy approach -- reference the assembly in Visual Studio
        '       Assemblies loaded on demand at runtime

        'Namespaces
        '   Namespaces organizes types
        '       Help to avoid type name collisions
        '       Can define namespace in one or more places
        '   Full qualified type names
        '       Includes the assembly name
        '       Includes the namespace
        '       Includes the type name
        '   Imports
        '       Brings other namespaces into scope
        '       No need to namespace qualify a type

    End Sub
End Module
