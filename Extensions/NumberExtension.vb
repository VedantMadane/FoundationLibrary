Imports System.Runtime.CompilerServices



Namespace Extensions
    <Extension>
    Module NumberExtension
        Public Structure SInteger

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


        <Extension>
        Public Function RangeNumber(Number As SInteger, Optional MinNumber As SInteger? = Nothing, Optional MaxNumber As SInteger? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True

        End Function

        <Extension>
        Public Function RangeNumber(Number As Integer, Optional MinNumber As Integer? = Nothing, Optional MaxNumber As Integer? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function

        <Extension>
        Public Function RangeNumber(Number As UInteger, Optional MinNumber As UInteger? = Nothing, Optional MaxNumber As UInteger? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function
        <Extension>
        Public Function RangeNumber(Number As Double, Optional MinNumber As Double? = Nothing, Optional MaxNumber As Double? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function
        <Extension>
        Public Function RangeNumber(Number As Decimal, Optional MinNumber As Decimal? = Nothing, Optional MaxNumber As Decimal? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function

        <Extension>
        Public Function RangeNumber(Number As Long, Optional MinNumber As Long? = Nothing, Optional MaxNumber As Long? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function
        <Extension>
        Public Function RangeNumber(Number As ULong, Optional MinNumber As ULong? = Nothing, Optional MaxNumber As ULong? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function

        <Extension>
        Public Function RangeNumber(Number As Single, Optional MinNumber As Single? = Nothing, Optional MaxNumber As Single? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function

        <Extension>
        Public Function RangeNumber(Number As Short, Optional MinNumber As Short? = Nothing, Optional MaxNumber As Short? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function
        <Extension>
        Public Function RangeNumber(Number As UShort, Optional MinNumber As UShort? = Nothing, Optional MaxNumber As UShort? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function
        <Extension>
        Public Function RangeNumber(Number As Byte, Optional MinNumber As Byte? = Nothing, Optional MaxNumber As Byte? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function
        <Extension>
        Public Function RangeNumber(Number As SByte, Optional MinNumber As SByte? = Nothing, Optional MaxNumber As SByte? = Nothing) As Boolean
            If MinNumber IsNot Nothing AndAlso MinNumber >= Number Then Return False
            If MaxNumber IsNot Nothing AndAlso MaxNumber <= Number Then Return False
            Return True
        End Function


    End Module

End Namespace
