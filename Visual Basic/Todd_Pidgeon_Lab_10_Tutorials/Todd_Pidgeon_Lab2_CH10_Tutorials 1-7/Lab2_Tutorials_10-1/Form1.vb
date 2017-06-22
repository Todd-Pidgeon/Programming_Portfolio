Public Class SalesStaff1
    ' Author: Todd Pidgeon
    ' Date: 02-22-2017
    ' Purpose: Lab 2 10-1
    Private Sub SalesStaff1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

    End Sub
End Class
