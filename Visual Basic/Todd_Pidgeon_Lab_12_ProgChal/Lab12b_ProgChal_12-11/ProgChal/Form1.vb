
' Author: Todd Pidgeon
' Date: 04-11-2017
' Purpose: Programming Challege 12-11

Public Class Form1

    ' The GetData procedure gets data from the text boxes
    ' and stores it in the object referanced by objStudent.
    Private Sub GetData(ByVal objCustomer As Customer)
        Try
            ' Assign values from the form to the object properties.
            objCustomer.Lastname = txtLastName.Text
            objCustomer.Firstname = txtFirstName.Text
            objCustomer.Address = txtAddress.Text
            objCustomer.City = txtCity.Text
            objCustomer.State = txtState.Text
            objCustomer.Zip = txtZip.Text
            objCustomer.Phone = txtPhone.Text
            objCustomer.CustomerNumber = CInt(txtCustNum.Text)
            objCustomer.MailingList = chkMailList.Checked
            objCustomer.Comments = txtComments.Text

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
        txtCustNum.Clear()
        chkMailList.Checked = False
        txtComments.Clear()

        ' Reset the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Create an instance of the Student class.
        Dim objCustomer As New Customer

        ' Get the data from the form.
        GetData(objCustomer)

        ' Confirm that the record was saved.
        MessageBox.Show("Customer record saved.")

        ' Clear the  form.
        ClearForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
