Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAverage As Decimal
        Dim decWeekOne As Decimal
        Dim decWeekTwo As Decimal
        Dim decWeekThree As Decimal
        Dim decWeekFour As Decimal
        Dim decWeekFive As Decimal

        Try
            decWeekOne = CDec(txtWeekOne.Text)
            decWeekTwo = CDec(txtWeekTwo.Text)
            decWeekThree = CDec(txtWeekThree.Text)
            decWeekFour = CDec(txtWeekFour.Text)
            decWeekFive = CDec(txtWeekFive.Text)

            decAverage = (decWeekOne + decWeekTwo + decWeekThree + decWeekFour + decWeekFive) / 5

            lblAverage.Text = decAverage.ToString("n")

        Catch
            MessageBox.Show("Input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWeekOne.Clear()
        txtWeekTwo.Clear()
        txtWeekThree.Clear()
        txtWeekFour.Clear()
        txtWeekFive.Clear()

        lblAverage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
