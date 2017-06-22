
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim strLanguage As String
        Dim dblCharge As Double

        If radEnglish.Checked = True Then
            strLanguage = "English"
        ElseIf radGerman.Checked = True Then
            strLanguage = "German"
        Else
            strLanguage = "Chinese"
        End If

        If chkAsia.Checked = True Then
            dblCharge = dblCharge + 10
        End If

        If chkEuro.Checked = True Then
            dblCharge = dblCharge + 10
        End If

        If chkMed.Checked = True Then
            dblCharge = dblCharge + 10
        End If

        If chkMes.Checked = True Then
            dblCharge = dblCharge + 10
        End If

        Session("Language") = strLanguage
        Session("Charge") = dblCharge.ToString()

        Response.Redirect("cost.aspx")
    End Sub
End Class
