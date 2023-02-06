<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsingString
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
        Me.btnReplacingSubStr = New System.Windows.Forms.Button()
        Me.btnSubString = New System.Windows.Forms.Button()
        Me.btnConcatenationInline = New System.Windows.Forms.Button()
        Me.btnConcatination = New System.Windows.Forms.Button()
        Me.btnUsingString = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnConcateWithForm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnConcateWithForm)
        Me.GroupBox1.Controls.Add(Me.txtString)
        Me.GroupBox1.Controls.Add(Me.btnLength)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtResult)
        Me.GroupBox1.Controls.Add(Me.btnReplacingSubStr)
        Me.GroupBox1.Controls.Add(Me.btnSubString)
        Me.GroupBox1.Controls.Add(Me.btnConcatenationInline)
        Me.GroupBox1.Controls.Add(Me.btnConcatination)
        Me.GroupBox1.Controls.Add(Me.btnUsingString)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 438)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ធ្វើការជាមួយ String"
        '
        'btnReplacingSubStr
        '
        Me.btnReplacingSubStr.Location = New System.Drawing.Point(23, 222)
        Me.btnReplacingSubStr.Name = "btnReplacingSubStr"
        Me.btnReplacingSubStr.Size = New System.Drawing.Size(540, 40)
        Me.btnReplacingSubStr.TabIndex = 9
        Me.btnReplacingSubStr.Text = "ការប្រើប្រាស់ Replacing Substrings"
        Me.btnReplacingSubStr.UseVisualStyleBackColor = True
        '
        'btnSubString
        '
        Me.btnSubString.Location = New System.Drawing.Point(23, 176)
        Me.btnSubString.Name = "btnSubString"
        Me.btnSubString.Size = New System.Drawing.Size(540, 40)
        Me.btnSubString.TabIndex = 8
        Me.btnSubString.Text = "ការប្រើប្រាស់ SubString"
        Me.btnSubString.UseVisualStyleBackColor = True
        '
        'btnConcatenationInline
        '
        Me.btnConcatenationInline.Location = New System.Drawing.Point(23, 130)
        Me.btnConcatenationInline.Name = "btnConcatenationInline"
        Me.btnConcatenationInline.Size = New System.Drawing.Size(540, 40)
        Me.btnConcatenationInline.TabIndex = 7
        Me.btnConcatenationInline.Text = "ការប្រើ Concatenation Inline"
        Me.btnConcatenationInline.UseVisualStyleBackColor = True
        '
        'btnConcatination
        '
        Me.btnConcatination.Location = New System.Drawing.Point(23, 84)
        Me.btnConcatination.Name = "btnConcatination"
        Me.btnConcatination.Size = New System.Drawing.Size(380, 40)
        Me.btnConcatination.TabIndex = 6
        Me.btnConcatination.Text = "ការប្រើប្រាស់ Concatenation"
        Me.btnConcatination.UseVisualStyleBackColor = True
        '
        'btnUsingString
        '
        Me.btnUsingString.Location = New System.Drawing.Point(23, 38)
        Me.btnUsingString.Name = "btnUsingString"
        Me.btnUsingString.Size = New System.Drawing.Size(540, 40)
        Me.btnUsingString.TabIndex = 5
        Me.btnUsingString.Text = "ការប្រើប្រាស់ String"
        Me.btnUsingString.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(27, 318)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(532, 37)
        Me.txtResult.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "លទ្ធផល-Result"
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(421, 372)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(137, 41)
        Me.btnLength.TabIndex = 12
        Me.btnLength.Text = "ប្រវែង-Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(27, 372)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(376, 37)
        Me.txtString.TabIndex = 13
        '
        'btnConcateWithForm
        '
        Me.btnConcateWithForm.Location = New System.Drawing.Point(409, 84)
        Me.btnConcateWithForm.Name = "btnConcateWithForm"
        Me.btnConcateWithForm.Size = New System.Drawing.Size(154, 40)
        Me.btnConcateWithForm.TabIndex = 14
        Me.btnConcateWithForm.Text = "ជាមួយ Form"
        Me.btnConcateWithForm.UseVisualStyleBackColor = True
        '
        'frmUsingString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmUsingString"
        Me.Text = "Using String"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnReplacingSubStr As Button
    Friend WithEvents btnSubString As Button
    Friend WithEvents btnConcatenationInline As Button
    Friend WithEvents btnConcatination As Button
    Friend WithEvents btnUsingString As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents btnLength As Button
    Friend WithEvents btnConcateWithForm As Button
End Class
