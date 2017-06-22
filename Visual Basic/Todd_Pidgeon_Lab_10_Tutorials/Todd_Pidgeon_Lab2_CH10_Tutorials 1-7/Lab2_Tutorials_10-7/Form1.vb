Public Class Form1
    ' Author: Todd Pidgeon
    ' Date: 02-22-2017
    ' Purpose: Lab 2 10-7
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

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim decTotal As Decimal = 0
        Dim row As KarateDataSet.PaymentsRow

        For Each row In Me.KarateDataSet.Payments.Rows
            decTotal += row.Amount
        Next

        MessageBox.Show("Total payments are equal to " & decTotal.ToString("c"), "Total")
    End Sub
End Class
