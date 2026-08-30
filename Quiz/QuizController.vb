Imports FoundationLibrary.Quiz.Data
Namespace Quiz


    Public Class QuizController

        Public Shared Index As Integer

        Shared Function Random_Quest(ByVal Questions() As QuizData) As QuizData()
            Dim Index As Integer = Nothing
            Dim Erwthseis(Questions.Count - 1) As QuizData
            Dim ListIndexs As New List(Of Integer)
            Randomize()

            While ListIndexs.Count - 1 <> Questions.Count - 1
                Do
                    Index = Int((Questions.Count) * Rnd())
                Loop Until ListIndexs.Contains(Index) = False
                ListIndexs.Add(Index)

            End While

            For i = 0 To ListIndexs.Count - 1
                Erwthseis(i) = Questions(ListIndexs(i))
            Next

            Return Erwthseis
        End Function




        Shared Function Random_Answers(ByVal ListAnswers As List(Of Answers)) As List(Of Answers)
            Dim index As Integer
            Dim ListIndexs As New List(Of Integer)
            Randomize()
            While ListIndexs.Count - 1 <> ListAnswers.Count - 1
                Do
                    index = Int((ListAnswers.Count) * Rnd())
                Loop Until ListIndexs.Contains(index) = False
                ListIndexs.Add(index)
            End While

            Dim ReturnListAnswer As New List(Of Answers)
            For i = 0 To ListIndexs.Count - 1
                ReturnListAnswer.Add(ListAnswers(ListIndexs(i)))
            Next


            Return ReturnListAnswer
        End Function

        Shared Function Next_Question(ByVal Question() As QuizData) As QuizData
            Index += 1
            If Question.Count >= Index Then
                Return Question(Index)
            Else
                Index = 0
                Return Question(Index)
            End If
        End Function

        Shared Function Preview_Question(ByVal Question() As QuizData) As QuizData
            Index -= 1
            If Question.Count <= Index Then
                Return Question(Index)
            Else
                Index = Question.Count - 1
                Return Question(Index)
            End If
        End Function
    End Class
End Namespace