Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCalories As Decimal
        Dim decFat As Decimal
        Dim decCalFromFat As Decimal
        Dim decPercentFromFat As Decimal
        Dim blnInputOk As Boolean = True

        lblError.Text = String.Empty
        If Decimal.TryParse(txtCalories.Text, decCalories) = False Then
            lblError.Text = "Input must be a number."
            blnInputOk = False
        ElseIf txtCalories.Text = 0 Then
            lblError.Text = "Input must not be 0."
            blnInputOk = False
        End If

        If Decimal.TryParse(txtFat.Text, decFat) = False Then
            lblError.Text = "Input must be a number."
            blnInputOk = False
        ElseIf txtFat.Text = 0 Then
            lblError.Text = "Input must not be 0."
            blnInputOk = False
        ElseIf (txtFat.Text * 9) > txtCalories.Text Then
            lblError.Text = "Your input of total calories or fat must be incorrect."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            decCalFromFat = decFat * 9

            decPercentFromFat = (decCalFromFat / decCalories) * 100

            If decPercentFromFat < 30 Then
                lblError.Text = "A low-fat food."
            End If

            lblPercentage.Text = decPercentFromFat.ToString("") + "%"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalories.Text = String.Empty
        txtFat.Text = String.Empty

        lblPercentage.Text = String.Empty
        lblError.Text = String.Empty
    End Sub
End Class
