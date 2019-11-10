Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_create_new_product

    Private Sub Form_create_new_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_ComboBox_category()
        If Form2.adding = True Then
            Button_add_product.Visible = True
            Button_update_product.Visible = False
        Else
            Button_add_product.Visible = False
            Button_update_product.Visible = True
        End If

    End Sub

    Public Sub Load_ComboBox_category()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.category", connection)
            reader = command.ExecuteReader
            While reader.Read
                Product_select_cat.Items.Add(reader.GetString("category"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Button_new_cat_Click(sender As Object, e As EventArgs) Handles Button_new_cat.Click
        Form_new_category.Show()
        Me.Close()
        Form2.Hide()
    End Sub

    Private Sub Button_add_product_Click(sender As Object, e As EventArgs) Handles Button_add_product.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String
            If TextBox_p_name.Text = "" Or TextBox_p_quantity.Text = "" Or TextBox_p_bprice.Text = "" Or TextBox_p_sprice.Text = "" Then
                MsgBox("Product name, quantity, buy price and selling price required fields.", MsgBoxStyle.Exclamation, "Create Product")
                Return
            End If
            query = "Select * from pos.products where name = '" & TextBox_p_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This product already exist.", MsgBoxStyle.Exclamation, "Create Product")
            Else
                connection.Close()
                connection.Open()
                query = "Insert into pos.products (bar_code, name, quantity, b_price, s_price, category, description, image, created_by) values('" & Product_bar_code.Text & "', '" & TextBox_p_name.Text & "', '" & TextBox_p_quantity.Text & "', '" & TextBox_p_bprice.Text & "', '" & TextBox_p_sprice.Text & "', '" & Product_select_cat.Text & "', '" & RichTextbox_description.Text & "', @img, '" & Username & "')"
                command = New MySqlCommand(query, connection)

                Dim ms As New MemoryStream
                Products_picture_box.Image.Save(ms, Products_picture_box.Image.RawFormat)
                command.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = ms.ToArray()

                reader = command.ExecuteReader

                MsgBox("Product inserted successfully.", MsgBoxStyle.Information, "Add product")

                Me.Close()

                connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Form2.Load_DataGridView_products()
        Form2.Load_DataGridView_orders_productss()
    End Sub

    Private Sub Button_cancel_product_Click(sender As Object, e As EventArgs) Handles Button_cancel_product.Click
        Me.Close()
    End Sub

    Private Sub Button_update_product_Click(sender As Object, e As EventArgs) Handles Button_update_product.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            connection.Close()
            connection.Open()
            Dim query As String
            If TextBox_p_name.Text = "" Or TextBox_p_quantity.Text = "" Or TextBox_p_bprice.Text = "" Or TextBox_p_sprice.Text = "" Then
                MsgBox("Product name, quantity, buy price and selling price required fields.", MsgBoxStyle.Exclamation, "Update")
                Return
            End If
            query = "Update pos.products set bar_code='" & Product_bar_code.Text & "',name='" & TextBox_p_name.Text & "', quantity='" & TextBox_p_quantity.Text & "', b_price='" & TextBox_p_bprice.Text & "', s_price='" & TextBox_p_sprice.Text & "', category='" & Product_select_cat.Text & "', description='" & RichTextbox_description.Text & "', image=@img, updated_by='" & Username & "'  WHERE id = '" & Product_id.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim ms As New MemoryStream
            Products_picture_box.Image.Save(ms, Products_picture_box.Image.RawFormat)
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()

            reader = command.ExecuteReader

            MsgBox("Product updated successfully.", MsgBoxStyle.Information, "Update Product")
            Me.Close()

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Form2.Load_DataGridView_products()
        Form2.Load_DataGridView_orders_productss()
    End Sub

    Private Sub Browse_images_Click(sender As Object, e As EventArgs) Handles Browse_images.Click
        Try
            With OpenFileDialog1
                .Filter = "images |*.png; *.jpg; *.jpeg; *.gif; *.ico; *.bmp;"
                .FilterIndex = 4
            End With
            'Clear file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Products_picture_box.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TextBox_p_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_p_quantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub TextBox_p_bprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_p_bprice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub TextBox_p_sprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_p_sprice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub
End Class