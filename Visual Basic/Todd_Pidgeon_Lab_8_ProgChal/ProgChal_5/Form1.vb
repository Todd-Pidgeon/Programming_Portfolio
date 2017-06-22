Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  08/12/2016
    ' Description: Chapter 8 Programming Challege #5

    Dim intOccupancy(9) As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Set the array to hold the value enter by the user.
        intOccupancy(cboFloor.SelectedItem) = txtOccupied.Text

        ' clear the text box
        txtOccupied.Text = String.Empty
    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click
        ' Variables
        Dim intCount As Integer
        Dim intTotalOccupants As Integer
        Dim decOccRate As Decimal
        Dim decOccRateOverall As Decimal

        ' Display the floor data
        For intCount = 0 To 9
            If intOccupancy(intCount) <> 0 Then
                decOccRate = (intOccupancy(intCount) / 30)

                lstData.Items.Add("Floor " + intCount.ToString + " Rooms Occupied: " + intOccupancy(intCount).ToString + "  Occupancy Rate: " + decOccRate.ToString("p"))
            End If
        Next

        ' Calculate the total room occupancy.
        For intCount = 0 To 9
            intTotalOccupants += intOccupancy(intCount)
        Next

        ' Display the total room occupany.
        lblTotal.Text = intTotalOccupants.ToString

        ' Calculate the overall room occupancy rate.
        decOccRateOverall = intTotalOccupants / 300

        ' Display the overall room occupancy rate.
        lblRate.Text = decOccRateOverall.ToString("p")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form labels
        lstData.Items.Clear()
        lblTotal.Text = String.Empty
        lblRate.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
