Public Class frmContainer

    Private Sub frmContainer_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmContainer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each c In Me.Controls
            Try
                Dim mdiCl = DirectCast(c, MdiClient)
                mdiCl.BackgroundImage = My.Resources.quizzit2010
            Catch ex As InvalidCastException
                'ignore
            End Try
        Next
    End Sub
End Class