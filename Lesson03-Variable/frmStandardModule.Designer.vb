<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandardModule
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
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.txtStandard = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeCrease = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIncrease
        '
        Me.btnIncrease.Location = New System.Drawing.Point(278, 106)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(145, 34)
        Me.btnIncrease.TabIndex = 6
        Me.btnIncrease.Text = "បង្កើនលេខ"
        Me.btnIncrease.UseVisualStyleBackColor = True
        '
        'txtStandard
        '
        Me.txtStandard.Location = New System.Drawing.Point(159, 52)
        Me.txtStandard.Name = "txtStandard"
        Me.txtStandard.Size = New System.Drawing.Size(264, 37)
        Me.txtStandard.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Standard Module"
        '
        'btnDeCrease
        '
        Me.btnDeCrease.Location = New System.Drawing.Point(159, 106)
        Me.btnDeCrease.Name = "btnDeCrease"
        Me.btnDeCrease.Size = New System.Drawing.Size(112, 34)
        Me.btnDeCrease.TabIndex = 7
        Me.btnDeCrease.Text = "បន្ថយលេខ"
        Me.btnDeCrease.UseVisualStyleBackColor = True
        '
        'frmStandardModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 203)
        Me.Controls.Add(Me.btnDeCrease)
        Me.Controls.Add(Me.btnIncrease)
        Me.Controls.Add(Me.txtStandard)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmStandardModule"
        Me.Text = "Standard Module"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIncrease As Button
    Friend WithEvents txtStandard As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeCrease As Button
End Class
