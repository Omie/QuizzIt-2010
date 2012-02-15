Module globalVariables

#Region "ValueTypeVars"
    Friend currentStage As String
    Friend crQuestionPoints As Integer
    Friend crTimerDuration As Integer
    Friend crTimeCount As Integer
    Friend crTeamTries As Integer 'For highstakes and hangman round
    Friend currentTeam As String
    Friend containerForm As frmContainer
    Friend polling As Boolean
    'Friend roundHasTimer As Boolean 'Every round Form sets value if it has timer used
    Friend roundHasVideo As Boolean
    Friend isBuzzerRound As Boolean

    Friend pointsTable As DataTable 'to store entire stage points of players

    'Friend roundHasNegativePoints As Boolean
#End Region

#Region "ReferenceTypeVars"
    Friend commonInterface As ICommonFormInterface
    Friend crosswordFrm As frmCrossword
    Friend wofForm As frmWof
    Friend WithEvents globalTmr As New Timer
#End Region

#Region "GlobalFunctions"

    'Add entry to application log listbox
    Friend Sub log(ByVal entry As String)
        Form1.appLog.Items.Insert(0, entry)
    End Sub

    'Close Previous Form
    Friend Sub closePreviousForm()
        If commonInterface IsNot Nothing Then
            commonInterface.closeMe()
        End If
    End Sub

    'Timer function to operate timer of each round for every question
    'Called in nextQuestion
    Friend Sub globalTmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles globalTmr.Tick
        Try
            If crTimeCount > 0 Then
                Form1.lblStatusTimer.Text = crTimeCount
                If crTimeCount > 9 Then
                    commonInterface.setTimerText(crTimeCount.ToString)
                Else
                    commonInterface.setTimerText("0" & crTimeCount.ToString)
                End If
                crTimeCount -= 1
            Else
                polling = False
                stopGlobalTmr()
                commonInterface.setTimerText("00")
                My.Computer.Audio.Play("buzzer.wav")
            End If
        Catch ex As Exception
            polling = False
            stopGlobalTmr()
            MsgBox("Exception while in Timer" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error in Operation")
        End Try
    End Sub

    'Force Stopping global timer
    Friend Sub stopGlobalTmr()
        globalTmr.Stop()
        crTimeCount = crTimerDuration
        'commonInterface.setTimerText("")
    End Sub

    Private formThread As System.Threading.Thread 'to show teamName form. If not shown in other thread, it doesnt draw properly
    'hate MDI $%^&*

    'Called by buzzer rounds as soon as buzzer is pressed
    Friend Sub showTeamName()
        formThread = New Threading.Thread(AddressOf showTeamForm)
        formThread.Start()
    End Sub

    Private Sub showTeamForm()
        Dim tempTeamName As New frmTeamName
        tempTeamName.StartPosition = FormStartPosition.CenterParent
        tempTeamName.lblTeamName.Text = currentTeam
        tempTeamName.TopLevel = True
        tempTeamName.ShowDialog(containerForm)
        'Send info to running form
        'Because of scroll effect. If done before showDialog, scroll effect wont be achieved.
        'will display ghost label in Round Form
        commonInterface.switchTeam(currentTeam)
    End Sub

#End Region

End Module