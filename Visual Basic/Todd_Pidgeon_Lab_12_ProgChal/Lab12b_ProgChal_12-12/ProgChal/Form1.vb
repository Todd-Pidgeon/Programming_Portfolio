
' Author: Todd Pidgeon
' Date: 04-11-2017
' Purpose: Programming Challege 12-12

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

    ' The UpdateListBox procedure updates the
    ' contents of the list box.
    Private Sub UpdateListBox()
        ' Clear the list box.
        lstCust.Items.Clear()

        ' Load the ID numbers in the collection
        ' into the list box.

        Dim s As PreferredCustomer

        For Each s In customerCollection
            lstCust.Items.Add(s.CustomerNumber)
        Next

        ' Select the first item in the list.
        If lstCust.Items.Count > 0 Then
            lstCust.SelectedIndex = 0
        Else
            ClearForm()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Create an instance of the Student class.
        Dim objCustomer As New PreferredCustomer

        ' Get the data from the form.
        GetData(objCustomer)

        ' Update the contents of the list box.
        AddRecord(objCustomer)
        UpdateListBox()

        ' Confirm that the record was saved.
        MessageBox.Show("Customer record saved.")

        ' Clear the  form.
        ClearForm()
    End Sub

    ' The DisplayData procedure diplays the data contained
    ' in the Student objhect parameter.
    Private Sub DisplayData(ByVal s As PreferredCustomer)
        txtFirstName.Text = s.Firstname
        txtLastName.Text = s.Lastname
        txtAddress.Text = s.Address
        txtCity.Text = s.City
        txtState.Text = s.State
        txtZip.Text = s.Zip
        txtPhone.Text = s.Phone
        txtCustNum.Text = s.CustomerNumber.ToString()
        chkMailList.Checked = s.MailingList
        txtComments.Text = s.Comments
        lblDiscount.Text = s.DiscountLevel.ToString()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim intIndex As Integer

        ' Make sure an item is selected.

        If lstCust.SelectedIndex <> -1 Then
            ' Confirm that the user wants to remove the item.
            If MessageBox.Show("Are you sure?", "Confirm Deletion",
                               MessageBoxButtons.YesNo) =
                               DialogResult.Yes Then

                ' Retrieve the student's data from the collection.
                intIndex = lstCust.SelectedIndex

                Try
                    ' Remove the selected item from the collection.
                    customerCollection.Remove(lstCust.SelectedItem.ToString())

                    ' Update the list box.
                    UpdateListBox()
                Catch ex As Exception
                    ' Display an error message
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub lstCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCust.SelectedIndexChanged
        Dim objCustomer As PreferredCustomer

        ' See if an item is selected.

        If lstCust.SelectedIndex <> -1 Then
            ' Retrieve the student's data from the collection.
            Try
                objCustomer = CType(customerCollection.Item(lstCust.SelectedItem.ToString()), PreferredCustomer)

                ' Display the student data.
                DisplayData(objCustomer)
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
