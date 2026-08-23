Imports FoundationLibrary.Keys

Namespace Errors
    Public Interface IErrors
        ReadOnly Property Title As String
        ReadOnly Property NameObj As String
        ReadOnly Property Value As String
        ReadOnly Property Description As String
    End Interface

    Public Class ErrFields
        Implements IErrors

        Public ReadOnly Property Title As String Implements IErrors.Title
        Public ReadOnly Property NameObj As String Implements IErrors.NameObj
        Public ReadOnly Property Value As String Implements IErrors.Value
        Public ReadOnly Property Description As String Implements IErrors.Description
        Sub New(Title As String, Name As String, Value As String, Optional Description As String = Nothing)
            Me.Title = Title
            Me.NameObj = Name
            Me.Value = Value
            Me.Description = Description
        End Sub
        Public Overrides Function ToString() As String
            Return "Title: " & Title & ", Name of Object: " & NameObj & ", Value: " & Value & ", Description: " & Description
        End Function
    End Class



End Namespace
