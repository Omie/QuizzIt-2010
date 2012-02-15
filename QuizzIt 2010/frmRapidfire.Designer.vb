<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRapidfire
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTimer = New iFormControls.iFormSegmentText(Me.components)
        CType(Me.txtTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(843, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimer
        '
        Me.txtTimer.BackColor = System.Drawing.Color.Transparent
        Me.txtTimer.BackColor1 = System.Drawing.Color.Transparent
        Me.txtTimer.BackColor2 = System.Drawing.Color.Transparent
        Me.txtTimer.BorderColor = System.Drawing.Color.Transparent
        Me.txtTimer.BorderWidth = 0
        Me.txtTimer.FadedSegmentAlpha = 255
        Me.txtTimer.FadedSegmentColor = System.Drawing.Color.Transparent
        Me.txtTimer.ForeColor = System.Drawing.Color.Lime
        Me.txtTimer.Location = New System.Drawing.Point(266, 125)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.SegmentCut = 0.5!
        Me.txtTimer.Size = New System.Drawing.Size(476, 480)
        Me.txtTimer.TabIndex = 0
        Me.txtTimer.Text = "00"
        '
        'frmRapidfire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.backlite1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmRapidfire"
        Me.Text = "Rapidfire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTimer As iFormControls.iFormSegmentText
End Class
