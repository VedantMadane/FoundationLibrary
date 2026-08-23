
Imports FoundationLibrary.Repositories
Imports FoundationLibrary.Keys
Imports FoundationLibrary.Repository
Imports FoundationLibrary.Results
Imports FoundationLibrary
Imports FoundationLibrary.Validation.Exceptions
Namespace Services
    ''' <summary>
    ''' <Title>
    ''' Ο Service επιστρέφει το Model που ειναι ενα αντιγραφο του Entity
    ''' </Title>
    ''' <para>Είναι ποιο ασφάλες και δεν μπορει να αλλαξει το αρχικο entity χώρις να περασει καποια εντολη απο τον Service! </para> 
    '''<para><em>
    ''' Για να λειτουργείσει ο Service και να επικοινωνηση με το Αποθετήριο θα πρέπει στην βάση Δεδομένων να υπαρχει στο <typeparamref name="TEntity"/> το αντιστοιχο κλειδι <see cref="Interfaces.Keys.IHasPrimaryKey(Of T)"/>
    ''' </em></para>
    ''' 
    ''' <important>
    ''' <b>* Θα χρειαστεί να υλοποιησεις Την <see cref="MemberizeClone">MemberizeClone()</see></b> 
    ''' </important>
    ''' 
    ''' </summary>
    ''' <typeparam name="TKey">Τον Τύπο του PK</typeparam>
    ''' <typeparam name="TModel">Το Model που κανει αντιγραφη απο το Entity</typeparam>
    ''' <typeparam name="TEntity">Το Αρχικο entity</typeparam>
    ''' <typeparam name="TRepository">To Αποθετήριο</typeparam>
    Public MustInherit Class Service(Of TKey, TModel, TEntity As IHasPrimaryKey(Of TKey), TRepository As IRepository(Of TKey, TEntity))
        Implements IService(Of TEntity, TModel)

        Public Property Repository As TRepository

        Sub New(RepositoryLink As TRepository)
            Repository = RepositoryLink
            AvailableExternalModel = False
        End Sub


        ' ================ Types For external models ================== 
        Public ReadOnly AvailableExternalModel As Boolean = False
        Public Delegate Function DelMemberizeClone(Entity As TEntity) As TModel
        Public ReadOnly Property ExternalModelMemberizeClone As DelMemberizeClone
        Sub New(LinkRepository As TRepository, ExternalModelofMemeberizeCloneLink As DelMemberizeClone)
            Repository = LinkRepository
            ExternalModelMemberizeClone = ExternalModelofMemeberizeCloneLink
            AvailableExternalModel = True
        End Sub
        '==============================================================


        ''' <summary>
        ''' Δημιουργει ενα αντιγραφο του Entity και το περναει στο Model
        ''' </summary>
        ''' <param name="Entity">Data</param>
        ''' <returns>Model</returns>
        MustOverride Function MemberizeClone(Entity As TEntity) As TModel
        MustOverride Function ToEntity(Of DTO)(DTOLink As DTO, Optional Entity As TEntity = Nothing) As TEntity
        MustOverride Function ToValidation(Of DTO)(DTOLink As DTO) As IErrResult(Of List(Of Object))

        Overridable Function Exist(Ref As TEntity) As IResult(Of TModel) Implements IService(Of TEntity, TModel).Exist
            Dim Entity As TEntity = Repository.ReadKey(Ref.PrimaryKey).Model
            Dim Model As TModel
            If Entity Is Nothing Then
                Return New Results.Result(Of TModel)(False, "Δεν βρέθηκε η Εγραφή!", Nothing)
            End If
            If AvailableExternalModel = False Then
                Model = MemberizeClone(Entity)
            Else
                Model = ExternalModelMemberizeClone.Invoke(Entity)
            End If
            Return New Results.Result(Of TModel)(True, "Βρέθηκε η Εγραφη!", Model)

        End Function
        Overridable Function Register(Of DTO)(RegisterDTO As DTO, Optional UseCaseLink As IService(Of TEntity, TModel).DelUseCase(Of DTO) = Nothing) As IResult(Of TModel) Implements IService(Of TEntity, TModel).Register
            Dim ValDTO As IErrResult(Of List(Of Object)) = ToValidation(Of DTO)(RegisterDTO)
            If ValDTO.Success = False Then
                Return New Results.Result(Of TModel)(False, "Διμιουργήθηκαν εξερέσεις στα πεδια εγραφής!", Nothing)
            End If
            If UseCaseLink IsNot Nothing Then
                Dim ValUseCase As IResult = UseCaseLink.Invoke(RegisterDTO)
                If ValUseCase.Success = False Then
                    Return New Results.Result(Of TModel)(False, ValUseCase.Msg, Nothing)
                End If
            End If
            Dim Entity As TEntity = ToEntity(RegisterDTO)
            Dim Model As TModel
            If Repository.Create(Entity).Success Then
                If AvailableExternalModel = False Then
                    Model = MemberizeClone(Entity)
                Else
                    Model = ExternalModelMemberizeClone.Invoke(Entity)
                End If
                Return New Results.Result(Of TModel)(True, "Επιτυχης Εγραφή !", Model)
            Else
                Return New Results.Result(Of TModel)(False, "αποτυχία Εγραφής !", Nothing)
            End If
        End Function
        Overridable Function Change(Of DTO)(Ref As TEntity, ChangeDTO As DTO, Optional UseCaseLink As IService(Of TEntity, TModel).DelUseCase(Of DTO) = Nothing) As IResult(Of TModel) Implements IService(Of TEntity, TModel).Change
            Dim ValDTO As Results.IErrResult(Of List(Of Object)) = ToValidation(Of DTO)(ChangeDTO)
            If ValDTO.Success = False Then
                Return New Results.Result(Of TModel)(False, "Διμιουργήθηκαν εξερέσεις στα πεδια!", Nothing)
            End If

            If UseCaseLink IsNot Nothing Then
                Dim ValUseCase As IResult = UseCaseLink.Invoke(ChangeDTO)
                If ValUseCase.Success = False Then
                    Return New Results.Result(Of TModel)(False, ValUseCase.Msg, Nothing)
                End If
            End If

            Dim Entity As TEntity = Repository.ReadKey(Ref.PrimaryKey).Model
            Entity = ToEntity(ChangeDTO, Entity)


            Dim RepResult As Results.Result(Of TEntity) = Repository.Update(Ref.PrimaryKey, Entity)
            If RepResult.Success Then
                Return New Results.Result(Of TModel)(True, "Επιτυχής Αλλαγή!", MemberizeClone(RepResult.Model))
            Else
                Return New Results.Result(Of TModel)(False, "Αποτηχία Αλλαγής!", Nothing)
            End If
        End Function

        Overridable Function Remove(Ref As TEntity) As IResult Implements IService(Of TEntity, TModel).Remove
            If Repository.Delete(Ref.PrimaryKey).Success Then
                Return New Results.Result(True, "Επιτυχής Διαγραφής!")
            Else
                Return New Results.Result(False, "Αποτυχία Διαγραφής!")
            End If
        End Function
        Overridable Function Get_All() As IResult(Of List(Of TModel)) Implements IService(Of TEntity, TModel).Get_All
            Dim Model As New List(Of TModel)
            For Each Entity In Repository.Read_All.Model
                If AvailableExternalModel = False Then
                    Model.Add(MemberizeClone(Entity))
                Else
                    Model.Add(ExternalModelMemberizeClone.Invoke(Entity))
                End If
            Next
            If Model.Count > 0 Then Return New Results.Result(Of List(Of TModel))(True, "Βρέθηκε Εγραφή!", Model)
            Return New Results.Result(Of List(Of TModel))(False, "Δεν Βρέθηκε Εγραφή!", Nothing)
        End Function

    End Class

End Namespace