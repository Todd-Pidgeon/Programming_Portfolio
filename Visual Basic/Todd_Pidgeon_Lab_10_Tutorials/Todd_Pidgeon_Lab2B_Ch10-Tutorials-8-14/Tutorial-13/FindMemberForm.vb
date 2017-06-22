' Author: Todd Pidgeon
' Date: 02-22-2017
' Purpose: Lab 2 10-13

Public Class FindMemberForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Perform a wildcard search for last name.
        Me.MembersTableAdapter.Fill(Me.FindMemberDataSet.Members, txtLastName.Text)
    End Sub
End Class