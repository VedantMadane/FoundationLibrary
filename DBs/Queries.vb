Namespace Database
    Public Module Queries
        Function QInstert(bash As String, colthmes As String, thmes() As String) As String
            Dim times As String = Nothing
            For i = 0 To thmes.Count - 1
                times += thmes(i)

                If Not i = thmes.Count - 1 Then
                    times += "','"
                End If
            Next
            Return "INSERT INTO " & bash & " (" & colthmes & ") VALUES ('" & times & "');"


        End Function
        Function QSelect(bash As String) As String
            Return "SELECT * FROM " & bash & ";"
        End Function
        Function SelectWhereDB(bash As String, thesh As String) As String
            SelectWhereDB = "SELECT * FROM " & bash & " WHERE " & thesh
        End Function
        Function UpdateDB(bash As String, thesh As String, colnames As String, thmes() As String) As String
            Dim times As String = Nothing
            Dim col() As String = Split(colnames, ",")
            For i = 0 To col.Count - 1
                times += col(i)
                times += " ='"
                times += thmes(i)
                times += "'"
                If Not i = col.Count - 1 Then
                    times += ","
                End If
            Next

            Return "UPDATE " & bash & " SET " & times & " WHERE " & thesh & ";"
        End Function
        Function QDelete(bash As String, thesh As String) As String
            Return "DELETE FROM " & bash & " WHERE " & thesh
        End Function
        Function QDelete(bash As String) As String
            Return "DELETE FROM " & bash & ";"
        End Function
    End Module
End Namespace
