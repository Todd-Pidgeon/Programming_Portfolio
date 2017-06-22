Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Tutorial 7-2
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		' Clear the list box.
		lstOutput.Items.Clear()
	End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnShowModal_Click(sender As Object, e As EventArgs) Handles btnShowModal.Click
        Dim intCount As Integer
        Dim frmMessage As New MessageForm

        ' Show the message form in modal style.
        frmMessage.ShowDialog()

        ' Display some numbers in the list box on the MainForm.
        ' This will happen AFTER the user closes the MessageForm.
        For intCount = 1 To 10
            lstOutput.Items.Add(intCount.ToString())
        Next
    End Sub

    Private Sub btnShowModeless_Click(sender As Object, e As EventArgs) Handles btnShowModeless.Click
        Dim intCount As Integer
        Dim frmMessage As New MessageForm

        ' Show the message form in modaless style.
        frmMessage.Show()

        ' Display some numbers in the list box on the MainForm.
        ' This will happen while the MessageForm is still on the screen.
        For intCount = 1 To 10
            lstOutput.Items.Add(intCount.ToString())
        Next
    End Sub
End Class
