Imports System

Module Program

    Enum Suits
        Clubs
        Hearts
        Diamonds
        Spades
    End Enum

    Sub Main(args As String())
        Dim suit As Suits = Suits.Clubs
        Console.WriteLine(Suits.Spades)
        Console.WriteLine(suit)
        If (Suits.Clubs = suit) Then
            Console.WriteLine("WHOAH MAN")
        End If
    End Sub

    'An enumeration is a set of named constants
    'A numeric value is associated with each constant
    'The convention is for enumerations to begin at value = 0, and each subsequently named enumerator value+=1
    'If you were to set Clubs = 10 above, Hearts would automatically become 11, Diamonds 12, Spades 13

End Module
