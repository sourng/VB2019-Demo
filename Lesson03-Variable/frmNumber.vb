Public Class frmNumber
    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        'Declare Variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intResult As Integer

        intNum1 = txtNumber1.Text
        intNum2 = txtNumber2.Text

        intResult = intNum1 + intNum2
        txtResult.Text = intResult

    End Sub

    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        'Declare Variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intResult As Integer

        intNum1 = txtNumber1.Text
        intNum2 = txtNumber2.Text

        intResult = intNum1 - intNum2
        txtResult.Text = intResult
    End Sub

    Private Sub BtnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        'Declare Variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intResult As Integer

        intNum1 = txtNumber1.Text
        intNum2 = txtNumber2.Text

        intResult = intNum1 * intNum2
        txtResult.Text = intResult
    End Sub

    Private Sub BtnDevision_Click(sender As Object, e As EventArgs) Handles btnDevision.Click
        'Declare Variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intResult As Double

        intNum1 = txtNumber1.Text
        intNum2 = txtNumber2.Text

        intResult = CDbl(intNum1 / intNum2)
        txtResult.Text = intResult
    End Sub


    Private Sub txtNumber1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber1.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FrmNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AssignValidation(Me.txtNumber1, ValidationType.Only_Numbers)
        'AssignValidation(Me.txtNumber1, ValidationType.Only_Characters)
        'AssignValidation(Me.txtNumber1, ValidationType.Not_Null)
        'AssignValidation(Me.txtNumber1, ValidationType.Only_Email)


        AssignValidation(Me.txtNumber1, ValidationType.Only_Numbers)
        AssignValidation(Me.txtNumber1, ValidationType.Not_Null)
        AssignValidation(Me.txtNumber2, ValidationType.Only_Numbers)
        AssignValidation(Me.txtNumber2, ValidationType.Not_Null)

    End Sub
End Class