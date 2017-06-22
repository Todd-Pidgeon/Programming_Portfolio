Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intNumber As Integer
        Dim bolPrime As Boolean

        If Integer.TryParse(txtNumber.Text, intNumber) = False Then
            MessageBox.Show("Enter a numeric value.")
        End If

        bolPrime = IsPrime(intNumber)

        If bolPrime = True Then
            lblMessage.Text = "Yes"
        Else
            lblMessage.Text = "No"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function IsPrime(intNumber As Integer) As Boolean
        If intNumber < 2 Then
            Return False
        End If

        For i As Integer = 2 To (intNumber - 1)
            If (intNumber Mod i) = 0 Then
                Return False
            End If
        Next

        Return True
    End Function
End Class
