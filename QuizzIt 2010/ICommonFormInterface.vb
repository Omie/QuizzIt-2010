Public Interface ICommonFormInterface
    Sub showQuestion(ByVal argQuestion As String)
    Sub showAnswer(ByVal argAnswer As String)
    Sub switchTeam(ByVal teamName As String)
    Sub closeMe()
    Sub setTimerText(ByVal value As String)
End Interface
