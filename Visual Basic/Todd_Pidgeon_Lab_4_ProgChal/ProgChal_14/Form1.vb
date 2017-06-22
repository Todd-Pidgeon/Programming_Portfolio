Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decMass As Decimal
        Dim decWeight As Decimal
        Dim blnInputOk As Boolean = True

        lblStatus.Text = String.Empty
        If Decimal.TryParse(txtMass.Text, decMass) = False Then
            lblStatus.Text = "Input must be a number."
            blnInputOk = False
        End If

        If blnInputOk = True Then
            decWeight = decMass * 9.8

            If decWeight > 1000 Then
                lblStatus.Text = "Object is Too heavy."
            ElseIf decWeight < 10 Then
                lblStatus.Text = "Object is Too light."
            Else
                lblWeight.Text = decWeight
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblStatus.Text = String.Empty
        lblWeight.Text = String.Empty
        txtMass.Text = String.Empty
    End Sub
End Class
