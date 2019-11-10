<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_my_info
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
        Me.My_firstname = New System.Windows.Forms.TextBox()
        Me.My_lastname = New System.Windows.Forms.TextBox()
        Me.My_email = New System.Windows.Forms.TextBox()
        Me.My_phone = New System.Windows.Forms.TextBox()
        Me.My_password = New System.Windows.Forms.TextBox()
        Me.My_update = New System.Windows.Forms.Button()
        Me.My_id = New System.Windows.Forms.TextBox()
        Me.My_info_cancel = New System.Windows.Forms.Button()
        Me.Add_user_avatar = New System.Windows.Forms.Button()
        Me.PictureBox_avatar = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog_avatar = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox_avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 242)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Password"
        '
        'My_firstname
        '
        Me.My_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_firstname.Location = New System.Drawing.Point(159, 30)
        Me.My_firstname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.My_firstname.Name = "My_firstname"
        Me.My_firstname.Size = New System.Drawing.Size(298, 26)
        Me.My_firstname.TabIndex = 6
        '
        'My_lastname
        '
        Me.My_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_lastname.Location = New System.Drawing.Point(158, 80)
        Me.My_lastname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.My_lastname.Name = "My_lastname"
        Me.My_lastname.Size = New System.Drawing.Size(160, 26)
        Me.My_lastname.TabIndex = 7
        '
        'My_email
        '
        Me.My_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_email.Location = New System.Drawing.Point(159, 135)
        Me.My_email.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.My_email.Name = "My_email"
        Me.My_email.Size = New System.Drawing.Size(159, 26)
        Me.My_email.TabIndex = 8
        '
        'My_phone
        '
        Me.My_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_phone.Location = New System.Drawing.Point(159, 185)
        Me.My_phone.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.My_phone.Name = "My_phone"
        Me.My_phone.Size = New System.Drawing.Size(159, 26)
        Me.My_phone.TabIndex = 9
        '
        'My_password
        '
        Me.My_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_password.Location = New System.Drawing.Point(158, 239)
        Me.My_password.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.My_password.Name = "My_password"
        Me.My_password.Size = New System.Drawing.Size(159, 26)
        Me.My_password.TabIndex = 10
        '
        'My_update
        '
        Me.My_update.BackColor = System.Drawing.Color.Green
        Me.My_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.My_update.ForeColor = System.Drawing.Color.White
        Me.My_update.Location = New System.Drawing.Point(35, 311)
        Me.My_update.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.My_update.Name = "My_update"
        Me.My_update.Size = New System.Drawing.Size(125, 40)
        Me.My_update.TabIndex = 11
        Me.My_update.Text = "Update"
        Me.My_update.UseVisualStyleBackColor = False
        '
        'My_id
        '
        Me.My_id.Enabled = False
        Me.My_id.Location = New System.Drawing.Point(159, -3)
        Me.My_id.Name = "My_id"
        Me.My_id.ReadOnly = True
        Me.My_id.Size = New System.Drawing.Size(298, 26)
        Me.My_id.TabIndex = 12
        Me.My_id.Visible = False
        '
        'My_info_cancel
        '
        Me.My_info_cancel.BackColor = System.Drawing.Color.Red
        Me.My_info_cancel.ForeColor = System.Drawing.Color.White
        Me.My_info_cancel.Location = New System.Drawing.Point(277, 311)
        Me.My_info_cancel.Name = "My_info_cancel"
        Me.My_info_cancel.Size = New System.Drawing.Size(116, 40)
        Me.My_info_cancel.TabIndex = 13
        Me.My_info_cancel.Text = "Cancel"
        Me.My_info_cancel.UseVisualStyleBackColor = False
        '
        'Add_user_avatar
        '
        Me.Add_user_avatar.BackColor = System.Drawing.Color.RoyalBlue
        Me.Add_user_avatar.ForeColor = System.Drawing.Color.White
        Me.Add_user_avatar.Location = New System.Drawing.Point(327, 239)
        Me.Add_user_avatar.Name = "Add_user_avatar"
        Me.Add_user_avatar.Size = New System.Drawing.Size(130, 26)
        Me.Add_user_avatar.TabIndex = 14
        Me.Add_user_avatar.Text = "Add avatar"
        Me.Add_user_avatar.UseVisualStyleBackColor = False
        '
        'PictureBox_avatar
        '
        Me.PictureBox_avatar.BackColor = System.Drawing.Color.Black
        Me.PictureBox_avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_avatar.Location = New System.Drawing.Point(327, 80)
        Me.PictureBox_avatar.Name = "PictureBox_avatar"
        Me.PictureBox_avatar.Size = New System.Drawing.Size(130, 131)
        Me.PictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_avatar.TabIndex = 15
        Me.PictureBox_avatar.TabStop = False
        '
        'OpenFileDialog_avatar
        '
        Me.OpenFileDialog_avatar.FileName = "OpenFileDialog_avatar"
        '
        'Form_my_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(489, 380)
        Me.Controls.Add(Me.PictureBox_avatar)
        Me.Controls.Add(Me.Add_user_avatar)
        Me.Controls.Add(Me.My_info_cancel)
        Me.Controls.Add(Me.My_id)
        Me.Controls.Add(Me.My_update)
        Me.Controls.Add(Me.My_password)
        Me.Controls.Add(Me.My_phone)
        Me.Controls.Add(Me.My_email)
        Me.Controls.Add(Me.My_lastname)
        Me.Controls.Add(Me.My_firstname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_my_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form_my_info"
        CType(Me.PictureBox_avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents My_firstname As TextBox
    Friend WithEvents My_lastname As TextBox
    Friend WithEvents My_email As TextBox
    Friend WithEvents My_phone As TextBox
    Friend WithEvents My_password As TextBox
    Friend WithEvents My_update As Button
    Friend WithEvents My_id As TextBox
    Friend WithEvents My_info_cancel As Button
    Friend WithEvents Add_user_avatar As Button
    Friend WithEvents PictureBox_avatar As PictureBox
    Friend WithEvents OpenFileDialog_avatar As OpenFileDialog
End Class
