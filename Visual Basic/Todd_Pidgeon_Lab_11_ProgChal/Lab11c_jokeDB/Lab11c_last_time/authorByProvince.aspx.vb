
Partial Class authorByProvince
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strProvince As String = btnConfirm.Text

        Dim strQuery As String = "SELECT author_name, author_prov FROM author WHERE author_prov = " + strProvince + " ORDER BY author_prov, author_name"


    End Sub
End Class
