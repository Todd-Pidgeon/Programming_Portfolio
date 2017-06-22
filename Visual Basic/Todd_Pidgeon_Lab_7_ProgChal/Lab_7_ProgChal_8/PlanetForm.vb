Public Class PlanetForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 8

    Private Sub PlanetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the planet infor based on the users selection
        If intSelection = 0 Then
            lblInfo.Text = strMERCURY.ToString
        ElseIf intSelection = 1 Then
            lblInfo.Text = strVENUS.ToString
        ElseIf intSelection = 2 Then
            lblInfo.Text = strEARTH.ToString
        ElseIf intSelection = 3 Then
            lblInfo.Text = strMARS.ToString
        ElseIf intSelection = 4 Then
            lblInfo.Text = strJUPITER.ToString
        ElseIf intSelection = 5 Then
            lblInfo.Text = strSATURN.ToString
        ElseIf intSelection = 6 Then
            lblInfo.Text = strURANUS.ToString
        ElseIf intSelection = 7 Then
            lblInfo.Text = strNEPTUNE.ToString
        ElseIf intSelection = 8 Then
            lblInfo.Text = strPLUTO.ToString
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' close the form
        Me.Close()
    End Sub
End Class