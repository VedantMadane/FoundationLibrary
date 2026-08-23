Imports System.Runtime.CompilerServices


Namespace Extensions
    <Extension>
    Public Module CharExtension
        Enum TypeChar
            None
            Letter
            Symbols
            SpecialCharacter
            Math
        End Enum

        <Extension>
        Public Function GetTypeCharacter(c As Char) As TypeChar
            If Char.IsDigit(c) Or Char.IsNumber(c) Then Return TypeChar.Math
            If Char.IsLetter(c) Then Return TypeChar.Letter
            If Char.IsSymbol(c) Or Char.IsPunctuation(c) Then Return TypeChar.Symbols
            If Char.IsWhiteSpace(c) Or c = Nothing Then Return TypeChar.SpecialCharacter
            Return TypeChar.None


        End Function
    End Module
End Namespace

