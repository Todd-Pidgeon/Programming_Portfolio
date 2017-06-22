Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 2
    Private Sub mnuProductPrintBooks_Click(sender As Object, e As EventArgs) Handles mnuProductPrintBooks.Click
        Dim frmPrint As New PrintForm

        ' Load a new Print book form
        frmPrint.ShowDialog()

        decSubtotal = 0

        ' Calculate the subtotal of all the books in the cart
        For i As Integer = 0 To lstCart.Items.Count - 1
            If lstCart.Items.Item(i).ToString.Equals(g_strPRINT_1) Then
                decSubtotal = decSubtotal + g_decPRINT_1
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strPRINT_2) Then
                decSubtotal = decSubtotal + g_decPRINT_2
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strPRINT_3) Then
                decSubtotal = decSubtotal + g_decPRINT_3
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strPRINT_4) Then
                decSubtotal = decSubtotal + g_decPRINT_4
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_1) Then
                decSubtotal = decSubtotal + g_decAUDIO_1
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_2) Then
                decSubtotal = decSubtotal + g_decAUDIO_2
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_3) Then
                decSubtotal = decSubtotal + g_decAUDIO_3
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_4) Then
                decSubtotal = decSubtotal + g_decAUDIO_4
            End If
        Next

        lblSubtotal.Text = decSubtotal.ToString("c")

        decTax = decSubtotal * g_decTAX
        lblTax.Text = decTax.ToString("c")

        decShipping = lstCart.Items.Count * g_decSHIPPING
        lblShipping.Text = decShipping.ToString("c")

        decTotal = decSubtotal + decShipping + decTax
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub mnuProductAudioBooks_Click(sender As Object, e As EventArgs) Handles mnuProductAudioBooks.Click
        Dim frmAudio As New AudioForm

        ' Load a new Audio book form
        frmAudio.ShowDialog()

        decSubtotal = 0

        ' Calculate the subtotal of all the books in the cart
        For i As Integer = 0 To lstCart.Items.Count - 1
            If lstCart.Items.Item(i).ToString.Equals(g_strPRINT_1) Then
                decSubtotal = decSubtotal + g_decPRINT_1
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strPRINT_2) Then
                decSubtotal = decSubtotal + g_decPRINT_2
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strPRINT_3) Then
                decSubtotal = decSubtotal + g_decPRINT_3
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strPRINT_4) Then
                decSubtotal = decSubtotal + g_decPRINT_4
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_1) Then
                decSubtotal = decSubtotal + g_decAUDIO_1
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_2) Then
                decSubtotal = decSubtotal + g_decAUDIO_2
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_3) Then
                decSubtotal = decSubtotal + g_decAUDIO_3
            ElseIf lstCart.Items.Item(i).ToString.Equals(g_strAUDIO_4) Then
                decSubtotal = decSubtotal + g_decAUDIO_4
            End If
        Next

        ' Get all the totals and display them to the labels
        lblSubtotal.Text = decSubtotal.ToString("c")

        decTax = decSubtotal * g_decTAX
        lblTax.Text = decTax.ToString("c")

        decShipping = lstCart.Items.Count * g_decSHIPPING
        lblShipping.Text = decShipping.ToString("c")

        decTotal = decSubtotal + decShipping + decTax
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the main form
        Me.Close()
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        ' Clear all the labels and the list"
        lstCart.Items.Clear()
        lblSubtotal.Text = String.Empty
        decSubtotal = 0
        lblTax.Text = String.Empty
        decTax = 0
        lblShipping.Text = String.Empty
        decShipping = 0
        lblTotal.Text = String.Empty
        decTotal = 0
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display an About box
        MessageBox.Show("A Book ordering program.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Subtract the selected Items price from the subtotal
        If lstCart.SelectedItem.ToString.Equals(g_strAUDIO_1) Then
            decSubtotal = decSubtotal - g_decAUDIO_1
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strAUDIO_2) Then
            decSubtotal = decSubtotal - g_decAUDIO_2
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strAUDIO_3) Then
            decSubtotal = decSubtotal - g_decAUDIO_3
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strAUDIO_4) Then
            decSubtotal = decSubtotal - g_decAUDIO_4
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strPRINT_1) Then
            decSubtotal = decSubtotal - g_decPRINT_1
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strPRINT_2) Then
            decSubtotal = decSubtotal - g_decPRINT_2
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strPRINT_3) Then
            decSubtotal = decSubtotal - g_decPRINT_3
        ElseIf lstCart.SelectedItem.ToString.Equals(g_strPRINT_4) Then
            decSubtotal = decSubtotal - g_decPRINT_4
        Else
            decSubtotal = 0
        End If

        ' Recalculate all the totals with the selected book removed
        lstCart.Items.Remove(lstCart.SelectedItem)

        lblSubtotal.Text = decSubtotal.ToString("c")

        decTax = decSubtotal * g_decTAX
        lblTax.Text = decTax.ToString("c")

        decShipping = lstCart.Items.Count * g_decSHIPPING
        lblShipping.Text = decShipping.ToString("c")

        decTotal = decSubtotal + decShipping + decTax
        lblTotal.Text = decTotal.ToString("c")
    End Sub
End Class
