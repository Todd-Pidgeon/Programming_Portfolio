Module StudentCollectionModule

    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Tutorial 12-3

    ' Create a collection to hold Student objects.
    Public studentCollection As New Collection

    ' The AddRecord procedure adds the object referanced
    ' by s to the collection. It uses the student ID number
    ' as the key.

    Public Sub AddRecord(ByVal s As Student)
        Try
            studentCollection.Add(s, s.IdNumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
