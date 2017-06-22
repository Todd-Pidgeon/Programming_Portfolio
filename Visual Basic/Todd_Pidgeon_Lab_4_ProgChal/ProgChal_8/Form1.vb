Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decMediumSpeed As Decimal
        Dim decDistance As Decimal
        Dim decTimeTraveled As Decimal
        Dim blnInputOk As Boolean = True

        Const decAIR As Decimal = 1100
        Const decWATER As Decimal = 4900
        Const decSTEEL As Decimal = 16400

        If radAir.Checked Then
            decMediumSpeed = decAIR
        ElseIf radWater.Checked Then
            decMediumSpeed = decWATER
        ElseIf radSteel.Checked Then
            decMediumSpeed = decSTEEL
        End If

        lblError.Text = String.Empty
        If Decimal.TryParse(txtDistance.Text, decDistance) = False Then
            lblError.Text = "Input must be a number."
            blnInputOk = False
        ElseIf txtDistance.Text <= 0 Then
            lblError.Text = "Input must be greater than 0."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            decTimeTraveled = decDistance / decMediumSpeed

            lblTime.Text = decTimeTraveled.ToString("n2") + " seconds."
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
