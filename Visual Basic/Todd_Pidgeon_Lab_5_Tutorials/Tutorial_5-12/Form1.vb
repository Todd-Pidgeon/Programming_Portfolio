Public Class Form1
    ' Class-level constants
    Const dblMONTHS_YEAR As Double = 12
    Const dblNEW_RATE As Double = 0.05
    Const dblUSED_RATE As Double = 0.08

    ' Class-level variable to hold the annaul interest rate
    Dim dblAnnualRate As Double = dblNEW_RATE
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblVehicleCost As Double
        Dim dblDownPayment As Double
        Dim intMonths As Integer
        Dim dblLoan As Double
        Dim dblMonthlyPayment As Double
        Dim dblInterest As Double
        Dim dblPrincipal As Double
        Dim intCount As Integer
        Dim strOut As String
        Dim blnInputOk As Boolean = True

        ' Get the vehicle cost, validating at the same time.
        If Not Double.TryParse(txtCost.Text, dblVehicleCost) Then
            lblMessage.Text = "Vehicle cost must be a number"
            blnInputOk = False
        End If

        ' Get the Down Payment, validating at the same time.
        If Not Double.TryParse(txtDownPayment.Text, dblDownPayment) Then
            lblMessage.Text = "Down Payment must be a number"
            blnInputOk = False
        End If

        ' Get the number of months, validating at the same time.
        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            lblMessage.Text = "Months must be a number"
            blnInputOk = False
        End If

        If blnInputOk = True Then
            ' Calculate the loan amount and monthly payment.
            dblLoan = dblVehicleCost - dblDownPayment
            dblMonthlyPayment = Pmt(dblAnnualRate / dblMONTHS_YEAR,
                                    intMonths, -dblLoan)

            ' Clear the list box and message label.
            lstOutput.Items.Clear()
            lblMessage.Text = String.Empty

            For intCount = 1 To intMonths
                ' Calculate the interest for this period.
                dblInterest = IPmt(dblAnnualRate / dblMONTHS_YEAR,
                                   intCount, intMonths, -dblLoan)

                ' Calculate the principal for this period.
                dblPrincipal = PPmt(dblAnnualRate / dblMONTHS_YEAR,
                                   intCount, intMonths, -dblLoan)

                ' Start building the output string with the month.
                strOut = "Month " & intCount.ToString("d2")

                ' Add the payment amount to the output string
                strOut &= ": payment = " & dblMonthlyPayment.ToString("n2")

                ' Add the interest amount to the output string
                strOut &= ": interest = " & dblInterest.ToString("n2")

                ' Add the principal amount to the output string
                strOut &= ": principal = " & dblPrincipal.ToString("n2")

                ' Add the output string to the list box
                lstOutput.Items.Add(strOut)
            Next
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the interest rate.
        dblAnnualRate = dblNEW_RATE

        ' Clear the text boxes
        txtCost.Clear()
        txtDownPayment.Clear()
        txtMonths.Clear()

        ' Clear the list box.
        lstOutput.Items.Clear()

        ' Set default interest rate for new car loans.
        lblAnnualRate.Text = dblNEW_RATE.ToString("p")
        radNew.Checked = True

        ' Clear any error messages.
        lblMessage.Text = String.Empty

        ' Reset the focus to txtCost.
        txtCost.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub radNew_CheckedChanged(sender As Object, e As EventArgs) Handles radNew.CheckedChanged
        ' If the New radio button is checked, then
        ' the user has selected a new car loan.
        If radNew.Checked = True Then
            dblAnnualRate = dblNEW_RATE
            lblAnnualRate.Text = dblNEW_RATE.ToString("p")
            lstOutput.Items.Clear()
        End If
    End Sub

    Private Sub radUsed_CheckedChanged(sender As Object, e As EventArgs) Handles radUsed.CheckedChanged
        ' If the Used radio button is checked, then
        ' the user has selected a Used car loan.
        If radUsed.Checked = True Then
            dblAnnualRate = dblUSED_RATE
            lblAnnualRate.Text = dblUSED_RATE.ToString("p")
            lstOutput.Items.Clear()
        End If
    End Sub
End Class
