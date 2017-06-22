Public Class Form1
    Dim intOne As Integer
    Dim intTwo As Integer
    Dim rand As New Random()
    Dim intAnswer As Integer
    Dim intInput As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If radAdd.Checked = True Then
            intOne = rand.Next(20, 120)
            intTwo = rand.Next(20, 120)

            lblQuestion.Text = CStr(intOne) & " + " & CStr(intTwo) & " = "

            intAnswer = intOne + intTwo
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        lblCheck.Text = String.Empty

        If Integer.TryParse(txtAnswer.Text, intInput) Then
            If intAnswer = intInput Then
                lblCheck.ForeColor = Color.Green
                lblCheck.Text = "Correct!"
            Else
                lblCheck.ForeColor = Color.Red
                lblCheck.Text = "Incorrect, Try Again."
            End If
        Else
            MessageBox.Show("Enter an Interger Value.")
        End If
    End Sub

    Private Sub btnNextProblem_Click(sender As Object, e As EventArgs) Handles btnNextProblem.Click
        Dim bolCheck As Boolean = False

        lblCheck.Text = String.Empty

        If radAdd.Checked = True Then
            intOne = rand.Next(20, 120)
            intTwo = rand.Next(20, 120)

            lblQuestion.Text = CStr(intOne) & " + " & CStr(intTwo) & " = "

            intAnswer = intOne + intTwo
        ElseIf radSub.Checked = True Then
            intOne = rand.Next(20, 120)
            intTwo = rand.Next(20, 120)

            lblQuestion.Text = CStr(intOne) & " - " & CStr(intTwo) & " = "

            intAnswer = intOne - intTwo
        ElseIf radMulti.Checked = True Then
            intOne = rand.Next(20, 120)
            intTwo = rand.Next(20, 120)

            lblQuestion.Text = CStr(intOne) & " * " & CStr(intTwo) & " = "

            intAnswer = intOne * intTwo
        ElseIf radDiv.Checked = True Then
            intOne = rand.Next(20, 120)

            While bolcheck = False
                intTwo = rand.Next(20, 120)

                If (intOne Mod intTwo) = 0 Then
                    bolCheck = True
                End If
            End While

            lblQuestion.Text = CStr(intOne) & " / " & CStr(intTwo) & " = "

            intAnswer = intOne / intTwo
        End If
    End Sub
End Class
