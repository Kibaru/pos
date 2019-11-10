<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_new_customer
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
        Me.Customer_name = New System.Windows.Forms.TextBox()
        Me.Customer_tel = New System.Windows.Forms.TextBox()
        Me.Customer_email = New System.Windows.Forms.TextBox()
        Me.Customer_add = New System.Windows.Forms.Button()
        Me.Customer_id = New System.Windows.Forms.TextBox()
        Me.Customer_location = New System.Windows.Forms.TextBox()
        Me.Customer_kra = New System.Windows.Forms.TextBox()
        Me.ComboBox_1_elect = New System.Windows.Forms.TextBox()
        Me.ComboBox_2_elect = New System.Windows.Forms.TextBox()
        Me.Customer_to_be_paid = New System.Windows.Forms.TextBox()
        Me.ComboBox_pay_mode = New System.Windows.Forms.TextBox()
        Me.Customer_ref = New System.Windows.Forms.TextBox()
        Me.Customer_srn = New System.Windows.Forms.TextBox()
        Me.Customer_work = New System.Windows.Forms.TextBox()
        Me.Customer_meter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tel No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email Address"
        '
        'Customer_name
        '
        Me.Customer_name.Location = New System.Drawing.Point(168, 51)
        Me.Customer_name.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Customer_name.Name = "Customer_name"
        Me.Customer_name.Size = New System.Drawing.Size(233, 25)
        Me.Customer_name.TabIndex = 3
        '
        'Customer_tel
        '
        Me.Customer_tel.Location = New System.Drawing.Point(168, 108)
        Me.Customer_tel.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Customer_tel.Name = "Customer_tel"
        Me.Customer_tel.Size = New System.Drawing.Size(233, 25)
        Me.Customer_tel.TabIndex = 4
        '
        'Customer_email
        '
        Me.Customer_email.Location = New System.Drawing.Point(168, 159)
        Me.Customer_email.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Customer_email.Name = "Customer_email"
        Me.Customer_email.Size = New System.Drawing.Size(233, 25)
        Me.Customer_email.TabIndex = 5
        '
        'Customer_add
        '
        Me.Customer_add.BackColor = System.Drawing.Color.LimeGreen
        Me.Customer_add.ForeColor = System.Drawing.Color.White
        Me.Customer_add.Location = New System.Drawing.Point(262, 231)
        Me.Customer_add.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Customer_add.Name = "Customer_add"
        Me.Customer_add.Size = New System.Drawing.Size(139, 32)
        Me.Customer_add.TabIndex = 6
        Me.Customer_add.Text = "Add Customer"
        Me.Customer_add.UseVisualStyleBackColor = False
        '
        'Customer_id
        '
        Me.Customer_id.Location = New System.Drawing.Point(168, 13)
        Me.Customer_id.Name = "Customer_id"
        Me.Customer_id.Size = New System.Drawing.Size(12, 25)
        Me.Customer_id.TabIndex = 7
        Me.Customer_id.Visible = False
        '
        'Customer_location
        '
        Me.Customer_location.Location = New System.Drawing.Point(186, 13)
        Me.Customer_location.Name = "Customer_location"
        Me.Customer_location.Size = New System.Drawing.Size(15, 25)
        Me.Customer_location.TabIndex = 8
        Me.Customer_location.Visible = False
        '
        'Customer_kra
        '
        Me.Customer_kra.Location = New System.Drawing.Point(207, 13)
        Me.Customer_kra.Name = "Customer_kra"
        Me.Customer_kra.Size = New System.Drawing.Size(14, 25)
        Me.Customer_kra.TabIndex = 9
        Me.Customer_kra.Visible = False
        '
        'ComboBox_1_elect
        '
        Me.ComboBox_1_elect.Location = New System.Drawing.Point(227, 13)
        Me.ComboBox_1_elect.Name = "ComboBox_1_elect"
        Me.ComboBox_1_elect.Size = New System.Drawing.Size(15, 25)
        Me.ComboBox_1_elect.TabIndex = 10
        Me.ComboBox_1_elect.Visible = False
        '
        'ComboBox_2_elect
        '
        Me.ComboBox_2_elect.Location = New System.Drawing.Point(248, 13)
        Me.ComboBox_2_elect.Name = "ComboBox_2_elect"
        Me.ComboBox_2_elect.Size = New System.Drawing.Size(13, 25)
        Me.ComboBox_2_elect.TabIndex = 11
        Me.ComboBox_2_elect.Visible = False
        '
        'Customer_to_be_paid
        '
        Me.Customer_to_be_paid.Location = New System.Drawing.Point(267, 13)
        Me.Customer_to_be_paid.Name = "Customer_to_be_paid"
        Me.Customer_to_be_paid.Size = New System.Drawing.Size(15, 25)
        Me.Customer_to_be_paid.TabIndex = 12
        Me.Customer_to_be_paid.Visible = False
        '
        'ComboBox_pay_mode
        '
        Me.ComboBox_pay_mode.Location = New System.Drawing.Point(288, 13)
        Me.ComboBox_pay_mode.Name = "ComboBox_pay_mode"
        Me.ComboBox_pay_mode.Size = New System.Drawing.Size(16, 25)
        Me.ComboBox_pay_mode.TabIndex = 13
        Me.ComboBox_pay_mode.Visible = False
        '
        'Customer_ref
        '
        Me.Customer_ref.Location = New System.Drawing.Point(310, 13)
        Me.Customer_ref.Name = "Customer_ref"
        Me.Customer_ref.Size = New System.Drawing.Size(15, 25)
        Me.Customer_ref.TabIndex = 14
        Me.Customer_ref.Visible = False
        '
        'Customer_srn
        '
        Me.Customer_srn.Location = New System.Drawing.Point(331, 13)
        Me.Customer_srn.Name = "Customer_srn"
        Me.Customer_srn.Size = New System.Drawing.Size(16, 25)
        Me.Customer_srn.TabIndex = 15
        Me.Customer_srn.Visible = False
        '
        'Customer_work
        '
        Me.Customer_work.Location = New System.Drawing.Point(353, 13)
        Me.Customer_work.Name = "Customer_work"
        Me.Customer_work.Size = New System.Drawing.Size(16, 25)
        Me.Customer_work.TabIndex = 16
        Me.Customer_work.Visible = False
        '
        'Customer_meter
        '
        Me.Customer_meter.Location = New System.Drawing.Point(376, 13)
        Me.Customer_meter.Name = "Customer_meter"
        Me.Customer_meter.Size = New System.Drawing.Size(25, 25)
        Me.Customer_meter.TabIndex = 17
        Me.Customer_meter.Visible = False
        '
        'Form_new_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(461, 317)
        Me.Controls.Add(Me.Customer_meter)
        Me.Controls.Add(Me.Customer_work)
        Me.Controls.Add(Me.Customer_srn)
        Me.Controls.Add(Me.Customer_ref)
        Me.Controls.Add(Me.ComboBox_pay_mode)
        Me.Controls.Add(Me.Customer_to_be_paid)
        Me.Controls.Add(Me.ComboBox_2_elect)
        Me.Controls.Add(Me.ComboBox_1_elect)
        Me.Controls.Add(Me.Customer_kra)
        Me.Controls.Add(Me.Customer_location)
        Me.Controls.Add(Me.Customer_id)
        Me.Controls.Add(Me.Customer_add)
        Me.Controls.Add(Me.Customer_email)
        Me.Controls.Add(Me.Customer_tel)
        Me.Controls.Add(Me.Customer_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_new_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_new_customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Customer_name As TextBox
    Friend WithEvents Customer_tel As TextBox
    Friend WithEvents Customer_email As TextBox
    Friend WithEvents Customer_add As Button
    Friend WithEvents Customer_id As TextBox
    Friend WithEvents Customer_location As TextBox
    Friend WithEvents Customer_kra As TextBox
    Friend WithEvents ComboBox_1_elect As TextBox
    Friend WithEvents ComboBox_2_elect As TextBox
    Friend WithEvents Customer_to_be_paid As TextBox
    Friend WithEvents ComboBox_pay_mode As TextBox
    Friend WithEvents Customer_ref As TextBox
    Friend WithEvents Customer_srn As TextBox
    Friend WithEvents Customer_work As TextBox
    Friend WithEvents Customer_meter As TextBox
End Class
