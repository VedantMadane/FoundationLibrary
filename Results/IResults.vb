Namespace Results

    Public Interface IResult
        ReadOnly Property Success As Boolean
        ReadOnly Property Msg As String
    End Interface

    Public Interface IResult(Of TModel)
        Inherits IResult
        ReadOnly Property Model As TModel
    End Interface

    Public Interface IErrResult(Of TError)
        Inherits IResult
        ReadOnly Property Err As TError
    End Interface

    Public Interface IErrResult(Of TModel, TError)
        Inherits IResult(Of TModel)
        ReadOnly Property Err As TError
    End Interface

End Namespace
