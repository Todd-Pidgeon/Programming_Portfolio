Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strCount As String

        If lstStudent.SelectedIndex = -1 Then
            MessageBox.Show("Select a Student to add.")
        ElseIf lstClub.Items.Contains(lstStudent.SelectedItem) Then
            MessageBox.Show("Student has already been added.")
        Else
            lstClub.Items.Add(lstStudent.SelectedItem)
        End If

        strCount = CStr(lstClub.Items.Count)

        If strCount <> 0 Then
            lblClubSize.Text = strCount
        Else
            lblClubSize.Text = String.Empty
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim strCount As String

        If lstClub.SelectedIndex = -1 Then
            MessageBox.Show("Select a Student to remove.")
        Else
            lstClub.Items.Remove(lstClub.SelectedItem)
        End If

        strCount = CStr(lstClub.Items.Count)

        If strCount <> 0 Then
            lblClubSize.Text = strCount
        Else
            lblClubSize.Text = String.Empty
        End If
    End Sub
End Class
