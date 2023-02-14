Public Class frmBurgers
    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnSelectMeal.Enabled = False
        btnExit.Enabled = True
        lblInstructions.Visible = False
        lblConfirmation.Visible = True

    End Sub
End Class
