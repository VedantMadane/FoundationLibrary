Imports FoundationLibrary.Results

Namespace Results
    Public Class Result
        Implements Results.IResult

        Public ReadOnly Property Success As Boolean Implements IResult.Success
        Public ReadOnly Property Msg As String Implements IResult.Msg

        Sub New(Succ As Boolean, Message As String)
            Success = Succ
            Msg = Message
        End Sub
    End Class

    Public Class Result(Of TModel)
        Implements Results.IResult(Of TModel)

        Public ReadOnly Property Model As TModel Implements IResult(Of TModel).Model
        Public ReadOnly Property Success As Boolean Implements IResult.Success
        Public ReadOnly Property Msg As String Implements IResult.Msg

        Sub New(Succ As Boolean, Message As String, Optional ModelLink As TModel = Nothing)
            Success = Succ
            Msg = Message
            Model = ModelLink
        End Sub

    End Class

    Public Class ErrResult(Of TError)
        Implements Results.IErrResult(Of TError)

        Public ReadOnly Property Err As TError Implements IErrResult(Of TError).Err
        Public ReadOnly Property Success As Boolean Implements IResult.Success
        Public ReadOnly Property Msg As String Implements IResult.Msg

        Sub New(Succ As Boolean, Message As String, ErrorLink As TError)
            Success = Succ
            Msg = Message
            Err = ErrorLink
        End Sub
    End Class

    Public Class ErrResult(Of TModel, TError)
        Implements Results.IErrResult(Of TModel, TError)

        Public ReadOnly Property Err As TError Implements IErrResult(Of TModel, TError).Err
        Public ReadOnly Property Model As TModel Implements IResult(Of TModel).Model
        Public ReadOnly Property Success As Boolean Implements IResult.Success
        Public ReadOnly Property Msg As String Implements IResult.Msg

        Sub New(Succ As Boolean, Message As String, ErrorLink As TError, Optional ModelLink As TModel = Nothing)
            Success = Succ
            Msg = Message
            Model = ModelLink
            Err = ErrorLink
        End Sub

    End Class
End Namespace

