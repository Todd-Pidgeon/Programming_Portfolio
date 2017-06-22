
Partial Class cost
    Inherits System.Web.UI.Page

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles form1.Load
        Dim language As String
        Dim charge As String

        language = CType(Session.Item("Language"), String)

        charge = CType(Session.Item("Charge"), String)

        lblCost.Text = "You selected " + language + " as your language, and " + "your cost will be $" + charge + "."
    End Sub
End Class
