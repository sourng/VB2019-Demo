Public Class frmSellingKHR
    Const RATE As Double = 4100

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUSD.Clear()
        txtKHR.Clear()
        txtCharge.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub txtUSD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUSD.KeyPress
        ObjectPress(sender, e)
    End Sub

    Private Sub txtUSD_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUSD.KeyUp

        Dim USD As Double = 0
        If IsNumeric(txtUSD.Text) Then
            USD = txtUSD.Text
        End If

        txtKHR.Text = FormatNumber(USD * RATE, 0)
        CalculateAmount()
    End Sub

    Private Sub txtUSD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUSD.LostFocus
        If Not IsNumeric(txtUSD.Text) Then
            txtUSD.Text = ""
        Else
            txtUSD.Text = FormatNumber(CDbl(txtUSD.Text), 0)
        End If
    End Sub

    Private Sub txtCharge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCharge.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtCharge_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCharge.KeyUp
        CalculateAmount()
    End Sub

    Private Sub txtCharge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCharge.LostFocus
        If Not IsNumeric(txtCharge.Text) Then
            txtCharge.Text = 0
        End If

        txtCharge.Text = FormatNumber(CDbl(txtCharge.Text), 0)
    End Sub

    Private Sub frmSellingKHR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRate.Text = FormatNumber(RATE, 2) + " រៀល"
    End Sub



    Private Sub txtKHR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKHR.KeyPress
        ObjectPress(sender, e)
    End Sub

    Private Sub txtKHR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKHR.KeyUp
        Dim Khr As Double = 0
        If IsNumeric(txtKHR.Text) Then
            Khr = txtKHR.Text
        End If

        txtUSD.Text = FormatNumber(Khr / RATE, 2)
        CalculateAmount()
    End Sub
    Private Sub txtKHR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKHR.LostFocus
        If IsNumeric(txtKHR.Text) Then
            txtKHR.Text = FormatNumber(CDbl(txtKHR.Text), 0)
        End If
    End Sub

    Private Sub CalculateAmount()
        Dim Amount As Double = 0
        Dim Total As Double = 0

        If IsNumeric(txtUSD.Text) Then
            Amount = txtUSD.Text
        End If

        Total = Amount * RATE

        If IsNumeric(txtCharge.Text) Then
            Total = (Amount * RATE) - CDbl(txtCharge.Text)
        End If

        txtTotal.Text = FormatNumber(Total, 0)
    End Sub
    Private Sub ObjectPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TxtUSD_TextChanged(sender As Object, e As EventArgs) Handles txtUSD.TextChanged

    End Sub

    Private Sub TxtCharge_TextChanged(sender As Object, e As EventArgs) Handles txtCharge.TextChanged

    End Sub
End Class