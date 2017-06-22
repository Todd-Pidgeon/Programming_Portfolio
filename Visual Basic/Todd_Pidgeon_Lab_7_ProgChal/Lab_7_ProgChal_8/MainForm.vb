Public Class MainForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 8

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim frmPlanet As New PlanetForm

        ' set the selection variable based on the selecet planet from the list
        intSelection = lstPlanets.SelectedIndex

        ' Load a new Planet form
        frmPlanet.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close the form
        Me.Close()
    End Sub
End Class
