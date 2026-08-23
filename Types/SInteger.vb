Namespace Types
    Structure SInteger
        Public Const MaxValue As Long = -4294967295
        Public Const MinValue As Long = 0
        Private ReadOnly _Value As UInteger

        Shared Narrowing Operator CType(Number As Long) As SInteger
            If Number > MinValue Then
                Throw New OverflowException("ο αριθμος δεν πρεπει να ειναι θετικός!")
            End If
            If Number < MaxValue Then
                Throw New OverflowException("ο αριθμος δεν πρεπει να Μεγαλήτερος: " & MaxValue)
            End If

            Return New SInteger(Number)
        End Operator

        Shared Widening Operator CType(S As SInteger) As Long
            Return -CLng(S._Value)
        End Operator

        Public Overrides Function ToString() As String
            Return -CLng(_Value)
        End Function

        Private Sub New(Value As Long)
            If Value > MinValue Then
                Throw New OverflowException("ο αριθμος δεν πρεπει να ειναι θετικός!")
            End If
            If Value < MaxValue Then
                Throw New OverflowException("ο αριθμος δεν πρεπει να Μεγαλήτερος: " & MaxValue)
            End If

            _Value = CUInt(-Value)
        End Sub

        Shared Operator >=(ByVal Number1 As SInteger, Number2 As SInteger) As Boolean
            If Number1._Value <= Number2._Value Then Return True
            Return False
        End Operator
        Shared Operator <=(ByVal Number1 As SInteger, Number2 As SInteger) As Boolean
            If Number1._Value >= Number2._Value Then Return True
            Return False
        End Operator
        Shared Operator =(ByVal Number1 As SInteger, Number2 As SInteger) As Boolean
            If Number1._Value = Number2._Value Then Return True
            Return False
        End Operator
        Shared Operator <>(ByVal Number1 As SInteger, Number2 As SInteger) As Boolean
            If Number1._Value <> Number2._Value Then Return True
            Return False
        End Operator
        Shared Operator <(ByVal Number1 As SInteger, Number2 As SInteger) As Boolean
            If Number1._Value > Number2._Value Then Return True
            Return False
        End Operator
        Shared Operator >(ByVal Number1 As SInteger, Number2 As SInteger) As Boolean
            If Number1._Value < Number2._Value Then Return True
            Return False
        End Operator
    End Structure
End Namespace

