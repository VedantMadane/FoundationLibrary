Namespace Quiz.Data
    Public Class QuizData
        Public Id As Integer
        Public NumQuestion As Integer
        Public Quest As String
        Public BookTitle As String
        Public Page As Integer
        Public Category As Integer
        Public Photo As String
        Public Sound As String
        Public Lang As String
        Public Answers As New List(Of Answers)
        Public Sub Options(Num As Integer, Str As String, Optional Correct As Boolean = False, Optional Dspn As String = Nothing)
            Answers.Add(New Answers With {.NumAnswer = Num, .Answer = Str, .Correct = Correct})
        End Sub
    End Class
    Public Class Answers
        Public Id As Integer
        Public NumAnswer As Integer
        Public Answer As String
        Public Sound As String
        Public Correct As Boolean = False
    End Class
End Namespace

