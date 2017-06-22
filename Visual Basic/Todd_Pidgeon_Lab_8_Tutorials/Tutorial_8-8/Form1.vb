Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  06/12/2016
    ' Description: Tutorial 8-8
    Private Sub btnCatchMe_Click(sender As Object, e As EventArgs) Handles btnCatchMe.Click
        ' Disable the timer
        tmrGameTimer.Enabled = False

        ' Display a message.
        MessageBox.Show("You Win!")
    End Sub

    Private Sub tmrGameTimer_Tick(sender As Object, e As EventArgs) Handles tmrGameTimer.Tick
        ' Create a Random object.
        Dim rand As New Random

        ' Variables to hold XY coordinates
        Dim intNewLeft, intNewTop As Integer

        ' Get random XY coordinates
        intNewLeft = rand.Next(Me.Width - btnCatchMe.Width)
        intNewTop = rand.Next(Me.Height - btnCatchMe.Height)

        ' Move the button to the new location.
        btnCatchMe.Left = intNewLeft
        btnCatchMe.Top = intNewTop
    End Sub
End Class
