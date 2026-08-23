Namespace Types.Interfaces
    Public Interface ITypeString
        Inherits Keys.IHasName
        Inherits Keys.IHasValue(Of String)
        Inherits Keys.IHasIndexOf(Of Char)

        Property OptionsValid As Validation.Types.IValidString
    End Interface

    Public Interface ITypeInteger
        Inherits Keys.IHasName
        Inherits Keys.IHasValue(Of Integer)

        Property OptionsValid As Validation.Types.IValidInteger
    End Interface

    Public Interface ITypeDate
        Inherits Keys.IHasName
        Inherits Keys.IHasValue(Of Date)
        Property OptionsValid As Validation.Types.IValidDate
    End Interface

    Public Interface ITypeBoolean
        Inherits Keys.IHasName
        Inherits Keys.IHasValue(Of Boolean)

        Property OptionsValid As Validation.Types.IValidBoolean
    End Interface

    Public Interface ITypeDouble
        Inherits Keys.IHasName
        Inherits Keys.IHasValue(Of Double)

        Property OptionsValid As Validation.Types.ITypeDouble
    End Interface
End Namespace

