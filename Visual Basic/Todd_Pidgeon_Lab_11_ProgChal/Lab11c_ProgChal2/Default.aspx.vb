
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharges.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                CDec(txtTelephone.Text) +
                CDec(txtMisc.Text)
            lblAdditionalCharges.Text = decAddCharges.ToString("c")

            ' Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            ' Calculate and Display the tax.
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("c")

            ' Calculate and display the Total charges.
            decTotal = decSubtotal + decTax
            lblTotalCharges.Text = decTotal.ToString("c")
        Catch
            ' Error message
            lblMessage.Text = "All input must be valid numeric values."
        End Try
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load
        ' Get Date
        lblDate.Text = Now.ToString("D")

        ' Get Time
        lblTime.Text = Now.ToString("T")

    End Sub
    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Text = String.Empty
        txtNightlyCharges.Text = String.Empty

        ' Clear the additional charges fields.
        txtRoomService.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtMisc.Text = String.Empty

        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAdditionalCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalCharges.Text = String.Empty

        ' Get today's date from the system and display it.
        lblDate.Text = Now.ToString("D")

        'Get the current time from the system and display it.
        lblTime.Text = Now.ToString("T")

        ' Reset the focus tot he first field.
        txtNights.Focus()
    End Sub
    Protected Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
