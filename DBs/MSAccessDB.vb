Imports FoundationLibrary.Database.Tools
Namespace Database
    Public Class MSAccessOLEDB
        Implements ICommands
        Private ReadOnly con As OleDb.OleDbConnection
        Private cmd As New OleDb.OleDbCommand
        Private da As New OleDb.OleDbDataAdapter

        Sub New(Provider As Providers.TypeProviders, DataSourse As String)
            con = New OleDb.OleDbConnection("Provider=" & New Providers(Provider) & ";Data Source=" & DataSourse & ";")
        End Sub
        Sub New(Provider As String, DataSource As String)
            con = New OleDb.OleDbConnection("Provider=" & Provider & ";Data Source=" & DataSource & ";")
        End Sub
        Sub New(ConnectionBuild As ConnectionStringBuild)
            con = New OleDb.OleDbConnection(ConnectionBuild)
        End Sub
        Sub New(ConnectionBuild As String)
            con = New OleDb.OleDbConnection(ConnectionBuild)
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
