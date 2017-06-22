Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        'Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
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
                CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            Try
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
                lblTotal.Text = decTotal.ToString("c")

                ' Change the colours for the total charges.
                lblTotal.BackColor = Color.Blue
                lblTotal.ForeColor = Color.White
            Catch
                ' Error message
                MessageBox.Show("Additional charges information must be valid numeric values.")
            End Try

        Catch
            ' Error message
            MessageBox.Show("Room information must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields.
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAdditionalCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Get today's date from the system and display it.
        lblDateToday.Text = Now.ToString("D")

        'Get the current time from the system and display it.
        lblTimeToday.Text = Now.ToString("T")

        ' Reset the lolTotal control's colors.
        lblTotal.BackColor = SystemColors.Control
        lblTotal.ForeColor = SystemColors.Control

        ' Reset the focus tot he first field.
        txtNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
