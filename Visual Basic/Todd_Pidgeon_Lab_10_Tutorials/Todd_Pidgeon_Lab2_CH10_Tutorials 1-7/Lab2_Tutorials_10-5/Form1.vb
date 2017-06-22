Public Class Form1
    ' Author: Todd Pidgeon
    ' Date: 02-22-2017
    ' Purpose: Lab 2 10-5
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub
End Class
