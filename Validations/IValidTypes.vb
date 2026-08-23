Imports FoundationLibrary.Errors
Namespace Validation.Types
    Public Interface IValidString
        Enum EnumsStringCase
            None
            Up
            Down
        End Enum
        Property Cases As EnumsStringCase
        Property MinLength As Integer?
        Property MaxLength As Integer?
        Property AvailableWhiteSpace As Boolean
        Property AvailableNothin As Boolean
        Property ValidNumber As Boolean
        Property ValidSymbols As Boolean
        Property ValidStrings As String()
        Property ValidChars As Char()
        Property ExceptionChars As Char()

        Function Check(Str As String, Optional NameObj As String = Nothing) As Results.IErrResult(Of List(Of IErrors))
    End Interface

    Public Interface IValidInteger
        Property StartNumber As Integer?
        Property EndNumber As Integer?
        Property ValidNumberChars As Integer()

        Function Check(Value As Integer, Optional NameObj As String = Nothing) As Results.IErrResult(Of List(Of IErrors))
    End Interface

    Public Interface IValidDate
        Property FormatDate As String
        Property StarDate As Date?
        Property EndDate As Date?
        Property ExceptionsDate As Date()

        Function Check(Value As Date, Optional NameObj As String = Nothing) As Results.IErrResult(Of List(Of IErrors))
    End Interface


    Public Interface IValidBoolean
        Property TypeFormatBool As String
        Property FormatBoolTrue As String
        Property FormatBoolFalse As String

        Function Check(Value As Boolean, Optional NameObj As String = Nothing) As Results.IErrResult(Of List(Of IErrors))
    End Interface


    Public Interface ITypeDouble
        Property FormatDouble As String
        Property StartNumber As Double?
        Property EndNumber As Double?
        Property ValidNumber As Double()

        Function Check(Value As Double, Optional NameObj As String = Nothing) As Results.IErrResult(Of List(Of IErrors))
    End Interface

End Namespace

