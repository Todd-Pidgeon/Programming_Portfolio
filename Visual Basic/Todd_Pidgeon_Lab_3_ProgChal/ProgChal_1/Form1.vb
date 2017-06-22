Public Class Form1
    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim decMPG As Decimal
        Dim decMiles As Decimal
        Dim decGallons As Decimal

        Try
            decGallons = CDec(txtGallonsCanHold.Text)
            decMiles = CDec(txtMilesCanDrive.Text)
            decMPG = decMiles / decGallons

            lblMilesPerGallon.Text = decMPG.ToString("n2")
        Catch
            MessageBox.Show("Input must be valid numeric Value")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallonsCanHold.Clear()
        txtMilesCanDrive.Clear()
        lblMilesPerGallon.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
