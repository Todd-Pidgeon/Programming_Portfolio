Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  08/12/2016
    ' Description: Chapter 8 Programming Challege #1

    'Global Variables
    Const intMAX_SUBSCRIPT As Integer = 9
    Dim intNumbers(intMAX_SUBSCRIPT) As Integer
    Private Sub btnStepOne_Click(sender As Object, e As EventArgs) Handles btnStepOne.Click
        ' Variables
        Dim intCount As Integer

        ' Tell user what to do.
        MessageBox.Show("Enter 10 integer values.")

        ' Get the integer values from the user.
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = InputBox("Enter a integer value.")
        Next

        ' Clear the current list box values
        lstNumbers.Items.Clear()

        ' Display the contents of the array in the list box.
        For intCount = 0 To intMAX_SUBSCRIPT
            lstNumbers.Items.Add(intNumbers(intCount))
        Next
    End Sub

    Private Sub btnStepTwo_Click(sender As Object, e As EventArgs) Handles btnStepTwo.Click
        ' Variables
        Dim intCount As Integer
        Dim intHighest As Integer
        Dim intLowest As Integer

        intHighest = intNumbers(0)
        intLowest = intNumbers(0)

        ' Get the highest value in the array.
        For intCount = 1 To (intMAX_SUBSCRIPT)
            If intNumbers(intCount) > intHighest Then
                intHighest = intNumbers(intCount)
            End If
        Next

        ' Get the lowest value in the array.
        For intCount = 1 To (intMAX_SUBSCRIPT)
            If intNumbers(intCount) < intLowest Then
                intLowest = intNumbers(intCount)
            End If
        Next

        ' Display the highest and lowest in the message box
        lblMessage.Text = "The largest value is " + intHighest.ToString() + " and the smallest value is " + intLowest.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the current list box values and the message box
        lstNumbers.Items.Clear()
        lblMessage.Text = String.Empty
    End Sub
End Class
