Imports System.IO

' Author: Todd Pidgeon
' Date: 04-11-2017
' Purpose: Tutorial 12-1

Public Class Form1

    ' The GetData procedure gets data from the text boxes
    ' and stores it in the object referanced by objStudent.
    Private Sub GetData(ByVal objStudent As Student)
        Try
            ' Assign values from the form to the object properties.
            objStudent.Lastname = txtLastName.Text
            objStudent.Firstname = txtFirstName.Text
            objStudent.IdNumber = txtIdNumber.Text
            objStudent.TestAverage = CDbl(txtTestAverage.Text)
        Catch ex As Exception
            ' Display an error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveRecord(ByVal objStudent As Student)
        Dim writer As StreamWriter

        Try
            ' Open the file in Append mode.
            writer = File.AppendText("Students.txt")

            ' Save the Student object's properties
            writer.WriteLine(objStudent.IdNumber)
            writer.WriteLine(objStudent.Firstname)
            writer.WriteLine(objStudent.Lastname)
            writer.WriteLine(objStudent.TestAverage)
            writer.WriteLine(objStudent.Grade)

            ' Close the StreamWriter.
            writer.Close()
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
        txtIdNumber.Clear()
        txtTestAverage.Clear()
        lblGrade.Text = String.Empty

        ' Reset the focus.
        txtLastName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Create an instance of the Student class.
        Dim objStudent As New Student

        ' Get the data from the form.
        GetData(objStudent)

        ' Display the student's grade.
        lblGrade.Text = objStudent.Grade

        ' Save this student's record.
        SaveRecord(objStudent)

        ' Confirm that the record was saved.
        MessageBox.Show("Student record saved.")

        ' Clear the  form.
        ClearForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Enable output to the Output window.
        Debug.Listeners.Add(New ConsoleTraceListener())
    End Sub
End Class
