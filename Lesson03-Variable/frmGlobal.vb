Public Class frmGlobal
    Public i As Int16
    Private Sub BtnGlobal_Click(sender As Object, e As EventArgs) Handles btnGlobal.Click
        i += 1
        txtTestGlobal.Text = i
    End Sub
End Class
