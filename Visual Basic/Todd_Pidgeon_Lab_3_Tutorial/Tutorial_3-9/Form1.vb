Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the current date from the syatem.
        Dim dtmSystemDate = Today

        ' Display the date.
        lblDate.Text = dtmSystemDate.ToString("d")
    End Sub
End Class
