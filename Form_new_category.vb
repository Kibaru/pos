Imports MySql.Data.MySqlClient

Public Class Form_new_category
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Add_new_category_Click(sender As Object, e As EventArgs) Handles Add_new_category.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Add_category_name.Text = "" Then
                MessageBox.Show("Category name is required.")
                Return
            End If
            query = "Select * from pos.category where category = '" & Add_category_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This category already exist.", MsgBoxStyle.Exclamation, "Create Category")
            Else
                connection.Close()
                connection.Open()
                query = "Insert into pos.category (category, created_by) values('" & Add_category_name.Text & "', '" & Username & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MessageBox.Show("Category added successfully.")
                Me.Close()
                Form2.Show()
                Dim form As New Form_create_new_product
                form.Products_picture_box.Image = pos.My.Resources.index
                form.Show()

                connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        'Form2.Load_ComboBox_orders_category()
        Form2.Load_DataGridView_category()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
        Dim form As New Form_create_new_product
        form.Products_picture_box.Image = pos.My.Resources.index
        form.Show()
    End Sub
End Class



