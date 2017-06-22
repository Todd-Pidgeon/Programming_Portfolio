Public Class Form1
    Dim bolCheck As Boolean = False
    Private Sub cmbRegions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRegions.SelectedIndexChanged
        bolCheck = True

        While bolCheck = True
            cmbProvince.Items.Clear()
            cmbProvince.Text = String.Empty

            cmbCity.Items.Clear()
            cmbCity.Text = String.Empty

            lblProvinces.Text = String.Empty
            lblCity.Text = String.Empty

            bolCheck = False
        End While

        If cmbRegions.SelectedIndex = 0 Then
            cmbProvince.Items.Add("NE-Prov1")
            cmbProvince.Items.Add("NE-Prov2")
            cmbProvince.Items.Add("NE-Prov3")
        ElseIf cmbRegions.SelectedIndex = 1 Then
            cmbProvince.Items.Add("SE-Prov4")
            cmbProvince.Items.Add("SE-Prov5")
            cmbProvince.Items.Add("SE-Prov6")
        ElseIf cmbRegions.SelectedIndex = 2 Then
            cmbProvince.Items.Add("NW-Prov7")
            cmbProvince.Items.Add("NW-Prov8")
            cmbProvince.Items.Add("NW-Prov9")
        End If

        lblRegion.Text = cmbRegions.Text
    End Sub

    Private Sub cmbProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvince.SelectedIndexChanged
        bolCheck = True

        While bolCheck = True
            cmbCity.Items.Clear()
            cmbCity.Text = String.Empty

            lblCity.Text = String.Empty
            bolCheck = False
        End While

        If cmbRegions.SelectedIndex = 0 Then
            If cmbProvince.SelectedIndex = 0 Then
                cmbCity.Items.Add("NE-Prov1-City1")
                cmbCity.Items.Add("NE-Prov1-City2")
            ElseIf cmbProvince.SelectedIndex = 1 Then
                cmbCity.Items.Add("NE-Prov2-City3")
                cmbCity.Items.Add("NE-Prov2-City4")
            ElseIf cmbProvince.SelectedIndex = 2 Then
                cmbCity.Items.Add("NE-Prov3-City5")
                cmbCity.Items.Add("NE-Prov3-City6")
            End If
        ElseIf cmbRegions.SelectedIndex = 1 Then
            If cmbProvince.SelectedIndex = 0 Then
                cmbCity.Items.Add("SE-Prov4-City7")
                cmbCity.Items.Add("SE-Prov4-City8")
            ElseIf cmbProvince.SelectedIndex = 1 Then
                cmbCity.Items.Add("SE-Prov5-City9")
                cmbCity.Items.Add("SE-Prov5-City10")
            ElseIf cmbProvince.SelectedIndex = 2 Then
                cmbCity.Items.Add("SE-Prov6-City11")
                cmbCity.Items.Add("SE-Prov6-City12")
            End If
        ElseIf cmbRegions.SelectedIndex = 2 Then
            If cmbProvince.SelectedIndex = 0 Then
                cmbCity.Items.Add("NW-Prov7-City13")
                cmbCity.Items.Add("NW-Prov7-City14")
            ElseIf cmbProvince.SelectedIndex = 1 Then
                cmbCity.Items.Add("NW-Prov8-City16")
                cmbCity.Items.Add("NW-Prov8-City17")
            ElseIf cmbProvince.SelectedIndex = 2 Then
                cmbCity.Items.Add("NW-Prov9-City18")
                cmbCity.Items.Add("NW-Prov9-City19")
            End If
        End If

        lblProvinces.Text = cmbProvince.Text
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
        lblCity.Text = cmbCity.Text
    End Sub
End Class
