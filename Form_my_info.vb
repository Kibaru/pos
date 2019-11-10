Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_my_info
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub My_update_Click(sender As Object, e As EventArgs) Handles My_update.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If My_firstname.Text = "" Or My_lastname.Text = "" Then
                MsgBox("Firstname and and lastname are required fields.", MsgBoxStyle.Exclamation, "Update User")
                Return
            End If
            query = "Update pos.users set firstname='" & My_firstname.Text & "', lastname='" & My_lastname.Text & "',  email='" & My_email.Text & "', phone='" & My_phone.Text & "', password='" & My_password.Text & "', avatar=@img, updated_by='" & Username & "' WHERE id = '" & My_id.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim ms As New MemoryStream
            PictureBox_avatar.Image.Save(ms, PictureBox_avatar.Image.RawFormat)
            command.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = ms.ToArray()
            reader = command.ExecuteReader

            MsgBox("Details updated successfully.", MsgBoxStyle.Information, "Update my info")
            Me.Close()

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Form2.Load_DataGridView_users()
    End Sub

    Private Sub My_info_cancel_Click(sender As Object, e As EventArgs) Handles My_info_cancel.Click
        Me.Close()
    End Sub

    Private Sub Add_user_avatar_Click(sender As Object, e As EventArgs) Handles Add_user_avatar.Click
        Try
            With OpenFileDialog_avatar
                .Filter = "images |*.png; *.jpg; *.jpeg; *.gif; *.ico; *.bmp;"
                .FilterIndex = 4
            End With
            'Clear file name
            OpenFileDialog_avatar.FileName = ""
            If OpenFileDialog_avatar.ShowDialog() = DialogResult.OK Then
                PictureBox_avatar.Image = Image.FromFile(OpenFileDialog_avatar.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub My_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles My_phone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub
End Class