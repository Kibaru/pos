<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_create_customer
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_deposit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_ref = New System.Windows.Forms.Label()
        Me.Label_srn = New System.Windows.Forms.Label()
        Me.Label_work = New System.Windows.Forms.Label()
        Me.Label_meter = New System.Windows.Forms.Label()
        Me.Customer_id = New System.Windows.Forms.TextBox()
        Me.Customer_ref = New System.Windows.Forms.TextBox()
        Me.Customer_srn = New System.Windows.Forms.TextBox()
        Me.Customer_work = New System.Windows.Forms.TextBox()
        Me.Customer_meter = New System.Windows.Forms.TextBox()
        Me.Customer_name = New System.Windows.Forms.TextBox()
        Me.Customer_location = New System.Windows.Forms.TextBox()
        Me.Customer_kra = New System.Windows.Forms.TextBox()
        Me.Customer_tel = New System.Windows.Forms.TextBox()
        Me.Customer_email = New System.Windows.Forms.TextBox()
        Me.Customer_to_be_paid = New System.Windows.Forms.TextBox()
        Me.Customer_deposit = New System.Windows.Forms.TextBox()
        Me.Customer_bal = New System.Windows.Forms.TextBox()
        Me.ComboBox_1_elect = New System.Windows.Forms.ComboBox()
        Me.ComboBox_2_elect = New System.Windows.Forms.ComboBox()
        Me.Button_create_customer = New System.Windows.Forms.Button()
        Me.Button_update_customer = New System.Windows.Forms.Button()
        Me.Label_required = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button_srn = New System.Windows.Forms.Button()
        Me.Button_work = New System.Windows.Forms.Button()
        Me.Button_meter = New System.Windows.Forms.Button()
        Me.Label_instalment = New System.Windows.Forms.Label()
        Me.Customer_rest_payment = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox_pay_mode = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label_amnt = New System.Windows.Forms.Label()
        Me.Customer_whole_amnt = New System.Windows.Forms.TextBox()
        Me.Customer_auto_id = New System.Windows.Forms.TextBox()
        Me.Customer_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Tel No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "1st Electrician"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "2nd Electrician"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "To  be paid"
        '
        'Label_deposit
        '
        Me.Label_deposit.AutoSize = True
        Me.Label_deposit.Location = New System.Drawing.Point(52, 448)
        Me.Label_deposit.Name = "Label_deposit"
        Me.Label_deposit.Size = New System.Drawing.Size(57, 18)
        Me.Label_deposit.TabIndex = 7
        Me.Label_deposit.Text = "Deposit"
        Me.Label_deposit.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 546)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Balance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "National Id"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "KRA Pin"
        '
        'Label_ref
        '
        Me.Label_ref.AutoSize = True
        Me.Label_ref.Location = New System.Drawing.Point(457, 20)
        Me.Label_ref.Name = "Label_ref"
        Me.Label_ref.Size = New System.Drawing.Size(58, 18)
        Me.Label_ref.TabIndex = 11
        Me.Label_ref.Text = "Ref No."
        '
        'Label_srn
        '
        Me.Label_srn.AutoSize = True
        Me.Label_srn.Location = New System.Drawing.Point(457, 99)
        Me.Label_srn.Name = "Label_srn"
        Me.Label_srn.Size = New System.Drawing.Size(65, 18)
        Me.Label_srn.TabIndex = 12
        Me.Label_srn.Text = "SRN No."
        Me.Label_srn.Visible = False
        '
        'Label_work
        '
        Me.Label_work.AutoSize = True
        Me.Label_work.Location = New System.Drawing.Point(458, 180)
        Me.Label_work.Name = "Label_work"
        Me.Label_work.Size = New System.Drawing.Size(71, 18)
        Me.Label_work.TabIndex = 13
        Me.Label_work.Text = "Work No."
        Me.Label_work.Visible = False
        '
        'Label_meter
        '
        Me.Label_meter.AutoSize = True
        Me.Label_meter.Location = New System.Drawing.Point(458, 265)
        Me.Label_meter.Name = "Label_meter"
        Me.Label_meter.Size = New System.Drawing.Size(72, 18)
        Me.Label_meter.TabIndex = 14
        Me.Label_meter.Text = "Meter No."
        Me.Label_meter.Visible = False
        '
        'Customer_id
        '
        Me.Customer_id.Location = New System.Drawing.Point(179, 15)
        Me.Customer_id.Name = "Customer_id"
        Me.Customer_id.Size = New System.Drawing.Size(176, 25)
        Me.Customer_id.TabIndex = 15
        '
        'Customer_ref
        '
        Me.Customer_ref.Location = New System.Drawing.Point(542, 19)
        Me.Customer_ref.Name = "Customer_ref"
        Me.Customer_ref.Size = New System.Drawing.Size(123, 25)
        Me.Customer_ref.TabIndex = 16
        '
        'Customer_srn
        '
        Me.Customer_srn.Location = New System.Drawing.Point(542, 99)
        Me.Customer_srn.Name = "Customer_srn"
        Me.Customer_srn.Size = New System.Drawing.Size(123, 25)
        Me.Customer_srn.TabIndex = 17
        Me.Customer_srn.Visible = False
        '
        'Customer_work
        '
        Me.Customer_work.Location = New System.Drawing.Point(542, 180)
        Me.Customer_work.Name = "Customer_work"
        Me.Customer_work.Size = New System.Drawing.Size(123, 25)
        Me.Customer_work.TabIndex = 18
        Me.Customer_work.Visible = False
        '
        'Customer_meter
        '
        Me.Customer_meter.Location = New System.Drawing.Point(542, 265)
        Me.Customer_meter.Name = "Customer_meter"
        Me.Customer_meter.Size = New System.Drawing.Size(123, 25)
        Me.Customer_meter.TabIndex = 19
        Me.Customer_meter.Visible = False
        '
        'Customer_name
        '
        Me.Customer_name.Location = New System.Drawing.Point(179, 56)
        Me.Customer_name.Name = "Customer_name"
        Me.Customer_name.Size = New System.Drawing.Size(176, 25)
        Me.Customer_name.TabIndex = 20
        '
        'Customer_location
        '
        Me.Customer_location.Location = New System.Drawing.Point(179, 100)
        Me.Customer_location.Name = "Customer_location"
        Me.Customer_location.Size = New System.Drawing.Size(176, 25)
        Me.Customer_location.TabIndex = 21
        '
        'Customer_kra
        '
        Me.Customer_kra.Location = New System.Drawing.Point(179, 141)
        Me.Customer_kra.Name = "Customer_kra"
        Me.Customer_kra.Size = New System.Drawing.Size(176, 25)
        Me.Customer_kra.TabIndex = 22
        '
        'Customer_tel
        '
        Me.Customer_tel.Location = New System.Drawing.Point(179, 185)
        Me.Customer_tel.Name = "Customer_tel"
        Me.Customer_tel.Size = New System.Drawing.Size(176, 25)
        Me.Customer_tel.TabIndex = 23
        '
        'Customer_email
        '
        Me.Customer_email.Location = New System.Drawing.Point(179, 227)
        Me.Customer_email.Name = "Customer_email"
        Me.Customer_email.Size = New System.Drawing.Size(176, 25)
        Me.Customer_email.TabIndex = 24
        '
        'Customer_to_be_paid
        '
        Me.Customer_to_be_paid.Location = New System.Drawing.Point(179, 357)
        Me.Customer_to_be_paid.Name = "Customer_to_be_paid"
        Me.Customer_to_be_paid.Size = New System.Drawing.Size(176, 25)
        Me.Customer_to_be_paid.TabIndex = 25
        '
        'Customer_deposit
        '
        Me.Customer_deposit.Location = New System.Drawing.Point(178, 449)
        Me.Customer_deposit.Name = "Customer_deposit"
        Me.Customer_deposit.Size = New System.Drawing.Size(176, 25)
        Me.Customer_deposit.TabIndex = 26
        Me.Customer_deposit.Visible = False
        '
        'Customer_bal
        '
        Me.Customer_bal.Enabled = False
        Me.Customer_bal.Location = New System.Drawing.Point(177, 543)
        Me.Customer_bal.Name = "Customer_bal"
        Me.Customer_bal.Size = New System.Drawing.Size(176, 25)
        Me.Customer_bal.TabIndex = 27
        '
        'ComboBox_1_elect
        '
        Me.ComboBox_1_elect.DropDownWidth = 160
        Me.ComboBox_1_elect.FormattingEnabled = True
        Me.ComboBox_1_elect.Location = New System.Drawing.Point(179, 270)
        Me.ComboBox_1_elect.Name = "ComboBox_1_elect"
        Me.ComboBox_1_elect.Size = New System.Drawing.Size(175, 26)
        Me.ComboBox_1_elect.TabIndex = 28
        '
        'ComboBox_2_elect
        '
        Me.ComboBox_2_elect.DropDownWidth = 160
        Me.ComboBox_2_elect.FormattingEnabled = True
        Me.ComboBox_2_elect.Location = New System.Drawing.Point(179, 314)
        Me.ComboBox_2_elect.Name = "ComboBox_2_elect"
        Me.ComboBox_2_elect.Size = New System.Drawing.Size(176, 26)
        Me.ComboBox_2_elect.TabIndex = 29
        '
        'Button_create_customer
        '
        Me.Button_create_customer.BackColor = System.Drawing.Color.LimeGreen
        Me.Button_create_customer.ForeColor = System.Drawing.Color.White
        Me.Button_create_customer.Location = New System.Drawing.Point(542, 348)
        Me.Button_create_customer.Name = "Button_create_customer"
        Me.Button_create_customer.Size = New System.Drawing.Size(123, 40)
        Me.Button_create_customer.TabIndex = 30
        Me.Button_create_customer.Text = "Create"
        Me.Button_create_customer.UseVisualStyleBackColor = False
        '
        'Button_update_customer
        '
        Me.Button_update_customer.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button_update_customer.ForeColor = System.Drawing.Color.White
        Me.Button_update_customer.Location = New System.Drawing.Point(542, 438)
        Me.Button_update_customer.Name = "Button_update_customer"
        Me.Button_update_customer.Size = New System.Drawing.Size(123, 39)
        Me.Button_update_customer.TabIndex = 31
        Me.Button_update_customer.Text = "Update"
        Me.Button_update_customer.UseVisualStyleBackColor = False
        '
        'Label_required
        '
        Me.Label_required.AutoSize = True
        Me.Label_required.ForeColor = System.Drawing.Color.Red
        Me.Label_required.Location = New System.Drawing.Point(290, 592)
        Me.Label_required.Name = "Label_required"
        Me.Label_required.Size = New System.Drawing.Size(183, 18)
        Me.Label_required.TabIndex = 32
        Me.Label_required.Text = "All * fields are mandatory."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(33, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 18)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(31, 357)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 18)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(33, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 18)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(33, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 18)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "*"
        '
        'Button_srn
        '
        Me.Button_srn.BackColor = System.Drawing.Color.Blue
        Me.Button_srn.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_srn.ForeColor = System.Drawing.Color.White
        Me.Button_srn.Location = New System.Drawing.Point(379, 86)
        Me.Button_srn.Name = "Button_srn"
        Me.Button_srn.Size = New System.Drawing.Size(57, 47)
        Me.Button_srn.TabIndex = 42
        Me.Button_srn.Text = "SRN"
        Me.Button_srn.UseVisualStyleBackColor = False
        Me.Button_srn.Visible = False
        '
        'Button_work
        '
        Me.Button_work.BackColor = System.Drawing.Color.Blue
        Me.Button_work.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_work.ForeColor = System.Drawing.Color.White
        Me.Button_work.Location = New System.Drawing.Point(379, 168)
        Me.Button_work.Name = "Button_work"
        Me.Button_work.Size = New System.Drawing.Size(57, 47)
        Me.Button_work.TabIndex = 44
        Me.Button_work.Text = "Work "
        Me.Button_work.UseVisualStyleBackColor = False
        Me.Button_work.Visible = False
        '
        'Button_meter
        '
        Me.Button_meter.BackColor = System.Drawing.Color.Blue
        Me.Button_meter.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_meter.ForeColor = System.Drawing.Color.White
        Me.Button_meter.Location = New System.Drawing.Point(379, 249)
        Me.Button_meter.Name = "Button_meter"
        Me.Button_meter.Size = New System.Drawing.Size(57, 47)
        Me.Button_meter.TabIndex = 45
        Me.Button_meter.Text = "Meter"
        Me.Button_meter.UseVisualStyleBackColor = False
        Me.Button_meter.Visible = False
        '
        'Label_instalment
        '
        Me.Label_instalment.AutoSize = True
        Me.Label_instalment.Location = New System.Drawing.Point(53, 499)
        Me.Label_instalment.Name = "Label_instalment"
        Me.Label_instalment.Size = New System.Drawing.Size(94, 18)
        Me.Label_instalment.TabIndex = 46
        Me.Label_instalment.Text = "Rem Amount"
        Me.Label_instalment.Visible = False
        '
        'Customer_rest_payment
        '
        Me.Customer_rest_payment.Location = New System.Drawing.Point(178, 496)
        Me.Customer_rest_payment.Name = "Customer_rest_payment"
        Me.Customer_rest_payment.Size = New System.Drawing.Size(175, 25)
        Me.Customer_rest_payment.TabIndex = 47
        Me.Customer_rest_payment.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(52, 405)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 18)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Mode of Payment"
        '
        'ComboBox_pay_mode
        '
        Me.ComboBox_pay_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_pay_mode.FormattingEnabled = True
        Me.ComboBox_pay_mode.Items.AddRange(New Object() {"Whole Amount", "Instalments"})
        Me.ComboBox_pay_mode.Location = New System.Drawing.Point(177, 402)
        Me.ComboBox_pay_mode.Name = "ComboBox_pay_mode"
        Me.ComboBox_pay_mode.Size = New System.Drawing.Size(174, 26)
        Me.ComboBox_pay_mode.TabIndex = 49
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(33, 410)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "*"
        '
        'Label_amnt
        '
        Me.Label_amnt.AutoSize = True
        Me.Label_amnt.Location = New System.Drawing.Point(53, 472)
        Me.Label_amnt.Name = "Label_amnt"
        Me.Label_amnt.Size = New System.Drawing.Size(60, 18)
        Me.Label_amnt.TabIndex = 51
        Me.Label_amnt.Text = "Amount"
        Me.Label_amnt.Visible = False
        '
        'Customer_whole_amnt
        '
        Me.Customer_whole_amnt.Location = New System.Drawing.Point(178, 472)
        Me.Customer_whole_amnt.Name = "Customer_whole_amnt"
        Me.Customer_whole_amnt.Size = New System.Drawing.Size(176, 25)
        Me.Customer_whole_amnt.TabIndex = 52
        Me.Customer_whole_amnt.Visible = False
        '
        'Customer_auto_id
        '
        Me.Customer_auto_id.Location = New System.Drawing.Point(361, 15)
        Me.Customer_auto_id.Name = "Customer_auto_id"
        Me.Customer_auto_id.Size = New System.Drawing.Size(19, 25)
        Me.Customer_auto_id.TabIndex = 53
        Me.Customer_auto_id.Visible = False
        '
        'Customer_cancel
        '
        Me.Customer_cancel.BackColor = System.Drawing.Color.Red
        Me.Customer_cancel.ForeColor = System.Drawing.Color.White
        Me.Customer_cancel.Location = New System.Drawing.Point(542, 536)
        Me.Customer_cancel.Name = "Customer_cancel"
        Me.Customer_cancel.Size = New System.Drawing.Size(123, 32)
        Me.Customer_cancel.TabIndex = 54
        Me.Customer_cancel.Text = "Cancel"
        Me.Customer_cancel.UseVisualStyleBackColor = False
        '
        'Form_create_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(727, 619)
        Me.Controls.Add(Me.Customer_cancel)
        Me.Controls.Add(Me.Customer_auto_id)
        Me.Controls.Add(Me.Customer_whole_amnt)
        Me.Controls.Add(Me.Label_amnt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBox_pay_mode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Customer_rest_payment)
        Me.Controls.Add(Me.Label_instalment)
        Me.Controls.Add(Me.Button_meter)
        Me.Controls.Add(Me.Button_work)
        Me.Controls.Add(Me.Button_srn)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label_required)
        Me.Controls.Add(Me.Button_update_customer)
        Me.Controls.Add(Me.Button_create_customer)
        Me.Controls.Add(Me.ComboBox_2_elect)
        Me.Controls.Add(Me.ComboBox_1_elect)
        Me.Controls.Add(Me.Customer_bal)
        Me.Controls.Add(Me.Customer_deposit)
        Me.Controls.Add(Me.Customer_to_be_paid)
        Me.Controls.Add(Me.Customer_email)
        Me.Controls.Add(Me.Customer_tel)
        Me.Controls.Add(Me.Customer_kra)
        Me.Controls.Add(Me.Customer_location)
        Me.Controls.Add(Me.Customer_name)
        Me.Controls.Add(Me.Customer_meter)
        Me.Controls.Add(Me.Customer_work)
        Me.Controls.Add(Me.Customer_srn)
        Me.Controls.Add(Me.Customer_ref)
        Me.Controls.Add(Me.Customer_id)
        Me.Controls.Add(Me.Label_meter)
        Me.Controls.Add(Me.Label_work)
        Me.Controls.Add(Me.Label_srn)
        Me.Controls.Add(Me.Label_ref)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label_deposit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_create_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_update_customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label_deposit As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label_ref As Label
    Friend WithEvents Label_srn As Label
    Friend WithEvents Label_work As Label
    Friend WithEvents Label_meter As Label
    Friend WithEvents Customer_id As TextBox
    Friend WithEvents Customer_ref As TextBox
    Friend WithEvents Customer_srn As TextBox
    Friend WithEvents Customer_work As TextBox
    Friend WithEvents Customer_meter As TextBox
    Friend WithEvents Customer_name As TextBox
    Friend WithEvents Customer_location As TextBox
    Friend WithEvents Customer_kra As TextBox
    Friend WithEvents Customer_tel As TextBox
    Friend WithEvents Customer_email As TextBox
    Friend WithEvents Customer_to_be_paid As TextBox
    Friend WithEvents Customer_deposit As TextBox
    Friend WithEvents Customer_bal As TextBox
    Friend WithEvents ComboBox_1_elect As ComboBox
    Friend WithEvents ComboBox_2_elect As ComboBox
    Friend WithEvents Button_create_customer As Button
    Friend WithEvents Button_update_customer As Button
    Friend WithEvents Label_required As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button_srn As Button
    Friend WithEvents Button_work As Button
    Friend WithEvents Button_meter As Button
    Friend WithEvents Label_instalment As Label
    Friend WithEvents Customer_rest_payment As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox_pay_mode As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label_amnt As Label
    Friend WithEvents Customer_whole_amnt As TextBox
    Friend WithEvents Customer_auto_id As TextBox
    Friend WithEvents Customer_cancel As Button
End Class
