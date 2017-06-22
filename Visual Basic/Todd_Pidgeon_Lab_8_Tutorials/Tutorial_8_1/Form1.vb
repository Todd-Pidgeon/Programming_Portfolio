Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  06/12/2016
    ' Description: Tutorial 8-1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim intLottery(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        ' Create a Random object
        Dim rand As New Random

        ' Fill the array with random numbers.
        ' Each number will be in the range 0-99.
        For intCount = 0 To intMAX_SUBSCRIPT
            intLottery(intCount) = rand.Next(100)
        Next

        ' Display the array elements in the labels.
        lblFirst.Text = intLottery(0).ToString()
        lblSecond.Text = intLottery(1).ToString()
        lblThird.Text = intLottery(2).ToString()
        lblFourth.Text = intLottery(3).ToString()
        lblFifth.Text = intLottery(4).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
