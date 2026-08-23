Namespace Validation.Structures
    Public Interface IObjectOfString
        Enum EnumsStringCase
            None
            Up
            Down
        End Enum
        Property Cases As EnumsStringCase
        Property MinLength As Integer
        Property MaxLength As Integer
        Property AvailableWhiteSpace As Boolean
        Property AvailableNothin As Boolean
        Property ValidNumber As Boolean
        Property ValidSymbols As Boolean
        Property ValidStrings As String()
        Property ValidChars As Char()
        Property ExceptionChars As Char()
    End Interface

    Public Interface IObjectOfInteger
        Property StartNumber As Integer?
        Property EndNumber As Integer?
        Property ValidNumberChars As Integer()
    End Interface

    Public Interface IObjectOfDate
        Property FormatDate As String
        Property StarDate As Date?
        Property EndDate As Date?
        Property ExceptionsDate As Date()
    End Interface

    Public Interface IObjectOfBoolean
        Property TypeFormatBool As String
        Property FormatBoolTrue As String
        Property FormatBoolFalse As String

    End Interface

    Public Interface IObjectOfDouble
        Property FormatDouble As String
        Property StartNumber As Double?
        Property EndNumber As Double?
        Property ValidNumber As Double()
    End Interface
End Namespace

