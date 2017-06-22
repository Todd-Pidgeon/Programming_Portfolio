Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dblFahrenheit As Double

        For i As Integer = 1 To 20
            dblFahrenheit = 1.8 * i + 32

            lstCelsius.Items.Add(i.ToString("n1"))
            lstFahrenheit.Items.Add(dblFahrenheit.ToString("n1"))
        Next
    End Sub
End Class
