Module CustomerModule
    ' Author: Todd Pidgeon
    ' Date: 04-11-2017
    ' Purpose: Programming Challege 12-12

    ' Create a collection to hold Student objects.
    Public customerCollection As New Collection

    ' The AddRecord procedure adds the object referanced
    ' by s to the collection. It uses the student ID number
    ' as the key.

    Public Sub AddRecord(ByVal s As PreferredCustomer)
        Try
            customerCollection.Add(s, s.CustomerNumber.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
