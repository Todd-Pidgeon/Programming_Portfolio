Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FilmsDataSet.Films' table. You can move, or remove it, as needed.
        Me.FilmsTableAdapter.Fill(Me.FilmsDataSet.Films)

    End Sub
End Class
