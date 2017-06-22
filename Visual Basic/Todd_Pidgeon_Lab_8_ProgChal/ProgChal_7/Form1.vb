Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  08/12/2016
    ' Description: Chapter 8 Programming Challege #7

    ' Arrays
    Dim decOneGrades(3) As Decimal
    Dim decTwoGrades(3) As Decimal
    Dim decThreeGrades(3) As Decimal
    Dim decFourGrades(3) As Decimal
    Dim decFiveGrades(3) As Decimal

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Does not allow values less then 0 or greater then 100
        If txtTest1.Text < 0 Or txtTest1.Text > 100 Or txtTest1.Text = String.Empty Or
            txtTest2.Text < 0 Or txtTest2.Text > 100 Or
            txtTest3.Text < 0 Or txtTest3.Text > 100 Or
            txtTest4.Text < 0 Or txtTest4.Text > 100 Then
            MessageBox.Show("Please enter a score between 0 and 100.")
        Else
            ' Places the values in the arrays
            If cboStudent.SelectedIndex = 0 Then
                decOneGrades(0) = txtTest1.Text
                decOneGrades(1) = txtTest2.Text
                decOneGrades(2) = txtTest3.Text
                decOneGrades(3) = txtTest4.Text
            ElseIf cboStudent.SelectedIndex = 1 Then
                decTwoGrades(0) = txtTest1.Text
                decTwoGrades(1) = txtTest2.Text
                decTwoGrades(2) = txtTest3.Text
                decTwoGrades(3) = txtTest4.Text
            ElseIf cboStudent.SelectedIndex = 2 Then
                decThreeGrades(0) = txtTest1.Text
                decThreeGrades(1) = txtTest2.Text
                decThreeGrades(2) = txtTest3.Text
                decThreeGrades(3) = txtTest4.Text
            ElseIf cboStudent.SelectedIndex = 3 Then
                decFourGrades(0) = txtTest1.Text
                decFourGrades(1) = txtTest2.Text
                decFourGrades(2) = txtTest3.Text
                decFourGrades(3) = txtTest4.Text
            ElseIf cboStudent.SelectedIndex = 4 Then
                decFiveGrades(0) = txtTest1.Text
                decFiveGrades(1) = txtTest2.Text
                decFiveGrades(2) = txtTest3.Text
                decFiveGrades(3) = txtTest4.Text
            End If
        End If

        ' Clears the text boxes
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        txtTest4.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variables
        Dim decAverage1 As Decimal
        Dim decAverage2 As Decimal
        Dim decAverage3 As Decimal
        Dim decAverage4 As Decimal
        Dim decAverage5 As Decimal
        Dim strLetter1 As String
        Dim strLetter2 As String
        Dim strLetter3 As String
        Dim strLetter4 As String
        Dim strLetter5 As String

        ' Calculate the averages
        decAverage1 = (decOneGrades(0) + decOneGrades(1) + decOneGrades(2) + decOneGrades(3)) / 4
        decAverage2 = (decTwoGrades(0) + decTwoGrades(1) + decTwoGrades(2) + decTwoGrades(3)) / 4
        decAverage3 = (decThreeGrades(0) + decThreeGrades(1) + decThreeGrades(2) + decThreeGrades(3)) / 4
        decAverage4 = (decFourGrades(0) + decFourGrades(1) + decFourGrades(2) + decFourGrades(3)) / 4
        decAverage5 = (decFiveGrades(0) + decFiveGrades(1) + decFiveGrades(2) + decFiveGrades(3)) / 4

        ' Calculate the letter grade for each student
        If decAverage1 >= 90 Then
            strLetter1 = "A"
        ElseIf decAverage1 >= 80 Then
            strLetter1 = "B"
        ElseIf decAverage1 >= 70 Then
            strLetter1 = "C"
        ElseIf decAverage1 >= 60 Then
            strLetter1 = "D"
        Else
            strLetter1 = "F"
        End If

        If decAverage2 >= 90 Then
            strLetter2 = "A"
        ElseIf decAverage2 >= 80 Then
            strLetter2 = "B"
        ElseIf decAverage2 >= 70 Then
            strLetter2 = "C"
        ElseIf decAverage2 >= 60 Then
            strLetter2 = "D"
        Else
            strLetter2 = "F"
        End If

        If decAverage3 >= 90 Then
            strLetter3 = "A"
        ElseIf decAverage3 >= 80 Then
            strLetter3 = "B"
        ElseIf decAverage3 >= 70 Then
            strLetter3 = "C"
        ElseIf decAverage3 >= 60 Then
            strLetter3 = "D"
        Else
            strLetter3 = "F"
        End If

        If decAverage4 >= 90 Then
            strLetter4 = "A"
        ElseIf decAverage4 >= 80 Then
            strLetter4 = "B"
        ElseIf decAverage4 >= 70 Then
            strLetter4 = "C"
        ElseIf decAverage4 >= 60 Then
            strLetter4 = "D"
        Else
            strLetter4 = "F"
        End If

        If decAverage5 >= 90 Then
            strLetter5 = "A"
        ElseIf decAverage5 >= 80 Then
            strLetter5 = "B"
        ElseIf decAverage5 >= 70 Then
            strLetter5 = "C"
        ElseIf decAverage5 >= 60 Then
            strLetter5 = "D"
        Else
            strLetter5 = "F"
        End If

        ' display the data
        lstGrades.Items.Add("Student: " + cboStudent.Items.Item(0) + "  Average Grade: " + decAverage1.ToString("n1") + "  Letter Grade: " + strLetter1)
        lstGrades.Items.Add("Student: " + cboStudent.Items.Item(1) + "  Average Grade: " + decAverage2.ToString("n1") + "  Letter Grade: " + strLetter2)
        lstGrades.Items.Add("Student: " + cboStudent.Items.Item(2) + "  Average Grade: " + decAverage3.ToString("n1") + "  Letter Grade: " + strLetter3)
        lstGrades.Items.Add("Student: " + cboStudent.Items.Item(3) + "  Average Grade: " + decAverage4.ToString("n1") + "  Letter Grade: " + strLetter4)
        lstGrades.Items.Add("Student: " + cboStudent.Items.Item(4) + "  Average Grade: " + decAverage5.ToString("n1") + "  Letter Grade: " + strLetter5)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close the form
        Me.Close()
    End Sub
End Class
