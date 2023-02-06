<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumber
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDevision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ចំនួនទី១"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(175, 44)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(222, 37)
        Me.txtNumber1.TabIndex = 1
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(175, 87)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(222, 37)
        Me.txtNumber2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ចំនួនទី២"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(175, 130)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(222, 37)
        Me.txtResult.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "លទ្ធផល"
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSum.Font = New System.Drawing.Font("Khmer OS Battambang", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSum.Location = New System.Drawing.Point(119, 191)
        Me.btnSum.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(58, 54)
        Me.btnSum.TabIndex = 6
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSub.Font = New System.Drawing.Font("Khmer OS Battambang", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(190, 191)
        Me.btnSub.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(58, 54)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnMult
        '
        Me.btnMult.BackColor = System.Drawing.Color.HotPink
        Me.btnMult.Font = New System.Drawing.Font("Khmer OS Battambang", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult.Location = New System.Drawing.Point(263, 191)
        Me.btnMult.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(58, 54)
        Me.btnMult.TabIndex = 8
        Me.btnMult.Text = "X"
        Me.btnMult.UseVisualStyleBackColor = False
        '
        'btnDevision
        '
        Me.btnDevision.BackColor = System.Drawing.Color.LimeGreen
        Me.btnDevision.Font = New System.Drawing.Font("Khmer OS Battambang", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevision.Location = New System.Drawing.Point(339, 191)
        Me.btnDevision.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDevision.Name = "btnDevision"
        Me.btnDevision.Size = New System.Drawing.Size(58, 54)
        Me.btnDevision.TabIndex = 9
        Me.btnDevision.Text = "/"
        Me.btnDevision.UseVisualStyleBackColor = False
        '
        'frmNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 282)
        Me.Controls.Add(Me.btnDevision)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmNumber"
        Me.Text = "ម៉ាស៊ីនគិតលេខ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSum As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDevision As Button
End Class
