Public Class Form1
    ' Author : Todd Pidgeon
    ' Date :  08/12/2016
    ' Description: Chapter 8 Programming Challege #2

    ' Make the arrays
    Dim strNouns(4) As String
    Dim strAdjectives(5) As String
    Dim strVerbs(6) As String
    Dim strPrepositions(4) As String
    Dim strArticles(1) As String

    Dim strSentence(8) As String
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        strNouns = {"Marian", "baby", "skunk", "computer", "mosquito"}
        strAdjectives = {"massive", "small", "crazy", "sexy", "funny"}
        strVerbs = {"flew", "ran", "Jumped", "crawled", "ate", "slapped"}
        strPrepositions = {"around", "through", "under", "over", "by"}
        strArticles = {"the", "a"}

        ' Variables
        Dim intRandom As Integer
        Dim strCompSent As String

        ' Create a random object
        Dim rand As New Random

        ' build the sentence array
        intRandom = rand.Next(1)
        strSentence(0) = strArticles(intRandom)

        intRandom = rand.Next(5)
        strSentence(1) = strAdjectives(intRandom)

        intRandom = rand.Next(4)
        strSentence(2) = strNouns(intRandom)

        intRandom = rand.Next(6)
        strSentence(3) = strVerbs(intRandom)

        intRandom = rand.Next(4)
        strSentence(4) = strPrepositions(intRandom)

        intRandom = rand.Next(1)
        strSentence(5) = strArticles(intRandom)

        intRandom = rand.Next(5)
        strSentence(6) = strAdjectives(intRandom)

        intRandom = rand.Next(4)
        strSentence(7) = strNouns(intRandom)

        ' turn the array into a sentance
        strCompSent = strSentence(0) + " " + strSentence(1) + " " + strSentence(2) + " " + strSentence(3) + " " + strSentence(4) + " " + strSentence(5) + " " + strSentence(6) + " " + strSentence(7)

        lstSentences.Items.Add(strCompSent)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the array
        lstSentences.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
