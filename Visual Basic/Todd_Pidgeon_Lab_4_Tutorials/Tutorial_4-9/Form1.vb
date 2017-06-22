Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Determine which radio button is selected.
        If radCoffee.Checked = True Then
            lblResult.Text = "You selected coffee"
        ElseIf radTea.Checked = True Then
            lblResult.Text = "You selected tea"
        ElseIf radSoftDrink.Checked = True Then
            lblResult.Text = "You selected a soft drink"
        End If

        ' Determine which check boxes are selected.
        If chkWhipped.Checked = True Then
            lblResult.Text &= ", and Whipped Cream"
        End If

        If chkMoca.Checked = True Then
            lblResult.Text &= ", and Moca"
        End If

        If chkAmaretto.Checked = True Then
            lblResult.Text &= ", and Amaretto"
        End If
    End Sub
End Class
