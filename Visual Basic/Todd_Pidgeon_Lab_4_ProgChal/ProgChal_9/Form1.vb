Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intTemp As Integer
        Dim blnInputOk As Boolean = True

        If Integer.TryParse(txtTemp.Text, intTemp) = False Then
            MessageBox.Show("Input must be a number.")
            blnInputOk = False
        End If

        If blnInputOk = True Then
            If intTemp <= -362 Then
                lblFreeze.Text = "Water" & vbNewLine & "Mercury" & vbNewLine & "Ethyl alcohol" & vbNewLine & "Oxygen"
            ElseIf intTemp <= -173 Then
                lblFreeze.Text = "Water" & vbNewLine & "Mercury" & vbNewLine & "Ethyl alcohol"
            ElseIf intTemp <= -38 Then
                lblFreeze.Text = "Water" & vbNewLine & "Mercury"
            ElseIf intTemp <= 32 Then
                lblFreeze.Text = "Water"
            End If

            If intTemp >= 676 Then
                lblBoil.Text = "Water" & vbNewLine & "Mercury" & vbNewLine & "Ethyl alcohol" & vbNewLine & "Oxygen"
            ElseIf intTemp >= 212 Then
                lblBoil.Text = "Water" & vbNewLine & "Ethyl alcohol" & vbNewLine & "Oxygen"
            ElseIf intTemp >= 172 Then
                lblBoil.Text = "Water" & vbNewLine & "Ethyl alcohol"
            ElseIf intTemp >= -306 Then
                lblBoil.Text = "Oxygen"
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTemp.Text = String.Empty
        lblFreeze.Text = String.Empty
        lblBoil.Text = String.Empty
    End Sub
End Class
