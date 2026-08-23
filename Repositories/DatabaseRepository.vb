Imports FoundationLibrary.Keys
Imports FoundationLibrary.Repository
Imports FoundationLibrary.Results
Imports database
Namespace Repositories
    ''' <summary>
    ''' <inheritdoc cref="IRepository(Of Tkey, TEntity)"/><br/><br/>
    ''' Το αποθετηριο συνδεεται με την DatabaseAccess της Microsoft
    ''' ολες οι αλλαγες που γίνονται κατευθειαν περνανε στο access,και οι αναγνωση απο την database!<br/>
    ''' θα πρεπει να το περάσεις μεσο inherits Μεσο μια αλλης class και να initallize το new μεσα se Mybase.new
    ''' </summary>
    ''' <typeparam name="Tkey"></typeparam>
    ''' <typeparam name="TEntity"></typeparam>
    Public MustInherit Class DatabaseRepository(Of Tkey, TEntity As IHasPrimaryKey(Of Tkey))

        Implements IRepository(Of Tkey, TEntity)

        ReadOnly Table As String
        ReadOnly Columns As String
        Public Database As database.DatabaseContecter
        ''' <summary>
        ''' οι Ρυθμησεις για να συνδεθει με την Database.
        ''' </summary>
        ''' <param name="Version">Version Accesdatabase της microsoft</param>
        ''' <param name="ConnectDatabase">Την διαδρομη της database</param>
        ''' <param name="tablelink">Το ονομα της Table</param>
        ''' <param name="ColumnsString">Τα columns που θα χρησημοποιησεις.</param>
        Sub New(Version As String, ConnectDatabase As String, tablelink As String, ColumnsString As String)
            Database = New database.DatabaseContecter(Version, ConnectDatabase)
            Table = tablelink
            Columns = ColumnsString
        End Sub

        MustOverride Function ConvertRows(Entity As TEntity) As String()
        MustOverride Function ConvertEntity(DT As DataRow) As TEntity
        MustOverride Function Match(Of TCreteria)(Entity As TEntity, Creteria As TCreteria) As Boolean

        Public Sub RemoveAll() Implements IRepository(Of Tkey, TEntity).RemoveAll
            Database.TableDbOLe(Database.DeleteDB(Table))
        End Sub

        Public Function GeneredID() As Tkey Implements IRepository(Of Tkey, TEntity).GeneredID
            Dim rnd As New Random
            Dim PK As Tkey = CType(0, Object)
            Dim DT As New DataTable


Again:
            Randomize()
            PK = CType(rnd.Next, Object)
            Database.TableDbOLe(Database.SelectWhereDB(Table, "[ID]=" & CType(PK, Object)), DT)

            If DT.Rows.Count > 0 Then
                DT.Clear()
                GoTo Again
            End If


            Return PK
        End Function

        Public Function Create(Entity As TEntity) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Create
            Dim rnd As New Random
            Dim DT As New DataTable
Again:
            Randomize()
            Entity.PrimaryKey = CType(rnd.Next, Object)
            Database.TableDbOLe(Database.SelectWhereDB(Table, "[ID]=" & CType(Entity.PrimaryKey, Object)), DT)

            If DT.Rows.Count > 0 Then
                DT.Clear()
                GoTo Again
            End If
            Database.TableDbOLe(Database.insertDB(Table, Columns, ConvertRows(Entity)))
            Return New Results.Result(Of TEntity)(True, "Επυτηχης προσθήκη στην Database", Entity)
        End Function

        Public Function Add(Entity As TEntity) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Add
            Database.TableDbOLe(Database.insertDB(Table, Columns, ConvertRows(Entity)))
            Return New Results.Result(Of TEntity)(True, "Επυτηχης προσθήκη στην Database", Entity)
        End Function

        Public Function TryCreate(Entity As TEntity, PK As Tkey) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).TryCreate
            Database.TableDbOLe(Database.insertDB(Table, Columns, ConvertRows(Entity)))
            Return New Results.Result(Of TEntity)(True, "Επυτηχης προσθήκη στην Database", Entity)
        End Function

        Public Function Update(PK As Tkey, Entity As TEntity) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Update
            Entity.PrimaryKey = PK
            Dim Str As String() = ConvertRows(Entity)
            Dim Str1(Str.Length - 2) As String
            For i = 1 To Str.Length - 1
                Str1(i - 1) = Str(i)
            Next
            Dim ColumnCopy As String = Columns.Replace("[ID],", Nothing)
            Database.TableDbOLe(Database.updateDB(Table, "[ID]=" & CType(PK, Object), ColumnCopy, Str1))
            Return New Results.Result(Of TEntity)(True, "Επυτηχης Αλλαγή στην Database", Entity)
        End Function

        Public Function UpdateAt(index As Integer, Entity As TEntity) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).UpdateAt
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            Dim ID As Integer = DT(index)(0)
            Dim Str As String() = ConvertRows(Entity)
            Dim Str1(Str.Length - 2) As String
            For i = 1 To Str.Length - 1
                Str1(i - 1) = Str(i)
            Next
            Dim ColumnCopy As String = Columns.Replace("[ID],", Nothing)
            Database.TableDbOLe(Database.updateDB(Table, "[ID]=" & ID, ColumnCopy, Str1))
            Return New Results.Result(Of TEntity)(True, "Επυτηχης Αλλαγή στην Database", Entity)
        End Function

        Public Function UpdateWhere(Match As Predicate(Of TEntity), Update As Func(Of TEntity, TEntity)) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).UpdateWhere
            Throw New NotImplementedException()
        End Function

        Public Function Delete(Entity As TEntity) As IResult Implements IRepository(Of Tkey, TEntity).Delete
            Throw New NotImplementedException()
        End Function

        Public Function Delete(PK As Tkey) As IResult Implements IRepository(Of Tkey, TEntity).Delete
            Database.TableDbOLe(Database.DeleteDB(Table, "[ID]=" & CType(PK, Object)))
            Return New Results.Result(True, "Επυτηχης Διαγραφή στην Database")
        End Function

        Public Function DeleteAt(Index As Integer) As IResult Implements IRepository(Of Tkey, TEntity).DeleteAt
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            Dim ID As Integer = DT(Index)(0)
            Database.TableDbOLe(Database.DeleteDB(Table, "[ID]=" & ID))
            Return New Results.Result(True, "Επυτηχης Διαγραφή στην Database")
        End Function

        Public Function DeleteWhere(Match As Predicate(Of TEntity)) As IResult Implements IRepository(Of Tkey, TEntity).DeleteWhere
            Throw New NotImplementedException()
        End Function

        Public Function Read_All() As IResult(Of List(Of TEntity)) Implements IRepository(Of Tkey, TEntity).Read_All
            Dim DT As New DataTable
            Dim ListEntity As New List(Of TEntity)
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            For i = 0 To DT.Rows.Count - 1
                ListEntity.Add(ConvertEntity(DT(i)))
            Next
            Return ListEntity
        End Function

        Public Function ReadKey(PK As Tkey) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).ReadKey
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectWhereDB(Table, "[ID]=" & CType(PK, Object)), DT)
            If DT.Rows.Count = 0 Then
                Return Nothing
            End If
            Return ConvertEntity(DT(0))
        End Function

        Public Function ReadAt(Index As Integer) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).ReadAt
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            Return ConvertEntity(DT(Index))
        End Function


        Public Function Read(Of TCreteria)(Creteria As TCreteria) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Read
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            For i = 0 To DT.Rows.Count - 1
                If Match(ConvertEntity(DT(i)), Creteria) Then Return ConvertEntity(DT(i))
            Next
        End Function

        Public Function Read(Match As Predicate(Of TEntity)) As IResult(Of TEntity) Implements IRepository(Of Tkey, TEntity).Read
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            For i = 0 To DT.Rows.Count - 1
                If Match(ConvertEntity(DT(i))) Then Return ConvertEntity(DT(i))
            Next
        End Function

        Public Function Search(Of TCreteria)(Creteria As TCreteria) As IResult(Of List(Of TEntity)) Implements IRepository(Of Tkey, TEntity).Search
            Dim Entity As New List(Of TEntity)
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            For i = 0 To DT.Rows.Count - 1
                If Match(ConvertEntity(DT(i)), Creteria) Then
                    Entity.Add(ConvertEntity(DT(i)))
                End If
            Next
            Return Entity
        End Function

        Public Function Search(Matches As Predicate(Of TEntity)) As IResult(Of List(Of TEntity)) Implements IRepository(Of Tkey, TEntity).Search
            Dim Entity As New List(Of TEntity)
            Dim DT As New DataTable
            Database.TableDbOLe(Database.SelectDB(Table), DT)
            For i = 0 To DT.Rows.Count - 1
                If Matches(ConvertEntity(DT(i))) Then
                    Entity.Add(ConvertEntity(DT(i)))
                End If
            Next
            Return Entity
        End Function


    End Class
End Namespace

