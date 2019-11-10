<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label_username = New System.Windows.Forms.Label()
        Me.Label_pass = New System.Windows.Forms.Label()
        Me.TextBox_name = New System.Windows.Forms.TextBox()
        Me.TextBox_pass = New System.Windows.Forms.TextBox()
        Me.Button_login = New System.Windows.Forms.Button()
        Me.CheckBox_show = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_username
        '
        Me.Label_username.AutoSize = True
        Me.Label_username.BackColor = System.Drawing.Color.Transparent
        Me.Label_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_username.ForeColor = System.Drawing.Color.Green
        Me.Label_username.Location = New System.Drawing.Point(11, 56)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(91, 20)
        Me.Label_username.TabIndex = 0
        Me.Label_username.Text = "Username"
        '
        'Label_pass
        '
        Me.Label_pass.AutoSize = True
        Me.Label_pass.BackColor = System.Drawing.Color.Transparent
        Me.Label_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_pass.ForeColor = System.Drawing.Color.Green
        Me.Label_pass.Location = New System.Drawing.Point(11, 113)
        Me.Label_pass.Name = "Label_pass"
        Me.Label_pass.Size = New System.Drawing.Size(86, 20)
        Me.Label_pass.TabIndex = 1
        Me.Label_pass.Text = "Password"
        '
        'TextBox_name
        '
        Me.TextBox_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_name.Location = New System.Drawing.Point(130, 53)
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.Size = New System.Drawing.Size(188, 26)
        Me.TextBox_name.TabIndex = 2
        '
        'TextBox_pass
        '
        Me.TextBox_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_pass.Location = New System.Drawing.Point(130, 110)
        Me.TextBox_pass.Name = "TextBox_pass"
        Me.TextBox_pass.Size = New System.Drawing.Size(188, 26)
        Me.TextBox_pass.TabIndex = 3
        '
        'Button_login
        '
        Me.Button_login.BackColor = System.Drawing.Color.Green
        Me.Button_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_login.Image = CType(resources.GetObject("Button_login.Image"), System.Drawing.Image)
        Me.Button_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_login.Location = New System.Drawing.Point(45, 224)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(349, 38)
        Me.Button_login.TabIndex = 4
        Me.Button_login.Text = "Log in"
        Me.Button_login.UseVisualStyleBackColor = False
        '
        'CheckBox_show
        '
        Me.CheckBox_show.AutoSize = True
        Me.CheckBox_show.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_show.ForeColor = System.Drawing.Color.Green
        Me.CheckBox_show.Location = New System.Drawing.Point(130, 158)
        Me.CheckBox_show.Name = "CheckBox_show"
        Me.CheckBox_show.Size = New System.Drawing.Size(113, 19)
        Me.CheckBox_show.TabIndex = 5
        Me.CheckBox_show.Text = "Show password"
        Me.CheckBox_show.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_pass)
        Me.GroupBox1.Controls.Add(Me.CheckBox_show)
        Me.GroupBox1.Controls.Add(Me.TextBox_name)
        Me.GroupBox1.Controls.Add(Me.Label_username)
        Me.GroupBox1.Controls.Add(Me.Label_pass)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.Location = New System.Drawing.Point(45, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 196)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_login)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_username As Label
    Friend WithEvents Label_pass As Label
    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents TextBox_pass As TextBox
    Friend WithEvents Button_login As Button
    Friend WithEvents CheckBox_show As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
