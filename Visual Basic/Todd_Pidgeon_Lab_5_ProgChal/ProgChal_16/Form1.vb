Public Class Form1
    Dim rand As Random = New Random()

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim intDieOne As Integer
        Dim intDieTwo As Integer
        Dim strPicName As String

        intDieOne = rand.Next(1, 6)
        intDieTwo = rand.Next(1, 6)

        strPicName = "Die" & intDieOne

        picDieOne.Image = My.Resources.ResourceManager.GetObject(strPicName)

        strPicName = "Die" & intDieTwo

        picDieTwo.Image = My.Resources.ResourceManager.GetObject(strPicName)
    End Sub
End Class
