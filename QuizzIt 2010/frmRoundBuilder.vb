Imports System.Xml
Public Class frmRoundBuilder

#Region "InternalClass"
    Private Class Question
        Public Question As String
        Public Answer As String

        'Crossword Specific Details
        Public startX As String
        Public startY As String
        Public Direction As String
        Public length As String

        'Highstakes specific details
        Public teamName As String

        'WOF specific details
        Public wofcat As String

        Public Sub New(ByVal Question As String, ByVal Answers As String, ByVal length As String, ByVal direction As String, _
                       ByVal startX As String, ByVal startY As String, ByVal teamName As String, ByVal wofcat As String)
            Me.Question = Question
            Me.Answer = Answers
            Me.startX = startX
            Me.startY = startY
            Me.Direction = direction
            Me.length = length
            Me.teamName = teamName
            Me.wofcat = wofcat
        End Sub

    End Class

#End Region


    Private Questions As New List(Of Question)
    Dim QuestionsDoc As New XmlDocument
    Dim currentQuestion As Integer

    'Form Load - Set selected indices
    Private Sub frmRoundBuilder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearEveryThing()
    End Sub

    'Create and show Crossword Grid for reference
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New Form
        frm.AutoSize = True
        frm.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        frm.Text = "Crossword Grid"

        Dim xLoc, yLoc As Integer
        Dim labels(10, 10) As Label
        xLoc = 0
        yLoc = 0
        For i = 0 To 9
            For j = 0 To 9
                labels(i, j) = New Label
                With labels(i, j)
                    .Location = New Point(xLoc, yLoc)
                    .Size = New Size(35, 35)
                    .Text = i.ToString & "," & j.ToString
                    .BorderStyle = BorderStyle.FixedSingle

                End With
                xLoc += 35
                frm.Controls.Add(labels(i, j))
            Next
            yLoc += 35
            xLoc = 0
        Next
        frm.Show()
    End Sub

    'Add question into the list
    Private Sub btnAppendQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppendQuestion.Click
        'Add question into the list
        Questions.Add(New Question( _
                      txtQuestion.Text, _
                      txtAnswer.Text, _
                      txtAnswerLength.Text, _
                      cmbAnswerDirection.SelectedItem.ToString, _
                      txtStartX.Text, _
                      txtStartY.Text, _
                      cmbTeamName.SelectedItem.ToString, _
                      txtWofCat.Text))

        lblTotalQuestions.Text = Questions.Count.ToString

        txtQuestion.Text = String.Empty
        txtAnswer.Text = String.Empty
        txtAnswerLength.Text = 0
        cmbAnswerDirection.SelectedIndex = 0
        txtStartX.Text = 0
        txtStartY.Text = 0
        currentQuestion += 1
    End Sub

    'Build XML document and save it
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        QuestionsDoc = New XmlDocument
        Dim mainNode As XmlNode = QuestionsDoc.CreateElement("Questions")

        Dim attrib As XmlAttribute
        attrib = QuestionsDoc.CreateAttribute("type")
        attrib.Value = cmbRoundType.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("subType")
        attrib.Value = cmbRoundSubType.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("mainQuestion")
        attrib.Value = txtMainQuestion.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("qPoints") 'question points
        attrib.Value = txtRoundPoints.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("nPoints") 'negative points
        attrib.Value = txtRoundNegativePoints.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("pPoints") 'points after pass
        attrib.Value = txtRoundPassPoints.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("time")
        attrib.Value = txtTimerDuration.Text
        mainNode.Attributes.Append(attrib)

        attrib = QuestionsDoc.CreateAttribute("buzzer")
        If chkBuzzerRound.Checked Then
            attrib.Value = "yes"
        Else
            attrib.Value = "no"
        End If
        mainNode.Attributes.Append(attrib)

        QuestionsDoc.AppendChild(mainNode)

        Dim questNode As XmlNode
        Dim innerNode As XmlNode
        For Each quest As Question In Questions
            questNode = QuestionsDoc.CreateElement("Question")

            attrib = QuestionsDoc.CreateAttribute("wofcat")
            attrib.Value = quest.wofcat 'quest.wofcat
            questNode.Attributes.Append(attrib)

            attrib = QuestionsDoc.CreateAttribute("team")
            attrib.Value = quest.teamName
            questNode.Attributes.Append(attrib)

            attrib = QuestionsDoc.CreateAttribute("startx")
            attrib.Value = quest.startX
            questNode.Attributes.Append(attrib)

            attrib = QuestionsDoc.CreateAttribute("starty")
            attrib.Value = quest.startY
            questNode.Attributes.Append(attrib)

            attrib = QuestionsDoc.CreateAttribute("length")
            attrib.Value = quest.length
            questNode.Attributes.Append(attrib)

            attrib = QuestionsDoc.CreateAttribute("dir")
            attrib.Value = quest.Direction
            questNode.Attributes.Append(attrib)

            innerNode = mainNode.AppendChild(questNode)

            questNode = QuestionsDoc.CreateElement("Question")
            questNode.InnerText = quest.Question
            innerNode.AppendChild(questNode)

            questNode = QuestionsDoc.CreateElement("Answer")
            questNode.InnerText = quest.Answer
            innerNode.AppendChild(questNode)

        Next
        QuestionsDoc.Save(txtRoundName.Text & ".xml")

        With SaveRoundFile
            .FileName = txtRoundName.Text
            .Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        End With
        If SaveRoundFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.Copy(txtRoundName.Text & ".xml", SaveRoundFile.FileName)
            IO.File.Delete(txtRoundName.Text & ".xml")
        End If

    End Sub

    'Show OpenFileDialog and Load existing Round
    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        If OpenRoundFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            QuestionsDoc.Load(OpenRoundFile.FileName)
            Dim QuestionNodes As XmlNodeList = QuestionsDoc.DocumentElement.SelectNodes("Question")
            Questions.Clear()

            txtRoundName.Text = OpenRoundFile.SafeFileName
            cmbRoundType.SelectedItem = QuestionsDoc.ChildNodes(0).Attributes("type").Value
            cmbRoundSubType.SelectedText = QuestionsDoc.ChildNodes(0).Attributes("subType").Value
            txtMainQuestion.Text = QuestionsDoc.ChildNodes(0).Attributes("mainQuestion").Value
            txtRoundPoints.Text = QuestionsDoc.ChildNodes(0).Attributes("qPoints").Value
            txtRoundPassPoints.Text = QuestionsDoc.ChildNodes(0).Attributes("pPoints").Value
            txtTimerDuration.Text = QuestionsDoc.ChildNodes(0).Attributes("time").Value

            For Each Node As XmlNode In QuestionNodes
                Questions.Add(New Question( _
                              Node.SelectSingleNode("Question").InnerText, _
                              Node.SelectSingleNode("Answer").InnerText, _
                              Node.Attributes("startx").Value, _
                              Node.Attributes("starty").Value, _
                              Node.Attributes("dir").Value, _
                              Node.Attributes("length").Value, _
                              Node.Attributes("team").Value, _
                              Node.Attributes("wofcat").Value))
            Next
            currentQuestion = 0
            updateTextBoxes(currentQuestion)
            lblTotalQuestions.Text = Questions.Count
        End If
    End Sub

    Private Sub updateTextBoxes(ByVal questionNumber As Integer)
        With Questions(questionNumber)
            txtQuestion.Text = .Question
            txtAnswer.Text = .Answer
            txtAnswerLength.Text = .length
            txtStartX.Text = .startX
            txtStartY.Text = .startY
            cmbAnswerDirection.SelectedItem = .Direction
            cmbTeamName.SelectedItem = .teamName
        End With
        Label14.Text = (currentQuestion + 1).ToString
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        currentQuestion = 0
        updateTextBoxes(currentQuestion)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If currentQuestion > 0 Then
            currentQuestion -= 1
            updateTextBoxes(currentQuestion)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If currentQuestion < Questions.Count - 1 Then
            currentQuestion += 1
            updateTextBoxes(currentQuestion)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        currentQuestion = Questions.Count - 1
        updateTextBoxes(currentQuestion)
    End Sub

    'Clear Every freaking thing
    Private Sub clearEveryThing()
        For Each c As Control In GroupBox1.Controls
            If TypeOf c Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        cmbRoundType.SelectedIndex = 0
        cmbRoundSubType.SelectedIndex = 0
        cmbAnswerDirection.SelectedIndex = 0
        currentQuestion = 0
        Questions.Clear()
    End Sub

    'New Round
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        clearEveryThing()
    End Sub

    'Reset question
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        cmbAnswerDirection.SelectedIndex = 0

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        With Questions(currentQuestion)
            .Answer = txtAnswer.Text
            .Direction = cmbAnswerDirection.SelectedItem.ToString
            .length = txtAnswerLength.Text
            .Question = txtQuestion.Text
            .startX = txtStartX.Text
            .startY = txtStartY.Text
        End With
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Questions.RemoveAt(currentQuestion)
        updateTextBoxes(currentQuestion)
    End Sub

End Class