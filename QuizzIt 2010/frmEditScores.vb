Public Class frmEditScores
    Dim textboxes(32) As TextBox
    Dim labels(8) As Label
    Private Sub frmEditScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xLoc, yLoc As Short
        xLoc = 10
        yLoc = 12
        For i As Integer = 0 To 7
            labels(i) = New Label
            yLoc += 30
            With labels(i)
                .Location = New Point(xLoc, yLoc)
            End With
            Me.Controls.Add(labels(i))
        Next

        'begin textboxes
        xLoc = 80
        yLoc = 10
        For i As Integer = 0 To 31
            textboxes(i) = New TextBox
            If i Mod 4 = 0 Then
                yLoc += 30
                xLoc = 130
            End If
            With textboxes(i)
                .Location = New Point(xLoc, yLoc)
                .Width = 50
            End With
            xLoc += 70
            Me.Controls.Add(textboxes(i))
        Next
        'fill scores
        fillScores()
    End Sub

    Private Sub fillScores()
        Dim itrCounter As Short = 0
        For i As Integer = 1 To pointsTable.Rows.Count - 1
            Debug.WriteLine(pointsTable.Rows(i).Item(1) & "," & pointsTable.Rows(i).Item(2) & "," & pointsTable.Rows(i).Item(3) & "," _
                            & pointsTable.Rows(i).Item(4) & ",")
            labels(i - 1).Text = pointsTable.Rows(i).Item(0)

            textboxes(0 + itrCounter).Text = pointsTable.Rows(i).Item(1)
            textboxes(1 + itrCounter).Text = pointsTable.Rows(i).Item(2)
            textboxes(2 + itrCounter).Text = pointsTable.Rows(i).Item(3)
            textboxes(3 + itrCounter).Text = pointsTable.Rows(i).Item(4)
            itrCounter += 4
        Next
    End Sub

    'Update scores
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim itrCounter As Short = 1
        For i As Integer = 1 To pointsTable.Rows.Count - 1
            With pointsTable.Rows(i)
                .Item(1) = textboxes(0 + itrCounter).Text 'potential bug should be itrCounter-1
                .Item(2) = textboxes(1 + itrCounter).Text
                .Item(3) = textboxes(2 + itrCounter).Text
                .Item(4) = textboxes(3 + itrCounter).Text
            End With
            itrCounter += 4
        Next
        fillScores()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class