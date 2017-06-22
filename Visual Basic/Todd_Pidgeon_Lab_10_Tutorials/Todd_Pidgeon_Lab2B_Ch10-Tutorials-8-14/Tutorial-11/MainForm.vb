' Author: Todd Pidgeon
' Date: 02-22-2017
' Purpose: Lab 2 10-11

Public Class MainForm
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMembershipListAll_Click(sender As Object, e As EventArgs) Handles mnuMembershipListAll.Click
        ' Create an instance of AllMembersForm
        Dim frmAllMembers As New AllMembersForm

        ' Display the form. 
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub mnuMembershipAdd_Click(sender As Object, e As EventArgs) Handles mnuMembershipAdd.Click
        ' Create an instance of AddMemberForm
        Dim frmAddMember As New AddMemberForm

        ' Display the form. 
        frmAddMember.ShowDialog()
    End Sub
End Class
