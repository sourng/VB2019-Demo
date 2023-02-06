Public Class frmStudentScore
    Dim stuID As Integer
    Dim VB, JAVA, DBMS, ENG, totalScore, avg As Double
    Dim mention As Char
    Private ListView1Changing As Boolean = False
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'stuID += 1
        txtID.Text = stuID
        btnAdd.Enabled = False
        txtName.Clear()
        cboGender.Text = ""
        cboSkill.Text = ""


        txtVB.Text = 0
        txtJava.Text = 0
        txtDBMS.Text = 0
        txtEnglish.Text = 0

        txtName.Focus()



    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtName.Focus()
        If Trim(txtName.Text) = "" Then
            MsgBox("Please Enter Student Name!", vbInformation, "Student Name Validation!")
            txtName.Focus()

        ElseIf Trim(cboGender.Text) = "" Then
            MsgBox("Please Select gender!", vbInformation, "Student gender Validation!")
            cboGender.Focus()


        ElseIf Trim(cboSkill.Text) = "" Then
            MsgBox("Please Select Skill!", vbInformation, "Student Skill Validation!")
            cboSkill.Focus()
        ElseIf Trim(txtVB.Text) = "" Then
            MsgBox("Please Enter VB.Net Score!", vbInformation, "Please Enter VB.Net Score!")
            txtVB.Focus()

        ElseIf Trim(txtJava.Text) = "" Then
            MsgBox("Please Enter Java Score!", vbInformation, "Please Enter Java Score!")
            txtJava.Focus()

        ElseIf Trim(txtDBMS.Text) = "" Then
            MsgBox("Please Enter DBMS Score!", vbInformation, "Please Enter DBMS Score!")
            txtJava.Focus()

        ElseIf Trim(txtEnglish.Text) = "" Then
            MsgBox("Please Enter English Score!", vbInformation, "Please Enter English Score!")
            txtJava.Focus()
        Else
            InitializeList()
            stuID += 1
            txtID.Text = stuID

            btnAdd.Enabled = True


            For Each lvi As ListViewItem In Me.lstStudents.Items
                lvi.UseItemStyleForSubItems = False
                lvi.SubItems(4).BackColor = Color.SeaGreen
                lvi.SubItems(5).BackColor = Color.SeaGreen
                lvi.SubItems(6).BackColor = Color.SeaGreen
                lvi.SubItems(7).BackColor = Color.SeaGreen
                lvi.SubItems(8).ForeColor = Color.Blue
                lvi.SubItems(8).ForeColor = Color.Blue
                lvi.SubItems(9).ForeColor = Color.Blue
                lvi.SubItems(10).ForeColor = Color.Blue
                'lvi.SubItems(11).ForeColor = Color.Blue
            Next
        End If

    End Sub

    Private Sub FrmStudentScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        stuID += 1
        txtID.Text = stuID



        txtVB.Text = 0
        txtJava.Text = 0
        txtDBMS.Text = 0
        txtEnglish.Text = 0


        AssignValidation(txtVB, ValidationType.Only_Numbers)
        AssignValidation(txtJava, ValidationType.Only_Numbers)
        AssignValidation(txtDBMS, ValidationType.Only_Numbers)
        AssignValidation(txtEnglish, ValidationType.Only_Numbers)

        txtName.Focus()
    End Sub
    Sub InitializeList()
        Dim list As ListViewItem

        list = New ListViewItem(txtID.Text)
        list.SubItems.Add(txtName.Text)
        list.SubItems.Add(cboGender.Text)
        list.SubItems.Add(cboSkill.Text)
        list.SubItems.Add(txtVB.Text)
        list.SubItems.Add(txtJava.Text)
        list.SubItems.Add(txtDBMS.Text)
        list.SubItems.Add(txtEnglish.Text)
        list.SubItems.Add(txtTotalScore.Text)
        list.SubItems.Add(txtAVG.Text)
        list.SubItems.Add(txtMension.Text)

        lstStudents.Items.Add(list)

    End Sub
    Private Sub calculateScore()
        If IsNumeric(txtVB.Text) Then
            VB = CDbl(txtVB.Text)
        End If

        If IsNumeric(txtJava.Text) Then
            JAVA = CDbl(txtJava.Text)
        End If

        If IsNumeric(txtDBMS.Text) Then
            DBMS = CDbl(txtDBMS.Text)
        End If

        If IsNumeric(txtEnglish.Text) Then
            ENG = CDbl(txtEnglish.Text)
        End If

        totalScore = (VB + JAVA + DBMS + ENG)
        txtTotalScore.Text = FormatNumber(totalScore, 2)
        txtAVG.Text = FormatNumber(totalScore / 4, 2)

        'totalScore = (txtVB.Text + txtJava.Text + txtDBMS.Text + txtEnglish.Text)
        'avg = totalScore / 4
        'mention = getMention(txtAVG.Text)
        'txtTotalScore.Text = totalScore
        'txtAVG.Text = avg
        txtMension.Text = getMention(txtAVG.Text)
    End Sub
    Private Function getMention(ByVal avg As Double) As Char
        Dim grade As Char

        If (avg >= 90) Then
            grade = "A"
        ElseIf (avg >= 80) Then
            grade = "B"
        ElseIf avg >= 70 Then
            grade = "C"
        ElseIf avg >= 60 Then
            grade = "D"
        ElseIf avg >= 50 Then
            grade = "E"
        Else
            grade = "F"
        End If
        Return grade

    End Function
    Private Sub ObjectPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub LstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged

    End Sub

    Private Sub TxtVB_TextChanged(sender As Object, e As EventArgs) Handles txtVB.TextChanged
        calculateScore()
    End Sub

    Private Sub TxtMension_TextChanged(sender As Object, e As EventArgs) Handles txtMension.TextChanged

    End Sub

    Private Sub txtEnglish_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnglish.KeyPress
        calculateScore()
    End Sub
    Private Sub TxtEnglish_TextChanged(sender As Object, e As EventArgs) Handles txtEnglish.TextChanged
        calculateScore()
    End Sub
    Private Sub txtDBMS_TextChanged(sender As Object, e As EventArgs) Handles txtDBMS.TextChanged
        calculateScore()
    End Sub
    Private Sub txtJava_TextChanged(sender As Object, e As EventArgs) Handles txtJava.TextChanged
        calculateScore()
    End Sub

    Private Sub lstStudents_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles lstStudents.ColumnWidthChanged
        'If ListView1Changing = False Then
        '    ListView1Changing = True
        '    ColumnHeader4.Width = ColumnHeader1.Width / 2
        '    ColumnHeader5.Width = ColumnHeader1.Width / 2
        '    ColumnHeader6.Width = ColumnHeader2.Width / 2
        '    ColumnHeader7.Width = ColumnHeader2.Width / 2
        '    ColumnHeader8.Width = ColumnHeader3.Width / 3
        '    ColumnHeader9.Width = ColumnHeader3.Width / 3
        '    ColumnHeader10.Width = ColumnHeader3.Width / 3
        '    ListView1Changing = False
        'End If
    End Sub
End Class
