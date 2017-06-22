Public Class PrintForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 2
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add the selected book to the cart list
        If lstPrintBooks.SelectedIndex = 0 Then
            MainForm.lstCart.Items.Add(g_strPRINT_1)
        ElseIf lstPrintBooks.SelectedIndex = 1 Then
            MainForm.lstCart.Items.Add(g_strPRINT_2)
        ElseIf lstPrintBooks.SelectedIndex = 2 Then
            MainForm.lstCart.Items.Add(g_strPRINT_3)
        ElseIf lstPrintBooks.SelectedIndex = 3 Then
            MainForm.lstCart.Items.Add(g_strPRINT_4)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class