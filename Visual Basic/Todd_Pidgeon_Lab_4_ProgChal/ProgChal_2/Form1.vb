Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intInput As Integer

        Try
            intInput = CInt(txtInput.Text)
        Catch
            lblRoman.Text = "Enter a number between 1 and 10."
        End Try


        If intInput = 1 Then
            lblRoman.Text = "I"
        ElseIf intInput = 2 Then
            lblRoman.Text = "II"
        ElseIf intInput = 3 Then
            lblRoman.Text = "III"
        ElseIf intInput = 4 Then
            lblRoman.Text = "IV"
        ElseIf intInput = 5 Then
            lblRoman.Text = "V"
        ElseIf intInput = 6 Then
            lblRoman.Text = "VI"
        ElseIf intInput = 7 Then
            lblRoman.Text = "VII"
        ElseIf intInput = 8 Then
            lblRoman.Text = "VIII"
        ElseIf intInput = 9 Then
            lblRoman.Text = "IX"
        ElseIf intInput = 10 Then
            lblRoman.Text = "X"
        Else
            lblRoman.Text = "Enter a number between 1 and 10."
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
