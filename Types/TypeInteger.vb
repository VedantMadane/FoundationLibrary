Imports FoundationLibrary.Keys
Imports FoundationLibrary.Types.Interfaces
Imports FoundationLibrary.Validation.Types

Namespace Types
    Public Class TypeInteger
        Implements Types.Interfaces.ITypeInteger

        Public Property OptionsValid As IValidInteger Implements ITypeInteger.OptionsValid
        Public Property NameObj As String Implements IHasName.Name
        Public Property Value As Integer Implements IHasValue(Of Integer).Value


        Shared Narrowing Operator CType(ByVal TInteger As TypeInteger) As Integer
            Return TInteger.Value
        End Operator

        Sub New()
            OptionsValid = New Validation.Types.ValidInteger
        End Sub
        Sub New(Validations As Validation.Types.IValidInteger)
            OptionsValid = Validations

        End Sub
        Sub New(Name As String, validations As IValidInteger)
            Me.NameObj = Name
            OptionsValid = validations
        End Sub
        Sub New(name As String)
            Me.NameObj = name
            OptionsValid = New Validation.Types.ValidInteger
        End Sub

    End Class
End Namespace

