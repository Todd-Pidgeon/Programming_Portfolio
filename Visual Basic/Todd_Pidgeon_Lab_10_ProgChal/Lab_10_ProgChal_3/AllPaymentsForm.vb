' Author: Todd Pidgeon
' Date: 02-22-2017
' Purpose: Lab 2 10-13

Public Class AllPaymentsForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AllPaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllPaymentsDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.AllPaymentsDataSet.Payments)

    End Sub
End Class