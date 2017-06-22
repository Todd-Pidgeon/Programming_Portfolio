Public Class MainForm

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-4

    ' The GetData procedure assigns data to the form
    ' to a CsStudent object's properties.
    Private Sub GetData(ByVal objCsStudent As CsStudent)
        Try
            ' Get name and Id Number.
            objCsStudent.Lastname = txtLastName.Text
            objCsStudent.Firstname = txtFirstName.Text
            objCsStudent.IdNumber = txtIdNumber.Text

            ' Get Hours
            objCsStudent.MathHours = CDbl(txtMath.Text)
            objCsStudent.CommHours = CDbl(txtComm.Text)
            objCsStudent.HumHours = CDbl(txtHum.Text)
            objCsStudent.ElectHours = CDbl(txtElect.Text)
            objCsStudent.CompSciHours = CDbl(txtCompSci.Text)
        Catch ex As Exception
            ' Display an error message
            MessageBox.Show("Enter valid numeric values for all hours.")
        End Try
    End Sub

    ' The ClearForm procedure clears the form.
    Private Sub ClearForm()
        ' Clear the text boxes.
        txtFirstName.Clear()
        txtLastName.Clear()
        txtIdNumber.Clear()
        txtMath.Clear()
        txtComm.Clear()
        txtHum.Clear()
        txtElect.Clear()
        txtCompSci.Clear()

        ' Reset the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Create an instance of the CsStudent class.
        Dim objCsStudent As New CsStudent

        ' Get the data from the form.
        GetData(objCsStudent)

        ' Add the CsStudent object to the Collection.
        AddStudent(objCsStudent)

        ' Clear the  form.
        ClearForm()

        ' Confirm that the record was saved.
        MessageBox.Show("Student record added successfully.")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Create an instance of the CDisplayForm form.
        Dim frmDidsplay As New DisplayForm

        ' Display the form.
        frmDidsplay.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
