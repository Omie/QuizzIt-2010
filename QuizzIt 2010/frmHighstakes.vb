Public Class frmHighstakes
    Implements ICommonFormInterface

    Dim label2 As Label
    Dim WithEvents tmr As New Timer

    Private Sub frmHighstakes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
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
        txtAnswer.Text = String.Empty
        txtQuestion.Text = argQuestion
    End Sub

    Public Sub setTimerText(ByVal value As String) Implements ICommonFormInterface.setTimerText
        lblTimer.Text = value
    End Sub

    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer
        txtAnswer.Text = argAnswer
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