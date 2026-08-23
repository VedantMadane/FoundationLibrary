Imports FoundationLibrary.Interfaces.Validation.Structures

Namespace Validation.Structures
    Public Class ValidString
        Implements Interfaces.Validation.Structures.IObjectOfString

        Public Property Cases As IObjectOfString.EnumsStringCase Implements IObjectOfString.Cases
        Public Property MinLength As Integer Implements IObjectOfString.MinLength
        Public Property MaxLength As Integer Implements IObjectOfString.MaxLength
        Public Property AvailableWhiteSpace As Boolean Implements IObjectOfString.AvailableWhiteSpace
        Public Property AvailableNothin As Boolean Implements IObjectOfString.AvailableNothin
        Public Property ValidNumber As Boolean Implements IObjectOfString.ValidNumber
        Public Property ValidSymbols As Boolean Implements IObjectOfString.ValidSymbols
        Public Property ValidStrings As String() Implements IObjectOfString.ValidStrings
        Public Property ValidChars As Char() Implements IObjectOfString.ValidChars
        Public Property ExceptionChars As Char() Implements IObjectOfString.ExceptionChars

        Function Check(Str As String, NameObj As String) As Interfaces.Results.IErrResult(Of List(Of Validation.Exceptions.ErrFields))
            Dim Validation As New List(Of Validation.Exceptions.IErrors)

            If MinLength > Str.Length Then Validation.Add(New Exceptions.ErrFields("Δεν επιτρέπεται το μέγεθος να είναι μικρότερο απο :" & MinLength, NameObj, Str))
            If MaxLength < Str.Length Then Validation.Add(New Exceptions.ErrFields("Δεν Επιτρέπεται το Μέγεθος να ειναι μεγαλύτερο απο: " & MaxLength, NameObj, Str))
            If AvailableNothin = True AndAlso Str.Length = 0 Then Validation.Add(New Exceptions.ErrFields("Δεν Επιτρέπεται το πεδιο να είναι χωρίς τιμή.", NameObj, Str))
            If AvailableWhiteSpace = True AndAlso Str.Contains(" ") Then Validation.Add(New Exceptions.ErrFields("Δεν επιτρέπεται στο πεδιο να υπάρχει κενο.", NameObj, Str))

            If Cases = IObjectOfString.EnumsStringCase.Up AndAlso Str.ToUpper <> Str Then Validation.Add(New Exceptions.ErrFields("Οι Χαρακτήρες δεν ειναι UP", NameObj, Str)) Else
            If Cases = IObjectOfString.EnumsStringCase.Down AndAlso Str.ToLower <> Str Then Validation.Add(New Exceptions.ErrFields("Οι Χαρακτήρες δεν ειναι Lower", NameObj, Str))

            If ValidNumber = True Then
                For i = 0 To Str.Length - 1
                    If Char.IsDigit(Str(i)) AndAlso ExceptionChars.Contains(Str(i)) = False Then Validation.Add(New Exceptions.ErrFields("Δεν μπορει να περιέχει αριθμό.", NameObj, Str))
                Next
            End If
            If ValidSymbols = True Then
                For i = 0 To Str.Length - 1
                    If Char.IsSymbol(Str(i)) AndAlso ExceptionChars.Contains(Str(i)) = False Then Validation.Add(New Exceptions.ErrFields("Δεν μπορει να περιέχει Σύμβολο.", NameObj, Str))
                Next
            End If
            If ValidStrings IsNot Nothing AndAlso ValidStrings.Count > 0 Then
                For i = 0 To ValidStrings.Count - 1
                    If Str.Contains(ValidStrings(i)) Then Validation.Add(New Exceptions.ErrFields("Δεν επιτρέπονται οι συλαβες." & ValidStrings.ToList.ToString, NameObj, Str))
                Next
            End If
            If ValidChars IsNot Nothing AndAlso ValidChars.Count > 0 Then
                For i = 0 To ValidChars.Count - 1
                    If Str.Contains(ValidChars(i)) Then Validation.Add(New Exceptions.ErrFields("Δεν Επιτρέπονται οι Χαρακτήρες." & ValidChars.ToList.ToString, NameObj, Str))
                Next
            End If

            If Validation.Count = 0 Then
                Return New Results.ErrResult(Of List(Of Validation.Exceptions.IErrors))(True, "Επιτυχής Πεδιου!", Validation)
            Else

                Return New Results.ErrResult(Of List(Of Validation.Exceptions.IErrors))(False, "Αποτυχία Πεδιου!", Validation)
            End If

        End Function

    End Class

    Public Class ValidInteger
        Implements Interfaces.Validation.Structures.IObjectOfInteger

        Public Property StartNumber As Integer? Implements IObjectOfInteger.StartNumber
        Public Property EndNumber As Integer? Implements IObjectOfInteger.EndNumber
        Public Property ValidNumberChars As Integer() Implements IObjectOfInteger.ValidNumberChars

        Function Check(Str As Integer, NameObj As String) As Interfaces.Results.IErrResult(Of List(Of Validation.Exceptions.IErrors))

            Dim Validation As New List(Of Validation.Exceptions.IErrors)

            If StartNumber IsNot Nothing AndAlso StartNumber > Str Then Validation.Add(New Exceptions.ErrFields("Δεν επιτέπεται ο αριθμός να είναι Μικρότερος: " & StartNumber, NameObj, Str))
            If EndNumber IsNot Nothing AndAlso EndNumber < Str Then Validation.Add(New Exceptions.ErrFields("Δεν Επιτρέπεται ο αριθμός να είναι μεγαλήτερος : " & EndNumber, NameObj, Str))
            If ValidNumberChars.Count > 0 Then
                For i = 0 To Str.ToString.Length - 1
                    If ValidNumberChars.Contains(Str) Then Validation.Add(New Exceptions.ErrFields("Δεν επιτρέπονται οι χαρακτήρες: (" & Validation.ToString & ") ", NameObj, Str))
                Next
            End If


            If Validation.Count = 0 Then
                Return New Results.Result(Of List(Of Validation.Exceptions.IErrors))(True, "Επίτηχές πεδίο!", Validation)
            Else
                Return New Results.Result(Of List(Of Validation.Exceptions.IErrors))(False, "Αποτηχία πεδίο!", Validation)
            End If


        End Function

    End Class

    Public Class ValidDouble
        Implements Interfaces.Validation.Structures.IObjectOfDouble

        Public Property FormatDouble As String Implements IObjectOfDouble.FormatDouble
        Public Property StartNumber As Double? Implements IObjectOfDouble.StartNumber
        Public Property EndNumber As Double? Implements IObjectOfDouble.EndNumber
        Public Property ValidNumber As Double() Implements IObjectOfDouble.ValidNumber

        Function Check(Str As Double, NameObj As String) As Interfaces.Results.IErrResult(Of List(Of Validation.Exceptions.IErrors))

            Dim Validation As New List(Of Validation.Exceptions.IErrors)

            If StartNumber IsNot Nothing AndAlso StartNumber > Str Then Validation.Add(New Exceptions.ErrFields("Δεν επιτέπεται ο αριθμός να είναι Μικρότερος: " & StartNumber, NameObj, Str))
            If EndNumber IsNot Nothing AndAlso EndNumber < Str Then Validation.Add(New Exceptions.ErrFields("Δεν Επιτρέπεται ο αριθμός να είναι μεγαλήτερος : " & EndNumber, NameObj, Str))
            If ValidNumber.Count > 0 Then
                For i = 0 To Str.ToString.Length - 1
                    If ValidNumber.Contains(Str) Then Validation.Add(New Exceptions.ErrFields("Δεν επιτρέπονται οι χαρακτήρες: (" & Validation.ToString & ") ", NameObj, Str))
                Next
            End If


            If Validation.Count = 0 Then
                Return New Results.Result(Of List(Of Validation.Exceptions.IErrors))(True, "Επίτηχές πεδίο!", Validation)
            Else
                Return New Results.Result(Of List(Of Validation.Exceptions.IErrors))(False, "Αποτηχία πεδίο!", Validation)
            End If

        End Function


    End Class

    Public Class ValidDate
        Implements Interfaces.Validation.Structures.IObjectOfDate

        Public Property FormatDate As String Implements IObjectOfDate.FormatDate
        Public Property StarDate As Date? Implements IObjectOfDate.StarDate
        Public Property EndDate As Date? Implements IObjectOfDate.EndDate
        Public Property ExceptionsDate As Date() Implements IObjectOfDate.ExceptionsDate

        Function Check(Str As Date, NameObj As String) As Interfaces.Results.IErrResult(Of List(Of Validation.Exceptions.IErrors))
            Dim Validation As New List(Of Validation.Exceptions.IErrors)

            If StarDate IsNot Nothing AndAlso StarDate > Str Then Validation.Add(New Exceptions.ErrFields("Δεν επιτέπεται ο αριθμός να είναι Μικρότερος: " & StarDate, NameObj, Str))
            If EndDate IsNot Nothing AndAlso EndDate < Str Then Validation.Add(New Exceptions.ErrFields("Δεν Επιτρέπεται ο αριθμός να είναι μεγαλήτερος : " & EndDate, NameObj, Str))
            If ExceptionsDate.Count > 0 Then
                For i = 0 To Str.ToString.Length - 1
                    If ExceptionsDate.Contains(Str) Then Validation.Add(New Exceptions.ErrFields("Δεν επιτρέπονται οι χαρακτήρες: (" & Validation.ToString & ") ", NameObj, Str))
                Next
            End If


            If Validation.Count = 0 Then
                Return New Results.Result(Of List(Of Validation.Exceptions.IErrors))(True, "Επίτηχές πεδίο!", Validation)
            Else
                Return New Results.Result(Of List(Of Validation.Exceptions.IErrors))(False, "Αποτηχία πεδίο!", Validation)
            End If
        End Function

    End Class
    Public Class ValidBoolean
        Implements Interfaces.Validation.Structures.IObjectOfBoolean

        Public Property TypeFormatBool As String Implements IObjectOfBoolean.TypeFormatBool
        Public Property FormatBoolTrue As String Implements IObjectOfBoolean.FormatBoolTrue
        Public Property FormatBoolFalse As String Implements IObjectOfBoolean.FormatBoolFalse

        Function Check(BoolStr As String, nameObj As String) As Interfaces.Results.IErrResult(Of List(Of Validation.Exceptions.IErrors))
            Dim Validation As New List(Of Validation.Exceptions.IErrors)
            If Not FormatBoolTrue = BoolStr Or Not FormatBoolFalse = BoolStr Then Validation.Add(New Validation.Exceptions.ErrFields("Δεν βρέθηκα οι ορησμοί: (True) = " & FormatBoolTrue & ", (False) = " & FormatBoolFalse & " .", nameObj, BoolStr))
            If Validation.Count = 0 Then
                Return New Results.ErrResult(Of List(Of Validation.Exceptions.IErrors))(True, "Επιτυχής Πεδιο", Validation)
            Else
                Return New Results.ErrResult(Of List(Of Validation.Exceptions.IErrors))(False, "Αποτυχία στην δήλωση πεδιου!", Validation)
            End If
        End Function
    End Class

End Namespace
