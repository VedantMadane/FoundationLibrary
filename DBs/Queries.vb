Namespace Database
    Public Module Queries
        Function insertDB(bash As String, colthmes As String, thmes() As String) As String
            Dim times As String = Nothing
            For i = 0 To thmes.Count - 1
                times += thmes(i)

                If Not i = thmes.Count - 1 Then
                    times += "','"
                End If
            Next
            insertDB = "INSERT INTO " & bash & " (" & colthmes & ") VALUES ('" & times & "');"
            times = Nothing

        End Function
        Function SelectDB(bash As String) As String
            SelectDB = "SELECT * FROM " & bash & ";"
        End Function
        Function SelectWhereDB(bash As String, thesh As String) As String
            SelectWhereDB = "SELECT * FROM " & bash & " WHERE " & thesh
        End Function
        Function updateDB(bash As String, thesh As String, colnames As String, thmes() As String) As String
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
        Function DeleteDB(bash As String, thesh As String) As String
            DeleteDB = "DELETE FROM " & bash & " WHERE " & thesh
        End Function
        Function DeleteDB(bash As String) As String
            DeleteDB = "DELETE FROM " & bash & ";"
        End Function
    End Module
End Namespace
