<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_new_category
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
        Me.Add_category_name = New System.Windows.Forms.TextBox()
        Me.Add_new_category = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Add_category_name
        '
        Me.Add_category_name.Location = New System.Drawing.Point(75, 89)
        Me.Add_category_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Add_category_name.Name = "Add_category_name"
        Me.Add_category_name.Size = New System.Drawing.Size(250, 26)
        Me.Add_category_name.TabIndex = 0
        '
        'Add_new_category
        '
        Me.Add_new_category.BackColor = System.Drawing.Color.RoyalBlue
        Me.Add_new_category.ForeColor = System.Drawing.Color.White
        Me.Add_new_category.Location = New System.Drawing.Point(75, 185)
        Me.Add_new_category.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Add_new_category.Name = "Add_new_category"
        Me.Add_new_category.Size = New System.Drawing.Size(151, 35)
        Me.Add_new_category.TabIndex = 1
        Me.Add_new_category.Text = "Add Category"
        Me.Add_new_category.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(233, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form_new_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(414, 311)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Add_new_category)
        Me.Controls.Add(Me.Add_category_name)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_new_category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_new_category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add_category_name As TextBox
    Friend WithEvents Add_new_category As Button
    Friend WithEvents Button1 As Button
End Class
