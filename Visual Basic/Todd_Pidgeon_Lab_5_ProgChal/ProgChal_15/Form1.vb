Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dblMPH As Double

        For i As Integer = 60 To 130 Step 5
            dblMPH = i * 0.6214
            lstConvertion.Items.Add(i & " KPH = " & dblMPH.ToString("n0") & " MPH")
        Next
    End Sub
End Class
