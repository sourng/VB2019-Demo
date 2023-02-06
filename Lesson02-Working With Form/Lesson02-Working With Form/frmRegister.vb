Public Class frmRegister
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim txtUN As String
        Dim txtPwd As String
        Dim txtConfirmPwd As String

        txtUN = txtFullName.Text
        txtPwd = txtPassword.Text
        txtConfirmPwd = txtConfirmPassword.Text

        MsgBox("Username :" & txtUN & ",Password:" & txtPwd)



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label3_DoubleClick(sender As Object, e As EventArgs) Handles Label3.DoubleClick
        MsgBox("Hello Now U double click!")
    End Sub
End Class
