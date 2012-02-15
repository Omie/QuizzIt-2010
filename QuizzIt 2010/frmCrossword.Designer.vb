<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrossword
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtQuestion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTimer = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Location = New System.Drawing.Point(108, 239)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 479)
        Me.Panel3.TabIndex = 5
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestion.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(12, 26)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(800, 184)
        Me.txtQuestion.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(843, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 60)
        Me.Label1.TabIndex = 9
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(873, 219)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 62)
        Me.lblTimer.TabIndex = 10
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCrossword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.backlite1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Name = "frmCrossword"
        Me.Text = "Crossword"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtQuestion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
End Class
