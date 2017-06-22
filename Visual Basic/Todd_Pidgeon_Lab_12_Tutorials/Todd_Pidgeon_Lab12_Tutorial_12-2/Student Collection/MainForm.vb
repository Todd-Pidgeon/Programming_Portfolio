Public Class MainForm

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-2

    ' The ClearForm procedure clears the form.
    Private Sub ClearForm()
        lblFirstName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblIdNumber.Text = String.Empty
        lblTestAverage.Text = String.Empty
        lblGrade.Text = String.Empty
    End Sub

    ' The UpdateListBox procedure updates the
    ' contents of the list box.
    Private Sub UpdateListBox()
        ' Clear the list box.
        lstIdNumbers.Items.Clear()

        ' Load the ID numbers in the collection
        ' into the list box.

        Dim s As Student

        For Each s In studentCollection
            lstIdNumbers.Items.Add(s.IdNumber)
        Next

        ' Select the first item in the list.
        If lstIdNumbers.Items.Count > 0 Then
            lstIdNumbers.SelectedIndex = 0
        Else
            ClearForm()
        End If
    End Sub

    ' The DisplayData procedure diplays the data contained
    ' in the Student objhect parameter.
    Private Sub DisplayData(ByVal s As Student)
        lblFirstName.Text = s.Firstname
        lblLastName.Text = s.Lastname
        lblIdNumber.Text = s.IdNumber
        lblTestAverage.Text = s.TestAverage.ToString()
        lblGrade.Text = s.Grade
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Create an instance of the AddForm form.
        Dim frmAdd As New AddForm

        ' Display the form.
        frmAdd.ShowDialog()

        ' Update the contents of the list box.
        UpdateListBox()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim intIndex As Integer

        ' Make sure an item is selected.

        If lstIdNumbers.SelectedIndex <> -1 Then
            ' Confirm that the user wants to remove the item.
            If MessageBox.Show("Are you sure?", "Confirm Deletion",
                               MessageBoxButtons.YesNo) =
                               Windows.Forms.DialogResult.Yes Then

                ' Retrieve the student's data from the collection.
                intIndex = lstIdNumbers.SelectedIndex

                Try
                    ' Remove the selected item from the collection.
                    studentCollection.Remove(lstIdNumbers.SelectedItem.ToString())

                    ' Update the list box.
                    UpdateListBox()
                Catch ex As Exception
                    ' Display an error message
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    ' Note: To create the code template for the
    ' following event handler, double-click the lstIdNumbers
    ' list box in the designer window.

    Private Sub lstIdNumbers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIdNumbers.SelectedIndexChanged
        Dim objStudent As Student

        ' See if an item is selected.

        If lstIdNumbers.SelectedIndex <> -1 Then
            ' Retrieve the student's data from the collection.
            Try
                objStudent = CType(studentCollection.Item(lstIdNumbers.SelectedItem), Student)

                ' Display the student data.
                DisplayData(objStudent)
            Catch ex As Exception
                ' Display an error message
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
