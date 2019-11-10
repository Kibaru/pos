<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_product_quantity
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
        Me.Product_quantity_change = New System.Windows.Forms.TextBox()
        Me.Product_name = New System.Windows.Forms.Label()
        Me.Quantity_ok = New System.Windows.Forms.Button()
        Me.Quantity_cancel = New System.Windows.Forms.Button()
        Me.Product_price = New System.Windows.Forms.Label()
        Me.Quantity_error = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'Product_quantity_change
        '
        Me.Product_quantity_change.Location = New System.Drawing.Point(161, 87)
        Me.Product_quantity_change.Name = "Product_quantity_change"
        Me.Product_quantity_change.Size = New System.Drawing.Size(153, 26)
        Me.Product_quantity_change.TabIndex = 1
        '
        'Product_name
        '
        Me.Product_name.AutoSize = True
        Me.Product_name.Location = New System.Drawing.Point(158, 21)
        Me.Product_name.Name = "Product_name"
        Me.Product_name.Size = New System.Drawing.Size(55, 20)
        Me.Product_name.TabIndex = 2
        Me.Product_name.Text = "Name"
        '
        'Quantity_ok
        '
        Me.Quantity_ok.BackColor = System.Drawing.Color.LimeGreen
        Me.Quantity_ok.ForeColor = System.Drawing.Color.White
        Me.Quantity_ok.Location = New System.Drawing.Point(72, 169)
        Me.Quantity_ok.Name = "Quantity_ok"
        Me.Quantity_ok.Size = New System.Drawing.Size(152, 36)
        Me.Quantity_ok.TabIndex = 3
        Me.Quantity_ok.Text = "Update Quantity"
        Me.Quantity_ok.UseVisualStyleBackColor = False
        '
        'Quantity_cancel
        '
        Me.Quantity_cancel.BackColor = System.Drawing.Color.Red
        Me.Quantity_cancel.ForeColor = System.Drawing.Color.White
        Me.Quantity_cancel.Location = New System.Drawing.Point(230, 169)
        Me.Quantity_cancel.Name = "Quantity_cancel"
        Me.Quantity_cancel.Size = New System.Drawing.Size(84, 36)
        Me.Quantity_cancel.TabIndex = 4
        Me.Quantity_cancel.Text = "Cancel"
        Me.Quantity_cancel.UseVisualStyleBackColor = False
        '
        'Product_price
        '
        Me.Product_price.AutoSize = True
        Me.Product_price.Location = New System.Drawing.Point(268, 21)
        Me.Product_price.Name = "Product_price"
        Me.Product_price.Size = New System.Drawing.Size(46, 18)
        Me.Product_price.TabIndex = 6
        Me.Product_price.Text = "Price"
        '
        'Quantity_error
        '
        Me.Quantity_error.AutoSize = True
        Me.Quantity_error.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity_error.ForeColor = System.Drawing.Color.Crimson
        Me.Quantity_error.Location = New System.Drawing.Point(70, 125)
        Me.Quantity_error.Name = "Quantity_error"
        Me.Quantity_error.Size = New System.Drawing.Size(13, 20)
        Me.Quantity_error.TabIndex = 7
        Me.Quantity_error.Text = "."
        '
        'Form_product_quantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(382, 248)
        Me.Controls.Add(Me.Quantity_error)
        Me.Controls.Add(Me.Quantity_cancel)
        Me.Controls.Add(Me.Quantity_ok)
        Me.Controls.Add(Me.Product_name)
        Me.Controls.Add(Me.Product_quantity_change)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_product_quantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_product_quantity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Product_quantity_change As TextBox
    Friend WithEvents Quantity_ok As Button
    Friend WithEvents Quantity_cancel As Button
    Friend WithEvents Product_name As Label
    Friend WithEvents Product_price As Label
    Friend WithEvents Quantity_error As Label
End Class
