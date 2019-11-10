<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_create_new_product
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
        Me.Label_cat = New System.Windows.Forms.Label()
        Me.Product_select_cat = New System.Windows.Forms.ComboBox()
        Me.Button_new_cat = New System.Windows.Forms.Button()
        Me.TextBox_p_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_p_quantity = New System.Windows.Forms.TextBox()
        Me.TextBox_p_bprice = New System.Windows.Forms.TextBox()
        Me.TextBox_p_sprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextbox_description = New System.Windows.Forms.RichTextBox()
        Me.Button_add_product = New System.Windows.Forms.Button()
        Me.Button_cancel_product = New System.Windows.Forms.Button()
        Me.Button_update_product = New System.Windows.Forms.Button()
        Me.Product_id = New System.Windows.Forms.TextBox()
        Me.Product_bar_code = New System.Windows.Forms.TextBox()
        Me.Products_picture_box = New System.Windows.Forms.PictureBox()
        Me.Browse_images = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Products_picture_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_cat
        '
        Me.Label_cat.AutoSize = True
        Me.Label_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_cat.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label_cat.Location = New System.Drawing.Point(26, 35)
        Me.Label_cat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_cat.Name = "Label_cat"
        Me.Label_cat.Size = New System.Drawing.Size(63, 15)
        Me.Label_cat.TabIndex = 0
        Me.Label_cat.Text = "Category"
        '
        'Product_select_cat
        '
        Me.Product_select_cat.AllowDrop = True
        Me.Product_select_cat.DropDownHeight = 100
        Me.Product_select_cat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Product_select_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_select_cat.FormattingEnabled = True
        Me.Product_select_cat.IntegralHeight = False
        Me.Product_select_cat.Location = New System.Drawing.Point(142, 31)
        Me.Product_select_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.Product_select_cat.Name = "Product_select_cat"
        Me.Product_select_cat.Size = New System.Drawing.Size(196, 24)
        Me.Product_select_cat.TabIndex = 1
        '
        'Button_new_cat
        '
        Me.Button_new_cat.BackColor = System.Drawing.Color.Blue
        Me.Button_new_cat.ForeColor = System.Drawing.Color.White
        Me.Button_new_cat.Location = New System.Drawing.Point(359, 24)
        Me.Button_new_cat.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_new_cat.Name = "Button_new_cat"
        Me.Button_new_cat.Size = New System.Drawing.Size(137, 37)
        Me.Button_new_cat.TabIndex = 2
        Me.Button_new_cat.Text = "Add new category"
        Me.Button_new_cat.UseVisualStyleBackColor = False
        '
        'TextBox_p_name
        '
        Me.TextBox_p_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_p_name.Location = New System.Drawing.Point(142, 91)
        Me.TextBox_p_name.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_p_name.Name = "TextBox_p_name"
        Me.TextBox_p_name.Size = New System.Drawing.Size(354, 22)
        Me.TextBox_p_name.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(26, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantity"
        '
        'TextBox_p_quantity
        '
        Me.TextBox_p_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_p_quantity.Location = New System.Drawing.Point(142, 156)
        Me.TextBox_p_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_p_quantity.Name = "TextBox_p_quantity"
        Me.TextBox_p_quantity.Size = New System.Drawing.Size(196, 22)
        Me.TextBox_p_quantity.TabIndex = 6
        '
        'TextBox_p_bprice
        '
        Me.TextBox_p_bprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_p_bprice.Location = New System.Drawing.Point(142, 214)
        Me.TextBox_p_bprice.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_p_bprice.Name = "TextBox_p_bprice"
        Me.TextBox_p_bprice.Size = New System.Drawing.Size(196, 22)
        Me.TextBox_p_bprice.TabIndex = 7
        '
        'TextBox_p_sprice
        '
        Me.TextBox_p_sprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_p_sprice.Location = New System.Drawing.Point(142, 272)
        Me.TextBox_p_sprice.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_p_sprice.Name = "TextBox_p_sprice"
        Me.TextBox_p_sprice.Size = New System.Drawing.Size(196, 22)
        Me.TextBox_p_sprice.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(26, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Buying Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(26, 275)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Selling Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(26, 328)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Description"
        '
        'RichTextbox_description
        '
        Me.RichTextbox_description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextbox_description.Location = New System.Drawing.Point(142, 325)
        Me.RichTextbox_description.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextbox_description.Name = "RichTextbox_description"
        Me.RichTextbox_description.Size = New System.Drawing.Size(354, 119)
        Me.RichTextbox_description.TabIndex = 13
        Me.RichTextbox_description.Text = ""
        '
        'Button_add_product
        '
        Me.Button_add_product.BackColor = System.Drawing.Color.Green
        Me.Button_add_product.ForeColor = System.Drawing.Color.White
        Me.Button_add_product.Location = New System.Drawing.Point(142, 484)
        Me.Button_add_product.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_add_product.Name = "Button_add_product"
        Me.Button_add_product.Size = New System.Drawing.Size(142, 41)
        Me.Button_add_product.TabIndex = 14
        Me.Button_add_product.Text = "Create"
        Me.Button_add_product.UseVisualStyleBackColor = False
        '
        'Button_cancel_product
        '
        Me.Button_cancel_product.BackColor = System.Drawing.Color.DarkRed
        Me.Button_cancel_product.ForeColor = System.Drawing.Color.White
        Me.Button_cancel_product.Location = New System.Drawing.Point(377, 484)
        Me.Button_cancel_product.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_cancel_product.Name = "Button_cancel_product"
        Me.Button_cancel_product.Size = New System.Drawing.Size(119, 41)
        Me.Button_cancel_product.TabIndex = 15
        Me.Button_cancel_product.Text = "Cancel"
        Me.Button_cancel_product.UseVisualStyleBackColor = False
        '
        'Button_update_product
        '
        Me.Button_update_product.BackColor = System.Drawing.Color.Orange
        Me.Button_update_product.Location = New System.Drawing.Point(29, 484)
        Me.Button_update_product.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_update_product.Name = "Button_update_product"
        Me.Button_update_product.Size = New System.Drawing.Size(119, 41)
        Me.Button_update_product.TabIndex = 16
        Me.Button_update_product.Text = "Update"
        Me.Button_update_product.UseVisualStyleBackColor = False
        '
        'Product_id
        '
        Me.Product_id.Enabled = False
        Me.Product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_id.Location = New System.Drawing.Point(142, -12)
        Me.Product_id.Margin = New System.Windows.Forms.Padding(4)
        Me.Product_id.Name = "Product_id"
        Me.Product_id.Size = New System.Drawing.Size(64, 22)
        Me.Product_id.TabIndex = 19
        Me.Product_id.Visible = False
        '
        'Product_bar_code
        '
        Me.Product_bar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_bar_code.Location = New System.Drawing.Point(249, -12)
        Me.Product_bar_code.Margin = New System.Windows.Forms.Padding(4)
        Me.Product_bar_code.Name = "Product_bar_code"
        Me.Product_bar_code.Size = New System.Drawing.Size(108, 22)
        Me.Product_bar_code.TabIndex = 20
        Me.Product_bar_code.Visible = False
        '
        'Products_picture_box
        '
        Me.Products_picture_box.BackColor = System.Drawing.Color.Black
        Me.Products_picture_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Products_picture_box.Location = New System.Drawing.Point(359, 121)
        Me.Products_picture_box.Margin = New System.Windows.Forms.Padding(4)
        Me.Products_picture_box.Name = "Products_picture_box"
        Me.Products_picture_box.Size = New System.Drawing.Size(136, 115)
        Me.Products_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Products_picture_box.TabIndex = 21
        Me.Products_picture_box.TabStop = False
        '
        'Browse_images
        '
        Me.Browse_images.BackColor = System.Drawing.Color.RoyalBlue
        Me.Browse_images.ForeColor = System.Drawing.Color.White
        Me.Browse_images.Location = New System.Drawing.Point(358, 266)
        Me.Browse_images.Margin = New System.Windows.Forms.Padding(4)
        Me.Browse_images.Name = "Browse_images"
        Me.Browse_images.Size = New System.Drawing.Size(137, 32)
        Me.Browse_images.TabIndex = 22
        Me.Browse_images.Text = "Add Image"
        Me.Browse_images.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form_create_new_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(536, 546)
        Me.Controls.Add(Me.Browse_images)
        Me.Controls.Add(Me.Products_picture_box)
        Me.Controls.Add(Me.Product_bar_code)
        Me.Controls.Add(Me.Product_id)
        Me.Controls.Add(Me.Button_update_product)
        Me.Controls.Add(Me.Button_cancel_product)
        Me.Controls.Add(Me.Button_add_product)
        Me.Controls.Add(Me.RichTextbox_description)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_p_sprice)
        Me.Controls.Add(Me.TextBox_p_bprice)
        Me.Controls.Add(Me.TextBox_p_quantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_p_name)
        Me.Controls.Add(Me.Button_new_cat)
        Me.Controls.Add(Me.Product_select_cat)
        Me.Controls.Add(Me.Label_cat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_create_new_product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_product"
        CType(Me.Products_picture_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_cat As Label
    Friend WithEvents Product_select_cat As ComboBox
    Friend WithEvents Button_new_cat As Button
    Friend WithEvents TextBox_p_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_p_quantity As TextBox
    Friend WithEvents TextBox_p_bprice As TextBox
    Friend WithEvents TextBox_p_sprice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextbox_description As RichTextBox
    Friend WithEvents Button_add_product As Button
    Friend WithEvents Button_cancel_product As Button
    Friend WithEvents Button_update_product As Button
    Friend WithEvents Product_id As TextBox
    Friend WithEvents Product_bar_code As TextBox
    Friend WithEvents Products_picture_box As PictureBox
    Friend WithEvents Browse_images As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
