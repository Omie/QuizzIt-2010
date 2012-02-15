Public Class frmMedia
    Implements ICommonFormInterface
    Dim buzzerStoppedMedia As Boolean

    Dim label2 As Label
    Dim WithEvents tmr As New Timer

    Private Sub frmMedia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
        buzzerStoppedMedia = True
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmr.Tick
        If Not label2.Location.Y >= 75 Then
            Label1.Location = New Point(Label1.Location.X, Label1.Location.Y + 10)
            label2.Location = New Point(label2.Location.X, label2.Location.Y + 10)
        Else
            Label1.ForeColor = Color.FromArgb(5, Color.White)
            label2.ForeColor = Color.FromArgb(255, Color.White)
            Label1.Visible = False
            Label1 = Nothing
            Label1 = label2
            tmr.Stop()
        End If
    End Sub

    Public Sub setMainQuestion(ByVal quest As String)
        txtQuestion.Text = quest
    End Sub
    Private Sub playstateChanged(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If e.newState = 8 And Not buzzerStoppedMedia Then 'Finished playing file
            globalTmr.Start()
        End If
    End Sub

#Region "InterfaceMembers"
    Public Sub showQuestion(ByVal argQuestion As String) Implements ICommonFormInterface.showQuestion
        If argQuestion = String.Empty Then
            txtAnswer.Text = String.Empty

        ElseIf argQuestion = "STOP" Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            buzzerStoppedMedia = True
        Else
            buzzerStoppedMedia = False
            AxWindowsMediaPlayer1.URL = Application.StartupPath & "\Rounds\" & currentStage & "\data\" & argQuestion
        End If
        

    End Sub

    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer
        txtAnswer.Text = argAnswer
    End Sub

    Public Sub setTimerText(ByVal value As String) Implements ICommonFormInterface.setTimerText
        lblTimer.Text = value
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) _
        Handles AxWindowsMediaPlayer1.PlayStateChange

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying And roundHasVideo Then
            AxWindowsMediaPlayer1.fullScreen = True
            'ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            '    Me.Close()
        End If
    End Sub

    Public Sub switchTeam(ByVal teamName As String) Implements ICommonFormInterface.switchTeam

        tmr.Interval = 33
        label2 = New Label
        With label2
            .Size = New Size(153, 60)
            .Location = New Point(Label1.Location.X, 5)
            If Not teamName = String.Empty Then
                .Text = teamName.Insert(4, " ")
            Else
                .Text = teamName
            End If
            .AutoSize = False
            .Font = New Font("Segoe UI", 25, FontStyle.Regular, GraphicsUnit.Point)
            .ForeColor = Color.FromArgb(0, Color.White)
            .BackColor = Color.Transparent
            .TextAlign = ContentAlignment.MiddleCenter
        End With
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf addLabel))
        Else
            Me.Controls.Add(label2)
            tmr.Start()
        End If
    End Sub

    Private Sub addLabel()
        Me.Controls.Add(label2)
        tmr.Start()
    End Sub

    Public Sub closeMe() Implements ICommonFormInterface.closeMe
        Me.Close()
    End Sub
#End Region

End Class