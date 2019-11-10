<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_print_receipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_thanks = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Receipt_change = New System.Windows.Forms.Label()
        Me.Receipt_vat = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Receipt_sub_total = New System.Windows.Forms.Label()
        Me.Receipt_cash = New System.Windows.Forms.Label()
        Me.Receipt_total = New System.Windows.Forms.Label()
        Me.Receipt_contact = New System.Windows.Forms.Label()
        Me.DataGridView_transaction = New System.Windows.Forms.DataGridView()
        Me.ItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Receipt_time = New System.Windows.Forms.Label()
        Me.Receipt_date = New System.Windows.Forms.Label()
        Me.Receipt_cashier = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Receipt_invoice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_tin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Receipt_address = New System.Windows.Forms.Label()
        Me.Receipt_name = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Receipt_contact)
        Me.Panel1.Controls.Add(Me.DataGridView_transaction)
        Me.Panel1.Controls.Add(Me.Receipt_time)
        Me.Panel1.Controls.Add(Me.Receipt_date)
        Me.Panel1.Controls.Add(Me.Receipt_cashier)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Receipt_invoice)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label_tin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Receipt_address)
        Me.Panel1.Controls.Add(Me.Receipt_name)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 446)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label_thanks)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Receipt_change)
        Me.Panel2.Controls.Add(Me.Receipt_vat)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Receipt_sub_total)
        Me.Panel2.Controls.Add(Me.Receipt_cash)
        Me.Panel2.Controls.Add(Me.Receipt_total)
        Me.Panel2.Location = New System.Drawing.Point(0, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(303, 182)
        Me.Panel2.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Sub Total :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Discount :"
        '
        'Label_thanks
        '
        Me.Label_thanks.AutoSize = True
        Me.Label_thanks.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_thanks.Location = New System.Drawing.Point(42, 165)
        Me.Label_thanks.Name = "Label_thanks"
        Me.Label_thanks.Size = New System.Drawing.Size(215, 13)
        Me.Label_thanks.TabIndex = 23
        Me.Label_thanks.Text = "Thank you for shopping with us."
        Me.Label_thanks.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(45, 137)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(202, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "THIS IS YOUR OFFICIAL RECEIPT."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Total Amount :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(4, 124)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(295, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "================================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Cash :"
        '
        'Receipt_change
        '
        Me.Receipt_change.AutoSize = True
        Me.Receipt_change.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt_change.Location = New System.Drawing.Point(217, 99)
        Me.Receipt_change.Name = "Receipt_change"
        Me.Receipt_change.Size = New System.Drawing.Size(47, 18)
        Me.Receipt_change.TabIndex = 20
        Me.Receipt_change.Text = "0.00"
        '
        'Receipt_vat
        '
        Me.Receipt_vat.AutoSize = True
        Me.Receipt_vat.Location = New System.Drawing.Point(220, 27)
        Me.Receipt_vat.Name = "Receipt_vat"
        Me.Receipt_vat.Size = New System.Drawing.Size(32, 13)
        Me.Receipt_vat.TabIndex = 16
        Me.Receipt_vat.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 18)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Change :"
        '
        'Receipt_sub_total
        '
        Me.Receipt_sub_total.AutoSize = True
        Me.Receipt_sub_total.Location = New System.Drawing.Point(220, 4)
        Me.Receipt_sub_total.Name = "Receipt_sub_total"
        Me.Receipt_sub_total.Size = New System.Drawing.Size(32, 13)
        Me.Receipt_sub_total.TabIndex = 17
        Me.Receipt_sub_total.Text = "0.00"
        '
        'Receipt_cash
        '
        Me.Receipt_cash.AutoSize = True
        Me.Receipt_cash.Location = New System.Drawing.Point(220, 74)
        Me.Receipt_cash.Name = "Receipt_cash"
        Me.Receipt_cash.Size = New System.Drawing.Size(32, 13)
        Me.Receipt_cash.TabIndex = 19
        Me.Receipt_cash.Text = "0.00"
        '
        'Receipt_total
        '
        Me.Receipt_total.AutoSize = True
        Me.Receipt_total.Location = New System.Drawing.Point(220, 49)
        Me.Receipt_total.Name = "Receipt_total"
        Me.Receipt_total.Size = New System.Drawing.Size(32, 13)
        Me.Receipt_total.TabIndex = 18
        Me.Receipt_total.Text = "0.00"
        '
        'Receipt_contact
        '
        Me.Receipt_contact.AutoSize = True
        Me.Receipt_contact.Location = New System.Drawing.Point(140, 63)
        Me.Receipt_contact.Name = "Receipt_contact"
        Me.Receipt_contact.Size = New System.Drawing.Size(77, 13)
        Me.Receipt_contact.TabIndex = 24
        Me.Receipt_contact.Text = "0701113810"
        '
        'DataGridView_transaction
        '
        Me.DataGridView_transaction.AllowUserToAddRows = False
        Me.DataGridView_transaction.AllowUserToDeleteRows = False
        Me.DataGridView_transaction.AllowUserToResizeColumns = False
        Me.DataGridView_transaction.AllowUserToResizeRows = False
        Me.DataGridView_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_transaction.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_transaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_transaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView_transaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_transaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemQuantity, Me.Unit_name, Me.UnitPrice, Me.Amount})
        Me.DataGridView_transaction.Location = New System.Drawing.Point(-10, 157)
        Me.DataGridView_transaction.Name = "DataGridView_transaction"
        Me.DataGridView_transaction.ReadOnly = True
        Me.DataGridView_transaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView_transaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView_transaction.Size = New System.Drawing.Size(323, 108)
        Me.DataGridView_transaction.TabIndex = 10
        '
        'ItemQuantity
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ItemQuantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.ItemQuantity.FillWeight = 78.68021!
        Me.ItemQuantity.HeaderText = "Qty"
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.ReadOnly = True
        Me.ItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Unit_name
        '
        Me.Unit_name.FillWeight = 77.1066!
        Me.Unit_name.HeaderText = "Name"
        Me.Unit_name.Name = "Unit_name"
        Me.Unit_name.ReadOnly = True
        '
        'UnitPrice
        '
        Me.UnitPrice.FillWeight = 77.1066!
        Me.UnitPrice.HeaderText = "Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.FillWeight = 77.1066!
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'Receipt_time
        '
        Me.Receipt_time.AutoSize = True
        Me.Receipt_time.Location = New System.Drawing.Point(229, 128)
        Me.Receipt_time.Name = "Receipt_time"
        Me.Receipt_time.Size = New System.Drawing.Size(35, 13)
        Me.Receipt_time.TabIndex = 9
        Me.Receipt_time.Text = "Time"
        '
        'Receipt_date
        '
        Me.Receipt_date.AutoSize = True
        Me.Receipt_date.Location = New System.Drawing.Point(229, 111)
        Me.Receipt_date.Name = "Receipt_date"
        Me.Receipt_date.Size = New System.Drawing.Size(34, 13)
        Me.Receipt_date.TabIndex = 8
        Me.Receipt_date.Text = "Date"
        '
        'Receipt_cashier
        '
        Me.Receipt_cashier.AutoSize = True
        Me.Receipt_cashier.Location = New System.Drawing.Point(110, 128)
        Me.Receipt_cashier.Name = "Receipt_cashier"
        Me.Receipt_cashier.Size = New System.Drawing.Size(40, 13)
        Me.Receipt_cashier.TabIndex = 7
        Me.Receipt_cashier.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cashier :"
        '
        'Receipt_invoice
        '
        Me.Receipt_invoice.AutoSize = True
        Me.Receipt_invoice.Location = New System.Drawing.Point(110, 111)
        Me.Receipt_invoice.Name = "Receipt_invoice"
        Me.Receipt_invoice.Size = New System.Drawing.Size(49, 13)
        Me.Receipt_invoice.TabIndex = 5
        Me.Receipt_invoice.Text = "Invoice"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Invoice No :"
        '
        'Label_tin
        '
        Me.Label_tin.AutoSize = True
        Me.Label_tin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tin.Location = New System.Drawing.Point(46, 85)
        Me.Label_tin.Name = "Label_tin"
        Me.Label_tin.Size = New System.Drawing.Size(113, 13)
        Me.Label_tin.TabIndex = 3
        Me.Label_tin.Text = "TIN# 119-123-455"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact No : "
        '
        'Receipt_address
        '
        Me.Receipt_address.AutoSize = True
        Me.Receipt_address.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt_address.Location = New System.Drawing.Point(45, 41)
        Me.Receipt_address.Name = "Receipt_address"
        Me.Receipt_address.Size = New System.Drawing.Size(171, 13)
        Me.Receipt_address.TabIndex = 1
        Me.Receipt_address.Text = "[Company Address Here]"
        Me.Receipt_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Receipt_name
        '
        Me.Receipt_name.AutoSize = True
        Me.Receipt_name.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt_name.Location = New System.Drawing.Point(45, 11)
        Me.Receipt_name.Name = "Receipt_name"
        Me.Receipt_name.Size = New System.Drawing.Size(212, 18)
        Me.Receipt_name.TabIndex = 0
        Me.Receipt_name.Text = "[Company Name Here]"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form_print_receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 459)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_print_receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_print_receipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Receipt_address As Label
    Friend WithEvents Receipt_name As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView_transaction As DataGridView
    Friend WithEvents Receipt_time As Label
    Friend WithEvents Receipt_date As Label
    Friend WithEvents Receipt_cashier As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Receipt_invoice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_tin As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label_thanks As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Receipt_change As Label
    Friend WithEvents Receipt_cash As Label
    Friend WithEvents Receipt_total As Label
    Friend WithEvents Receipt_sub_total As Label
    Friend WithEvents Receipt_vat As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Receipt_contact As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Unit_name As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
