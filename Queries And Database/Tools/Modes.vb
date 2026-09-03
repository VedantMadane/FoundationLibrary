Namespace Database.Tools
    Public Class Modes
        Enum TypeMode
            Read
            Write
            ReadWrite
            ShareDenyRead
            ShareDenyWrite
            ShareExclusive
            ShareDenyNone
        End Enum
        Private Shared ReadOnly Dictionary As New Dictionary(Of TypeMode, String) From {
            {TypeMode.Read, "Read"},
            {TypeMode.Write, "Write"},
            {TypeMode.ReadWrite, "Read/Write"},
            {TypeMode.ShareExclusive, "Share Exclusive"},
            {TypeMode.ShareDenyRead, "Share Deny Read"},
            {TypeMode.ShareDenyWrite, "Share Deny Write"},
            {TypeMode.ShareDenyNone, "Share Deny None"}
        }

        Default Public ReadOnly Property Mode(TypeMode As TypeMode) As String
            Get
                Return Dictionary(TypeMode)
            End Get
        End Property

        Public Function ListOfMode() As List(Of String)
            Dim list As New List(Of String)
            For Each Dict In Dictionary
                list.Add(Dict.Key & ") " & Dict.Value)
            Next
            Return list
        End Function
    End Class

End Namespace

