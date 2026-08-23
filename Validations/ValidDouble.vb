Imports FoundationLibrary.Results
Imports FoundationLibrary.Errors

Namespace Validation.Types
    Public Structure ValidDouble
        Implements Validation.Types.ITypeDouble

        Public Property FormatDouble As String Implements ITypeDouble.FormatDouble
        Public Property StartNumber As Double? Implements ITypeDouble.StartNumber
        Public Property EndNumber As Double? Implements ITypeDouble.EndNumber
        Public Property ValidNumber As Double() Implements ITypeDouble.ValidNumber


        Public Function Check(Value As Double, Optional NameObj As String = Nothing) As IErrResult(Of List(Of IErrors)) Implements ITypeDouble.Check
            Dim Valid As New List(Of IErrors)
            If StartNumber IsNot Nothing AndAlso Value < StartNumber Then Valid.Add(New ErrFields("Δεν επιτρέται ο αριθμος να ειναι κατω απο: " & StartNumber, NameObj, Value))
            If EndNumber IsNot Nothing AndAlso Value > EndNumber Then Valid.Add(New ErrFields("Δεν επιτρέπεται ο αριθμος να ειναι πανω απο: " & EndNumber, NameObj, Value))

            If Valid.Count = 0 Then
                Return New ErrResult(Of List(Of IErrors))(True, "Επιτυχης Έλενχος! ", Valid)
            Else
                Return New ErrResult(Of List(Of IErrors))(False, "Αποτυχία Έλενχου! ", Valid)
            End If
        End Function
    End Structure
End Namespace

