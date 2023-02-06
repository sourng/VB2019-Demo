Public Class frmLocal
    Private Sub BtnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        'Dim i As Int16
        Static i As Int16
        i += 1
        txtTestLocal.Text = i
    End Sub
End Class

