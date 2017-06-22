Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Tutorial 7-5
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuColorRed_Click(sender As Object, e As EventArgs) Handles mnuColorRed.Click
        ' Set the label's forground color to red.
        lblMessage.ForeColor = Color.Red
    End Sub

    Private Sub mnuColorGreen_Click(sender As Object, e As EventArgs) Handles mnuColorGreen.Click
        ' Set the label's forground color to green.
        lblMessage.ForeColor = Color.Green
    End Sub

    Private Sub mnuColorBlue_Click(sender As Object, e As EventArgs) Handles mnuColorBlue.Click
        ' Set the label's forground color to blue.
        lblMessage.ForeColor = Color.Blue
    End Sub

    Private Sub mnuColorBlack_Click(sender As Object, e As EventArgs) Handles mnuColorBlack.Click
        ' Set the label's forground color to black.
        lblMessage.ForeColor = Color.Black
    End Sub

    Private Sub mnuColorVisable_Click(sender As Object, e As EventArgs) Handles mnuColorVisable.Click
        ' Make the label visable or invisable
        If mnuColorVisable.Checked = True Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display a simple About box.
        MessageBox.Show("A simple Menu System Demo")
    End Sub
End Class
