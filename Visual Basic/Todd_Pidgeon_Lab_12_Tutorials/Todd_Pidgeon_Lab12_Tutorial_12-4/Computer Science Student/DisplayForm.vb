Public Class DisplayForm

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-4

    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Declare an object variable that can referance
        ' a CsStudent object.
        Dim objCsStudent As CsStudent

        ' Get each object in the collection and add its
        ' data to the list box.
        For Each objCsStudent In csStudentCollection
            lstStudents.Items.Add(objCsStudent.ToString())
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class