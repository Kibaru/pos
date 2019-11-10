Imports MySql.Data.MySqlClient

Public Class Form1
    'Dim connection As New MySqlConnection("server=localhost;username=root;password=;database=pos;")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        Dim query As String
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            If TextBox_name.Text = "" Or TextBox_pass.Text = "" Then
                MsgBox("All fields are required", MsgBoxStyle.Exclamation, "Log in")
            Else
                query = "Select * from pos.users where username='" & TextBox_name.Text & "' and password='" & TextBox_pass.Text & "'"
                command = New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                reader = command.ExecuteReader

                If reader.Read() = True Then
                    MsgBox("Logged in successfully.", MsgBoxStyle.Information, "Logged in")
                    Username = reader.GetString("username")
                    User_role = reader.GetString("role")
                    TextBox_name.Text = ""
                    TextBox_pass.Text = ""
                    Form2.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid user credentials.", MsgBoxStyle.Exclamation, "Credentials")
                End If
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub CheckBox_show_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_show.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBox_show.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            TextBox_pass.UseSystemPasswordChar = False
            CheckBox_show.Text = "Hide password"
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            TextBox_pass.UseSystemPasswordChar = True
            CheckBox_show.Text = "Show password"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class
