Public Class frmUsingString
    Private Sub BtnUsingString_Click(sender As Object, e As EventArgs) Handles btnUsingString.Click
        'Declare variable
        Dim strData As String
        strData = "Hello, VB.Net 2019"

        'Display the results
        MessageBox.Show(strData, "Using String")

    End Sub

    Private Sub BtnConcatination_Click(sender As Object, e As EventArgs) Handles btnConcatination.Click
        'Declare variables
        Dim strOne As String
        Dim strTwo As String
        Dim strResults As String

        'Set the string values
        strOne = "Hello"
        strTwo = ", world!"

        'Concatenate the strings
        strResults = strOne & strTwo

        'Display the results
        MessageBox.Show(strResults, "Strings")

    End Sub

    Private Sub BtnConcatenationInline_Click(sender As Object, e As EventArgs) Handles btnConcatenationInline.Click
        'Declare variable
        Dim intNumber As Integer
        'Set the value
        intNumber = 26
        'Display the results
        MessageBox.Show("The value of intNumber is: " & intNumber, "Strings")
    End Sub

    Private Sub BtnConcateWithForm_Click(sender As Object, e As EventArgs) Handles btnConcateWithForm.Click
        frmStringConcatenation.Show()

    End Sub

    Private Sub BtnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        'Declare variable
        Dim strData As String
        'Get the text from the TextBox
        strData = txtString.Text
        'Display the length of the string
        MessageBox.Show(strData.Length & " character(s)", "Strings")
    End Sub

    Private Sub BtnSubString_Click(sender As Object, e As EventArgs) Handles btnSubString.Click
        'Declare variable
        Dim strData As String
        'Get the text from the TextBox
        strData = txtString.Text
        'Display the first three characters
        MessageBox.Show(strData.Substring(0, 3), "Strings")
        'Display the middle three characters
        MessageBox.Show(strData.Substring(3, 3), "Strings")
        'Display the last three characters
        MessageBox.Show(strData.Substring(strData.Length - 4), "Strings")
    End Sub

    Private Sub BtnReplacingSubStr_Click(sender As Object, e As EventArgs) Handles btnReplacingSubStr.Click

    End Sub
End Class