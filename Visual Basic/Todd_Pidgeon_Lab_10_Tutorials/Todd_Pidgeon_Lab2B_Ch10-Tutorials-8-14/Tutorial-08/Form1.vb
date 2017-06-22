' Author: Todd Pidgeon
' Date: 02-22-2017
' Purpose: Lab 2 10-8

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

    End Sub

    Private Sub Full_TimeToolStripButton_Click(sender As Object, e As EventArgs) Handles Full_TimeToolStripButton.Click
        Try
            Me.SalesStaffTableAdapter.Full_Time(Me.CompanyDataSet.SalesStaff)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub All_RowsToolStripButton_Click(sender As Object, e As EventArgs) Handles All_RowsToolStripButton.Click
        Try
            Me.SalesStaffTableAdapter.All_Rows(Me.CompanyDataSet.SalesStaff)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
