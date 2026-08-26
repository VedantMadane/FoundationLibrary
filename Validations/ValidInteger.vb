Imports FoundationLibrary.Results
Imports FoundationLibrary.Errors

Namespace Validation.Types
    Public Structure ValidInteger
        Implements Types.IValidInteger

        Public Property StartNumber As Integer? Implements IValidInteger.StartNumber
        Public Property EndNumber As Integer? Implements IValidInteger.EndNumber
        Public Property ValidNumberChars As Integer() Implements IValidInteger.ValidNumberChars


        Public Function Check(Value As Integer, Optional NameObj As String = Nothing) As IErrResult(Of List(Of IErrors)) Implements IValidInteger.Check
            Dim Validation As New List(Of IErrors)

            If StartNumber IsNot Nothing AndAlso StartNumber > Value Then Validation.Add(New ErrFields("Δεν επιτέπεται ο αριθμός να είναι Μικρότερος: " & StartNumber, NameObj, Value))
            If EndNumber IsNot Nothing AndAlso EndNumber < Value Then Validation.Add(New ErrFields("Δεν Επιτρέπεται ο αριθμός να είναι μεγαλήτερος : " & EndNumber, NameObj, Value))
            If ValidNumberChars.Count > 0 Then
                For i = 0 To Value.ToString.Length - 1
                    If ValidNumberChars.Contains(Value) Then Validation.Add(New ErrFields("Δεν επιτρέπονται οι χαρακτήρες: (" & Validation.ToString & ") ", NameObj, Value))
                Next
            End If


            If Validation.Count = 0 Then
                Return New Results.ErrResult(Of List(Of IErrors))(True, "Επίτηχές πεδίο!", Validation)
            Else
                Return New Results.ErrResult(Of List(Of IErrors))(False, "Αποτηχία πεδίο!", Validation)
            End If
        End Function
    End Structure
End Namespace

