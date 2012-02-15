Public Class frmImage
    Implements ICommonFormInterface

    Dim label2 As Label
    Dim WithEvents tmr As New Timer

    Private Sub frmImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub setMainQuestion(ByVal quest As String)
        txtQuestion.Text = quest
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

#Region "InterfaceMembers"
    Public Sub showQuestion(ByVal argQuestion As String) Implements ICommonFormInterface.showQuestion
        If argQuestion = String.Empty Then
            txtAnswer.Text = String.Empty
            PictureBox1.Image = Nothing
            Me.setMainQuestion(String.Empty)
        Else
            Dim argSplit() As String = argQuestion.Split(New Char() {"#"}, System.StringSplitOptions.None)
            Me.setMainQuestion(argSplit(0))
            PictureBox1.ImageLocation = Application.StartupPath & "\Rounds\" & currentStage & "\data\" & argSplit(1)
        End If
    End Sub

    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer
        txtAnswer.Text = argAnswer
    End Sub

    Public Sub setTimerText(ByVal value As String) Implements ICommonFormInterface.setTimerText
        lblTimer.Text = value
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