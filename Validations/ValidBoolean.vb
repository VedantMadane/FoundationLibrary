Imports FoundationLibrary.Results
Imports FoundationLibrary.Errors

Namespace Validation.Types
    Public Structure ValidBoolean
        Implements IValidBoolean

        Public Property TypeFormatBool As String Implements IValidBoolean.TypeFormatBool
        Public Property FormatBoolTrue As String Implements IValidBoolean.FormatBoolTrue
        Public Property FormatBoolFalse As String Implements IValidBoolean.FormatBoolFalse


        Public Function Check(Value As Boolean, Optional NameObj As String = Nothing) As IErrResult(Of List(Of IErrors)) Implements IValidBoolean.Check
            Dim Validation As New List(Of IErrors)
            If Not FormatBoolTrue = Value Or Not FormatBoolFalse = Value Then Validation.Add(New ErrFields("Δεν βρέθηκα οι ορησμοί: (True) = " & FormatBoolTrue & ", (False) = " & FormatBoolFalse & " .", NameObj, Value))
            If Validation.Count = 0 Then
                Return New Results.ErrResult(Of List(Of IErrors))(True, "Επιτυχής Πεδιο", Validation)
            Else
                Return New Results.ErrResult(Of List(Of IErrors))(False, "Αποτυχία στην δήλωση πεδιου!", Validation)
            End If
        End Function
    End Structure
End Namespace

