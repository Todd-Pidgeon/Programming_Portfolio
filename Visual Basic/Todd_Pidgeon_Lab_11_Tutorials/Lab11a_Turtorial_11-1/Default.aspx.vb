' Author: Todd Pidgeon
' Date :  03/29/2017
' Description: Lab 11 A Tutorial 11.1
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        lblMessage.Text = "Thank you for clicking the button!"
    End Sub
End Class
