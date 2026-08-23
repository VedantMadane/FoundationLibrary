Imports FoundationLibrary.Keys

Namespace Types
    Public Class TypeDouble
        Implements Types.Interfaces.ITypeDouble

        Public Property OptionsValid As Validation.Types.ITypeDouble Implements Interfaces.ITypeDouble.OptionsValid
        Public Property Name As String Implements IHasName.Name
        Public Property Value As Double Implements IHasValue(Of Double).Value


        Shared Narrowing Operator CType(ByVal Tdouble As TypeDouble) As Double
            Return Tdouble.Value
        End Operator
        Sub New()
            OptionsValid = New Validation.Types.ValidDouble
        End Sub
        Sub New(Validation As Validation.Types.IValidBoolean)
            OptionsValid = Validation

        End Sub
        Sub New(Name As String, Validation As Validation.Types.ITypeDouble)
            OptionsValid = Validation
        End Sub
        Sub New(name As String)
            Me.Name = name
        End Sub


    End Class
End Namespace

