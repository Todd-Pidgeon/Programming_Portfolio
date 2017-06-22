Public Class AddForm

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-3

    ' The GetData procedure gets data from the form
    ' and stores it in the  Student object parameter.
    Private Sub GetData(ByVal s As Student)
        s.Lastname = txtLastName.Text
        s.Firstname = txtFirstName.Text
        s.IdNumber = txtIdNumber.Text
        s.TestAverage = CDbl(txtTestAverage.Text)
    End Sub

    ' The ClearForm procedure clears the form.
    Private Sub ClearForm()
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtIdNumber.Text = String.Empty
        txtTestAverage.Text = String.Empty
        lblGrade.Text = String.Empty

        ' Reset the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Create an instance of the Student class.
        Dim objStudent As New Student

        ' Get the data from the form.
        GetData(objStudent)

        ' Display the student's grade.
        lblGrade.Text = objStudent.Grade

        ' Save this student's record.
        AddRecord(objStudent)

        ' Confirm that the record was saved.
        MessageBox.Show("Record added.")

        ' Clear the  form.
        ClearForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class