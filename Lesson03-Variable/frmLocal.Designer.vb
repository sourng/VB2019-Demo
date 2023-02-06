<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocal
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
        Me.txtTestLocal = New System.Windows.Forms.TextBox()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local Variable"
        '
        'txtTestLocal
        '
        Me.txtTestLocal.Location = New System.Drawing.Point(141, 54)
        Me.txtTestLocal.Name = "txtTestLocal"
        Me.txtTestLocal.Size = New System.Drawing.Size(197, 37)
        Me.txtTestLocal.TabIndex = 1
        '
        'btnLocal
        '
        Me.btnLocal.Location = New System.Drawing.Point(360, 57)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(143, 34)
        Me.btnLocal.TabIndex = 3
        Me.btnLocal.Text = "Test Local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'frmLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 185)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.txtTestLocal)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmLocal"
        Me.Text = "Local Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTestLocal As TextBox
    Friend WithEvents btnLocal As Button
End Class
