Namespace Database.Tools
    Public Class ConnectionStringBuild
        Public Provider As String
        Public DataSource As String
        Public PersistSecurityInfo As Boolean? = False
        Public Mode As String
        Public UserId As String
        Public Passwword As String
        Public SystemDatabase As String
        Public SystemPassword As String

        Sub New()
        End Sub
        Sub New(Provider As String, DataSource As String)
            Me.Provider = Provider
            Me.DataSource = DataSource
        End Sub

        Public Function Build() As String

            Dim Opt As New Dictionary(Of String, String)

            If String.IsNullOrWhiteSpace(Provider) Then Opt.Add("Provider", Provider)
            If String.IsNullOrWhiteSpace(DataSource) Then Opt.Add("Data Source", DataSource)
            If PersistSecurityInfo.HasValue Then Opt.Add("Persist Security Info", PersistSecurityInfo.Value)
            If String.IsNullOrWhiteSpace(Mode) Then Opt.Add("Mode", Mode)
            If String.IsNullOrWhiteSpace(UserId) Then Opt.Add("User ID", UserId)
            If String.IsNullOrWhiteSpace(Passwword) Then Opt.Add("Password", Passwword)

            If String.IsNullOrWhiteSpace(SystemDatabase) Then Opt.Add("Jet OLEDB:Database System", SystemDatabase)
            If String.IsNullOrWhiteSpace(SystemPassword) Then Opt.Add("Jet OLEDB:Database Password", SystemPassword)

            Dim StrBuld As String = Nothing

            For Each dict In Opt
                StrBuld += dict.Key & "=" & dict.Value & ";"
            Next
            Return StrBuld
        End Function

        Shared Narrowing Operator CType(ConnectionString As ConnectionStringBuild) As String
            Return ConnectionString.Build
        End Operator

        Shared Widening Operator CType(ConnectionString As String) As ConnectionStringBuild
            Dim Connection As New ConnectionStringBuild
            Dim Str As String = Nothing

            For i = 0 To ConnectionString.ToLower.Length - 1
                If ConnectionString(i) = ";" Then
                    Dim Splited As String() = Str.Split("=")

                    Select Case Splited(0).Replace(" ", "")
                        Case "provider" : Connection.Provider = Splited(1)
                        Case "datasource" : Connection.DataSource = Splited(1)
                        Case "persistsecurityinfo" : Connection.PersistSecurityInfo = Splited(1)
                        Case "mode" : Connection.Mode = Splited(1)
                        Case "userid" : Connection.UserId = Splited(1)
                        Case "password" : Connection.Passwword = Splited(1)
                        Case "JetOLEDB:DatabaseSystem" : Connection.SystemDatabase = Splited(1)
                        Case "JetOLEDB:DatabasePassword" : Connection.SystemPassword = Splited(1)
                    End Select

                    Continue For
                Else
                    Str += ConnectionString(i)
                End If
            Next

            Return Connection
        End Operator
    End Class

End Namespace
