Public Class Form1
    Const decPER_DAY As Decimal = 350
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intDays As Integer
        Dim decMedication As Decimal
        Dim decSurgical As Decimal
        Dim decLabFees As Decimal
        Dim decPhysical As Decimal
        Dim decStayCharges As Decimal
        Dim decMiscCharges As Decimal
        Dim decTotalCharges As Decimal
        Dim bolCheck As Boolean = True

        bolCheck = ValidateInputFields(intDays, decMedication, decSurgical, decLabFees, decPhysical)

        If bolCheck = True Then
            decStayCharges = CalcStayCharges(intDays)
            decMiscCharges = CalcMiscCharges(decMedication, decSurgical, decLabFees, decPhysical)
            decTotalCharges = CalcTotalCharges(decStayCharges, decMiscCharges)

            lblMessage.Text = "Total Cost: " & decTotalCharges.ToString("c")
        End If

    End Sub

    Function CalcStayCharges(ByRef intDays As Integer) As Decimal
        Dim decStayCharges As Decimal

        decStayCharges = intDays * decPER_DAY

        Return decStayCharges
    End Function

    Function CalcMiscCharges(ByRef decMedication As Decimal, ByRef decSurgical As Decimal, ByRef decLabFees As Decimal, ByRef decPhysical As Decimal) As Decimal
        Dim decMiscCharges As Decimal

        decMiscCharges = decMedication + decSurgical + decLabFees + decPhysical

        Return decMiscCharges
    End Function

    Function CalcTotalCharges(ByRef decStayCharges As Decimal, ByRef decMiscCharges As Decimal) As Decimal
        Dim decTotalCharges As Decimal

        decTotalCharges = decStayCharges + decMiscCharges

        Return decTotalCharges
    End Function

    Function ValidateInputFields(ByRef intDays As Integer, ByRef decMedication As Decimal, ByRef decSurgical As Decimal, ByRef decLabFees As Decimal, ByRef decPhysical As Decimal) As Boolean
        If Integer.TryParse(txtStay.Text, intDays) = False Then
            lblMessage.Text = "Length of stay must be a positive numeric value."
            Return False
        ElseIf intDays < 0 Then
            lblMessage.Text = "Length of stay must be a positive numeric value."
            Return False
        ElseIf Decimal.TryParse(txtMedication.Text, decMedication) = False Then
            lblMessage.Text = "Medication must be a positive numeric value."
            Return False
        ElseIf decMedication < 0 Then
            lblMessage.Text = "Medication must be a positive numeric value."
            Return False
        ElseIf Decimal.TryParse(txtSurgical.Text, decSurgical) = False Then
            lblMessage.Text = "Surgical Charges must be a positive numeric value."
            Return False
        ElseIf decSurgical < 0 Then
            lblMessage.Text = "Surgical Charges must be a positive numeric value."
            Return False
        ElseIf Decimal.TryParse(txtLab.Text, decLabFees) = False Then
            lblMessage.Text = "Lab Fees must be a positive numeric value."
            Return False
        ElseIf decLabFees < 0 Then
            lblMessage.Text = "Lab Fees must be a positive numeric value."
            Return False
        ElseIf Decimal.TryParse(txtPhysical.Text, decPhysical) = False Then
            lblMessage.Text = "Physical Rehab must be a positive numeric value."
            Return False
        ElseIf decPhysical < 0 Then
            lblMessage.Text = "Physical Rehab must be a positive numeric value."
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = String.Empty
        txtLab.Text = String.Empty
        txtMedication.Text = String.Empty
        txtPhysical.Text = String.Empty
        txtStay.Text = String.Empty
        txtSurgical.Text = String.Empty
    End Sub
End Class
