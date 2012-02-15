<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSwfForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSwfForm))
        Me.axFlash = New AxShockwaveFlashObjects.AxShockwaveFlash
        CType(Me.axFlash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'axFlash
        '
        Me.axFlash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.axFlash.Enabled = True
        Me.axFlash.Location = New System.Drawing.Point(0, 0)
        Me.axFlash.Name = "axFlash"
        Me.axFlash.OcxState = CType(resources.GetObject("axFlash.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axFlash.Size = New System.Drawing.Size(1008, 730)
        Me.axFlash.TabIndex = 0
        '
        'frmSwfForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.axFlash)
        Me.Name = "frmSwfForm"
        Me.Text = "frmSwfForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.axFlash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents axFlash As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
