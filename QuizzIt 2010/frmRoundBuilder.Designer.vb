<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoundBuilder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoundBuilder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRoundNegativePoints = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.chkBuzzerRound = New System.Windows.Forms.CheckBox
        Me.txtTimerDuration = New System.Windows.Forms.TextBox
        Me.txtRoundPassPoints = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtRoundPoints = New System.Windows.Forms.TextBox
        Me.txtMainQuestion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbRoundSubType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbRoundType = New System.Windows.Forms.ComboBox
        Me.txtRoundName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbTeamName = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblQuestNo = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbAnswerDirection = New System.Windows.Forms.ComboBox
        Me.txtAnswerLength = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtStartY = New System.Windows.Forms.TextBox
        Me.txtStartX = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtQuestion = New System.Windows.Forms.TextBox
        Me.btnAppendQuestion = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblTotalQuestions = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.OpenRoundFile = New System.Windows.Forms.OpenFileDialog
        Me.SaveRoundFile = New System.Windows.Forms.SaveFileDialog
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtWofCat = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRoundNegativePoints)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.chkBuzzerRound)
        Me.GroupBox1.Controls.Add(Me.txtTimerDuration)
        Me.GroupBox1.Controls.Add(Me.txtRoundPassPoints)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtRoundPoints)
        Me.GroupBox1.Controls.Add(Me.txtMainQuestion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbRoundSubType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbRoundType)
        Me.GroupBox1.Controls.Add(Me.txtRoundName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Round Details"
        '
        'txtRoundNegativePoints
        '
        Me.txtRoundNegativePoints.Location = New System.Drawing.Point(563, 51)
        Me.txtRoundNegativePoints.Name = "txtRoundNegativePoints"
        Me.txtRoundNegativePoints.Size = New System.Drawing.Size(51, 20)
        Me.txtRoundNegativePoints.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(478, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "NegativePoints"
        '
        'chkBuzzerRound
        '
        Me.chkBuzzerRound.AutoSize = True
        Me.chkBuzzerRound.Location = New System.Drawing.Point(395, 107)
        Me.chkBuzzerRound.Name = "chkBuzzerRound"
        Me.chkBuzzerRound.Size = New System.Drawing.Size(112, 17)
        Me.chkBuzzerRound.TabIndex = 16
        Me.chkBuzzerRound.Text = "is Buzzer Round ?"
        Me.chkBuzzerRound.UseVisualStyleBackColor = True
        '
        'txtTimerDuration
        '
        Me.txtTimerDuration.Location = New System.Drawing.Point(88, 105)
        Me.txtTimerDuration.Name = "txtTimerDuration"
        Me.txtTimerDuration.Size = New System.Drawing.Size(206, 20)
        Me.txtTimerDuration.TabIndex = 7
        '
        'txtRoundPassPoints
        '
        Me.txtRoundPassPoints.Location = New System.Drawing.Point(395, 78)
        Me.txtRoundPassPoints.Name = "txtRoundPassPoints"
        Me.txtRoundPassPoints.Size = New System.Drawing.Size(219, 20)
        Me.txtRoundPassPoints.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Timer Duration"
        '
        'txtRoundPoints
        '
        Me.txtRoundPoints.Location = New System.Drawing.Point(395, 52)
        Me.txtRoundPoints.Name = "txtRoundPoints"
        Me.txtRoundPoints.Size = New System.Drawing.Size(51, 20)
        Me.txtRoundPoints.TabIndex = 11
        '
        'txtMainQuestion
        '
        Me.txtMainQuestion.Location = New System.Drawing.Point(395, 25)
        Me.txtMainQuestion.Name = "txtMainQuestion"
        Me.txtMainQuestion.Size = New System.Drawing.Size(219, 20)
        Me.txtMainQuestion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Points after Pass"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Points"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Main Question"
        '
        'cmbRoundSubType
        '
        Me.cmbRoundSubType.FormattingEnabled = True
        Me.cmbRoundSubType.Items.AddRange(New Object() {"none", "audio", "video"})
        Me.cmbRoundSubType.Location = New System.Drawing.Point(88, 78)
        Me.cmbRoundSubType.Name = "cmbRoundSubType"
        Me.cmbRoundSubType.Size = New System.Drawing.Size(206, 21)
        Me.cmbRoundSubType.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sub Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type"
        '
        'cmbRoundType
        '
        Me.cmbRoundType.FormattingEnabled = True
        Me.cmbRoundType.Items.AddRange(New Object() {"general", "image", "media", "crossword", "hangman", "highstakes", "WOF"})
        Me.cmbRoundType.Location = New System.Drawing.Point(88, 51)
        Me.cmbRoundType.Name = "cmbRoundType"
        Me.cmbRoundType.Size = New System.Drawing.Size(206, 21)
        Me.cmbRoundType.TabIndex = 3
        '
        'txtRoundName
        '
        Me.txtRoundName.Location = New System.Drawing.Point(88, 25)
        Me.txtRoundName.Name = "txtRoundName"
        Me.txtRoundName.Size = New System.Drawing.Size(206, 20)
        Me.txtRoundName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtWofCat)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmbTeamName)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblQuestNo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.cmbAnswerDirection)
        Me.GroupBox2.Controls.Add(Me.txtAnswerLength)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtStartY)
        Me.GroupBox2.Controls.Add(Me.txtStartX)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAnswer)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtQuestion)
        Me.GroupBox2.Controls.Add(Me.btnAppendQuestion)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 248)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Question Details"
        '
        'cmbTeamName
        '
        Me.cmbTeamName.FormattingEnabled = True
        Me.cmbTeamName.Items.AddRange(New Object() {"TeamA", "TeamB", "TeamC", "TeamD"})
        Me.cmbTeamName.Location = New System.Drawing.Point(224, 22)
        Me.cmbTeamName.Name = "cmbTeamName"
        Me.cmbTeamName.Size = New System.Drawing.Size(121, 21)
        Me.cmbTeamName.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(72, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "For Highstakes Round Only - "
        '
        'lblQuestNo
        '
        Me.lblQuestNo.AutoSize = True
        Me.lblQuestNo.Location = New System.Drawing.Point(474, 25)
        Me.lblQuestNo.Name = "lblQuestNo"
        Me.lblQuestNo.Size = New System.Drawing.Size(89, 13)
        Me.lblQuestNo.TabIndex = 30
        Me.lblQuestNo.Text = "Question Number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(569, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "0"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(176, 201)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(509, 201)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete Question"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(398, 201)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 23)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update Question"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Grid"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbAnswerDirection
        '
        Me.cmbAnswerDirection.FormattingEnabled = True
        Me.cmbAnswerDirection.Items.AddRange(New Object() {"hor", "ver"})
        Me.cmbAnswerDirection.Location = New System.Drawing.Point(121, 167)
        Me.cmbAnswerDirection.Name = "cmbAnswerDirection"
        Me.cmbAnswerDirection.Size = New System.Drawing.Size(51, 21)
        Me.cmbAnswerDirection.TabIndex = 9
        '
        'txtAnswerLength
        '
        Me.txtAnswerLength.Location = New System.Drawing.Point(121, 141)
        Me.txtAnswerLength.Name = "txtAnswerLength"
        Me.txtAnswerLength.Size = New System.Drawing.Size(51, 20)
        Me.txtAnswerLength.TabIndex = 7
        Me.txtAnswerLength.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(66, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Direction"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(66, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Length"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(204, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "StartY"
        '
        'txtStartY
        '
        Me.txtStartY.Location = New System.Drawing.Point(246, 170)
        Me.txtStartY.Name = "txtStartY"
        Me.txtStartY.Size = New System.Drawing.Size(51, 20)
        Me.txtStartY.TabIndex = 13
        Me.txtStartY.Text = "0"
        '
        'txtStartX
        '
        Me.txtStartX.Location = New System.Drawing.Point(246, 141)
        Me.txtStartX.Name = "txtStartX"
        Me.txtStartX.Size = New System.Drawing.Size(51, 20)
        Me.txtStartX.TabIndex = 11
        Me.txtStartX.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(204, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "StartX"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(75, 106)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(539, 20)
        Me.txtAnswer.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Answer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Question"
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(75, 54)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(539, 42)
        Me.txtQuestion.TabIndex = 3
        '
        'btnAppendQuestion
        '
        Me.btnAppendQuestion.Location = New System.Drawing.Point(287, 201)
        Me.btnAppendQuestion.Name = "btnAppendQuestion"
        Me.btnAppendQuestion.Size = New System.Drawing.Size(105, 23)
        Me.btnAppendQuestion.TabIndex = 18
        Me.btnAppendQuestion.Text = "Add Question"
        Me.btnAppendQuestion.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalQuestions)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 431)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 72)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tasks"
        '
        'lblTotalQuestions
        '
        Me.lblTotalQuestions.AutoSize = True
        Me.lblTotalQuestions.Location = New System.Drawing.Point(102, 27)
        Me.lblTotalQuestions.Name = "lblTotalQuestions"
        Me.lblTotalQuestions.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalQuestions.TabIndex = 1
        Me.lblTotalQuestions.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Total Questions - "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save Round"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.toolStripSeparator, Me.ToolStripLabel1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(658, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = "Navigation"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.DataContainer_MoveFirstHS
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources.DataContainer_MovePreviousHS
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.WindowsApplication1.My.Resources.Resources.DataContainer_MoveNextHS
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.WindowsApplication1.My.Resources.Resources.DataContainer_MoveLastHS
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'OpenRoundFile
        '
        Me.OpenRoundFile.Filter = """XML Files | *.xml|All Files | *.*"""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(392, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "WOF Category Index"
        '
        'txtWofCat
        '
        Me.txtWofCat.Location = New System.Drawing.Point(504, 141)
        Me.txtWofCat.Name = "txtWofCat"
        Me.txtWofCat.Size = New System.Drawing.Size(51, 20)
        Me.txtWofCat.TabIndex = 16
        Me.txtWofCat.Text = "0"
        '
        'frmRoundBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 515)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRoundBuilder"
        Me.Text = "RoundBuilder - QuizIt2010"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbRoundSubType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRoundType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRoundName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoundPassPoints As System.Windows.Forms.TextBox
    Friend WithEvents txtRoundPoints As System.Windows.Forms.TextBox
    Friend WithEvents txtMainQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAppendQuestion As System.Windows.Forms.Button
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents cmbAnswerDirection As System.Windows.Forms.ComboBox
    Friend WithEvents txtAnswerLength As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtStartY As System.Windows.Forms.TextBox
    Friend WithEvents txtStartX As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotalQuestions As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenRoundFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblQuestNo As System.Windows.Forms.Label
    Friend WithEvents txtTimerDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SaveRoundFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkBuzzerRound As System.Windows.Forms.CheckBox
    Friend WithEvents txtRoundNegativePoints As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbTeamName As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtWofCat As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
