Public Class Form1
    Const dblGRAVITY As Double = 9.8
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intTime As Integer
        Dim dblDistance As Double

        If Integer.TryParse(txtTime.Text, intTime) = False Then
            MessageBox.Show("Enter a numeric value.")
        End If

        dblDistance = FallingDistance(intTime)

        lblDistance.Text = dblDistance.ToString("n2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function FallingDistance(intTime As Integer) As Double
        Dim dblDistance As Double

        dblDistance = 0.5 * (dblGRAVITY * (intTime ^ 2))

        Return dblDistance
    End Function
End Class
