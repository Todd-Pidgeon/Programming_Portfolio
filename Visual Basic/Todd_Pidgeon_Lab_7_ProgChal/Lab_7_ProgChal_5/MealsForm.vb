Public Class MealsForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 5

    Private Sub MealsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill the meal plan list with constants
        lstMeals.Items.Add(strSEVEN & " - " & decSEVEN.ToString("c"))
        lstMeals.Items.Add(strFOURTEEN & " - " & decFOURTEEN.ToString("c"))
        lstMeals.Items.Add(strUNLIMITED & " - " & decUNLIMITED.ToString("c"))
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Set the meal price based on selection
        If lstMeals.SelectedIndex = 0 Then
            decMeals = decSEVEN
        ElseIf lstMeals.SelectedIndex = 1 Then
            decMeals = decFOURTEEN
        ElseIf lstMeals.SelectedIndex = 2 Then
            decMeals = decUNLIMITED
        End If
    End Sub
End Class