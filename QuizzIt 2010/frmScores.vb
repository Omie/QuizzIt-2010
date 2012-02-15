Public Class frmScores
    Implements ICommonFormInterface

    Private Sub frmScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
        AxShockwaveFlash1.BringToFront()
        AxShockwaveFlash1.Movie = Application.StartupPath & "\flash\main_score.swf"
    End Sub


#Region "InterfaceMembers"
    Public Sub closeMe() Implements ICommonFormInterface.closeMe
        Me.Close()
    End Sub
    Public Sub setTimerText(ByVal value As String) Implements ICommonFormInterface.setTimerText
        MsgBox("This function isnt implemented in scores form. You've missed one step I guess..")
    End Sub
    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer
        MsgBox("This function isnt implemented in scores form. You've missed one step I guess..")
    End Sub
    Public Sub showQuestion(ByVal argQuestion As String) Implements ICommonFormInterface.showQuestion
        MsgBox("This function isnt implemented in scores form. You've missed one step I guess..")
    End Sub
    Public Sub switchTeam(ByVal teamName As String) Implements ICommonFormInterface.switchTeam
        MsgBox("This function isnt implemented in scores form. You've missed one step I guess..")
    End Sub
#End Region

End Class