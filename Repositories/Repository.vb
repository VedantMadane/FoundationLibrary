Imports FoundationLibrary.Keys
Imports FoundationLibrary.Repository

Namespace Repositories
    ''' <summary>
    ''' <inheritdoc cref=" IRepository(Of Tkey, TEntity)"/><br/><br/>
    ''' Το Repository εκχωρίτε μεσα στην μνημη,
    ''' χρησημοποιειτε κυριος για testing.  <br/>
    ''' θα Πρέπει να περαστει απο μεσο inherits στην class που θέλεις να κανεις αποθητεριο.
    ''' </summary>
    ''' <typeparam name="Tkey">Τύπος κλίδιου</typeparam>
    ''' <typeparam name="TEntity">Βάση δεδομένων</typeparam>
    Public MustInherit Class Repository(Of Tkey, TEntity As IHasPrimaryKey(Of Tkey))
        Implements IRepository(Of Tkey, TEntity)


        Protected Friend Property Rep As New List(Of TEntity)

        Public Overridable Sub RemoveAll() Implements IRepository(Of Tkey, TEntity).RemoveAll
            Rep.Clear()
        End Sub


        Public Overridable Function Create(Entity As TEntity) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Create
            Dim rnd As New Random
Again:
            Randomize()
            Entity.PrimaryKey = CType(rnd.Next, Object)
            For i = 0 To Rep.Count - 1
                If Equals(Rep(i).PrimaryKey, Entity.PrimaryKey) Then
                    GoTo Again
                    Return New Results.Result(Of TEntity)(False, "Δεν μπόρεσε να διμιουργηθει η Data")
                End If
            Next
            Rep.Add(Entity)
            Return New Results.Result(Of TEntity)(True, "Διμιουργήθηκε με επιτυχεία", Entity)
        End Function

        Public Overridable Function Update(PK As Tkey, Entity As TEntity) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Update
            For i = 0 To Rep.Count - 1
                If Equals(Rep(i).PrimaryKey, PK) Then
                    Rep(i) = Entity
                    Return New Results.Result(Of TEntity)(True, "Η αλλαγή ήταν επιτυχής!", Rep(i))
                End If
            Next
            Return New Results.Result(Of TEntity)(False, "Δεν ήταν επιτυχής η αλλαγή!")
        End Function

        Public Overridable Function Delete(Entity As TEntity) As Results.IResult Implements IRepository(Of Tkey, TEntity).Delete

            For i = 0 To Rep.Count - 1
                If Rep(i).Equals(Entity) Then
                    Rep.RemoveAt(i)
                    Return New Results.Result(True, "Διαγράφηκε με επιτηχία!")
                End If
            Next
            Return New Results.Result(False, "Δεν μπόρεσε να διαγραφή!")
        End Function

        Public Overridable Function Read_All() As Results.IResult(Of List(Of TEntity)) Implements IRepository(Of Tkey, TEntity).Read_All
            Dim Result As New List(Of TEntity)
            For i = 0 To Rep.Count - 1
                Result.Add(Rep(i))
            Next

            If Result.Count > 0 Then Return New Results.Result(Of List(Of TEntity))(True, "Βρέθηκαν εγραφές!", Result)
            Return New Results.Result(Of List(Of TEntity))(False, "Δεν υπάρχει εγραφή!")
        End Function

        Public Overridable Function ReadKey(PK As Tkey) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).ReadKey
            For i = 0 To Rep.Count - 1
                If Equals(Rep(i).PrimaryKey, PK) Then
                    Return New Results.Result(Of TEntity)(True, "Βρέθηκε εγραφή!", Rep(i))
                End If
            Next
            Return New Results.Result(Of TEntity)(False, "Δεν Βρέθηκε εγραφή!")
        End Function

        Public Overridable Function ReadAT(Index As Integer) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).ReadAt


            If Rep(Index) IsNot Nothing Then
                Return New Results.Result(Of TEntity)(True, "Βρέθηκε η εγραφή!", Rep(Index))
            End If
            Return New Results.Result(Of TEntity)(True, "Δεν βρέθηκε η εγραφή!")
        End Function

        Public Function Read(Of TCreteria)(Creteria As TCreteria) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Read
            For i = 0 To Rep.Count - 1
                If Match(Rep(i), Creteria) Then
                    Return New Results.Result(Of TEntity)(True, "Βρέθηκε η εγραφή!", Rep(i))
                End If
            Next
            Return New Results.Result(Of TEntity)(True, "Δεν βρέθηκε η εγραφή!")
        End Function

        Public Function Read(Match As Predicate(Of TEntity)) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Read
            For i = 0 To Rep.Count - 1
                If Match(Rep(i)) Then
                    Return New Results.Result(Of TEntity)(True, "Βρέθηκε η εγραφή!", Rep(i))
                End If
            Next
            Return New Results.Result(Of TEntity)(False, "Δεν βρέθηκε η εγραφή!")
        End Function

        Public Overridable Function UpdateAT(index As Integer, Entity As TEntity) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).UpdateAt
            If Rep(index) IsNot Nothing Then
                Return New Results.Result(Of TEntity)(True, "Επιτυχής εγραφή!", Rep(index))
            Else

                Return New Results.Result(Of TEntity)(False, "Δεν ήταν επιτυχης ή εγραφή !")
            End If
        End Function

        Public Overridable Function Delete(PK As Tkey) As Results.IResult Implements IRepository(Of Tkey, TEntity).Delete
            For i = 0 To Rep.Count - 1
                If Equals(Rep(i).PrimaryKey, PK) Then
                    Rep.RemoveAt(i)
                    Return New Results.Result(True, "Επιτηχής εγραφή!")
                End If
            Next
            Return New Results.Result(False, "Δεν μπόρεσε να βρεθεί η εγραφή!")
        End Function

        Public Overridable Function DeleteAt(Index As Integer) As Results.IResult Implements IRepository(Of Tkey, TEntity).DeleteAt
            If Rep(Index) IsNot Nothing Then
                Rep.RemoveAt(Index)
                Return New Results.Result(True, "Η διαγραφή ηταν επιτυχής!")
            End If
            Return New Results.Result(False, "Δε μπόρεσε να βραθεί η εγραφή!")
        End Function

        Public Function GeneredID() As Tkey Implements IRepository(Of Tkey, TEntity).GeneredID
            Dim rnd As New Random
            Dim PK As Tkey = CType(0, Object)
