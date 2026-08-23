
Imports System.Runtime.CompilerServices
Namespace Extensions

    <Extension>
    Public Module StringExtensions

#Region "Letters Methods"
        <Extension>
        Public Function IsHasUpperLetter(Str As String, Optional NumberCountUpperLetter As Integer? = Nothing) As Boolean

            Dim CountUppers As Integer = 0
            For i = 0 To Str.Length - 1
                If Char.IsLetter(Str(i)) And Char.ToUpper(Str(i)) = Str(i) Then CountUppers += 1
            Next
            If NumberCountUpperLetter IsNot Nothing AndAlso CountUppers >= NumberCountUpperLetter Then Return True
            If CountUppers > 0 Then Return True

            Return False
        End Function

        <Extension>
        Public Function IsHasLowerLetter(Str As String, Optional NumberCountLowerLetter As Integer? = Nothing) As Boolean
            Dim CountLower As Integer = 0
            For i = 0 To Str.Length - 1
                If Char.IsLetter(Str(i)) And Char.ToUpper(Str(i)) = Str(i) Then CountLower += 1
            Next
            If NumberCountLowerLetter IsNot Nothing AndAlso CountLower >= NumberCountLowerLetter Then Return True
            If CountLower > 0 Then Return True
            Return False
        End Function

        <Extension>
        Public Function ContainsOnlyLettersWithException(Str As String, ParamArray Exceptions() As String) As Boolean
            For i = 0 To Str.Length - 1
                If Char.IsLetter(Str(i)) AndAlso Exceptions.Contains(Str(i)) = True Then Return False
                If Not Char.IsLetter(Str(i)) Then Return False
            Next
            Return True
        End Function

        <Extension>
        Public Function ContainsOnlyLetters(Str As String) As Boolean
            For i = 0 To Str.Length - 1
                If Not Char.IsLetter(Str(i)) Then Return False
            Next
            Return True
        End Function

        <Extension>
        Public Function AreAllUpperCase(Str As String) As Boolean
            For i = 0 To Str.Length - 1
                If Char.IsLower(Str(i)) Then Return False
            Next
            Return True
        End Function

        <Extension>
        Public Function AreAllLowerCase(Str As String) As Boolean
            For i = 0 To Str.Length - 1
                If Char.IsUpper(Str(i)) Then Return False
            Next
            Return True
        End Function
#End Region

#Region "Digit Methods"
        <Extension>
        Public Function IsHasDigit(Str As String, Optional NumberCountDigit As Integer? = Nothing) As Boolean
            Dim Count As Integer = 0
            For i = 0 To Str.Length - 1
                If Char.IsDigit(Str(i)) Then Count += 1
            Next
            If NumberCountDigit IsNot Nothing AndAlso Count >= NumberCountDigit Then Return True
            Return False
        End Function
        <Extension>
        Public Function ContainsOnlyDigitsWithExceptions(Str As String, ParamArray Exceptions() As Integer) As Boolean
            For i = 0 To Str.Length - 1
                If Char.IsDigit(Str(i)) = True AndAlso Exceptions.Contains(AscW(Str(i))) = True Then Return False
                If Not Char.IsDigit(Str(i)) Then Return False
            Next
            Return True
        End Function

        <Extension>
        Public Function ContainsOnlyDigits(str As String) As Boolean
            For i = 0 To str.Length - 1
                If Not Char.IsDigit(str(i)) Then Return False
            Next
            Return True
        End Function
#End Region

        <Extension>
        Public Function IsEmail(Str As String) As Boolean
            If Str.Contains("@") Then Return True
            Return False
        End Function
        <Extension>
        Public Function IsWebSite(Str As String) As Boolean
            If Str.ToUpper.Contains("HTTP:\\") Or Str.ToUpper.Contains("HTTPS:\\") Or Str.ToUpper.Contains("WWW.") Or Str.ToUpper.Contains(".COM") Then Return True
            Return False
        End Function

        <Extension>
        Public Function ContainsSpecialCharacter(Str As String) As Boolean
            If String.IsNullOrEmpty(Str) Then Return True
            For Each c As Char In Str
                If Not Char.IsLetterOrDigit(c) AndAlso Char.IsWhiteSpace(c) Or Char.IsSymbol(c) Or Char.IsSeparator(c) Then Return True
            Next
            Return False
        End Function
        <Extension>
        Public Function ContainsSymbols(Str As String) As Boolean
            For i = 0 To Str.Length - 1
                If Char.IsSymbol(Str(i)) Then Return True
            Next
            Return False
        End Function

        <Extension>
        Public Function ContainsAny(Str As String, ParamArray ListStrings() As String) As Boolean
            For i = 0 To ListStrings.Length - 1
                If Str.Contains(ListStrings(i)) Then Return True
            Next
            Return False
        End Function
        <Extension>
        Public Function IsLengthInRange(Str As String, MinLength As Integer?, MaxLength As Integer?) As Boolean
            If MinLength IsNot Nothing AndAlso Str.Length < MinLength Then Return False
            If MaxLength IsNot Nothing AndAlso Str.Length > MaxLength Then Return False
            Return True
        End Function
        <Extension>
        Public Function TryConvertToInt(Str As String, Optional ByRef Result As Integer = Nothing) As Boolean
            If Integer.TryParse(Str, Result) Then Return True
            Return False
        End Function
    End Module
End Namespace