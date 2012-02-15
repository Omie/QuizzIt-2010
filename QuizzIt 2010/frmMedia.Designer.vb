<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedia))
        Me.lblTimer = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtAnswer = New System.Windows.Forms.Label
        Me.txtQuestion = New System.Windows.Forms.Label
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblTimer.TabIndex = 6
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(842, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(800, 90)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel2.Location = New System.Drawing.Point(12, 339)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 90)
        Me.Panel2.TabIndex = 2
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.Transparent
        Me.txtAnswer.Font = New System.Drawing.Font("Segoe UI", 39.75!)
        Me.txtAnswer.ForeColor = System.Drawing.Color.White
        Me.txtAnswer.Location = New System.Drawing.Point(12, 447)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(724, 245)
        Me.txtAnswer.TabIndex = 7
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestion.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(12, 26)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(800, 298)
        Me.txtQuestion.TabIndex = 8
        '
        'frmMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.backlite1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MinimizeBox = False
        Me.Name = "frmMedia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.Label
End Class
