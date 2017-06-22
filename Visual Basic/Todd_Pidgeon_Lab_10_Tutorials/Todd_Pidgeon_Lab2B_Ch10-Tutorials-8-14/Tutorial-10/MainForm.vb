' Author: Todd Pidgeon
' Date: 02-22-2017
' Purpose: Lab 2 10-10

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
End Class
