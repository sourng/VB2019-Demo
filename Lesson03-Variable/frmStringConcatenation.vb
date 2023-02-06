Public Class frmStringConcatenation
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        txtResult.Text = txtCompanyName.Text & vbCrLf & " គឺជា " & vbCrLf & txtCompanyType.Text


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCompanyType.Clear()
        txtCompanyName.Clear()
        txtResult.Clear()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class