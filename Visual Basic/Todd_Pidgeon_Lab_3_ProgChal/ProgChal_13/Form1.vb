Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decFiveHours As Decimal
        Dim decEightHours As Decimal
        Dim decTwelveHours As Decimal

        Try
            decFiveHours = CDec(txtSpeed.Text) * 5
            decEightHours = CDec(txtSpeed.Text) * 8
            decTwelveHours = CDec(txtSpeed.Text) * 12

            lblFiveHours.Text = decFiveHours.ToString("") + " miles."
            lblEightHours.Text = decEightHours.ToString("") + " miles."
            lblTwelveHours.Text = decTwelveHours.ToString("") + " miles."
        Catch
            MessageBox.Show("Speed Must be a valid numeric value.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
