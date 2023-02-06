<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSkill = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstStudents = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMension = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAVG = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDBMS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJava = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.cboSkill)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "បញ្ចូលពត៌មានសិស្ស"
        '
        'cboSkill
        '
        Me.cboSkill.FormattingEnabled = True
        Me.cboSkill.Items.AddRange(New Object() {"ICT-P14", "ICT-P15", "ACC-P13", "ACC-P14"})
        Me.cboSkill.Location = New System.Drawing.Point(166, 165)
        Me.cboSkill.Name = "cboSkill"
        Me.cboSkill.Size = New System.Drawing.Size(306, 44)
        Me.cboSkill.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 36)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ជំនាញ-ជំនាន់"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(167, 122)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(194, 44)
        Me.cboGender.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ភេទ"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(167, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(307, 45)
        Me.txtName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "គោត្តនាម និងនាម"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtID.Location = New System.Drawing.Point(166, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(195, 45)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "លេខរៀង"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(950, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "គ្រប់គ្រងពិន្ទុសិស្ស"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(767, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 242)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "សកម្មភាព"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(21, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 39)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "ចាកចេញ"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(21, 130)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(155, 39)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "កែប្រែ"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(21, 85)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(155, 39)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(21, 40)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 39)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "បន្ថែម"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstStudents
        '
        Me.lstStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lstStudents.FullRowSelect = True
        Me.lstStudents.GridLines = True
        Me.lstStudents.HideSelection = False
        Me.lstStudents.Location = New System.Drawing.Point(12, 475)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(963, 215)
        Me.lstStudents.TabIndex = 3
        Me.lstStudents.UseCompatibleStateImageBehavior = False
        Me.lstStudents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ល.រ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "គោត្តនាម និងនាម"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ភេទ"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ជំនាញ-ជំនាន់"
        Me.ColumnHeader4.Width = 160
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "VB.Net"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Java"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "DBMS"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "English"
        Me.ColumnHeader8.Width = 80
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total Score"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Average"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Mention"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 80
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.txtMension)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtAVG)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtTotalScore)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtEnglish)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtDBMS)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtJava)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtVB)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(950, 142)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "បញ្ចូលពិន្ទុសិស្ស"
        '
        'txtMension
        '
        Me.txtMension.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMension.Location = New System.Drawing.Point(807, 72)
        Me.txtMension.Name = "txtMension"
        Me.txtMension.ReadOnly = True
        Me.txtMension.Size = New System.Drawing.Size(128, 45)
        Me.txtMension.TabIndex = 15
        Me.txtMension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(807, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 36)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "MENTION"
        '
        'txtAVG
        '
        Me.txtAVG.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAVG.Location = New System.Drawing.Point(669, 72)
        Me.txtAVG.Name = "txtAVG"
        Me.txtAVG.ReadOnly = True
        Me.txtAVG.Size = New System.Drawing.Size(128, 45)
        Me.txtAVG.TabIndex = 13
        Me.txtAVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(678, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 36)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "AVERAGE"
        '
        'txtTotalScore
        '
        Me.txtTotalScore.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalScore.Location = New System.Drawing.Point(535, 72)
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.ReadOnly = True
        Me.txtTotalScore.Size = New System.Drawing.Size(128, 45)
        Me.txtTotalScore.TabIndex = 11
        Me.txtTotalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(535, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 36)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "TOTAL SCORE"
        '
        'txtEnglish
        '
        Me.txtEnglish.BackColor = System.Drawing.Color.SeaGreen
        Me.txtEnglish.Location = New System.Drawing.Point(318, 72)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(84, 45)
        Me.txtEnglish.TabIndex = 8
        Me.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 36)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ENGLISH"
        '
        'txtDBMS
        '
        Me.txtDBMS.BackColor = System.Drawing.Color.SeaGreen
        Me.txtDBMS.Location = New System.Drawing.Point(221, 72)
        Me.txtDBMS.Name = "txtDBMS"
        Me.txtDBMS.Size = New System.Drawing.Size(84, 45)
        Me.txtDBMS.TabIndex = 7
        Me.txtDBMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 36)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "DBMS"
        '
        'txtJava
        '
        Me.txtJava.BackColor = System.Drawing.Color.SeaGreen
        Me.txtJava.Location = New System.Drawing.Point(124, 72)
        Me.txtJava.Name = "txtJava"
        Me.txtJava.Size = New System.Drawing.Size(84, 45)
        Me.txtJava.TabIndex = 6
        Me.txtJava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(124, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 36)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "JAVA"
        '
        'txtVB
        '
        Me.txtVB.BackColor = System.Drawing.Color.SeaGreen
        Me.txtVB.Location = New System.Drawing.Point(27, 72)
        Me.txtVB.Name = "txtVB"
        Me.txtVB.Size = New System.Drawing.Size(84, 45)
        Me.txtVB.TabIndex = 5
        Me.txtVB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 36)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "VB.Net"
        '
        'frmStudentScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 713)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lstStudents)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmStudentScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Score"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSkill As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstStudents As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMension As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAVG As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalScore As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDBMS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJava As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
End Class
