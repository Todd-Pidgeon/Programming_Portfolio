Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  08/12/2016
    ' Description: Chapter 8 Programming Challege #9

    ' Array
    Dim intNumbers(18) As Integer

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        ' Variable
        Dim bolCheck As Boolean

        ' Load the array with valid account numbers
        intNumbers = {5658845, 4520125, 7895122, 8777541, 8451277, 1302850,
                      8080152, 4562555, 5552012, 5050552, 7825877, 1250255,
                      1005231, 6545231, 3852085, 7576651, 7881200, 4581002}

        ' Loop to check if the number entered matches any in the array
        For intCount = 0 To 17
            If txtNumber.Text = intNumbers(intCount) Then
                bolCheck = True
                Exit For
            Else
                bolCheck = False
            End If
        Next

        ' checks the boolean to see if the number is valid or not
        If bolCheck = True Then
            MessageBox.Show("Your Account Number is valid.")
        Else
            MessageBox.Show("Your Account Number is invalid.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close the form
        Me.Close()
    End Sub
End Class
