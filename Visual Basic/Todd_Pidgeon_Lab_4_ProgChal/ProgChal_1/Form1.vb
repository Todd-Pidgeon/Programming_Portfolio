Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        ' Variables.
        Dim intA As Integer
        Dim intB As Integer
        Dim blnInputOk As Boolean = True

        ' Validate user input.
        lblAnswer.Text = String.Empty
        If Integer.TryParse(txtA.Text, intA) = False Then
            lblAnswer.Text = "Input must be an Integer."
            blnInputOk = False
        End If

        If Integer.TryParse(txtB.Text, intB) = False Then
            lblAnswer.Text = "Input must be an Integer."
            blnInputOk = False
        End If

        ' Calculate and display comparison.
        If blnInputOk = True Then
            If intA = intB Then
                lblAnswer.Text = "Both values A and B are equal."
            ElseIf intA > intB Then
                lblAnswer.Text = "Value A is greatest."
            ElseIf intB > intA Then
                lblAnswer.Text = "Value B is greatest."
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
