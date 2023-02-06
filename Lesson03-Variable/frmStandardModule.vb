Public Class frmStandardModule
    Private Sub BtnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        gStuNumber += 1
        txtStandard.Text = gStuNumber
    End Sub

    Private Sub BtnDeCrease_Click(sender As Object, e As EventArgs) Handles btnDeCrease.Click
        gStuNumber -= 1
        txtStandard.Text = gStuNumber
    End Sub
End Class