Public Class frmVote
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblSignIn.Click

    End Sub

    Private Sub btnCheckStudentID_Click(sender As Object, e As EventArgs) Handles btnCheckStudentID.Click
        'variables
        Dim id As Double

        'input
        id = CDbl(txtCheckStudentID.Text)

        'process
        If txtCheckStudentID.Text = "900123413" Then
            grpVoting.Visible = True
            grpSignIn.Visible = False
        Else
            MessageBox.Show("StudentID is not valid")
            grpSignIn.Visible = True
        End If
    End Sub


    Private Sub txtCheckStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtCheckStudentID.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        Me.Close()
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        'process
        If rdbCandidate1.Checked = True Then
            rdbCandidate2Confirm.Visible = False
            rdbCandidate1Confirm.Visible = True
            grpConfirmation.Visible = True
            grpVoting.Visible = False
        ElseIf rdbCandidate2.Checked = True Then
            rdbCandidate1Confirm.Visible = False
            rdbCandidate2Confirm.Visible = True
            grpConfirmation.Visible = True
            grpVoting.Visible = False
        ElseIf rdbCandidate1.Checked = False AndAlso rdbCandidate2.Checked = False Then
            MessageBox.Show("You have not selected a candidate to vote for")
        End If
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        grpVoting.Visible = True
        grpConfirmation.Visible = False
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        grpThankYou.Visible = True
        grpConfirmation.Visible = False
    End Sub
End Class
