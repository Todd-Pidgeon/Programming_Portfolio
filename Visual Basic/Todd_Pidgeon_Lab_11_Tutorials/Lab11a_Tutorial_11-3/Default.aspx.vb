' Author: Todd Pidgeon
' Date :  03/29/2017
' Description: Lab 11 A Tutorial 11.4
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        ' Clear the lstSummary Listbox and message label
        lstSummary.Items.Clear()
        lblMessage.Text = String.Empty

        ' If the user selects a tour from the DropDown, add the tour name 
        ' Else display an error
        If ddlTour.SelectedIndex = 0 Then
            lblMessage.Text = "Please select a tour"
            Return
        Else
            lstSummary.Items.Add("Tour = " & ddlTour.Text)
        End If

        If lstKayak.SelectedIndex = -1 Then
            lblMessage.Text = "Please select a Kayak type"
            Return
        Else
            lstSummary.Items.Add("Kayak = " & lstKayak.SelectedItem.ToString())
        End If

        For Each item As ListItem In chkEquipment.Items
            If item.Selected Then
                lstSummary.Items.Add(item.Text)
            End If
        Next
    End Sub
    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ddlTour.SelectedIndex = 0
        lstKayak.SelectedIndex = -1
        lblMessage.Text = String.Empty

        ' Clear the CheckBoxList
        Dim item As ListItem
        For Each item In chkEquipment.Items
            item.Selected = False
        Next
        lstSummary.Items.Clear()
    End Sub
End Class
