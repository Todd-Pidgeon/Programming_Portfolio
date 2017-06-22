Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Tutorial 7-3
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Create an instance of the NutritionForm
        Dim frmNutrition As New NutritionForm

        ' Find the selected radio button.
        If radBanana.Checked = True Then
            frmNutrition.lblFood.Text = "1 banana"
            frmNutrition.lblCalories.Text = "100"
            frmNutrition.lblFat.Text = "0.4"
            frmNutrition.lblCarb.Text = "27"
        ElseIf radPopcorn.Checked = True Then
            frmNutrition.lblFood.Text = "1 cup air-popped popcorn"
            frmNutrition.lblCalories.Text = "31"
            frmNutrition.lblFat.Text = "0.4"
            frmNutrition.lblCarb.Text = "6"
        ElseIf radMuffin.Checked = True Then
            frmNutrition.lblFood.Text = "1 large blueberry muffin"
            frmNutrition.lblCalories.Text = "385"
            frmNutrition.lblFat.Text = "9"
            frmNutrition.lblCarb.Text = "67"
        End If

        ' Display the NutritionForm.
        frmNutrition.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
