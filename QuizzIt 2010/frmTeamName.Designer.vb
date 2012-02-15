<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeamName
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
        Me.lblTeamName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTeamName
        '
        Me.lblTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeamName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamName.Location = New System.Drawing.Point(0, 0)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(397, 120)
        Me.lblTeamName.TabIndex = 0
        Me.lblTeamName.Text = "Team A"
        Me.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTeamName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 120)
        Me.Controls.Add(Me.lblTeamName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTeamName"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblTeamName As System.Windows.Forms.Label
End Class
