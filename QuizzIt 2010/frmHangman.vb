Public Class frmHangman
    Implements ICommonFormInterface

    Dim labels(50) As Label
    Dim ans As String
    Dim alphabets(26) As Label
    Dim xLoc, yLoc As Short
    Dim label2 As Label
    Dim WithEvents tmr As New Timer

    Private Sub frmHangman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        commonInterface = Me
        loadGrid()
    End Sub

    Private Sub loadGrid()
        Panel4.Controls.Clear()
        xLoc = 250
        yLoc = 10
        For i = 0 To 25
            labels(i) = New Label
            With labels(i)
                If i = 13 Then
                    xLoc = 250
                    yLoc += 45
                End If
                .Location = New Point(xLoc, yLoc)
                .Font = New Font("Microsoft Sans Serif", 25, FontStyle.Regular)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.White
                .Size = New Size(40, 40)
                .BorderStyle = BorderStyle.FixedSingle
                .BackColor = Color.Transparent
                .Text = CChar(ChrW(65 + i))
                AddHandler .Click, AddressOf highLightMe
            End With
            xLoc += 41
            Panel4.Controls.Add(labels(i))
        Next
    End Sub

    Private Sub highLightMe(ByVal sender As Object, ByVal e As EventArgs)
        If crTeamTries < 2 Then
            With DirectCast(sender, Label)
                .BackColor = Color.LimeGreen
                .ForeColor = Color.White
                crTeamTries += 1
                crQuestionPoints -= 5
                lblAlphaTries.Text = crTeamTries.ToString
                revealLetter(.Text)
            End With
        End If
    End Sub

    Private Sub revealLetter(ByVal letter As Char)
        For i As Integer = 0 To ans.Length - 1
            If Char.ToLower(ans(i)) = Char.ToLower(letter) Then
                labels(i).Text = ans(i)
            End If
        Next
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
            'Reach here only from Prepare Question
            txtQuestion.Text = String.Empty
            Panel2.Controls.Clear()
            Panel4.Controls.Clear()
            loadGrid()
            lblAlphaTries.Text = 0
            crTeamTries = 0
            Exit Sub
        End If
        Dim pair() As String = argQuestion.Split(New Char() {"#"}, System.StringSplitOptions.RemoveEmptyEntries)
        ans = pair(1)
        txtQuestion.Text = pair(0)

        Panel2.Controls.Clear()
        xLoc = 0
        yLoc = 0
        For i = 0 To ans.Length - 1
            labels(i) = New Label
            With labels(i)
                If ans(i) = "%" Then
                    xLoc = 0
                    yLoc += 45
                    .Visible = False
                End If
                .Location = New Point(xLoc, yLoc)
                .Font = New Font("Microsoft Sans Serif", 25, FontStyle.Regular)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.White
                .Size = New Size(40, 40)
                If Not ans(i) = " " Then
                    .BorderStyle = BorderStyle.FixedSingle
                    .BackColor = Color.Black
                    .Text = "_"
                End If
            End With
            xLoc += 41
            If xLoc >= 945 Then
                xLoc = 0
                yLoc += 45
            End If
            Panel2.Controls.Add(labels(i))
        Next

    End Sub

    Public Sub showAnswer(ByVal argAnswer As String) Implements ICommonFormInterface.showAnswer
        For i = 0 To argAnswer.Length - 1
            labels(i).Text = argAnswer(i)
        Next
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
        Me.Controls.Add(label2)
        tmr.Start()

    End Sub

    Public Sub closeMe() Implements ICommonFormInterface.closeMe
        Me.Close()
    End Sub

#End Region

End Class