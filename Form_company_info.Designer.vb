<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_company_info
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Company_email = New System.Windows.Forms.TextBox()
        Me.Company_tel = New System.Windows.Forms.TextBox()
        Me.Company_branch = New System.Windows.Forms.TextBox()
        Me.Company_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Company_update = New System.Windows.Forms.Button()
        Me.Company_cancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Company_email)
        Me.Panel1.Controls.Add(Me.Company_tel)
        Me.Panel1.Controls.Add(Me.Company_branch)
        Me.Panel1.Controls.Add(Me.Company_name)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(18, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 354)
        Me.Panel1.TabIndex = 0
        '
        'Company_email
        '
        Me.Company_email.Location = New System.Drawing.Point(159, 275)
        Me.Company_email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Company_email.Name = "Company_email"
        Me.Company_email.Size = New System.Drawing.Size(216, 26)
        Me.Company_email.TabIndex = 7
        '
        'Company_tel
        '
        Me.Company_tel.Location = New System.Drawing.Point(159, 205)
        Me.Company_tel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Company_tel.Name = "Company_tel"
        Me.Company_tel.Size = New System.Drawing.Size(216, 26)
        Me.Company_tel.TabIndex = 6
        '
        'Company_branch
        '
        Me.Company_branch.Location = New System.Drawing.Point(159, 131)
        Me.Company_branch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Company_branch.Name = "Company_branch"
        Me.Company_branch.Size = New System.Drawing.Size(216, 26)
        Me.Company_branch.TabIndex = 5
        '
        'Company_name
        '
        Me.Company_name.Location = New System.Drawing.Point(159, 54)
        Me.Company_name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Company_name.Name = "Company_name"
        Me.Company_name.Size = New System.Drawing.Size(216, 26)
        Me.Company_name.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 205)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telephone No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 131)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Company_update)
        Me.Panel2.Controls.Add(Me.Company_cancel)
        Me.Panel2.Location = New System.Drawing.Point(18, 426)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 94)
        Me.Panel2.TabIndex = 1
        '
        'Company_update
        '
        Me.Company_update.BackColor = System.Drawing.Color.LimeGreen
        Me.Company_update.ForeColor = System.Drawing.Color.White
        Me.Company_update.Location = New System.Drawing.Point(38, 37)
        Me.Company_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Company_update.Name = "Company_update"
        Me.Company_update.Size = New System.Drawing.Size(112, 35)
        Me.Company_update.TabIndex = 1
        Me.Company_update.Text = "Update"
        Me.Company_update.UseVisualStyleBackColor = False
        '
        'Company_cancel
        '
        Me.Company_cancel.BackColor = System.Drawing.Color.Red
        Me.Company_cancel.ForeColor = System.Drawing.Color.White
        Me.Company_cancel.Location = New System.Drawing.Point(263, 37)
        Me.Company_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Company_cancel.Name = "Company_cancel"
        Me.Company_cancel.Size = New System.Drawing.Size(112, 35)
        Me.Company_cancel.TabIndex = 0
        Me.Company_cancel.Text = "Cancel"
        Me.Company_cancel.UseVisualStyleBackColor = False
        '
        'Form_company_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(447, 574)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_company_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_company_info"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Company_update As Button
    Friend WithEvents Company_email As TextBox
    Friend WithEvents Company_tel As TextBox
    Friend WithEvents Company_branch As TextBox
    Friend WithEvents Company_name As TextBox
    Friend WithEvents Company_cancel As Button
End Class
