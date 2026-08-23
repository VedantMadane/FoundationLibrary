Imports FoundationLibrary.Results
Imports FoundationLibrary.Errors

Namespace Validation.Types
    Public Structure ValidDate
        Implements Types.IValidDate

        Public Property FormatDate As String Implements IValidDate.FormatDate
        Public Property StarDate As Date? Implements IValidDate.StarDate
        Public Property EndDate As Date? Implements IValidDate.EndDate
        Public Property ExceptionsDate As Date() Implements IValidDate.ExceptionsDate

        Public Function Check(Value As Date, Optional NameObj As String = Nothing) As IErrResult(Of List(Of IErrors)) Implements IValidDate.Check
            Dim Validation As New List(Of IErrors)

            If StarDate IsNot Nothing AndAlso StarDate > Value Then Validation.Add(New ErrFields("Δεν επιτέπεται ο αριθμός να είναι Μικρότερος: " & StarDate, NameObj, Value))
            If EndDate IsNot Nothing AndAlso EndDate < Value Then Validation.Add(New ErrFields("Δεν Επιτρέπεται ο αριθμός να είναι μεγαλήτερος : " & EndDate, NameObj, Value))
            If ExceptionsDate.Count > 0 Then
                For i = 0 To Value.ToString.Length - 1
                    If ExceptionsDate.Contains(Value) Then Validation.Add(New ErrFields("Δεν επιτρέπονται οι χαρακτήρες: (" & Validation.ToString & ") ", NameObj, Value))
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

