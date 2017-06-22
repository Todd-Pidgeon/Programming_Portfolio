Public Class ConferenceForm
    ' Author : Todd Pidgeon
    ' Date :  16/11/2016
    ' Description: Programming Challege 1

    Dim bolCheck As Boolean = False
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Add the conferance type selected to the total
        If chkConRef.Checked = True Then
            decTotal += g_decCONFERENCE_REGISTRATION
            bolCheck = True
        End If

        If chkOpeningNight.Checked = True Then
            decTotal += g_decOPENING_NIGHT
        End If

        ' Add the extras choosen to the total
        If bolCheck = True Then
            If lstWorkshops.SelectedIndex = 1 Then
                decTotal += g_decINTRO_E_COMMERCE
            ElseIf lstWorkshops.SelectedIndex = 2 Then
                decTotal += g_decFUTURE_WEB
            ElseIf lstWorkshops.SelectedIndex = 3 Then
                decTotal += g_decADVANCED_VB
            ElseIf lstWorkshops.SelectedIndex = 4 Then
                decTotal += g_decNETWORK_SECURITY
            End If
        End If

        ' close the form
        Me.Close()
    End Sub

    Private Sub lstWorkshops_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWorkshops.SelectedIndexChanged
        ' Check to see if a conferance type was selected before adding extras
        If lstWorkshops.SelectedIndex <> -1 Then
            If chkConRef.Checked = False Then
                MessageBox.Show("Conference Registration must be selected before adding Workshops.")
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the form
        chkConRef.Checked = False
        chkOpeningNight.Checked = False

        lstWorkshops.SelectedIndex = -1
    End Sub
End Class