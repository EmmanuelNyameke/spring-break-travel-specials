Public Class frmSpringBreakTravelSpecials
    Private Sub btnMrytle_Click(sender As Object, e As EventArgs) Handles btnMrytle.Click
        picMyrtleBeach.Visible = True
        picKeyWest.Visible = False
        picVeniceBeach.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnWest_Click(sender As Object, e As EventArgs) Handles btnWest.Click
        picKeyWest.Visible = True
        picMyrtleBeach.Visible = False
        picVeniceBeach.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnVenice_Click(sender As Object, e As EventArgs) Handles btnVenice.Click
        picVeniceBeach.Visible = True
        picKeyWest.Visible = False
        picMyrtleBeach.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btnMrytle.Enabled = False
        btnWest.Enabled = False
        btnVenice.Enabled = False
        lblInstruction.Visible = False
        btnPurchase.Enabled = True
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
