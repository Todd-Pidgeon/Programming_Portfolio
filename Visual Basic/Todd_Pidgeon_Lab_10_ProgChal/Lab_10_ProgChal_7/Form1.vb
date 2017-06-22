Public Class Form1
    Private Sub PaymentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PaymentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KarateDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet1.Members)
        'TODO: This line of code loads data into the 'KarateDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateDataSet.Payments)

    End Sub
End Class
