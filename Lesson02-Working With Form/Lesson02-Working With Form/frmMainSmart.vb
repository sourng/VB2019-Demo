Public Class frmMainSmart
    Private Sub BtnMenuHome_Click(sender As Object, e As EventArgs) Handles btnMenuHome.Click
        btnActive.Top = btnMenuHome.Top

    End Sub

    Private Sub BtnMenuGoogle_Click(sender As Object, e As EventArgs) Handles btnMenuGoogle.Click
        btnActive.Top = btnMenuGoogle.Top
        Dim f As New frmRegister

        f.TopLevel = False
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'f.Size = New System.Drawing.Size(200, 150)
        'f.Location = New System.Drawing.Point(20, 20)
        f.WindowState = FormWindowState.Normal
        f.Visible = False
        pnlForms.Controls.Add(f)
        If f.Visible = False Then f.Visible = True Else f.Visible = False

    End Sub

    Private Sub BtnMenuStudents_Click(sender As Object, e As EventArgs) Handles btnMenuStudents.Click
        btnActive.Top = btnMenuStudents.Top
        Dim f As New frmAdminLogin

        f.TopLevel = False
        'f.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'f.Size = New System.Drawing.Size(200, 150)
        'f.Location = New System.Drawing.Point(20, 20)
        f.WindowState = FormWindowState.Normal


        f.Visible = False
        pnlForms.Controls.Add(f)
        If f.Visible = False Then f.Visible = True Else f.Visible = False
    End Sub
End Class