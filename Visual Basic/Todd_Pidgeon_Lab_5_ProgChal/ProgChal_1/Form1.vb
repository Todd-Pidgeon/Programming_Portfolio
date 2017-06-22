Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strInputNumber As String
        Dim intNumber As Integer
        Dim DblSum As Double

        strInputNumber = InputBox("Enter a positive integer value.", "Input Needed", "10")

        intNumber = CInt(strInputNumber)

        DblSum = (intNumber * (intNumber + 1) / 2)

        MessageBox.Show("The sum of numbers 1 through " & intNumber & " is " & CInt(DblSum))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
