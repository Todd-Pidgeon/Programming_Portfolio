Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConference.Click
        ' Create a new conferance form
        Dim frmConference As New ConferenceForm

        decTotal = 0
        frmConference.ShowDialog()
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear all the labels
        txtName.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtState.Clear()
        txtZip.Clear()

        decTotal = 0
        lblTotal.Text = decTotal.ToString("c")
    End Sub
End Class
