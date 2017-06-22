Public Class Form1

    Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim decWholesale As Decimal
        Dim decMarkup As Decimal
        Dim decRetailPrice As Decimal
        Dim bolCheck As Boolean

        If Decimal.TryParse(txtWholesale.Text, decWholesale) = False Then
            MessageBox.Show("Enter a possitive numeric value.")
        ElseIf txtWholesale.Text < 0 Then
            MessageBox.Show("Enter a possitive numeric value.")
        ElseIf Decimal.TryParse(txtMarkup.Text, decMarkup) = False Then
            MessageBox.Show("Enter a possitive numeric value.")
        ElseIf txtMarkup.Text < 0 Then
            MessageBox.Show("Enter a possitive numeric value.")
        Else
            bolCheck = True
        End If

        While bolCheck = True
            decRetailPrice = CalculateRetail(decWholesale, decMarkup)

            lblRetailPrice.Text = decRetailPrice.ToString("c")

            bolCheck = False
        End While
    End Sub

    Function CalculateRetail(ByVal decWholesale As Decimal, ByVal decMarkup As Decimal) As Decimal
        Dim decRetail As Decimal

        decMarkup = decMarkup / 100

        decRetail = (decWholesale * decMarkup) + decWholesale

        Return decRetail
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
