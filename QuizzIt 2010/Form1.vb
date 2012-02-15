Imports UsbLibrary
Imports System.Xml
Public Class Form1

#Region "VariableDeclarations"
    Private currentRound As String
    Private currentQuestion As Integer

    Private roundButtons(10) As RadioButton
    Private selectedRadioButton As String

    Private oldBackColor, oldForeColor As Color 'To De-select team button
    Private teamButtons(4) As Button

    Private questionWasPassed As Boolean
    Private roundIsWof As Boolean = False
    Private passCounter As Integer

    Private flashForm As frmSwfForm 'is used to display all the Flash things

    Private cRoundPoints As New Dictionary(Of String, Integer) 'to store current round points of players
    Private crQuestionPassPoints As Integer 'stores points to allot if team answers passed question. Is Read from XML File
    Private crQuestionNegativePoints As Integer 'Store negative points. is read from XML File

    Private QuestionsDoc As New XmlDocument 'Stores current rounds XML File
    Private strQuestion, strAnswer As String
    Private QuestionNodes As XmlNodeList

    Private Questions As New List(Of Question) 'stores questions by iterating through QuestionNodesList
    Private teamQuestions As New List(Of Question) 'for highstakes round only. gets selected team questions

    'Required to solve buzzer problem
    Private lessFifteen As Integer 'input value - 15. 15 is a constant value given by circuit
    Private numbers(4) As Integer
    Private counter As Short = 0

#End Region

#Region "SubClass"

    'List of this class holds whole round questions
    Private Class Question
        Public Question As String
        Public Answer As String

        'Crossword Specific Details
        Public startX As Integer
        Public startY As Integer
        Public Direction As String
        Public length As Integer

        'highstakes specific
        Public teamName As String

        'WOF Specific
        Public wofCat As Integer

        Public Sub New(ByVal Question As String, ByVal Answers As String)
            Me.Question = Question
            Me.Answer = Answers
        End Sub

        'Overload used for wheel of fortune round
        Public Sub New(ByVal question As String, ByVal answer As String, ByVal wofCat As Integer)
            Me.Question = question
            Me.Answer = answer
            Me.wofCat = wofCat
        End Sub

        'Overload used for Crossword
        Public Sub New(ByVal Question As String, ByVal Answers As String, ByVal startX As Integer, ByVal startY As Integer, _
                     ByVal direction As String, ByVal length As Integer)
            Me.Question = Question
            Me.Answer = Answers
            Me.startX = startX
            Me.startY = startY
            Me.Direction = direction
            Me.length = length
            Me.teamName = teamName
        End Sub

        'Overload used for Highstakes
        Public Sub New(ByVal Question As String, ByVal Answers As String, ByVal teamName As String)
            Me.Question = Question
            Me.Answer = Answers
            Me.teamName = teamName
        End Sub
    End Class

#End Region

