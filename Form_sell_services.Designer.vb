<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_sell_services
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sell_service = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Service_name = New System.Windows.Forms.TextBox()
        Me.Service_quantity = New System.Windows.Forms.TextBox()
        Me.Service_unit_price = New System.Windows.Forms.TextBox()
        Me.Service_total_price = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Price"
        '
        'Sell_service
        '
        Me.Sell_service.BackColor = System.Drawing.Color.RoyalBlue
        Me.Sell_service.ForeColor = System.Drawing.Color.White
        Me.Sell_service.Location = New System.Drawing.Point(157, 275)
        Me.Sell_service.Name = "Sell_service"
        Me.Sell_service.Size = New System.Drawing.Size(111, 33)
        Me.Sell_service.TabIndex = 4
        Me.Sell_service.Text = "Sell Service"
        Me.Sell_service.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(330, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Service_name
        '
        Me.Service_name.Location = New System.Drawing.Point(157, 50)
        Me.Service_name.Name = "Service_name"
        Me.Service_name.Size = New System.Drawing.Size(276, 26)
        Me.Service_name.TabIndex = 6
        '
        'Service_quantity
        '
        Me.Service_quantity.Location = New System.Drawing.Point(157, 106)
        Me.Service_quantity.Name = "Service_quantity"
        Me.Service_quantity.Size = New System.Drawing.Size(276, 26)
        Me.Service_quantity.TabIndex = 7
        '
        'Service_unit_price
        '
        Me.Service_unit_price.Location = New System.Drawing.Point(157, 156)
        Me.Service_unit_price.Name = "Service_unit_price"
        Me.Service_unit_price.Size = New System.Drawing.Size(276, 26)
        Me.Service_unit_price.TabIndex = 8
        '
        'Service_total_price
        '
        Me.Service_total_price.Enabled = False
        Me.Service_total_price.Location = New System.Drawing.Point(157, 208)
        Me.Service_total_price.Name = "Service_total_price"
        Me.Service_total_price.ReadOnly = True
        Me.Service_total_price.Size = New System.Drawing.Size(276, 26)
        Me.Service_total_price.TabIndex = 9
        '
        'Form_sell_services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(496, 357)
        Me.Controls.Add(Me.Service_total_price)
        Me.Controls.Add(Me.Service_unit_price)
        Me.Controls.Add(Me.Service_quantity)
        Me.Controls.Add(Me.Service_name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Sell_service)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_sell_services"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_sell_services"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Sell_service As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Service_name As TextBox
    Friend WithEvents Service_quantity As TextBox
    Friend WithEvents Service_unit_price As TextBox
    Friend WithEvents Service_total_price As TextBox
End Class