Again:
            Randomize()
            PK = CType(rnd.Next, Object)

            For i = 0 To Rep.Count - 1
                If Equals(Rep(i).PrimaryKey, PK) Then
                    GoTo Again
                End If
            Next

            Return PK
        End Function

        Public Function TryCreate(Entity As TEntity, PK As Tkey) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).TryCreate
            For i = 0 To Rep.Count - 1
                If Equals(Rep(i).PrimaryKey, PK) Then
                    Return New Results.Result(Of TEntity)(False, "Δεν μπόρει να διμιουργηθει με το ιδιο κλειδί")
                End If
            Next
            Entity.PrimaryKey = PK
            Rep.Add(Entity)
            Return New Results.Result(Of TEntity)(True, "Διμιουργήθηκε με επιτυχία!", Entity)
        End Function

        Public Function UpdateWhere(Match As Predicate(Of TEntity), Update As Func(Of TEntity, TEntity)) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).UpdateWhere
            For i = 0 To Rep.Count - 1
                If Match(Rep(i)) Then
                    Rep(i) = Update(Rep(i))
                    Return New Results.Result(Of TEntity)(True, "Επιτυχής αλλαγή!", Rep(i))
                End If
            Next
            Return New Results.Result(Of TEntity)(False, "Δεν μπόρεσε να γίνει η αλλαγή!")
        End Function

        Public Function Search(Of TCreteria)(Creteria As TCreteria) As Results.IResult(Of List(Of TEntity)) Implements IRepository(Of Tkey, TEntity).Search
            Dim Result As New List(Of TEntity)
            For i = 0 To Rep.Count - 1
                If Match(Rep(i), Creteria) Then Result.Add(Rep(i))
            Next
            If Result.Count > 0 Then Return New Results.Result(Of List(Of TEntity))(True, "Βρέθηκαν εγραφές!", Result)
            Return New Results.Result(Of List(Of TEntity))(False, "Δεν βρέθηκαν εγραφές!")
        End Function

        Public Function Search(Match As Predicate(Of TEntity)) As Results.IResult(Of List(Of TEntity)) Implements IRepository(Of Tkey, TEntity).Search
            Dim Result As New List(Of TEntity)
            For i = 0 To Rep.Count - 1
                If Match(Rep(i)) Then
                    Result.Add(Rep(i))
                End If
            Next
            If Result.Count > 0 Then Return New Results.Result(Of List(Of TEntity))(True, "Βρέθηκαν εγραφές!", Result)
            Return New Results.Result(Of List(Of TEntity))(False, "Δεν βρέθηκαν εγραφές!")
        End Function

        MustOverride Function Match(Of TCreteria)(Entity As TEntity, Creteria As TCreteria) As Boolean



        Public Function DeleteWhere(Match As Predicate(Of TEntity)) As Results.IResult Implements IRepository(Of Tkey, TEntity).DeleteWhere
            For i = 0 To Rep.Count - 1
                If Match(Rep(i)) Then
                    Rep.RemoveAt(i)
                    Return New Results.Result(True, "Επιτυχής Διαγραφή!")
                End If
            Next
            Return New Results.Result(False, "Δεν μπόρεσε να γίνει διαγραφή!")
        End Function

        Public Function Add(Entity As TEntity) As Results.IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Add
            Rep.Add(Entity)
            Return New Results.Result(Of TEntity)(True, "Προσθέθηκε με επιτυχία", Entity)
        End Function
    End Class

End Namespace