#Region "UtilitySubs"
    'Initialize everything
    Private Sub initAll()
        'Initialize everything

        'Set Application status Initializing
        lblAppStatus.Text = "Initializing"
        lblRoundName.Text = String.Empty
        lblStageName.Text = String.Empty
        lblTeamName.Text = String.Empty

        'Load Stages List
        RefreshStageListToolStripMenuItem_Click(Nothing, Nothing)

        'load team buttons
        Dim btXLoc As Integer
        btXLoc = 47
        For buttonIndex = 0 To 3
            teamButtons(buttonIndex) = New Button
            With teamButtons(buttonIndex)
                .Location = New Point(btXLoc, 27)
                .Size = New Size(106, 49)
                '.Name = "btnTeam" & buttonIndex.ToString
                AddHandler .Click, AddressOf setCurrentTeam
                .Text = "Team" & CChar(ChrW(65 + buttonIndex))
                .Name = "btn" & .Text
            End With
            btXLoc += 112
        Next
        mainControlPanel.Controls.AddRange(teamButtons)
        'save old color settings
        oldBackColor = teamButtons(0).BackColor
        oldForeColor = teamButtons(0).ForeColor

        'Prepare datatable
        pointsTable = New DataTable
        With pointsTable
            .Columns.Add("RoundNo")
            .Columns.Add("TeamA")
            .Columns.Add("TeamB")
            .Columns.Add("TeamC")
            .Columns.Add("TeamD")
            .Rows.Add(New Object() {0, 0, 0, 0, 0})
        End With

        gainBuzzerControl()

        cRoundPoints.Add("TeamA", 0)
        cRoundPoints.Add("TeamB", 0)
        cRoundPoints.Add("TeamC", 0)
        cRoundPoints.Add("TeamD", 0)

        scoresLabelTeamA.Text = pointsTable.Rows(0).Item("TeamA")
        scoresLabelTeamB.Text = pointsTable.Rows(0).Item("TeamB")
        scoresLabelTeamC.Text = pointsTable.Rows(0).Item("TeamC")
        scoresLabelTeamD.Text = pointsTable.Rows(0).Item("TeamD")

        updateScoresOnControlPanel()

        globalTmr.Interval = 1000
        'Set Application status Ready
        lblAppStatus.Text = "Ready"
        log("Ready")

    End Sub

    'Check buzzer connectivity
    Private Sub gainBuzzerControl()
        'Check buzzer connectivity
        Try
            If device IsNot Nothing Then
                device.Dispose()
            End If
            device = New SpecifiedDevice
            port.VendorId = Int32.Parse(My.Settings.venId, Globalization.NumberStyles.AllowHexSpecifier)
            port.ProductId = Int32.Parse(My.Settings.hdId, Globalization.NumberStyles.AllowHexSpecifier)
            Control.CheckForIllegalCrossThreadCalls = False
            device = SpecifiedDevice.FindSpecifiedDevice(port.VendorId, port.ProductId)
            If device IsNot Nothing Then
                lblBuzzerIcon.Text = "Buzzer Connected"
            Else
                lblBuzzerIcon.Text = "Buzzer DISConnected"
            End If
        Catch ex As Exception
            lblBuzzerIcon.Text = "BuzzerError"
        End Try
    End Sub

    'Get xml files in Selected stage directory and set that many radio buttons
    Private Sub loadRounds()
        'Get xml files in Selected stage directory and set that many radio buttons
        Try
            For Each radioButton In roundButtons
                radioButton.Dispose()
            Next
        Catch ex As Exception
        End Try

        Dim i As Integer = 0
        Dim xLoc, yLoc As Integer

        xLoc = 17
        yLoc = 35

        For Each file As String In IO.Directory.GetFiles(Application.StartupPath & "\Rounds\" & stagesList.SelectedItem, "*.*", IO.SearchOption.TopDirectoryOnly)
            If file.EndsWith("xml") Then
                roundButtons(i) = New RadioButton
                With roundButtons(i)
                    .Name = "roundRadioButton" & i.ToString
                    .Location = New Point(xLoc, yLoc)
                    .Text = file.Substring(file.LastIndexOf("\") + 1, file.Length - file.LastIndexOf("\") - 5)
                    AddHandler .CheckedChanged, AddressOf setSelectedRound

                End With
                gBoxRounds.Controls.Add(roundButtons(i))
                i += 1
                xLoc += 130
                If i Mod 4 = 0 Then
                    yLoc += 23
                    xLoc = 17
                End If
            End If
        Next
        If i > 0 Then
            roundButtons(0).Checked = True
        End If
        'Log Application Event
        log(i.ToString & " rounds found")
    End Sub

    'Get questions for particular team for Highstakes round
    Private Function getTeamQuestions(ByVal teamName As String) As Boolean
        teamQuestions.Clear() 'teamQuestions is a dictionary(of Question)
        For Each quest As Question In Questions
            If quest.teamName = teamName Then
                teamQuestions.Add(quest)
            End If
        Next
        If teamQuestions.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Set Current Team
    Private Sub setCurrentTeam(ByVal sender As Object, ByVal e As System.EventArgs)
        'Set Current Team
        Try
            If DirectCast(sender, Button).BackColor = Color.Black Then 'If true then de-select current team
                For i = 0 To 3
                    With teamButtons(i)
                        .BackColor = oldBackColor
                        .ForeColor = oldForeColor
                    End With
                Next
                currentTeam = String.Empty
                lblTeamName.Text = currentTeam
                commonInterface.switchTeam(currentTeam)
            Else 'set current team
                For i = 0 To 3
                    With teamButtons(i)
                        .BackColor = oldBackColor
                        .ForeColor = oldForeColor
                    End With
                Next
                currentTeam = String.Empty
                lblTeamName.Text = currentTeam
                With DirectCast(sender, Button)
                    .BackColor = Color.Black
                    .ForeColor = Color.Wheat
                    currentTeam = .Text
                    lblTeamName.Text = currentTeam
                End With
                If isBuzzerRound And Not roundIsWof Then 'WOF is a buzzer round but in a different way
                    showTeamName()
                Else
                    'Send info to running form
                    commonInterface.switchTeam(currentTeam)
                End If

                crTeamTries = 0 'here too because hangman uses same variable
                'Load questions for that particular team if round is highStakes
                If currentRound = "highstakes" Then
                    If getTeamQuestions(currentTeam) Then
                        log("Questions loaded for current team")
                        Button3.Enabled = True 'Enable next question button
                        crTeamTries = 0
                        currentQuestion = 0
                        crQuestionPoints = 10
                    Else
                        MsgBox("No Questions loaded for " & currentTeam, MsgBoxStyle.Critical, "No questions")
                    End If
                End If
                'Log Application Event
                log(currentTeam & " selected")
            End If
        Catch ex As Exception
            log("Error:setCurrentTeam " & ex.Message)
            MsgBox("Error in Form1::setCurrentTeam" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error in Operation")
        End Try
    End Sub

    'Add Entry to scores log listbox
    Private Sub sLog(ByVal entry As String)
        scoresLog.Items.Insert(0, entry)
    End Sub

    'Get columnTotal of DataTable for team
    Private Function getColumnTotal(ByVal columnName As String) As Integer
        'Get column total of Datatable
        'To get total scores of team
        Dim total As Integer = 0
        For Each row As DataRow In pointsTable.Rows
            total += CInt(row(columnName))
        Next
        Return total
    End Function

    'Update scores on control panel
    Private Sub updateScoresOnControlPanel()
        'pointsLabels show points for current rounds
        pointsLabelTeamA.Text = cRoundPoints("TeamA")
        pointsLabelTeamB.Text = cRoundPoints("TeamB")
        pointsLabelTeamC.Text = cRoundPoints("TeamC")
        pointsLabelTeamD.Text = cRoundPoints("TeamD")
    End Sub

#End Region

#Region "BuzzerWork"
    Dim WithEvents port As New UsbHidPort
    Dim WithEvents device As UsbLibrary.SpecifiedDevice

    Private Sub afterBuzzerPress(ByVal team As Integer)
        stopGlobalTmr()
        If currentRound = "audio" Or currentRound = "video" Then
            commonInterface.showQuestion("STOP") 'STOP is handled in MediaForm only
        End If
        teamButtons(team).PerformClick() 'To setCurrentTeam and its afterEffects.
    End Sub

    'Read inputvalues from circuit
    Private Sub device_DataRecieved(ByVal sender As Object, ByVal args As UsbLibrary.DataRecievedEventArgs) Handles device.DataRecieved
        If polling Then
            Try
                If roundIsWof Then
                    If args.data(My.Settings.dataIndex) = My.Settings(currentTeam) Then
                        polling = False
                        wofForm.spinWheel() 'wofForm is an instance of frmWof in globalVariables. 
                    End If
                Else
                    Select Case args.data(My.Settings.dataIndex)
                        Case My.Settings.TeamA
                            'Show TeamA                           
                            polling = False
                            afterBuzzerPress(0)
                        Case My.Settings.TeamB
                            'Show TeamB
                            polling = False
                            afterBuzzerPress(1)
                        Case My.Settings.TeamC
                            'Show TeamC
                            polling = False
                            afterBuzzerPress(2)
                        Case My.Settings.TeamD
                            'Show TeamD                           
                            polling = False
                            afterBuzzerPress(3)
                        Case 15
                            'avoid default input value
                        Case Else 'reach here if two teams pressed buzzer at the same time
                            ' get which teams pressed the buttons at the same time
                            ' get random of those teams
                            ' show that teamName
                            ' Sorry, no other option :-(
                            counter = 0
                            polling = False
                            lessFifteen = CInt(args.data(My.Settings.dataIndex)) - 15 '15 is a constant sent by circuit
                            While lessFifteen >= 16
                                Debug.WriteLine("else data recieved " & lessFifteen)
                                If lessFifteen >= 16 Then
                                    If lessFifteen >= 32 Then
                                        If lessFifteen >= 64 Then
                                            If lessFifteen >= 128 Then
                                                numbers(counter) = 128
                                                lessFifteen = lessFifteen - 128
                                            Else
                                                'number is greater than 64 but less than 128
                                                numbers(counter) = 64
                                                lessFifteen = lessFifteen - 64
                                            End If
                                        Else
                                            'number is greater than 32 but less than 64
                                            numbers(counter) = 32
                                            lessFifteen = lessFifteen - 32
                                        End If
                                    Else
                                        'number is greater than 16 but less than 32
                                        numbers(counter) = 16
                                        lessFifteen = lessFifteen - 16
                                    End If
                                Else
                                    numbers(counter) = lessFifteen
                                End If
                                counter += 1
                            End While
                            Application.DoEvents()
                            'Debug.WriteLine(getRandomOfTeams(numbers, counter))
                            afterBuzzerPress(getRandomOfTeams(numbers, counter))
                    End Select
                End If
            Catch ex As Exception
                log("Error: DataReceived" & ex.Message)
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Data Receive Error in Operation")
            End Try
        End If
    End Sub

    'Return random team name out of multiple teams
    Private Function getRandomOfTeams(ByVal numbers() As Integer, ByVal counter As Short) As Integer
        Dim rnd As New Random
        Dim temp As Integer = rnd.Next(0, counter - 1)
        'Debug.WriteLine("Counter " & counter)
        temp = numbers(temp)
        Select Case temp + 15
            Case My.Settings.TeamA
                Return 0
            Case My.Settings.TeamB
                Return 1
            Case My.Settings.TeamC
                Return 2
            Case My.Settings.TeamD
                Return 3
        End Select
        'Return 0
    End Function

#End Region

#Region "HandlerSubs"

    'Form Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initialize everything
        initAll() 'in utility subs region
        containerForm = New frmContainer 'Public Display Form
        containerForm.Show()
        Control.CheckForIllegalCrossThreadCalls = False
        Dim abtForm As New frmAbout
        abtForm.ShowDialog()
    End Sub

    'Load Stages List
    Private Sub RefreshStageListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshStageListToolStripMenuItem.Click
        'Load Stages List
        stagesList.Items.Clear()
        Dim dirs() As String = IO.Directory.GetDirectories(Application.StartupPath & "\Rounds")
        For Each dir As String In dirs
            stagesList.Items.Add(dir.Substring(dir.LastIndexOf("\") + 1, dir.Length - dir.LastIndexOf("\") - 1))
        Next
    End Sub

    'Select Stage
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Select Stage
        currentStage = stagesList.SelectedItem
        lblStageName.Text = currentStage
        Button2.Enabled = True 'Enable Select round button
        closePreviousForm()
        Dim openingFlash As New frmSwfForm
        openingFlash.filepath = Application.StartupPath & "\flash\Brain.swf"
        openingFlash.MdiParent = containerForm
        openingFlash.Show()
        'Log Application event
        log(currentStage & " selected")

        'Load Rounds
        loadRounds()

    End Sub

    'Set selected radio button to global reference
    Private Sub setSelectedRound(ByVal sender As Object, ByVal e As System.EventArgs)
        'Set selected radio button to global reference
        selectedRadioButton = DirectCast(sender, RadioButton).Text
        mainControlPanel.Enabled = False
    End Sub

    'Show round display form to Public
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        closePreviousForm()

        Button12.Enabled = True 'Enable Prepare Question button
        Dim roundType As String = QuestionsDoc.ChildNodes(0).Attributes("type").Value 'Get round type.
        Select Case roundType
            Case "general"
                'Dim currentRoundForm As New frmHangman
                Dim currentRoundForm As New frmGeneral
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case "media"
                Dim currentRoundForm As New frmMedia
                currentRoundForm.setMainQuestion(QuestionsDoc.ChildNodes(0).Attributes("mainQuestion").Value)
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case "image"
                Dim currentRoundForm As New frmImage
                'currentRoundForm.setMainQuestion(QuestionsDoc.ChildNodes(0).Attributes("mainQuestion").Value)
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case "crossword"
                Dim currentRoundForm As New frmCrossword
                crosswordFrm = currentRoundForm
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
                For Each quest As Question In Questions
                    Select Case quest.Direction
                        Case "hor"
                            For i = 0 To quest.length - 1
                                currentRoundForm.labels(quest.startX, quest.startY + i).BackColor = Color.White
                            Next
                        Case "ver"
                            For i = 0 To quest.length - 1
                                currentRoundForm.labels(quest.startX + i, quest.startY).BackColor = Color.White
                            Next
                    End Select
                Next
            Case "hangman"
                Dim currentRoundForm As New frmHangman
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case "highstakes"
                Dim currentRoundForm As New frmHighstakes
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case "rapidfire"
                Dim currentRoundForm As New frmRapidfire
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case "wof"
                Dim currentRoundForm As New frmWof
                currentRoundForm.MdiParent = containerForm
                currentRoundForm.Show()
            Case Else
                MsgBox("Invalid parameter for round type. Check XML file for " & currentRound)
                Exit Sub
        End Select
        Button9.Enabled = False 'Disable Show Round Button
        mainControlPanel.Enabled = True
        'Reset Current Round Points
        cRoundPoints("TeamA") = 0
        cRoundPoints("TeamB") = 0
        cRoundPoints("TeamC") = 0
        cRoundPoints("TeamD") = 0
        updateScoresOnControlPanel()

    End Sub

    'Load Selected Round into List
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Load Selected Round into List
        If currentStage <> String.Empty Then
            Try
                QuestionsDoc.Load(Application.StartupPath & "\Rounds\" & stagesList.SelectedItem & "\" & selectedRadioButton & ".Xml")
                QuestionNodes = QuestionsDoc.DocumentElement.SelectNodes("Question")
                Questions.Clear()
                currentRound = selectedRadioButton.Substring(1).ToLower

                Select Case currentRound
                    Case "crossword"
                        For Each Node As XmlNode In QuestionNodes
                            strQuestion = Node.SelectSingleNode("Question").InnerText
                            strAnswer = Node.SelectSingleNode("Answer").InnerText
                            Questions.Add(New Question(strQuestion, strAnswer, CInt(Node.Attributes("startx").Value), _
                                                       CInt(Node.Attributes("starty").Value), Node.Attributes("dir").Value, _
                                                       CInt(Node.Attributes("length").Value)))
                        Next
                    Case "highstakes"
                        For Each Node As XmlNode In QuestionNodes
                            strQuestion = Node.SelectSingleNode("Question").InnerText
                            strAnswer = Node.SelectSingleNode("Answer").InnerText
                            Questions.Add(New Question(strQuestion, strAnswer, Node.Attributes("team").Value))
                        Next

                    Case "wheeloffortune"
                        For Each Node As XmlNode In QuestionNodes
                            strQuestion = Node.SelectSingleNode("Question").InnerText
                            strAnswer = Node.SelectSingleNode("Answer").InnerText
                            Questions.Add(New Question(strQuestion, strAnswer, CInt(Node.Attributes("wofcat").Value)))
                        Next
                    Case Else
                        For Each Node As XmlNode In QuestionNodes
                            strQuestion = Node.SelectSingleNode("Question").InnerText
                            strAnswer = Node.SelectSingleNode("Answer").InnerText
                            Questions.Add(New Question(strQuestion, strAnswer))
                        Next
                End Select

                If currentRound = "wheeloffortune" Then
                    roundIsWof = True
                Else
                    roundIsWof = False
                End If

                currentQuestion = 0
                lblRoundName.Text = selectedRadioButton
                questionNumber.Text = currentQuestion.ToString


                crQuestionPoints = CInt(QuestionsDoc.ChildNodes(0).Attributes("qPoints").Value)
                crQuestionPassPoints = CInt(QuestionsDoc.ChildNodes(0).Attributes("pPoints").Value)
                crQuestionNegativePoints = CInt(QuestionsDoc.ChildNodes(0).Attributes("nPoints").Value)
                crTimerDuration = CInt(QuestionsDoc.ChildNodes(0).Attributes("time").Value)


                If QuestionsDoc.ChildNodes(0).Attributes("buzzer").Value = "yes" Then
                    isBuzzerRound = True
                Else
                    isBuzzerRound = False
                End If

                If QuestionsDoc.ChildNodes(0).Attributes("subType").Value = "video" Then
                    roundHasVideo = True
                Else
                    roundHasVideo = False
                End If

                Button8.Enabled = True 'Enable Showing Round Flash
                'Log Application event
                log(selectedRadioButton & " Loaded")
            Catch ex As Exception
                MsgBox("Error loading " & selectedRadioButton & _
                vbCrLf & "This is a critical error and should be resolved immediately" & _
                vbCrLf & "Details :-" & _
                vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error Loading Selected Round")

                log("Error loading " & selectedRadioButton)
            End Try
        End If
        
    End Sub

    'Prepare Question
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'Prepare Question
        'Do cleanup and reset text fields
        tBoxQuestion.Text = String.Empty
        tBoxAnswer.Text = String.Empty
        lblStatusTimer.Text = String.Empty
        qAnswered.Checked = False
        If commonInterface IsNot Nothing Then
            commonInterface.setTimerText(String.Empty)
            commonInterface.showAnswer(String.Empty)
            commonInterface.showQuestion(String.Empty)
        End If

        'DirectCast(Me.mainControlPanel.Controls("btn" & currentTeam), Button).PerformClick()
        If isBuzzerRound Then
            commonInterface.switchTeam(String.Empty)
        End If

        If Not currentRound = "rapidfire" Then
            Button3.Enabled = True 'Enable Next Question Button
        End If

        'Deselect currentTeam
        If Not currentTeam = String.Empty And Not currentRound = "highstakes" Then
            Select Case currentTeam
                Case "TeamA"
                    teamButtons(0).PerformClick()
                Case "TeamB"
                    teamButtons(1).PerformClick()
                Case "TeamC"
                    teamButtons(2).PerformClick()
                Case "TeamD"
                    teamButtons(3).PerformClick()
            End Select
        End If
        'For Crossword Round
        If currentRound = "crossword" Then
            Try
                Select Case Questions(currentQuestion).Direction
                    Case "hor"
                        For i = 0 To Questions(currentQuestion).length - 1
                            crosswordFrm.labels(Questions(currentQuestion).startX, Questions(currentQuestion).startY + i).BackColor = Color.Yellow
                        Next
                    Case "ver"
                        For i = 0 To Questions(currentQuestion).length - 1
                            crosswordFrm.labels(Questions(currentQuestion).startX + i, Questions(currentQuestion).startY).BackColor = Color.Yellow
                        Next
                End Select
            Catch ex As Exception
                'Dirty, only to supress indexOutOfRange exception
            End Try
        End If

        'Start polling if crossword round. for other buzzer rounds, polling starts in Next Question
        If currentRound = "crossword" Then
            polling = True
        End If

    End Sub

    'Next Question
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Next Question
        Try
            tBoxQuestion.Text = Questions(currentQuestion).Question
            tBoxAnswer.Text = Questions(currentQuestion).Answer

            qAnswered.Checked = False
            questionWasPassed = False

            'Show Question in display form
            Select Case currentRound
                Case "hangman"
                    crQuestionPoints = CInt(QuestionsDoc.ChildNodes(0).Attributes("qPoints").Value)
                    commonInterface.showQuestion(Questions(currentQuestion).Question & "#" & Questions(currentQuestion).Answer)
                Case "highstakes"
                    'Note that TeamQuestions list is different that Questions list
                    commonInterface.showQuestion(teamQuestions(currentQuestion).Question)
                    tBoxQuestion.Text = teamQuestions(currentQuestion).Question
                    tBoxAnswer.Text = teamQuestions(currentQuestion).Answer
                Case "wheeloffortune"
                    tBoxQuestion.Text = getCurrentCatQuestion()
                    commonInterface.showQuestion(tBoxQuestion.Text)
                    tBoxAnswer.Text = getCurrentCatAnswer()
                Case Else
                    commonInterface.showQuestion(Questions(currentQuestion).Question)
            End Select

            'Start Timer
            crTimeCount = crTimerDuration

            If Not currentRound = "audio" And Not currentRound = "video" Then
                globalTmr.Start()
            End If

            If isBuzzerRound And Not currentRound = "crossword" Then
                polling = True
            End If

            passCounter = 4
            btnPass.Enabled = True
            questionNumber.Text = (currentQuestion + 1).ToString

            'Disable Next Question button when reached last question
            If currentRound = "highstakes" Then
                If currentQuestion + 1 = teamQuestions.Count Then
                    Button3.Enabled = False
                End If
            Else
                If currentQuestion + 1 = Questions.Count Then
                    Button3.Enabled = False
                End If
            End If
        Catch ex As Exception
            log("Error:Form1-NextQuestion " & ex.Message)
        End Try

    End Sub

    'For WOF Round. Get selected category from Combobox and return its question
    Private Function getCurrentCatQuestion() As String
        'For WOF Round. Get selected category from Combobox and return its question
        Dim catIndex As Short = cmbWofCat.SelectedIndex
        Dim tempQuest As Question = Nothing 'dagerous
        For Each Quest As Question In Questions
            If Quest.wofCat = catIndex Then
                tempQuest = New Question(Quest.Question, Quest.Answer)
                Exit For
            End If
        Next
        Return tempQuest.Question
    End Function

    'For WOF Round. Get selected category from Combobox and return its answer
    Private Function getCurrentCatAnswer() As String 'BAD. Should have used string array in above function. but it works and dont touch it
        'For WOF Round. Get selected category from Combobox and return its answer
        Dim catIndex As Short = cmbWofCat.SelectedIndex
        Dim tempQuest As Question = Nothing 'dagerous
        For Each Quest As Question In Questions
            If Quest.wofCat = catIndex Then
                tempQuest = New Question(Quest.Question, Quest.Answer)
                Exit For
            End If
        Next
        Return tempQuest.Answer

    End Function

    'Pass Question
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        'Pass Question
        If passCounter > 1 Then
            Select Case currentTeam
                Case "TeamA"
                    setCurrentTeam(teamButtons(1), Nothing)
                    log("was passed to: TeamB")
                Case "TeamB"
                    setCurrentTeam(teamButtons(2), Nothing)
                    log("was passed to: TeamC")
                Case "TeamC"
                    setCurrentTeam(teamButtons(3), Nothing)
                    log("was passed to: TeamD")
                Case "TeamD"
                    setCurrentTeam(teamButtons(0), Nothing)
                    log("was passed to: TeamA")
                Case Else
            End Select
            questionWasPassed = True
            passCounter -= 1
            stopGlobalTmr()
        End If
        If passCounter = 1 Then
            btnPass.Enabled = False
        End If
    End Sub

    'Finalize Question. Answered or unanswered. Add/Less Points and Move to next question.
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If qAnswered.Checked Then 'If correct answer was given
            If questionWasPassed Then
                cRoundPoints(currentTeam) += crQuestionPassPoints
                sLog(currentRound & ":Q:" & currentQuestion + 1 & currentTeam & "+" & crQuestionPassPoints)
            Else
                cRoundPoints(currentTeam) += crQuestionPoints
                sLog(currentRound & ":Q:" & currentQuestion + 1 & currentTeam & "+" & crQuestionPoints)
                If currentRound = "highstakes" Then 'increment points if its a correct answer
                    crQuestionPoints += 10
                End If
            End If
        Else ' If has negative points
            'Deduct points from team score
            If Not currentTeam = String.Empty Then
                cRoundPoints(currentTeam) -= crQuestionNegativePoints
                If currentRound = "highstakes" Then 'Reset points to 10
                    crQuestionPoints = 10
                    crTeamTries += 1
                    log(currentTeam & " lost a try")
                    If crTeamTries = 2 Then
                        Button3.Enabled = False 'Disable next question button
                    End If
                End If
                sLog(currentRound & ":Q:" & currentQuestion + 1 & " " & currentTeam & "-" & crQuestionNegativePoints)
            End If
            sLog(currentRound & ":Q:" & currentQuestion + 1 & " UnAnswered")
        End If
        updateScoresOnControlPanel()
        currentQuestion += 1
    End Sub

    'Rapidfire round finalize team points
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            Dim rightAnswers As Integer = CInt(txtCorrectAnswers.Text)
            Dim points As Integer = rightAnswers * 10

            If rightAnswers >= 5 Then
                If rightAnswers >= 10 Then
                    points += 30
                Else
                    If rightAnswers <= 7 Then
                        points += 10
                    Else
                        points += 20
                    End If
                End If
            End If

            cRoundPoints(currentTeam) += points

            updateScoresOnControlPanel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Display answer to public
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        stopGlobalTmr()

        If currentRound = "crossword" Then
            'why crossword answer is set from main form and NOT from inside crossword form ?
            'I'd have to make Questions() public or send details as argument
            'For sending answer as argument, I'd have to change definition of showAnswer() in interface
            'and then in every form. Kind of useless work
            'and this works
            Select Case Questions(currentQuestion).Direction
                Case "hor"
                    For i = 0 To Questions(currentQuestion).length - 1
                        With crosswordFrm.labels(Questions(currentQuestion).startX, Questions(currentQuestion).startY + i)
                            .BackColor = Color.White
                            .Text = Questions(currentQuestion).Answer(i)
                        End With
                    Next
                Case "ver"
                    For i = 0 To Questions(currentQuestion).length - 1
                        With crosswordFrm.labels(Questions(currentQuestion).startX + i, Questions(currentQuestion).startY)
                            .BackColor = Color.White
                            .Text = Questions(currentQuestion).Answer(i)
                        End With
                    Next
            End Select
        End If

        'Following is needed because highstakes questions are in different list
        If currentRound = "highstakes" Then
            commonInterface.showAnswer(teamQuestions(currentQuestion).Answer)
        ElseIf roundIsWof Then 'because WOF questions are random
            commonInterface.showAnswer(tBoxAnswer.Text)
        Else
            commonInterface.showAnswer(Questions(currentQuestion).Answer)
        End If
    End Sub

    'Display flash presentation
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            flashForm = New frmSwfForm
            flashForm.filepath = Application.StartupPath & "\flash\" & currentRound & ".swf"
            flashForm.MdiParent = containerForm
            closePreviousForm()
            flashForm.Show()
            Button8.Enabled = False
            Button9.Enabled = True
        Catch ex As Exception
            MsgBox("Display Form is missing !")
        End Try
    End Sub

    'End Round
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        pointsTable.Rows.Add(New Object() {pointsTable.Rows.Count, cRoundPoints("TeamA"), cRoundPoints("TeamB"), cRoundPoints("TeamC"), _
                                          cRoundPoints("TeamD")})
        refreshWholeRoundScores()
    End Sub

    'Refresh Scores button
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        refreshWholeRoundScores()
    End Sub

    'Fetch the column total from pointsTable and show it on scoresLabel
    Private Sub refreshWholeRoundScores()
        scoresLabelTeamA.Text = getColumnTotal("TeamA")
        scoresLabelTeamB.Text = getColumnTotal("TeamB")
        scoresLabelTeamC.Text = getColumnTotal("TeamC")
        scoresLabelTeamD.Text = getColumnTotal("TeamD")
    End Sub

    'Clear Application Log
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Clear Application Log
        appLog.Items.Clear()
    End Sub

    'Save Application Log
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim logString As String = ""
        For Each item In appLog.Items
            logString = vbCrLf & item.ToString & logString
        Next
        IO.File.AppendAllText(Application.StartupPath & "\Rounds\" & currentStage & Date.Now.ToShortDateString & "-applicationLog.txt", logString)
        logString = Nothing
    End Sub

    'Show Scores Form to public
    Dim teamCounter As Integer 'to manage showing scores one by one
    Dim sortedPoints As New Dictionary(Of String, Integer)
    Dim scoresForm As frmScores

    'Show Scores Form
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        closePreviousForm()
        teamCounter = 0

        getTeamPointsSorted()

        scoresForm = New frmScores
        scoresForm.MdiParent = containerForm
        scoresForm.Show()

    End Sub

    'Show Team Scores
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        scoresForm.AxShockwaveFlash1.SendToBack() 'To make labels visible
        Select Case teamCounter
            Case 0
                scoresForm.lblRank4Name.Text = sortedPoints.Keys(teamCounter)
                scoresForm.lblRank4Points.Text = sortedPoints(sortedPoints.Keys(teamCounter))
            Case 1
                scoresForm.lblRank3Name.Text = sortedPoints.Keys(teamCounter)
                scoresForm.lblRank3Points.Text = sortedPoints(sortedPoints.Keys(teamCounter))
            Case 2
                scoresForm.lblRank2Name.Text = sortedPoints.Keys(teamCounter)
                scoresForm.lblRank2Points.Text = sortedPoints(sortedPoints.Keys(teamCounter))
            Case 3
                scoresForm.lblRank1Name.Text = sortedPoints.Keys(teamCounter)
                scoresForm.lblRank1Points.Text = sortedPoints(sortedPoints.Keys(teamCounter))
        End Select
        teamCounter += 1
    End Sub

    Private Structure teamPointsStruct
        Dim teamName As String
        Dim teamPoints As Integer
    End Structure

    'Prepare sorted points dictionary to show points one by one
    Private Sub getTeamPointsSorted()
        Dim pointsStruct(4) As teamPointsStruct

        pointsStruct(0).teamName = "TeamA"
        pointsStruct(0).teamPoints = getColumnTotal("TeamA")
        pointsStruct(1).teamName = "TeamB"
        pointsStruct(1).teamPoints = getColumnTotal("TeamB")
        pointsStruct(2).teamName = "TeamC"
        pointsStruct(2).teamPoints = getColumnTotal("TeamC")
        pointsStruct(3).teamName = "TeamD"
        pointsStruct(3).teamPoints = getColumnTotal("TeamD")

        Dim tempStruct As teamPointsStruct
        For i As Integer = 0 To 3
            For j As Integer = i + 1 To 3
                If pointsStruct(i).teamPoints > pointsStruct(j).teamPoints Then
                    tempStruct = pointsStruct(i)
                    pointsStruct(i) = pointsStruct(j)
                    pointsStruct(j) = tempStruct
                End If
            Next
        Next

        sortedPoints.Clear()
        For k As Integer = 0 To 3
            sortedPoints.Add(pointsStruct(k).teamName, pointsStruct(k).teamPoints)
        Next

        'For l As Integer = 0 To 3
        '    Debug.WriteLine(sortedPoints.Keys(l) & ":" & sortedPoints(sortedPoints.Keys(l)))
        'Next

    End Sub

    'Show Container Form again if it was closed
    Private Sub ShowDisplayFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowDisplayFormToolStripMenuItem.Click
        If Not containerForm.Visible Then
            containerForm = New frmContainer
            containerForm.Show()
        Else
            containerForm.BringToFront()
        End If
    End Sub

    'Show Round Builder Form
    Private Sub RoundBuilderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoundBuilderToolStripMenuItem.Click
        Dim rndBuilder As New frmRoundBuilder
        rndBuilder.Show()
    End Sub

    'Custom Start Timer
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            If txtTimerStartValue.ReadOnly And currentRound = "rapidfire" Then
                commonInterface.showQuestion(crTimerDuration)
            Else
                If currentRound = "rapidfire" Then
                    commonInterface.showQuestion(txtTimerStartValue.Text) 'Rapidshare form has its own timer
                Else
                    If Not txtTimerStartValue.ReadOnly Then
                        crTimeCount = CInt(txtTimerStartValue.Text) 'Set timer duration for glablaTmr
                        globalTmr.Start()
                    Else 'reach here if round is not Rapidfire and Textbox is still readonly
                        MsgBox("Set timer duration first." & vbCrLf & _
                               "Double Click on textbox to Enable Writing", MsgBoxStyle.Information, _
                               "Timer Start is not set")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Force stopping timer
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If currentRound = "rapidfire" Then
            commonInterface.showQuestion(String.Empty) 'frmRapidfire stops timer on receiving string.empty
        End If
        If globalTmr.Enabled Then
            globalTmr.Stop()
        End If
    End Sub

    'Enable or Disable Custom timer start textbox on double click
    Private Sub txtTimerStartValue_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTimerStartValue.DoubleClick
        txtTimerStartValue.ReadOnly = Not txtTimerStartValue.ReadOnly
        txtTimerStartValue.Text = "Custom Timer"
    End Sub

    'Show Buzzer setupDialog
    Private Sub BuzzerSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuzzerSettingsToolStripMenuItem.Click
        Dim buzzerForm As New frmBuzzerSetup
        buzzerForm.ShowDialog()
    End Sub

    'Force Start Polling
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        polling = True
    End Sub

    'Force Stop Polling
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        polling = False
    End Sub

    'Get buzzer control
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        gainBuzzerControl()
    End Sub

    'Show form to edit scores
    Private Sub EditScoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditScoresToolStripMenuItem.Click
        Dim editScoresForm As New frmEditScores
        If editScoresForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            refreshWholeRoundScores()
        End If
    End Sub

    'Force close Form
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If commonInterface IsNot Nothing Then
            commonInterface.closeMe()
        End If
    End Sub

    'Exit toolstrip menu item
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'About menu item
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abtForm As New frmAbout
        abtForm.ShowDialog()
    End Sub

#End Region


End Class