Public Class Form1

    Private Sub btnClear_Click() Handles btnClear.Click
        ' Clear the TextBoxes and the Label
        txtSalary.Clear()
        txtYearsOnJob.Clear()
        lblMessage.Text = String.Empty

        ' Give the focus to txtSalary
        txtSalary.Focus()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnCheckQual_Click(sender As Object, e As EventArgs) Handles btnCheckQual.Click
        ' Variables to hold input data.
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer

        Try
            ' Get the user's input.
            dblSalary = CDbl(txtSalary.Text)
            intYearsOnJob = CInt(txtYearsOnJob.Text)

            ' Determin whether the applicant qualifies
            ' for the special loan.
            If dblSalary > 30000 Then
                If intYearsOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify."
                End If
            Else
                If intYearsOnJob > 5 Then
                    lblMessage.Text = "The applicant qualifies."
                Else
                    lblMessage.Text = "The applicant does not qualify."
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
