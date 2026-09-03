Namespace WebPackages.HTML.Structures

    Public Structure HTMLATTRIBUTES
            Dim idiothta As String
            Dim Eltrans As String
            Dim Perigrafh As String
            Dim syndesmos As String
            Dim values() As HTMLATTRIBUTESVALUE
        End Structure

        Public Structure HTMLATTRIBUTESVALUE
            Dim onoma As String
            Dim ellinika As String
            Dim perigrafh As String
        End Structure

        Public Structure EventsScript
            Dim onoma As String
            Dim Ellinika As String
            Dim Perigrafh As String
        End Structure

        Public Structure HTMLTAG
            Dim Etiketa As String
            Dim onomasia As String
            Dim ELtrans As String
            Dim Perigrafh As String
            Dim Syndesmos As String
            Dim HTMLIDIOTHTES() As HTMLATTRIBUTES
            Dim GlobalAttributes() As HTMLATTRIBUTES
            Dim Events() As EventsScript
        End Structure

    End Namespace

