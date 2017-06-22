' Author: Todd Pidgeon
' Date: 02-22-2017
' Purpose: Lab 2 10-10

Public Class AllMembersForm
    Private Sub AllMembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllMembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.AllMembersDataSet.Members)

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Me.MembersTableAdapter.Update(Me.AllMembersDataSet.Members)
    End Sub

    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub
End Class