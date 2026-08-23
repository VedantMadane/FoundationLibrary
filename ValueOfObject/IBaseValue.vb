Namespace ValueOfObject.Bases
    Public Interface IColumnsDB(Of T)
        Inherits Keys.IHasValue(Of T)
        Property Column As String
        Property IndexOfColumn As Integer
        Property Type As String
        Property Format As String
    End Interface
End Namespace
