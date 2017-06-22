Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decOriginalPrice As Decimal = 0
        Dim decDiscountPercentage As Decimal = 0
        Dim decDiscountAmount As Decimal = 0
        Dim decSalePrice As Decimal = 0

        ' Get the item's original price.
        decOriginalPrice = CDec(txtOriginalPrice.Text)

        ' Get the discount percentage.
        decDiscountPercentage = CDec(txtDiscountPercentage.Text)

        'Move the percentage's decimal point left 2 spaces.
        decDiscountPercentage = decDiscountPercentage / 100

        ' Calculate the amount of the discount.
        decDiscountAmount = decOriginalPrice * decDiscountPercentage

        ' Calculate the sales price.
        decSalePrice = decOriginalPrice - decDiscountAmount

        ' Display the sale price.
        lblSalePrice.Text = decSalePrice.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
