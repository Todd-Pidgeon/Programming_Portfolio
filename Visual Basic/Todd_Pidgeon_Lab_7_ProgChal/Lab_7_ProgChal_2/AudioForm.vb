Public Class AudioForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 2

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add the selected book to the cart list
        If lstAudioBooks.SelectedIndex = 0 Then
            MainForm.lstCart.Items.Add(g_strAUDIO_1)
        ElseIf lstAudioBooks.SelectedIndex = 1 Then
            MainForm.lstCart.Items.Add(g_strAUDIO_2)
        ElseIf lstAudioBooks.SelectedIndex = 2 Then
            MainForm.lstCart.Items.Add(g_strAUDIO_3)
        ElseIf lstAudioBooks.SelectedIndex = 3 Then
            MainForm.lstCart.Items.Add(g_strAUDIO_4)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class