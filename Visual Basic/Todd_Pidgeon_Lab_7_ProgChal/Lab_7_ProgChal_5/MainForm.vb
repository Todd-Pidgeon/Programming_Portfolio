Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 5

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill the dorm list with constants
        lstDorms.Items.Add(strALLEN & " - " & decALLEN.ToString("c"))
        lstDorms.Items.Add(strPIKE & " - " & decPIKE.ToString("c"))
        lstDorms.Items.Add(strFARTHING & " - " & decFARTHING.ToString("c"))
        lstDorms.Items.Add(strSUITES & " - " & decSUITES.ToString("c"))
    End Sub

    Private Sub btnAddDorm_Click(sender As Object, e As EventArgs) Handles btnAddDorm.Click
        ' Set the dorm price based on selection
        If lstDorms.SelectedIndex = 0 Then
            decDorm = decALLEN
        ElseIf lstDorms.SelectedIndex = 1 Then
            decDorm = decPIKE
        ElseIf lstDorms.SelectedIndex = 2 Then
            decDorm = decFARTHING
        ElseIf lstDorms.SelectedIndex = 3 Then
            decDorm = decSUITES
        End If

        ' Display the totals
        lblDormitory.Text = decDorm.ToString("c")

        decTotal = decDorm + decMeals
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnMealPlan_Click(sender As Object, e As EventArgs) Handles btnMealPlan.Click
        Dim frmMeals As New MealsForm

        ' Load a new Print book form
        frmMeals.ShowDialog()

        ' Display the totals
        lblMealPlan.Text = decMeals.ToString("c")

        decTotal = decDorm + decMeals
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the form
        lblDormitory.Text = String.Empty
        lblMealPlan.Text = String.Empty
        lblTotal.Text = String.Empty

        decDorm = 0
        decMeals = 0
        decTotal = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
