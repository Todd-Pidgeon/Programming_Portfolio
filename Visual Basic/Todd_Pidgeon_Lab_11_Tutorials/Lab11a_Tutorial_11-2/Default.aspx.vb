' Author: Todd Pidgeon
' Date :  03/29/2017
' Description: Lab 11 A Tutorial 11.2
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        lblMessage.Text = "Thank you for signing up for the " &
            "picnic, " & txtFirst.Text & " " & txtLast.Text & "."
        If chkVegetarian.Checked = True Then
            lblMessage.Text &= " You will be recieving a " &
                "Vegetarian meal."
        End If
    End Sub
End Class
