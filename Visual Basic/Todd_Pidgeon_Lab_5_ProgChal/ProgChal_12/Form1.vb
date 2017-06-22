Public Class Form1
    Const dblLOW As Double = 3.5
    Const dblMEDIUM As Double = 4.5
    Const dblHIGH As Double = 6.0

    Private Sub cboSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSpeed.SelectedIndexChanged
        Dim dblCalPerMin As Double

        lstBurned.Items.Clear()

        If cboSpeed.SelectedIndex = 0 Then
            For i As Integer = 10 To 30 Step 5
                dblCalPerMin = dblLOW * i
                lstBurned.Items.Add(dblCalPerMin.ToString("n1") & " calories in " & i & " minutes.")
            Next
        ElseIf cboSpeed.SelectedIndex = 1 Then
            For i As Integer = 10 To 30 Step 5
                dblCalPerMin = dblMEDIUM * i
                lstBurned.Items.Add(dblCalPerMin.ToString("n1") & " calories in " & i & " minutes.")
            Next
        ElseIf cboSpeed.SelectedIndex = 2 Then
            For i As Integer = 10 To 30 Step 5
                dblCalPerMin = dblHIGH * i
                lstBurned.Items.Add(dblCalPerMin.ToString("n1") & " calories in " & i & " minutes.")
            Next
        End If
    End Sub
End Class
