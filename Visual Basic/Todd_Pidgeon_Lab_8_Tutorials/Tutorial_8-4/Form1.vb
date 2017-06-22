Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  06/12/2016
    ' Description: Tutorial 8-4
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Array with the names of the months
        Dim strMonths() As String = {"January", "February", "March",
            "April", "May", "June", "July", "August", "September",
            "October", "Novemeber", "December"}

        ' Array with the days of each month
        Dim intDays() As Integer = {31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31}

        ' Display a list of the months and days.
        For intCount As Integer = 0 To strMonths.Length - 1
            lstOutput.Items.Add(strMonths(intCount) & " has " &
                                intDays(intCount).ToString() & " days.")
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
