Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Tutorial 7-1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Create an instance of MessageForm.
        Dim frmMessage As New MessageForm

        ' Display the form in modal style.
        frmMessage.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
