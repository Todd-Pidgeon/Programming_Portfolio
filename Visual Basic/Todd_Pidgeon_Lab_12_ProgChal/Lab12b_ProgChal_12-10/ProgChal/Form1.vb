
' Author: Todd Pidgeon
' Date: 04-11-2017
' Purpose: Programming Challege 12-10

Public Class Form1

    ' The GetData procedure gets data from the text boxes
    ' and stores it in the object referanced by objStudent.
    Private Sub GetData(ByVal objPerson As Person)
            Try
            ' Assign values from the form to the object properties.
            objPerson.Lastname = txtLastName.Text
            objPerson.Firstname = txtFirstName.Text
            objPerson.Address = txtAddress.Text
            objPerson.City = txtCity.Text
            objPerson.State = txtState.Text
            objPerson.Zip = txtZip.Text
            objPerson.Phone = txtPhone.Text
        Catch ex As Exception
                ' Display an error message
                MessageBox.Show(ex.Message)
            End Try
        End Sub

    ' The ClearForm procedure clears the form.
    Private Sub ClearForm()
        ' Clear the text boxes.
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()

        ' Reset the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Create an instance of the Student class.
        Dim objPerson As New Person

        ' Get the data from the form.
        GetData(objPerson)

        ' Confirm that the record was saved.
        MessageBox.Show("Person record saved.")

        ' Clear the  form.
        ClearForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
