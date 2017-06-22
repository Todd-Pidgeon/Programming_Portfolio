Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  06/12/2016
    ' Description: Tutorial 8-6
    Private Sub btnDisplayPrice_Click(sender As Object, e As EventArgs) Handles btnDisplayPrice.Click
        ' Variables for the selected row and column
        Dim intRow, intCol As Integer

        ' Constants for the maximum row and column subscripts
        Const intMAX_ROW As Integer = 5
        Const intMAX_COL As Integer = 3

        ' Array with seat prices
        Dim decPrices(,) As Decimal = {{450D, 450D, 450D, 450D},
                                       {425D, 425D, 425D, 425D},
                                       {400D, 400D, 400D, 400D},
                                       {375D, 375D, 375D, 375D},
                                       {375D, 375D, 375D, 375D},
                                       {350D, 350D, 350D, 350D}}
        Try
            ' Get the selected row and column number.
            intRow = CInt(txtRow.Text)
            intCol = CInt(txtCol.Text)

            ' Make sure the row and col are within range.
            If intRow >= 0 And intRow <= intMAX_ROW Then
                If intCol >= 0 And intCol <= intMAX_COL Then
                    ' Display the selected seat's price.
                    lblPrice.Text = decPrices(intRow, intCol).ToString("c")
                Else
                    ' Error message for invalid column.
                    MessageBox.Show("Column must be 0 through " &
                                    intMAX_COL.ToString())
                End If
            Else
                ' Error message for invalid row.
                MessageBox.Show("Row must be 0 through " &
                                    intMAX_ROW.ToString())
            End If
        Catch
            ' Error message for non-integer input.
            MessageBox.Show("Row and Column must be integers.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Clsoe the form
        Me.Close()
    End Sub
End Class
