Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Display the combo box Selections.
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = cboPlays.Text
        lblArtist.Text = cboArtists.Text
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset the combo boxes.
        cboCountries.SelectedIndex = -1
        cboCountries.Text = String.Empty
        cboPlays.SelectedIndex = -1
        cboPlays.Text = String.Empty
        cboArtists.SelectedIndex = -1
        ' Note: cboArtists.Text is read-only

        ' Reset the labels.
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
