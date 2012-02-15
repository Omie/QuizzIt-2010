Public Class frmRapidfire
    Implements ICommonFormInterface

    Dim WithEvents countdownTmr As New Timer
    Dim count As Short

    Dim label2 As Label
    Dim WithEvents tmr As New Timer

    Private Sub frmRapidfire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
        countdownTmr.Interval = 1000
    End Sub

    Private Sub countdownTmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles countdownTmr.Tick
        If count > 0 Then
            If count < 10 Then
                txtTimer.Text = "0" & count
            Else
                txtTimer.Text = count
            End If
            count -= 1
        Else
            txtTimer.Text = "0" & count
            My.Computer.Audio.Play("buzzer.wav")
            countdownTmr.Stop()
        End If
        If count < 30 And count > 15 Then
            txtTimer.ForeColor = Color.Orange
        End If
        If count < 15 Then
            txtTimer.ForeColor = Color.Red
        End If
    End Sub

    'tmr_tick for switch team animation
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

#Region "InterfaceMembers"

    Public Sub showQuestion(ByVal argQuestion As String) Implements ICommonFormInterface.showQuestion
        If argQuestion = String.Empty Then
            countdownTmr.Stop()
        Else
            count = CInt(argQuestion)
            txtTimer.ForeColor = Color.Lime
            txtTimer.Text = count
            countdownTmr.Start()
        End If
    End Sub

    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer

    End Sub

    Public Sub setTimerText(ByVal value As String) Implements ICommonFormInterface.setTimerText
        'This round has BIG Timer
        'This aint needed
        'lblTimer.Text = value
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
        Me.Controls.Add(label2)
        tmr.Start()

    End Sub

    Public Sub closeMe() Implements ICommonFormInterface.closeMe
        Me.Close()
    End Sub

#End Region

End Class