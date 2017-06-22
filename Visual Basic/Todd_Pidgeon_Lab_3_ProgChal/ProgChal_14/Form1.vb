Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decBMI As Decimal

        Try
            decBMI = CDec(txtWeight.Text) * CDec((703 / CDec(txtHeight.Text) ^ 2))

            lblBMI.Text = decBMI.ToString("n2")
        Catch
            MessageBox.Show("Input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
