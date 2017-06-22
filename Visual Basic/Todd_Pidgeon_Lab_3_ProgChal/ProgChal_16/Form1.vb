Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCalories As Decimal

        Try
            decCalories = CDec(txtCookies.Text) * 75

            lblCalories.Text = decCalories.ToString("n2")
        Catch
            MessageBox.Show("Input must be a valid numeric value.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
