Public Class Form1
    Private Sub btnCalculate_Click() Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal  ' Annual salary
        Dim intPayPeriods As Integer    ' Number of pay periods
        Dim decSalary As Decimal        ' Salary per pay period

        lblError.Text = String.Empty

        ' Get the annual salary and number of pay periods.
        Try
            decAnnualSalary = CDec(txtAnnualSalary.Text)

            Try
                intPayPeriods = CInt(txtPayPeriods.Text)

                ' Calculate the salary per pay period.
                decSalary = decAnnualSalary / intPayPeriods

                ' Display the salary per pay period.
                lblSalary.Text = decSalary.ToString("c")
            Catch
                lblError.Text = "Pay Periods must be a nonzero " &
                            "numeric value."
            End Try
        Catch
            lblError.Text = "Annual Salary must be a nonzero " &
                            "numeric value."
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
