<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScores))
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.lblRank1Points = New System.Windows.Forms.Label
        Me.lblRank2Points = New System.Windows.Forms.Label
        Me.lblRank3Points = New System.Windows.Forms.Label
        Me.lblRank4Points = New System.Windows.Forms.Label
        Me.lblRank4Name = New System.Windows.Forms.Label
        Me.lblRank3Name = New System.Windows.Forms.Label
        Me.lblRank2Name = New System.Windows.Forms.Label
        Me.lblRank1Name = New System.Windows.Forms.Label
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(1008, 730)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'lblRank1Points
        '
        Me.lblRank1Points.BackColor = System.Drawing.Color.Transparent
        Me.lblRank1Points.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank1Points.Location = New System.Drawing.Point(369, 179)
        Me.lblRank1Points.Name = "lblRank1Points"
        Me.lblRank1Points.Size = New System.Drawing.Size(96, 54)
        Me.lblRank1Points.TabIndex = 1
        Me.lblRank1Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank2Points
        '
        Me.lblRank2Points.BackColor = System.Drawing.Color.Transparent
        Me.lblRank2Points.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank2Points.Location = New System.Drawing.Point(151, 281)
        Me.lblRank2Points.Name = "lblRank2Points"
        Me.lblRank2Points.Size = New System.Drawing.Size(96, 54)
        Me.lblRank2Points.TabIndex = 2
        Me.lblRank2Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank3Points
        '
        Me.lblRank3Points.BackColor = System.Drawing.Color.Transparent
        Me.lblRank3Points.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank3Points.Location = New System.Drawing.Point(571, 347)
        Me.lblRank3Points.Name = "lblRank3Points"
        Me.lblRank3Points.Size = New System.Drawing.Size(96, 54)
        Me.lblRank3Points.TabIndex = 3
        Me.lblRank3Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank4Points
        '
        Me.lblRank4Points.BackColor = System.Drawing.Color.Transparent
        Me.lblRank4Points.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank4Points.Location = New System.Drawing.Point(768, 438)
        Me.lblRank4Points.Name = "lblRank4Points"
        Me.lblRank4Points.Size = New System.Drawing.Size(96, 54)
        Me.lblRank4Points.TabIndex = 4
        Me.lblRank4Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank4Name
        '
        Me.lblRank4Name.BackColor = System.Drawing.Color.Transparent
        Me.lblRank4Name.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank4Name.Location = New System.Drawing.Point(741, 642)
        Me.lblRank4Name.Name = "lblRank4Name"
        Me.lblRank4Name.Size = New System.Drawing.Size(154, 54)
        Me.lblRank4Name.TabIndex = 8
        Me.lblRank4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank3Name
        '
        Me.lblRank3Name.BackColor = System.Drawing.Color.Transparent
        Me.lblRank3Name.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank3Name.Location = New System.Drawing.Point(543, 642)
        Me.lblRank3Name.Name = "lblRank3Name"
        Me.lblRank3Name.Size = New System.Drawing.Size(154, 54)
        Me.lblRank3Name.TabIndex = 7
        Me.lblRank3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank2Name
        '
        Me.lblRank2Name.BackColor = System.Drawing.Color.Transparent
        Me.lblRank2Name.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank2Name.Location = New System.Drawing.Point(119, 642)
        Me.lblRank2Name.Name = "lblRank2Name"
        Me.lblRank2Name.Size = New System.Drawing.Size(154, 54)
        Me.lblRank2Name.TabIndex = 6
        Me.lblRank2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRank1Name
        '
        Me.lblRank1Name.BackColor = System.Drawing.Color.Transparent
        Me.lblRank1Name.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank1Name.Location = New System.Drawing.Point(340, 642)
        Me.lblRank1Name.Name = "lblRank1Name"
        Me.lblRank1Name.Size = New System.Drawing.Size(154, 54)
        Me.lblRank1Name.TabIndex = 5
        Me.lblRank1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.lblRank4Name)
        Me.Controls.Add(Me.lblRank3Name)
        Me.Controls.Add(Me.lblRank2Name)
        Me.Controls.Add(Me.lblRank1Name)
        Me.Controls.Add(Me.lblRank4Points)
        Me.Controls.Add(Me.lblRank3Points)
        Me.Controls.Add(Me.lblRank2Points)
        Me.Controls.Add(Me.lblRank1Points)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.DoubleBuffered = True
        Me.Name = "frmScores"
        Me.Text = "Scores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblRank1Points As System.Windows.Forms.Label
    Friend WithEvents lblRank2Points As System.Windows.Forms.Label
    Friend WithEvents lblRank3Points As System.Windows.Forms.Label
    Friend WithEvents lblRank4Points As System.Windows.Forms.Label
    Friend WithEvents lblRank4Name As System.Windows.Forms.Label
    Friend WithEvents lblRank3Name As System.Windows.Forms.Label
    Friend WithEvents lblRank2Name As System.Windows.Forms.Label
    Friend WithEvents lblRank1Name As System.Windows.Forms.Label
    Public WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
