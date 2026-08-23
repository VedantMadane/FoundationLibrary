Imports FoundationLibrary.Results
Imports FoundationLibrary.Types.Interfaces
Imports FoundationLibrary.Errors
Imports FoundationLibrary.Validation.Types
Namespace Validation.Types
    Public Structure ValidString
        Implements Validation.Types.IValidString

        Public Property MinLength As Integer? Implements IValidString.MinLength
        Public Property MaxLength As Integer? Implements IValidString.MaxLength
        Public Property AvailableWhiteSpace As Boolean Implements IValidString.AvailableWhiteSpace
        Public Property AvailableNothin As Boolean Implements IValidString.AvailableNothin
        Public Property ValidNumber As Boolean Implements IValidString.ValidNumber
        Public Property ValidSymbols As Boolean Implements IValidString.ValidSymbols
        Public Property ValidStrings As String() Implements IValidString.ValidStrings
        Public Property ValidChars As Char() Implements IValidString.ValidChars
        Public Property ExceptionChars As Char() Implements IValidString.ExceptionChars

        Public Property Cases As IValidString.EnumsStringCase Implements IValidString.Cases


        Public Function Check(Str As String, Optional NameObj As String = Nothing) As IErrResult(Of List(Of IErrors)) Implements IValidString.Check
            Dim Validation As New List(Of IErrors)

            If MinLength IsNot Nothing AndAlso MinLength > Str.Length Then Validation.Add(New ErrFields("Δεν επιτρέπεται το μέγεθος να είναι μικρότερο απο :" & MinLength, NameObj, Str))
            If MaxLength IsNot Nothing AndAlso MaxLength < Str.Length Then Validation.Add(New ErrFields("Δεν Επιτρέπεται το Μέγεθος να ειναι μεγαλύτερο απο: " & MaxLength, NameObj, Str))
            If AvailableNothin = True AndAlso Str.Length = 0 Then Validation.Add(New ErrFields("Δεν Επιτρέπεται το πεδιο να είναι χωρίς τιμή.", NameObj, Str))
            If AvailableWhiteSpace = True AndAlso Str.Contains(" ") Then Validation.Add(New ErrFields("Δεν επιτρέπεται στο πεδιο να υπάρχει κενο.", NameObj, Str))

            If Cases = Types.IValidString.EnumsStringCase.Up AndAlso Str.ToUpper <> Str Then Validation.Add(New ErrFields("Οι Χαρακτήρες δεν ειναι UP", NameObj, Str)) Else
            If Cases = IValidString.EnumsStringCase.Down AndAlso Str.ToLower <> Str Then Validation.Add(New ErrFields("Οι Χαρακτήρες δεν ειναι Lower", NameObj, Str))

            If ValidNumber = True Then
                For i = 0 To Str.Length - 1
                    If Char.IsDigit(Str(i)) AndAlso ExceptionChars.Contains(Str(i)) = False Then Validation.Add(New ErrFields("Δεν μπορει να περιέχει αριθμό.", NameObj, Str))
                Next
            End If
            If ValidSymbols = True Then
                For i = 0 To Str.Length - 1
                    If Char.IsSymbol(Str(i)) AndAlso ExceptionChars.Contains(Str(i)) = False Then Validation.Add(New ErrFields("Δεν μπορει να περιέχει Σύμβολο.", NameObj, Str))
                Next
            End If
            If ValidStrings IsNot Nothing AndAlso ValidStrings.Count > 0 Then
                For i = 0 To ValidStrings.Count - 1
                    If Str.Contains(ValidStrings(i)) Then Validation.Add(New ErrFields("Δεν επιτρέπονται οι συλαβες." & ValidStrings.ToList.ToString, NameObj, Str))
                Next
            End If
            If ValidChars IsNot Nothing AndAlso ValidChars.Count > 0 Then
                For i = 0 To ValidChars.Count - 1
                    If Str.Contains(ValidChars(i)) Then Validation.Add(New ErrFields("Δεν Επιτρέπονται οι Χαρακτήρες." & ValidChars.ToList.ToString, NameObj, Str))
                Next
            End If

            If Validation.Count = 0 Then
                Return New Results.ErrResult(Of List(Of IErrors))(True, "Επιτυχής Πεδιου!", Validation)
            Else

                Return New Results.ErrResult(Of List(Of IErrors))(False, "Αποτυχία Πεδιου!", Validation)
            End If
        End Function
    End Structure
End Namespace

