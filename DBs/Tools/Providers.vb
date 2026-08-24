Namespace Database.Tools
    Public Class Providers
        Enum TypeProviders
            Jet4
            ACE12
            ACE15
            ACE16
        End Enum

        Private _Value As String

        Private Shared Property ProvidersDictionary As New Dictionary(Of Integer, String) From {
            {TypeProviders.Jet4, "Microsoft.Jet.OLEDB.4.0"},
            {TypeProviders.ACE12, "Microsoft.ACE.OLEDB.12.0"},
            {TypeProviders.ACE15, "Microsoft.ACE.OLEDB.15.0"},
            {TypeProviders.ACE16, "Microsoft.ACE.OLEDB.16.0"}
        }

        Sub New(TypeVersion As TypeProviders)
            _Value = ProvidersDictionary(TypeVersion)
        End Sub
        Sub New(Key As Integer)
            _Value = ProvidersDictionary(Key)
        End Sub

        Default Public ReadOnly Property Provider(ProviderValue As Integer) As String
            Get
                _Value = ProvidersDictionary(ProviderValue)
                Return _Value
            End Get
        End Property
        Default Public ReadOnly Property Provider(Typeprovider As TypeProviders) As String
            Get
                _Value = ProvidersDictionary(Typeprovider)
                Return _Value
            End Get
        End Property
        Shared Narrowing Operator CType(Provider As Providers) As String
            Return Provider._Value
        End Operator
        Shared Narrowing Operator CType(Value As TypeProviders) As Providers
            Return New Providers(Value)
        End Operator
        Shared Narrowing Operator CType(Value As Integer) As Providers
            Return New Providers(Value)
        End Operator
        Shared Operator &(ByVal Provider As Providers, Value As String) As String
            Return Provider._Value
        End Operator
        Shared Operator &(Value As String, ByVal Provider As Providers) As String
            Return Provider._Value
        End Operator



        Public Function Add(ProviderStr As String) As Integer
            ProvidersDictionary.Add(ProvidersDictionary.Count, ProviderStr)
            Return ProvidersDictionary.Count - 1
        End Function
        Public Function ListOfProviders() As List(Of String)
            Dim List As New List(Of String)
            For Each Dict In ProvidersDictionary
                List.Add(Dict.Key & ") " & Dict.Value)
            Next
            Return List
        End Function
    End Class
End Namespace
