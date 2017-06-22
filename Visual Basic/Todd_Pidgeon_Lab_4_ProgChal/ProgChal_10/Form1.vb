Public Class Form1

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        Dim strName As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim intIndex As Integer
        Dim blnInputOk As Boolean = True

        strName = txtName.Text

        intIndex = strName.IndexOf(",")

        If intIndex = -1 Then
            MessageBox.Show("Please use a comma between names.")
            blnInputOk = False
        End If

        If blnInputOk = True Then
            strName.Trim()

            strLastName = strName.Substring(0, intIndex)
            strFirstName = strName.Substring(intIndex + 1)

            lblFormatedName.Text = strFirstName + " " + strLastName
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFormatedName.Text = String.Empty
        txtName.Text = String.Empty
    End Sub
End Class
