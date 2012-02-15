Public Class frmTeamName
    Private WithEvents tmr As New Timer
    Private count As Short

    Private Sub frmTeamName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("glass.wav")
        tmr.Interval = 1000
        count = 1
        tmr.Start()
    End Sub
    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmr.Tick
        count += 1
        If count = 3 Then
            tmr.Stop()
            Me.Close()
        End If
    End Sub
End Class