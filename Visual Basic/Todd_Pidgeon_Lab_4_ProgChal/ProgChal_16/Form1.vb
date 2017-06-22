Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBMI As Decimal
        Dim blnInputOk As Boolean = True

        lblStatus.Text = String.Empty
        Try
            decBMI = CDec(txtWeight.Text) * CDec((703 / CDec(txtHeight.Text) ^ 2))

            lblBMI.Text = decBMI.ToString("n2")
        Catch
            MessageBox.Show("Input must be valid numeric values.")
            blnInputOk = False
        End Try

        If blnInputOk = True Then
            If decBMI >= 18.5 And decBMI <= 25 Then
                lblStatus.Text = "Your weight is optimal."
            ElseIf decBMI < 18.5 Then
                lblStatus.Text = "You are underweight."
            ElseIf decBMI > 25 Then
                lblStatus.Text = "You are overweight."
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblBMI.Text = String.Empty
        lblStatus.Text = String.Empty
    End Sub
End Class
