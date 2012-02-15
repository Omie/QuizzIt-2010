Public Class frmSwfForm
    Implements ICommonFormInterface

    Public filepath As String = String.Empty

    Private Sub frmSwfForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
        If Not filepath Is String.Empty Then
            Me.axFlash.Movie = filepath
            Me.axFlash.Play()
        End If
    End Sub

#Region "InterfaceMembers"
    Public Sub closeMe() Implements ICommonFormInterface.closeMe
        Me.Close()
    End Sub

    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer
        Throw New NotImplementedException("showAnswer is not implemented in SWF Form")
    End Sub

    Public Sub setTimerText(ByVal value As String) Implements ICommonFormInterface.setTimerText
        Throw New NotImplementedException("setTimerText is not implemented in SWF Form")
    End Sub

    Public Sub showQuestion(ByVal argQuestion As String) Implements ICommonFormInterface.showQuestion
        Throw New NotImplementedException("showQuestion is not implemented in SWF Form")
    End Sub

    Public Sub switchTeam(ByVal teamName As String) Implements ICommonFormInterface.switchTeam
        Throw New NotImplementedException("switchTeam is not implemented in SWF Form")
    End Sub
#End Region

End Class