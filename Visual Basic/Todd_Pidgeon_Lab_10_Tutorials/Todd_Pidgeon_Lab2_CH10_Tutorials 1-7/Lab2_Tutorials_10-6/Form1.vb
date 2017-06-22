Public Class Form1
    ' Author: Todd Pidgeon
    ' Date: 02-22-2017
    ' Purpose: Lab 2 10-6
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateDataSet.Payments)

        ' Set the text box to today's Date.
        txtDate.Text = Today().ToString("d")
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Me.PaymentsTableAdapter.Insert(CShort(txtMemberId.Text),
                CDate(txtDate.Text), CDec(txtAmount.Text))
            Me.PaymentsTableAdapter.Fill(KarateDataSet.Payments)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try
    End Sub
End Class
