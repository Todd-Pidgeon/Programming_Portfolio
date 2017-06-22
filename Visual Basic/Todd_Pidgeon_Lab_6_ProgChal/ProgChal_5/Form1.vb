Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUsername As String
        Dim strPassword As String
        Dim bolCheck As Boolean

        strUsername = txtUsername.Text

        strPassword = txtPassword.Text

        bolCheck = IsValid(strPassword)

        If bolCheck = True Then
            lblMessage.ForeColor = Color.Green
            lblMessage.Text = "Password is Valid"
        Else
            lblMessage.ForeColor = Color.Red
            lblMessage.Text = "Password is Invalid"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function IsValid(ByVal strPassword As String) As Boolean

        If strPassword.Length < 6 Then
            Return False
        Else
            For i As Integer = 0 To (strPassword.Length - 1)
                If Char.IsDigit(strPassword, i) = True Then
                    Return True
                End If
            Next
            Return False
        End If
    End Function
End Class
