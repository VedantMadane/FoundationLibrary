Imports FoundationLibrary.Keys
Imports FoundationLibrary.Results
Namespace Services
    ''' <summary>
    ''' Τα βασικά κλειδια που θα χρειαστεις για να διμιουργήσεις Service
    ''' </summary>
    ''' <typeparam name="TRef">Η αναγνώρηση του κλιδειου(PK)</typeparam>
    ''' <typeparam name="TReturn">Τι να επιστρέψει μεσο του <seealso cref="Results.IResult(Of TReturn)"/></typeparam>
    Public Interface IService(Of TRef, TReturn)
        Delegate Function DelUseCase(Of DTO)(DTOLink As DTO) As Results.IResult

        ''' <summary>
        ''' Κάνει έλενχο αν υπάρχει στο αποθετήριο η σηγκεκριμένη εγραφή και αν το επιτρέπεται να επιστραφή η εγραφή.
        ''' </summary>
        ''' <param name="Ref">Data</param>
        ''' <returns>Επιστρέφει <seealso cref="Results.IResult(Of TReturn)"/></returns>
        Function Exist(Ref As TRef) As Results.IResult(Of TReturn)
        ''' <summary>
        ''' ο Service κάνει έλενχο αν μπορει και αν επιτρέπεται να κανει εγραφή στο Αποθετήριο περνώντας τα δεδομένα απο το DTO.
        ''' </summary>
        ''' <typeparam name="DTO">Data Transfer Object</typeparam>
        ''' <param name="RegisterDTO">Register Data Transfer Object</param>
        ''' <returns>Επιστρέφει <seealso cref="Results.IResult(Of TReturn)"/></returns>
        Function Register(Of DTO)(RegisterDTO As DTO, Optional UseCaseLink As DelUseCase(Of DTO) = Nothing) As Results.IResult(Of TReturn)
        ''' <summary>
        ''' ο Service κάνει έλενχο αμα μπορει και επιτρέπεται να να κανει καποια αλλαγή μεσα στα δεδομένα.
        ''' </summary>
        ''' <typeparam name="DTO"></typeparam>
        ''' <param name="Ref"></param>
        ''' <param name="ChangeDTO"></param>
        ''' <returns>Επιστρέφει <seealso cref="Results.IResult(Of TReturn)"/></returns>
        Function Change(Of DTO)(Ref As TRef, ChangeDTO As DTO, Optional UseCaseLink As DelUseCase(Of DTO) = Nothing) As Results.IResult(Of TReturn)
        ''' <summary>
        ''' o Service Κανει ελενχο αν μπορει να διαγραφή η συγκεκριμένη εγραφή.
        ''' </summary>
        ''' <param name="Ref">DATA</param>
        ''' <returns>Επιστρέφει <seealso cref="Results.IResult"/></returns>
        Function Remove(Ref As TRef) As Results.IResult
        ''' <summary>
        ''' o Service Ελέχνει αμα μπορει να δωσει όλες της εγραφες στον χρήστη.
        ''' </summary>
        ''' <returns>Επιστρέφει <seealso cref="Results.IResult(Of List(Of TReturn))"/></returns>
        Function Get_All() As Results.IResult(Of List(Of TReturn))

    End Interface

End Namespace
