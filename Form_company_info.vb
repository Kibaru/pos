Imports MySql.Data.MySqlClient

Public Class Form_company_info
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Company_update_Click(sender As Object, e As EventArgs) Handles Company_update.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Company_name.Text = "" Then
                MsgBox("Company name is required.", MsgBoxStyle.Exclamation, "Update Company Info")
                Return
            End If
            query = "Update pos.company set name='" & Company_name.Text & "', branch='" & Company_branch.Text & "', tel='" & Company_tel.Text & "', email='" & Company_email.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            MsgBox("Company info updated successfully.", MsgBoxStyle.Information, "Update Company Info")
            Me.Close()

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Company_cancel_Click(sender As Object, e As EventArgs) Handles Company_cancel.Click
        Me.Close()
    End Sub
End Class