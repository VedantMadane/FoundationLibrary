Namespace Database
    Public Class MSAccessOLEDB
        Implements Database.ICommands
        Enum TypeProviders
            Jet4
            ACE12
            ACE15
            ACE16
        End Enum
        Private ReadOnly con As OleDb.OleDbConnection
        Private cmd As New OleDb.OleDbCommand
        Private da As New OleDb.OleDbDataAdapter

        Public ReadOnly Version As String
        Public ReadOnly Source As String
        Private ReadOnly _username, _Password As String
        Sub New(Provider As TypeProviders, DataSourse As String, Optional Username As String = Nothing, Optional Password As String = Nothing)
            Select Case Provider
                Case TypeProviders.Jet4 : Version = "Microsoft.Jet.OLEDB.4.0"
                Case TypeProviders.ACE12 : Version = "Microsoft.ACE.OLEDB.12.0"
                Case TypeProviders.ACE15 : Version = "Microsoft.ACE.OLEDB.15.0"
                Case TypeProviders.ACE16 : Version = "Microsoft.ACE.OLEDB.16.0"
            End Select
            Source = DataSourse
            _username = Username
            _Password = Password
            con = New OleDb.OleDbConnection("Provider=" & Version & ";Data Source=" & DataSourse & ";")
        End Sub

        Sub Command(Query As String) Implements ICommands.Command
            con.Open()
            cmd.Connection = con
            cmd.CommandText = Query
            cmd.ExecuteNonQuery()
            con.Close()
        End Sub
        Sub Command(Query As String, ByRef dt As DataTable) Implements ICommands.Command
            dt.Rows.Clear()
            dt.Columns.Clear()
            con.Open()
            cmd.Connection = con
            cmd.CommandText = Query
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            con.Close()
        End Sub
        Sub Command(Query As String, ByRef dt As DataSet) Implements ICommands.Command
            con.Open()
            cmd.Connection = con
            cmd.CommandText = Query
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            con.Close()

        End Sub

    End Class
End Namespace
