Imports FoundationLibrary.Keys
Imports FoundationLibrary.Types.Interfaces
Imports FoundationLibrary.Validation.Types

Namespace Types
    Public Class TypeString
        Implements Types.Interfaces.ITypeString


        Public Property OptionsValid As IValidString Implements ITypeString.OptionsValid
        Public Property NameObj As String Implements IHasName.Name
        Public Property Value As String Implements IHasValue(Of String).Value
        Default Public ReadOnly Property IndexOf(Index As Integer) As Char Implements IHasIndexOf(Of Char).IndexOf
            Get
                Return Value(Index)
            End Get
        End Property

        Shared Widening Operator CType(TyString As TypeString) As String
            Return TyString.Value
        End Operator


        Sub New()
            OptionsValid = New ValidString
        End Sub
        Private Sub New(Validations As IValidString)
            OptionsValid = Validations
        End Sub
        Private Sub New(Name As String, Validations As IValidString)
            Me.NameObj = Name
            OptionsValid = Validations
        End Sub
        Private Sub New(Name As String)
            Me.NameObj = Name
            OptionsValid = New ValidString
        End Sub

        Public Overrides Function ToString() As String
            Return Value
        End Function

    End Class

End Namespace
