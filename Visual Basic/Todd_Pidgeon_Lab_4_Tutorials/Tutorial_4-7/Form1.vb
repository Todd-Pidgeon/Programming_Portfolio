Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text boxes and labels.
        txtAdvancePayAmount.Clear()
        txtSalesAmount.Clear()
        lblCommissionAmount.Text = String.Empty
        lblCommissionRate.Text = String.Empty
        lblNetPay.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Set the focus to txtSalesAmount.
        txtSalesAmount.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variable declarations.
        Dim decSalesAmount As Decimal
        Dim decAdvancePayAmount As Decimal
        Dim decCommissionRate As Decimal
        Dim decCommissionAmount As Decimal
        Dim decNetPay As Decimal

        Try
            ' CLear any previous error messages.
            lblStatus.Text = String.Empty

            ' Get the amount of Sales.
            decSalesAmount = CDec(txtSalesAmount.Text)

            ' Get the amount of advance pay.
            decAdvancePayAmount = CDec(txtAdvancePayAmount.Text)

            ' Determine the commission rate.
            Select Case decSalesAmount
                Case Is < 10000
                    decCommissionRate = 0.05D

                Case 10000 To 14999
                    decCommissionRate = 0.1D

                Case 15000 To 17999
                    decCommissionRate = 0.12D

                Case 18000 To 21999
                    decCommissionRate = 0.14D

                Case Is >= 22000
                    decCommissionRate = 0.15D
            End Select

            ' Calculate the commission and net pay amounts.
            decCommissionAmount = decSalesAmount * decCommissionRate
            decNetPay = decCommissionAmount - decAdvancePayAmount

            ' Display the rate, commission, and net pay.
            lblCommissionRate.Text = decCommissionRate.ToString("p")
            lblCommissionAmount.Text = decCommissionAmount.ToString("c")
            lblNetPay.Text = decNetPay.ToString("c")

        Catch
            ' Display an error message alerting user to invalid input.
            lblStatus.Text = "Please enter numeric values."
        End Try
    End Sub
End Class
