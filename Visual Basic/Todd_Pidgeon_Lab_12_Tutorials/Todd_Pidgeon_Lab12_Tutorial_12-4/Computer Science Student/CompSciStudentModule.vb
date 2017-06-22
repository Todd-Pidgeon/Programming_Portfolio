Module CompSciStudentModule

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-4

    ' Collection for computer science Students.
    Public csStudentCollection As New Collection

    ' The AddStudent procedure adds a csStudent object
    ' to the collection and uses the ID number property
    ' as the key.

    Public Sub AddStudent(ByVal objCsStudent As CsStudent)
        Try
            csStudentCollection.Add(objCsStudent, objCsStudent.IdNumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
