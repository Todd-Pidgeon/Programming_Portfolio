Public Class Form1

    Private Sub btnRunDemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunDemo.Click
        Dim intCount As Integer = 0

        Do
            lstOutput.Items.Add("Hello")
            intCount += 1
        Loop While intCount > 10
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the list box.
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
