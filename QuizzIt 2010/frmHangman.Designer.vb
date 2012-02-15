<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangman
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
        Me.lblTimer = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblAlphaTries = New System.Windows.Forms.Label
        Me.txtQuestion = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 35.25!)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(873, 219)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(77, 62)
        Me.lblTimer.TabIndex = 6
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(843, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(8, 351)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 190)
        Me.Panel2.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(8, 563)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(832, 155)
        Me.Panel4.TabIndex = 7
        '
        'lblAlphaTries
        '
        Me.lblAlphaTries.AutoSize = True
        Me.lblAlphaTries.BackColor = System.Drawing.Color.Transparent
        Me.lblAlphaTries.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlphaTries.ForeColor = System.Drawing.Color.Turquoise
        Me.lblAlphaTries.Location = New System.Drawing.Point(846, 563)
        Me.lblAlphaTries.Name = "lblAlphaTries"
        Me.lblAlphaTries.Size = New System.Drawing.Size(45, 54)
        Me.lblAlphaTries.TabIndex = 0
        Me.lblAlphaTries.Text = "0"
        Me.lblAlphaTries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frmHangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.backlite1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.lblAlphaTries)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Name = "frmHangman"
        Me.Text = "Hangman"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblAlphaTries As System.Windows.Forms.Label
    Friend WithEvents txtQuestion As System.Windows.Forms.Label
End Class
