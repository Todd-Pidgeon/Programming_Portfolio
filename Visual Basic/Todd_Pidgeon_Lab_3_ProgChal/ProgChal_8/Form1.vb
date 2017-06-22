Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decFahrenheit As Decimal

        Try
            decFahrenheit = CDec(1.8) * CDec(txtCelsius.Text) + 32

            lblFahrenheit.Text = decFahrenheit.ToString("")
        Catch
            MessageBox.Show("Input must be a valid numeric value.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
