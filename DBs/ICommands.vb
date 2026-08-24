Namespace Database
    Public Interface ICommands
        Sub Command(Query As String)
        Sub Command(Query As String, ByRef DataSet As DataSet)
        Sub Command(Query As String, ByRef DataTable As DataTable)
    End Interface
End Namespace
