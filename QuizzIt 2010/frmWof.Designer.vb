<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWof
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWof))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTimer = New System.Windows.Forms.Label
        Me.txtQuestion = New System.Windows.Forms.Label
        Me.txtAnswer = New System.Windows.Forms.Label
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.IFormAlphaColor1 = New iFormControls.iFormAlphaColor
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(843, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 60)
        Me.Label1.TabIndex = 3
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 35.25!)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(873, 219)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 62)
        Me.lblTimer.TabIndex = 7
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestion.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(12, 9)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(825, 188)
        Me.txtQuestion.TabIndex = 8
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.Transparent
        Me.txtAnswer.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.White
        Me.txtAnswer.Location = New System.Drawing.Point(12, 603)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(786, 118)
        Me.txtAnswer.TabIndex = 9
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(12, 200)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(788, 400)
        Me.AxShockwaveFlash1.TabIndex = 10
        '
        'IFormAlphaColor1
        '
        Me.IFormAlphaColor1.Alpha = 255
        Me.IFormAlphaColor1.Color = System.Drawing.Color.Yellow
        Me.IFormAlphaColor1.Parent = Nothing
        '
        'frmWof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.backlite1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmWof"
        Me.Text = "WheelOfFortune"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents IFormAlphaColor1 As iFormControls.iFormAlphaColor
End Class
