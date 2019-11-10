Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2
    'Dim connection As New MySqlConnection("server=localhost;username=root;password=;database=pos;")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Public adding As Boolean
    Dim rowIndex As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Order_customer_search.Text = "Search customer . . ."
        Order_product_search.Text = "Search product . . ."
        TextBox_search.Text = "Search product . . ."
        Customer_search.Text = "Search customer . . ."
        Electrician_search.Text = "Search electrician . . ."
        Load_DataGridView_category()
        Load_DataGridView_products()
        Load_DataGridView_customers()
        Load_DataGridView_users()
        Load_DataGridView_orders_customers()
        Load_DataGridView_orders_productss()
        Load_ComboBox_orders_category()
        Load_DataGridView_reports()
        Load_ComboBox_invoice_no()
        Load_ComboBox_cashier()
        Load_DataGridView_below()
        Load_DataGridView_stock_in()
        Load_DataGridView_electrician()

        Label_user.Text = "Hallo " & Username & ". You are logged in as " & Module1.User_role & "."
        Timer1.Enabled = True

        If Module1.User_role = "User" Then
            Tab_manage_users.Text = "Manage my account"
            GroupBox_manage_users.Visible = False
            GroupBox_company_info.Visible = False
            User_next.Visible = False
            User_previous.Visible = False
            User_fname.Enabled = False
            User_lname.Enabled = False
            User_username.Enabled = False
            User_rights.Enabled = False
            User_email.Enabled = False
            User_phone.Enabled = False
        Else
            Tab_manage_users.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_time.Text = Date.Now.ToString("dd MMM yyy hh:mm:ss")
    End Sub

    Private Sub Button_logout_Click_1(sender As Object, e As EventArgs) Handles Button_logout.Click
        If Order_id.Text = ":" Then
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                MsgBox("Goodbye " & Username & ". See you soon.")
                Order_table.Clear()
                DataGridView_orders.DataSource = Order_table
                Form1.Show()
                Me.Close()
            End If
        Else
            MsgBox("Please complete the ongoing transaction before you can logout.", MsgBoxStyle.Exclamation, "Incomplete Transaction.")
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If DataGridView_orders.Rows.Count() Then
            e.Cancel = True
            MsgBox("Please complete the ongoing transaction before you can logout.", MsgBoxStyle.Exclamation, "Incomplete Transaction.")
        End If
    End Sub

    'category
    Public Sub Load_DataGridView_category()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim query As String
            query = "Select * from pos.category"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            DataGridView_category.RowTemplate.Height = 50
            DataGridView_category.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_category_Click(sender As Object, e As EventArgs) Handles DataGridView_category.Click

        Category_id.Text = DataGridView_category.CurrentRow.Cells(0).Value.ToString()
        TextBox_cat_name.Text = DataGridView_category.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub TextBox_cat_name_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cat_name.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim query As String
            query = "Select * from pos.products where category ='" & TextBox_cat_name.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            ListBox_cat.DataSource = table
            ListBox_cat.ValueMember = "id"
            ListBox_cat.DisplayMember = "name"
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Cat_create_Click(sender As Object, e As EventArgs) Handles Cat_create.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

        If TextBox_cat_name.Text = "" Then
            MsgBox("Category name is required.", MsgBoxStyle.Exclamation, "Create Category")
            Return
        End If

        Try
            connection.Open()
            Dim query As String
            query = "Select * from pos.category where category = '" & TextBox_cat_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This category already exist.", MsgBoxStyle.Exclamation, "Create Category")
                Return
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Add_new_category()
        Load_DataGridView_category()

    End Sub

    Private Sub Add_new_category()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            Dim table As New DataTable
            query = "Insert into pos.category (category, created_by) values('" & TextBox_cat_name.Text & "', '" & Username & "')"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            MsgBox("Data saved successfully.", MsgBoxStyle.Information, "Add category")
            Category_id.Text = ""
            TextBox_cat_name.Text = ""

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        'Load_ComboBox_orders_category()
    End Sub

    Private Sub Cat_edit_Click(sender As Object, e As EventArgs) Handles Cat_edit.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Category_id.Text = "" Then
                MsgBox("Please select the category to update", MsgBoxStyle.Exclamation, "Update")
                Return
            End If
            query = "Update pos.category set category='" & TextBox_cat_name.Text & "', updated_by='" & Username & "' WHERE id = '" & Category_id.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            MsgBox("Category updated successfully.", MsgBoxStyle.Information, "Update category")
            Category_id.Text = ""
            TextBox_cat_name.Text = ""

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Load_DataGridView_category()

    End Sub

    Private Sub Cat_delete_Click(sender As Object, e As EventArgs) Handles Cat_delete.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

        If Module1.User_role = "User" Then
            MsgBox("Oops! You are not allow to perform this action. Please contact your admin.", MsgBoxStyle.Exclamation, "Access Denied")
            Return
        End If
        If Category_id.Text = "" Then
            MsgBox("Please select the category to delete", MsgBoxStyle.Exclamation, "Delete")
            Return
        End If
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete category " & DataGridView_category.CurrentRow.Cells(1).Value.ToString() & "?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Try
                connection.Open()
                Dim query As String
                query = "Delete from pos.category where id='" & Category_id.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("Category deleted successfully.", MsgBoxStyle.Information, "Delete category")
                Category_id.Text = ""
                TextBox_cat_name.Text = ""

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

            Load_DataGridView_category()
        End If

    End Sub

    Private Sub Cat_reset_Click(sender As Object, e As EventArgs) Handles Cat_reset.Click
        Category_id.Text = ""
        TextBox_cat_name.Text = ""
        Load_DataGridView_category()
    End Sub

    Private Sub Next_category_Click(sender As Object, e As EventArgs) Handles Next_category.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.category", connection)
            adapter.Fill(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        rowIndex = DataGridView_category.SelectedCells(0).OwningRow.Index


        If rowIndex < DataGridView_category.Rows.Count - 1 Then

            DataGridView_category.ClearSelection()

            DataGridView_category.Rows(rowIndex + 1).Selected = True
            Category_id.Text = DataGridView_category.Rows(rowIndex + 1).Cells(0).Value.ToString()
            TextBox_cat_name.Text = DataGridView_category.Rows(rowIndex + 1).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Previous_category_Click(sender As Object, e As EventArgs) Handles Previous_category.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.category", connection)
            adapter.Fill(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        rowIndex = DataGridView_category.SelectedCells(0).OwningRow.Index

        If rowIndex > 0 Then
            DataGridView_category.ClearSelection()

            DataGridView_category.Rows(rowIndex - 1).Selected = True
            Category_id.Text = DataGridView_category.Rows(rowIndex - 1).Cells(0).Value.ToString()
            TextBox_cat_name.Text = DataGridView_category.Rows(rowIndex - 1).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Support_category_MouseHover(sender As Object, e As EventArgs) Handles Support_category.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_category_MouseLeave(sender As Object, e As EventArgs) Handles Support_category.MouseLeave
        Form_support.Close()
    End Sub

    'Products
    Public Sub Load_DataGridView_products()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products", connection)
            adapter.Fill(table)
            DataGridView_products.AllowUserToAddRows = False
            DataGridView_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridView_products.RowTemplate.Height = 70
            Dim img As New DataGridViewImageColumn()

            DataGridView_products.DataSource = table
            img = DataGridView_products.Columns(8)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch

            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Get_total_stock_worth()
    End Sub

    Private Sub Refresh_stock_Click(sender As Object, e As EventArgs) Handles Refresh_stock.Click
        Load_DataGridView_products()
    End Sub

    Public Sub Get_total_stock_worth()
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView_products.Rows.Count() - 1 Step +1
            sum = sum + DataGridView_products.Rows(i).Cells(4).Value
        Next
        Stock_worth.Text = sum.ToString()
    End Sub

    Private Sub Product_create_Click(sender As Object, e As EventArgs) Handles Product_create.Click
        Dim form As New Form_create_new_product
        form.Products_picture_box.Image = pos.My.Resources.index
        adding = True
        Form_create_new_product.Text = "Add new product."

        form.ShowDialog()
    End Sub

    Private Sub Product_edit_Click(sender As Object, e As EventArgs) Handles Product_edit.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        adding = False

        If DataGridView_products.CurrentRow.Cells(0).Value.ToString() = "" Then
            MsgBox("Please select a row to update", MsgBoxStyle.Exclamation, "Update")
        Else
            Dim table As New DataTable
            Dim query As String
            Dim form As New Form_create_new_product
            Try
                connection.Open()
                query = "Select * from pos.products where id = '" & DataGridView_products.CurrentRow.Cells(0).Value & "'"
                command = New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)


                form.Product_id.Text = table.Rows(0)(0)
                form.Product_bar_code.Text = table.Rows(0)(1)
                form.TextBox_p_name.Text = table.Rows(0)(2).ToString()
                form.TextBox_p_quantity.Text = table.Rows(0)(3)
                form.TextBox_p_bprice.Text = table.Rows(0)(4)
                form.TextBox_p_sprice.Text = table.Rows(0)(5)
                form.Product_select_cat.Text = table.Rows(0)(6).ToString()
                form.RichTextbox_description.Text = table.Rows(0)(7).ToString()

                If table.Rows(0)(8) IsNot DBNull.Value Then
                    Dim img() As Byte
                    img = table.Rows(0)(8)
                    Dim ms As New MemoryStream(img)
                    form.Products_picture_box.Image = Image.FromStream(ms)
                Else
                    form.Products_picture_box.Image = pos.My.Resources.index
                End If

                connection.Close()

                form.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Product_delete_Click(sender As Object, e As EventArgs) Handles Product_delete.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If Module1.User_role = "User" Then
            MsgBox("Oops! You are not allow to perform this action. Please contact your admin.", MsgBoxStyle.Exclamation, "Access Denied")
            Return
        End If
        If DataGridView_products.CurrentRow.Cells(0).Value.ToString() = "" Then
            MsgBox("Please select a product to delete", MsgBoxStyle.Exclamation, "Delete")
            Return
        End If
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete " & DataGridView_products.CurrentRow.Cells(2).Value.ToString() & "?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Try
                connection.Open()
                Dim query As String
                query = "Delete from pos.products where id='" & DataGridView_products.CurrentRow.Cells(0).Value.ToString() & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("Product deleted successfully.", MsgBoxStyle.Information, "Delete Product")

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

            Load_DataGridView_products()
        End If
    End Sub

    Private Sub TextBox_search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_search.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products", connection)
            adapter.Fill(table)
            DataGridView_products.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("name like '%{0}%'", TextBox_search.Text)
        DataGridView_products.DataSource = dv
    End Sub

    Private Sub TextBox_search_Enter(sender As Object, e As EventArgs) Handles TextBox_search.Enter
        If TextBox_search.Text = "Search product . . ." Then
            TextBox_search.Text = ""
        End If
    End Sub

    Private Sub TextBox_search_Leave(sender As Object, e As EventArgs) Handles TextBox_search.Leave
        If TextBox_search.Text = "" Then
            TextBox_search.Text = "Search product . . ."
            Load_DataGridView_products()
        End If
    End Sub

    Private Sub Support_stock_MouseHover(sender As Object, e As EventArgs) Handles Support_stock.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_stock_MouseLeave(sender As Object, e As EventArgs) Handles Support_stock.MouseLeave
        Form_support.Close()
    End Sub


    'Customers
    Public Sub Load_DataGridView_customers()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select id, national, name, location, pin, tel, first_elec, second_elec, payment, payment_mode, deposit, rest, whole_amount, balance, ref, srn, work, meter from pos.customers", connection)
            adapter.Fill(table)
            DataGridView_customers.RowTemplate.Height = 50
            DataGridView_customers.DataSource = table
            adapter.Update(table)

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_customer_Click(sender As Object, e As EventArgs) Handles DataGridView_customers.Click
        If DataGridView_customers.Rows.Count() Then
            Customer_id.Text = DataGridView_customers.CurrentRow.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub Create_new_customer_Click(sender As Object, e As EventArgs) Handles Create_new_customer.Click
        Dim form As New Form_create_customer
        adding = True
        form.Text = "Add new Customer."

        form.Button_srn.Visible = True
        form.Button_work.Visible = True
        form.Button_meter.Visible = True

        form.Button_update_customer.Visible = False

        form.ShowDialog()
    End Sub

    Private Sub Edit_customer_Click(sender As Object, e As EventArgs) Handles Edit_customer.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        adding = False

        If DataGridView_customers.CurrentRow.Cells(0).Value.ToString() = "" Then
            MsgBox("Please select a row to update", MsgBoxStyle.Exclamation, "Update")
        Else
            Dim table As New DataTable
            Dim query As String
            Dim form As New Form_create_customer
            Try
                connection.Open()
                query = "Select * from pos.customers where id = '" & DataGridView_customers.CurrentRow.Cells(0).Value & "'"
                command = New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                form.Customer_auto_id.Text = table.Rows(0)(0)
                form.Customer_id.Text = table.Rows(0)(1)
                form.Customer_name.Text = table.Rows(0)(2)
                form.Customer_location.Text = table.Rows(0)(3)
                form.Customer_kra.Text = table.Rows(0)(4)
                form.Customer_tel.Text = table.Rows(0)(5)
                form.Customer_email.Text = table.Rows(0)(6)
                form.ComboBox_1_elect.Text = table.Rows(0)(7)
                form.ComboBox_2_elect.Text = table.Rows(0)(8)
                form.Customer_to_be_paid.Text = table.Rows(0)(9)
                form.ComboBox_pay_mode.Text = table.Rows(0)(10)
                form.Customer_deposit.Text = table.Rows(0)(11)
                form.Customer_rest_payment.Text = table.Rows(0)(12)
                form.Customer_whole_amnt.Text = table.Rows(0)(13)
                form.Customer_bal.Text = table.Rows(0)(14)
                form.Customer_ref.Text = table.Rows(0)(15)
                form.Customer_srn.Text = table.Rows(0)(16)
                form.Customer_work.Text = table.Rows(0)(17)
                form.Customer_meter.Text = table.Rows(0)(18)

                form.Button_srn.Visible = True
                form.Button_work.Visible = True
                form.Button_meter.Visible = True

                If table.Rows(0)(16) IsNot "" Then
                    form.Label_srn.Visible = True
                    form.Customer_srn.Visible = True
                    form.Button_srn.Visible = False
                End If

                If table.Rows(0)(17) IsNot "" Then
                    form.Label_work.Visible = True
                    form.Customer_work.Visible = True
                    form.Button_work.Visible = False
                End If

                If table.Rows(0)(18) IsNot "" Then
                    form.Label_meter.Visible = True
                    form.Customer_meter.Visible = True
                    form.Button_meter.Visible = False
                End If

                form.Button_create_customer.Visible = False

                connection.Close()

                form.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Customer_delete_Click(sender As Object, e As EventArgs) Handles Customer_delete.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If Module1.User_role = "User" Then
            MsgBox("Oops! You are not allow to perform this action. Please contact your admin.", MsgBoxStyle.Exclamation, "Access Denied")
            Return
        End If
        If DataGridView_customers.CurrentRow.Cells(0).Value.ToString() = "" Then
            MsgBox("Please select a customer to delete", MsgBoxStyle.Exclamation, "Delete")
            Return
        End If
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete " & DataGridView_customers.CurrentRow.Cells(2).Value.ToString() & "?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Try
                connection.Open()
                Dim query As String

                query = "Delete from pos.customers where id='" & DataGridView_customers.CurrentRow.Cells(0).Value.ToString() & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("Customer deleted successfully.", MsgBoxStyle.Information, "Delete Customer")

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

            Load_DataGridView_customers()
        End If
    End Sub

    Private Sub Customer_status_Click(sender As Object, e As EventArgs) Handles Customer_status.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        adding = False

        If DataGridView_customers.CurrentRow.Cells(0).Value.ToString() = "" Then
            MsgBox("Please select a row to update", MsgBoxStyle.Exclamation, "Update")
        Else
            Dim table As New DataTable
            Dim query As String
            Dim form As New Form_create_customer
            Try
                connection.Open()
                query = "Select * from pos.customers where id = '" & DataGridView_customers.CurrentRow.Cells(0).Value & "'"
                command = New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                form.Customer_auto_id.Text = table.Rows(0)(0)
                form.Customer_id.Text = table.Rows(0)(1)
                form.Customer_name.Text = table.Rows(0)(2)
                form.Customer_location.Text = table.Rows(0)(3)
                form.Customer_kra.Text = table.Rows(0)(4)
                form.Customer_tel.Text = table.Rows(0)(5)
                form.Customer_email.Text = table.Rows(0)(6)
                form.ComboBox_1_elect.Text = table.Rows(0)(7)
                form.ComboBox_2_elect.Text = table.Rows(0)(8)
                form.Customer_to_be_paid.Text = table.Rows(0)(9)
                form.ComboBox_pay_mode.Text = table.Rows(0)(10)
                form.Customer_deposit.Text = table.Rows(0)(11)
                form.Customer_rest_payment.Text = table.Rows(0)(12)
                form.Customer_whole_amnt.Text = table.Rows(0)(13)
                form.Customer_bal.Text = table.Rows(0)(14)
                form.Customer_ref.Text = table.Rows(0)(15)
                form.Customer_srn.Text = table.Rows(0)(16)
                form.Customer_work.Text = table.Rows(0)(17)
                form.Customer_meter.Text = table.Rows(0)(18)

                If table.Rows(0)(16) IsNot "" Then
                    form.Label_srn.Visible = True
                    form.Customer_srn.Visible = True
                End If

                If table.Rows(0)(17) IsNot "" Then
                    form.Label_work.Visible = True
                    form.Customer_work.Visible = True
                End If

                If table.Rows(0)(18) IsNot "" Then
                    form.Label_meter.Visible = True
                    form.Customer_meter.Visible = True
                End If

                form.Customer_auto_id.Enabled = False
                form.Customer_id.Enabled = False
                form.Customer_name.Enabled = False
                form.Customer_location.Enabled = False
                form.Customer_kra.Enabled = False
                form.Customer_tel.Enabled = False
                form.Customer_email.Enabled = False
                form.ComboBox_1_elect.Enabled = False
                form.ComboBox_2_elect.Enabled = False
                form.Customer_to_be_paid.Enabled = False
                form.ComboBox_pay_mode.Enabled = False
                form.Customer_deposit.Enabled = False
                form.Customer_rest_payment.Enabled = False
                form.Customer_whole_amnt.Enabled = False
                form.Customer_bal.Enabled = False
                form.Customer_ref.Enabled = False
                form.Customer_srn.Enabled = False
                form.Customer_work.Enabled = False
                form.Customer_meter.Enabled = False

                form.Label_required.Visible = False
                form.Text = "Check customer status."
                form.Button_create_customer.Visible = False
                form.Button_update_customer.Visible = False

                connection.Close()

                form.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Customer_reset_Click(sender As Object, e As EventArgs) Handles Customer_reset.Click
        Load_DataGridView_customers()
        Last_order_date.Text = "Date"
        Total_orders_amount.Text = "Amount"
        Orders_count.Text = "Count"
    End Sub

    Private Sub Customer_next_Click(sender As Object, e As EventArgs) Handles Customer_next.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If DataGridView_customers.Rows.Count() Then
            Dim table As New DataTable
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter("Select * from pos.customers", connection)
                adapter.Fill(table)
                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
            If DataGridView_customers.Rows.Count() Then
                rowIndex = DataGridView_customers.SelectedCells(0).OwningRow.Index
            End If


            If rowIndex < DataGridView_customers.Rows.Count - 1 Then

                DataGridView_customers.ClearSelection()

                DataGridView_customers.Rows(rowIndex + 1).Selected = True
                Customer_id.Text = DataGridView_customers.Rows(rowIndex + 1).Cells(0).Value.ToString()
            End If
        End If
    End Sub

    Private Sub Customer_prev_Click(sender As Object, e As EventArgs) Handles Customer_prev.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If DataGridView_customers.Rows.Count() Then
            Dim table As New DataTable
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter("Select * from pos.customers", connection)
                adapter.Fill(table)
                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
            If DataGridView_customers.Rows.Count() Then
                rowIndex = DataGridView_customers.SelectedCells(0).OwningRow.Index
            End If

            If rowIndex > 0 Then
                DataGridView_customers.ClearSelection()

                DataGridView_customers.Rows(rowIndex - 1).Selected = True
                Customer_id.Text = DataGridView_customers.Rows(rowIndex - 1).Cells(0).Value.ToString()
            End If
        End If
    End Sub

    Private Sub Customer_search_Enter(sender As Object, e As EventArgs) Handles Customer_search.Enter
        If Customer_search.Text = "Search customer . . ." Then
            Customer_search.Text = ""
        End If
    End Sub

    Private Sub Customer_search_Leave(sender As Object, e As EventArgs) Handles Customer_search.Leave
        If Customer_search.Text = "" Then
            Customer_search.Text = "Search customer . . ."
            Load_DataGridView_customers()
        End If
    End Sub

    Private Sub Customer_search_TextChanged(sender As Object, e As EventArgs) Handles Customer_search.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.customers", connection)
            adapter.Fill(table)
            DataGridView_customers.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("name like '%{0}%'", Customer_search.Text)
        DataGridView_customers.DataSource = dv
    End Sub

    'Customer_id_TextChanged
    Private Sub Customer_id_TextChanged(sender As Object, e As EventArgs) Handles Customer_id.TextChanged
        Get_Customer_orders_count()
        Get_customers_total_orders_amount()
        Get_customers_last_orders_date()
    End Sub

    'orders count
    Private Sub Get_Customer_orders_count()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            Dim query As String
            Dim table As New DataTable
            connection.Close()
            connection.Open()
            'get current database quantity
            query = "Select * from orders where customer_id='" & Customer_id.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                Orders_count.Text = table.Rows.Count()
            Else
                Orders_count.Text = 0
            End If

            'table.Rows(0)(3)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Get total orders amount
    Private Sub Get_customers_total_orders_amount()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            Dim query As String
            connection.Open()
            'get current database quantity
            query = "Select sum(net_total) from orders where customer_id='" & Customer_id.Text & "'"
            command = New MySqlCommand(query, connection)
            Total_orders_amount.Text = command.ExecuteScalar().ToString

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Get last orders date
    Private Sub Get_customers_last_orders_date()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            Dim query As String
            Dim table As New DataTable
            connection.Open()
            'get current database quantity
            query = "Select created_at from orders where customer_id='" & Customer_id.Text & "' ORDER By created_at Desc"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                Last_order_date.Text = table.Rows(0)(0).ToString()
            Else
                Last_order_date.Text = "No order yet"
            End If

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Support_customers_MouseHover(sender As Object, e As EventArgs) Handles Support_customers.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_customers_MouseLeave(sender As Object, e As EventArgs) Handles Support_customers.MouseLeave
        Form_support.Close()
    End Sub

    Private Sub Generate_customers_report_Click(sender As Object, e As EventArgs) Handles Generate_customers_report.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Dim query As String
        Try
            connection.Open()
            query = "Select * from pos.customers where id = '" & DataGridView_customers.CurrentRow.Cells(0).Value & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            table.TableName = "Report"
            table.WriteXml("Report.xml")
            'table.WriteXml(CurDir() & "\Report.xml", XmlWriteMode.WriteSchema)
            connection.Close()
            Form_customers_report.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Manage users
    Public Sub Load_DataGridView_users()
        If Module1.User_role = "Admin" Then
            Admin()
        Else
            User()
        End If
    End Sub

    Private Sub Admin()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Close()
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select id, firstname, lastname, username, role, email, phone, avatar, created_by, updated_by from pos.users", connection)
            adapter.Fill(table)
            DataGridView_users.RowTemplate.Height = 80
            Dim img As New DataGridViewImageColumn()
            DataGridView_users.DataSource = table
            img = DataGridView_users.Columns(7)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub User()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Close()
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select id, firstname, lastname, username, role, email, phone, avatar, created_by, updated_by from pos.users where username='" & Username & "'", connection)
            adapter.Fill(table)
            DataGridView_users.RowTemplate.Height = 80
            Dim img As New DataGridViewImageColumn()
            DataGridView_users.DataSource = table
            img = DataGridView_users.Columns(7)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_users_Click(sender As Object, e As EventArgs) Handles DataGridView_users.Click
        User_id.Text = DataGridView_users.CurrentRow.Cells(0).Value.ToString()
        User_fname.Text = DataGridView_users.CurrentRow.Cells(1).Value.ToString()
        User_lname.Text = DataGridView_users.CurrentRow.Cells(2).Value.ToString()
        User_username.Text = DataGridView_users.CurrentRow.Cells(3).Value.ToString()
        User_rights.Text = DataGridView_users.CurrentRow.Cells(4).Value.ToString()
        User_email.Text = DataGridView_users.CurrentRow.Cells(5).Value.ToString()
        User_phone.Text = DataGridView_users.CurrentRow.Cells(6).Value.ToString()
    End Sub

    Private Sub User_reset_Click(sender As Object, e As EventArgs) Handles User_reset.Click
        User_id.Text = ""
        User_fname.Text = ""
        User_lname.Text = ""
        User_username.Text = ""
        User_rights.Text = ""
        User_email.Text = ""
        User_phone.Text = ""
    End Sub

    Private Sub User_create_Click(sender As Object, e As EventArgs) Handles User_create.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If User_username.Text = "" Or User_rights.Text = "" Then
                MsgBox("Username and role field are required.", MsgBoxStyle.Exclamation, "Create User")
                Return
            End If
            query = "Select * from pos.users where username = '" & User_username.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This User already exist.", MsgBoxStyle.Exclamation, "Create User")
            Else
                connection.Close()
                connection.Open()
                query = "Insert into pos.users (firstname, lastname, username, role, email, phone, created_by) values('" & User_fname.Text & "', '" & User_lname.Text & "', '" & User_username.Text & "', '" & User_rights.Text & "', '" & User_email.Text & "', '" & User_phone.Text & "', '" & Username & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("User added successfully & can now log in.", MsgBoxStyle.Information, "Create User")
                User_id.Text = ""
                User_fname.Text = ""
                User_lname.Text = ""
                User_username.Text = ""
                User_rights.Text = ""
                User_email.Text = ""
                User_phone.Text = ""

                connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Load_DataGridView_users()
    End Sub

    Private Sub User_update_Click(sender As Object, e As EventArgs) Handles User_update.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If User_id.Text = "" Then
                MsgBox("Please select a row to update", MsgBoxStyle.Exclamation, "Update User")
                Return
            End If
            query = "Update pos.users set firstname='" & User_fname.Text & "', lastname='" & User_lname.Text & "', username='" & User_username.Text & "', role='" & User_rights.Text & "', email='" & User_email.Text & "', phone='" & User_phone.Text & "', updated_by='" & Username & "' WHERE id = '" & User_id.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            MsgBox("User details updated successfully.", MsgBoxStyle.Information, "Update user")
            User_id.Text = ""
            User_fname.Text = ""
            User_lname.Text = ""
            User_username.Text = ""
            User_rights.Text = ""
            User_email.Text = ""
            User_phone.Text = ""

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Load_DataGridView_users()
    End Sub

    Private Sub Personal_update_Click(sender As Object, e As EventArgs) Handles Personal_update.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If User_id.Text = "" Then
            MsgBox("Please select a row that corresponds to your account to update.", MsgBoxStyle.Exclamation, "Update User")
            Return
        End If
        If Username = DataGridView_users.CurrentRow.Cells(3).Value.ToString() Then

            Dim table As New DataTable
            Dim query As String
            Dim form As New Form_my_info
            Try
                connection.Open()
                query = "Select * from pos.users where username = '" & DataGridView_users.CurrentRow.Cells(3).Value.ToString() & "'"
                command = New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(table)

                form.My_id.Text = table.Rows(0)(0).ToString()
                form.My_firstname.Text = table.Rows(0)(1).ToString()
                form.My_lastname.Text = table.Rows(0)(2).ToString()
                form.My_email.Text = table.Rows(0)(6).ToString()
                form.My_phone.Text = table.Rows(0)(7).ToString()
                form.My_password.Text = table.Rows(0)(4).ToString()

                If table.Rows(0)(8) IsNot DBNull.Value Then
                    Dim img() As Byte
                    img = table.Rows(0)(8)
                    Dim ms As New MemoryStream(img)
                    form.PictureBox_avatar.Image = Image.FromStream(ms)
                Else
                    form.PictureBox_avatar.Image = pos.My.Resources.index
                End If

                connection.Close()

                User_id.Text = ""
                User_fname.Text = ""
                User_lname.Text = ""
                User_username.Text = ""
                User_rights.Text = ""
                User_email.Text = ""
                User_phone.Text = ""

                form.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

        Else
            MsgBox("Please select a row that corresponds to your account.", MsgBoxStyle.Exclamation, "Update my account")
        End If
    End Sub

    Private Sub User_next_Click(sender As Object, e As EventArgs) Handles User_next.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.users", connection)
            adapter.Fill(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        rowIndex = DataGridView_users.SelectedCells(0).OwningRow.Index


        If rowIndex < DataGridView_users.Rows.Count - 1 Then

            DataGridView_users.ClearSelection()

            DataGridView_users.Rows(rowIndex + 1).Selected = True
            User_id.Text = DataGridView_users.Rows(rowIndex + 1).Cells(0).Value.ToString()
            User_fname.Text = DataGridView_users.Rows(rowIndex + 1).Cells(1).Value.ToString()
            User_lname.Text = DataGridView_users.Rows(rowIndex + 1).Cells(2).Value.ToString()
            User_username.Text = DataGridView_users.Rows(rowIndex + 1).Cells(3).Value.ToString()
            User_rights.Text = DataGridView_users.Rows(rowIndex + 1).Cells(4).Value.ToString()
            User_email.Text = DataGridView_users.Rows(rowIndex + 1).Cells(5).Value.ToString()
            User_phone.Text = DataGridView_users.Rows(rowIndex + 1).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub User_previous_Click(sender As Object, e As EventArgs) Handles User_previous.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.users", connection)
            adapter.Fill(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        rowIndex = DataGridView_users.SelectedCells(0).OwningRow.Index

        If rowIndex > 0 Then
            DataGridView_users.ClearSelection()

            DataGridView_users.Rows(rowIndex - 1).Selected = True
            User_id.Text = DataGridView_users.Rows(rowIndex - 1).Cells(0).Value.ToString()
            User_fname.Text = DataGridView_users.Rows(rowIndex - 1).Cells(1).Value.ToString()
            User_lname.Text = DataGridView_users.Rows(rowIndex - 1).Cells(2).Value.ToString()
            User_username.Text = DataGridView_users.Rows(rowIndex - 1).Cells(3).Value.ToString()
            User_rights.Text = DataGridView_users.Rows(rowIndex - 1).Cells(4).Value.ToString()
            User_email.Text = DataGridView_users.Rows(rowIndex - 1).Cells(5).Value.ToString()
            User_phone.Text = DataGridView_users.Rows(rowIndex - 1).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub Company_update_Click(sender As Object, e As EventArgs) Handles Company_update_show.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.company", connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim form As New Form_company_info

                form.Company_name.Text = reader.GetString("name")
                form.Company_branch.Text = reader.GetString("branch")
                form.Company_tel.Text = reader.GetString("tel")
                form.Company_email.Text = reader.GetString("email")

                form.ShowDialog()

            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub User_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles User_phone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Support_mangement_MouseHover(sender As Object, e As EventArgs) Handles Support_mangement.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_mangement_MouseLeave(sender As Object, e As EventArgs) Handles Support_mangement.MouseLeave
        Form_support.Close()
    End Sub

    'Orders
    Public Sub Load_DataGridView_orders_customers()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select id, name, tel, email from pos.customers", connection)
            adapter.Fill(table)
            DataGridView_orders_customers.RowTemplate.Height = 50
            DataGridView_orders_customers.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public Sub Load_DataGridView_orders_productss()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Close()
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products", connection)
            adapter.Fill(table)

            DataGridView_orders_products.AllowUserToAddRows = False
            DataGridView_orders_products.RowTemplate.Height = 50
            Dim img As New DataGridViewImageColumn()

            DataGridView_orders_products.DataSource = table

            img = DataGridView_orders_products.Columns(8)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        'Order_product_box.Image = pos.My.Resources.index
    End Sub

    Private Sub Order_add_new_customer_Click(sender As Object, e As EventArgs) Handles Order_add_new_customer.Click
        Form_new_customer.Show()
    End Sub

    Public Sub Load_ComboBox_orders_category()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.category", connection)
            reader = command.ExecuteReader
            While reader.Read
                ComboBox_orders_category.Items.Add(reader.GetString("category"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Order_customer_search_Enter(sender As Object, e As EventArgs) Handles Order_customer_search.Enter
        If Order_customer_search.Text = "Search customer . . ." Then
            Order_customer_search.Text = ""
        End If
    End Sub

    Private Sub Order_customer_search_Leave(sender As Object, e As EventArgs) Handles Order_customer_search.Leave
        If Order_customer_search.Text = "" Then
            Order_customer_search.Text = "Search customer . . ."
        End If
    End Sub

    Private Sub Order_customer_search_TextChanged(sender As Object, e As EventArgs) Handles Order_customer_search.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.customers", connection)
            adapter.Fill(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("name like '%{0}%'", Order_customer_search.Text)
        DataGridView_orders_customers.DataSource = dv
    End Sub

    Private Sub ComboBox_orders_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_orders_category.SelectedIndexChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products where category = '" & ComboBox_orders_category.Text & "'", connection)
            adapter.Fill(table)
            If table.Rows.Count() Then
                DataGridView_orders_products.DataSource = table
                adapter.Update(table)
            Else
                MsgBox("Record not found.", MsgBoxStyle.Exclamation, "Not Found.")
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_orders_products_Click(sender As Object, e As EventArgs) Handles DataGridView_orders_products.Click
        If Order_id.Text = ":" Then
            MsgBox("First you need to create new transaction for you to sells products.", MsgBoxStyle.Exclamation, "Create Order")
            Return
        End If
        Load_product_image_upon_click()
        'Dim newform As New Form1
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim dr As New System.Windows.Forms.DataGridViewRow
        Dim query As String
        Dim table As New DataTable
        If DataGridView_orders_products.CurrentRow.Cells(3).Value <= 0 Then
            MsgBox("You are out of stock for " & DataGridView_orders_products.CurrentRow.Cells(2).Value.ToString() & ".", MsgBoxStyle.Information, "Out Of Stock")
        Else
            Try
                connection.Open()

                'update quantity
                query = "Update pos.products set quantity='" & (DataGridView_orders_products.CurrentRow.Cells(3).Value - 1) & "' WHERE name = '" & DataGridView_orders_products.CurrentRow.Cells(2).Value.ToString() & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                DataGridView_orders.RowTemplate.Height = 50
                For Each dr In Me.DataGridView_orders_products.SelectedRows
                    DataGridView_orders.Rows.Add(dr.Cells(2).Value, 1, dr.Cells(5).Value, dr.Cells(5).Value)
                    'DataGridView_orders.DataSource = table
                Next
                Get_total_prices()
                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
            Load_DataGridView_orders_productss()

        End If

    End Sub

    Private Sub Load_product_image_upon_click()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim query As String
        Dim table As New DataTable

        Try
            connection.Open()
            query = "Select * from pos.products where id = '" & DataGridView_orders_products.CurrentRow.Cells(0).Value & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            If table.Rows(0)(8) IsNot DBNull.Value Then
                Dim img() As Byte
                img = table.Rows(0)(8)
                Dim ms As New MemoryStream(img)
                Order_product_box.Image = Image.FromStream(ms)
            Else
                Order_product_box.Image = pos.My.Resources.index
            End If

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_orders_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_orders.CellDoubleClick
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView_orders.Rows(index)
        Dim query As String
        Dim table As New DataTable
        Dim form As New Form_product_quantity

        Try
            connection.Open()
            query = "Select * from pos.products where name='" & selectedRow.Cells(0).Value.ToString() & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            If table.Rows.Count() Then
                form.Owner = Me
                form.Product_name.Text = table.Rows(0)(2)
                form.Product_quantity_change.Text = table.Rows(0)(3)
                form.ShowDialog()
            Else
                form.Owner = Me
                form.Product_name.Text = selectedRow.Cells(0).Value.ToString()
                form.Product_quantity_change.Text = selectedRow.Cells(1).Value.ToString()
                form.ShowDialog()
            End If

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Order_product_search_Enter(sender As Object, e As EventArgs) Handles Order_product_search.Enter
        If Order_product_search.Text = "Search product . . ." Then
            Order_product_search.Text = ""
        End If
    End Sub

    Private Sub Order_product_search_Leave(sender As Object, e As EventArgs) Handles Order_product_search.Leave
        If Order_product_search.Text = "" Then
            Order_product_search.Text = "Search product . . ."
        End If
    End Sub

    Private Sub Order_product_search_KeyDown(sender As Object, e As KeyEventArgs) Handles Order_product_search.KeyDown
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products", connection)
            adapter.Fill(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("name like '%{0}%'", Order_product_search.Text)
        DataGridView_orders_products.DataSource = dv
    End Sub

    Private Sub Order_create_Click(sender As Object, e As EventArgs) Handles Order_create.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If Order_id.Text = ":" Then
            Try
                connection.Open()
                Dim query As String
                query = "Insert into pos.orders (order_by) values('" & Username & "'); SELECT LAST_INSERT_ID()"
                Dim command As New MySqlCommand(query, connection)
                Dim result As Integer = CInt(command.ExecuteScalar())

                MsgBox("New transaction created.", MsgBoxStyle.Information, "Generate Order")
                Order_id.Text = result

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        Else
            MsgBox("You already have an ongoing transaction.", MsgBoxStyle.Exclamation, "Create Transaction")
        End If
    End Sub

    Private Sub Order_cancel_Click(sender As Object, e As EventArgs) Handles Order_cancel.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        'If Module1.User_role = "User" Then
        'MsgBox("Oops! You are not allow to perform this action. Please contact your admin.", MsgBoxStyle.Exclamation, "Access Denied")
        'Return
        'End If
        If Order_id.Text = ":" Then
            MsgBox("You cannot cancel an empty transaction.", MsgBoxStyle.Exclamation, "Add Customer")
            Return
        End If
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to cancel this transaction with id " & Order_id.Text & "?", "Cancel Order", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Update_products_upon_order_cancel()
            Try
                connection.Open()
                Dim query As String
                Dim table As New DataTable
                query = "Delete from pos.orders where id='" & Order_id.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("Transaction cancelled.", MsgBoxStyle.Information, "Cancel Order")
                Order_id.Text = ":"
                Order_customer_id.Text = ":"
                DataGridView_orders.Rows.Clear()
                Order_subtotal.Text = ""
                Order_net_total.Text = ""
                Order_discount.Text = ""
                Order_received.Text = ""
                Order_change.Text = ""

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Update_products_upon_order_cancel()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If DataGridView_orders.Rows.Count() Then
            Try
                Dim query As String
                Dim table As New DataTable

                For i As Integer = 0 To DataGridView_orders.Rows.Count() - 1 Step +1
                    connection.Open()
                    'get current database quantity
                    query = "Select * from pos.products where name='" & DataGridView_orders.Rows(i).Cells(0).Value.ToString() & "'"
                    command = New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)

                    If table.Rows.Count() Then
                        query = "Update pos.products set quantity='" & (table.Rows(i)(3) + Convert.ToInt64(DataGridView_orders.Rows(i).Cells(1).Value)) & "' WHERE name = '" & DataGridView_orders.Rows(i).Cells(0).Value.ToString() & "'"
                        command = New MySqlCommand(query, connection)
                        reader = command.ExecuteReader
                    End If
                    connection.Close()
                Next
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

            Load_DataGridView_orders_productss()

        End If
    End Sub

    Private Sub Add_customer_to_order_Click(sender As Object, e As EventArgs) Handles Add_customer_to_order.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If Order_id.Text = ":" Then
            MsgBox("First you need to create new transaction for you to add a customer.", MsgBoxStyle.Exclamation, "Create Order")
            Return
        End If
        If DataGridView_orders_customers.Rows.Count() Then
            Try
                connection.Open()
                Dim query As String
                query = "Update pos.orders set customer_id='" & DataGridView_orders_customers.CurrentRow.Cells(0).Value.ToString() & "' WHERE id = '" & Order_id.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox(DataGridView_orders_customers.CurrentRow.Cells(1).Value.ToString() & " was added to transaction no. " & Order_id.Text & ".", MsgBoxStyle.Information, "Update Order")
                Order_customer_id.Text = DataGridView_orders_customers.CurrentRow.Cells(0).Value.ToString()

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    Private Sub Order_remove_product_Click(sender As Object, e As EventArgs) Handles Order_remove_product.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If DataGridView_orders.Rows.Count() Then
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Are you sure you want to remove " & DataGridView_orders.CurrentRow.Cells(0).Value.ToString() & "?", "Remove product from order", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Try
                    Dim query As String
                    Dim index As Integer
                    Dim table As New DataTable
                    connection.Open()
                    'get current database quantity
                    query = "Select * from pos.products where name='" & DataGridView_orders.CurrentRow.Cells(0).Value.ToString() & "'"
                    command = New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)

                    'update quantity
                    If table.Rows.Count() Then
                        query = "Update pos.products set quantity='" & (table.Rows(0)(3) + Convert.ToInt64(DataGridView_orders.CurrentRow.Cells(1).Value)) & "' WHERE name = '" & DataGridView_orders.CurrentRow.Cells(0).Value.ToString() & "'"
                        command = New MySqlCommand(query, connection)
                        reader = command.ExecuteReader
                    End If
                    index = DataGridView_orders.CurrentCell.RowIndex
                    DataGridView_orders.Rows.RemoveAt(index)

                    Get_total_prices()

                    connection.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    connection.Dispose()
                End Try
            End If

            Load_DataGridView_orders_productss()
        End If
    End Sub

    Private Sub Order_save_print_Click(sender As Object, e As EventArgs) Handles Order_save_print.Click
        If DataGridView_orders.Rows.Count() Then
            Insert_transaction_to_db()
        End If
    End Sub

    Private Sub Insert_transaction_to_db()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            Dim query As String
            'Dim form As New Form_print_receipt
            If Order_received.Text = "" Then
                MsgBox("You cannot save|print unpaid transaction.", MsgBoxStyle.Exclamation, "Transaction")
                Return
            ElseIf Convert.ToInt64(Order_received.Text) < Convert.ToInt64(Order_net_total.Text) Then
                MsgBox("Sorry! You are not allowed to process an underpayment transction.", MsgBoxStyle.Exclamation, "Transaction")
                Return
            End If

            For i As Integer = 0 To DataGridView_orders.Rows.Count() - 1 Step +1
                connection.Open()
                query = "Insert into pos.sales (order_id, product_name, quantity, price, total_price, sale_by) values('" & Order_id.Text & "', '" & DataGridView_orders.Rows(i).Cells(0).Value & "', '" & DataGridView_orders.Rows(i).Cells(1).Value & "', '" & DataGridView_orders.Rows(i).Cells(2).Value & "', '" & DataGridView_orders.Rows(i).Cells(3).Value & "', '" & Username & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                connection.Close()
            Next
            Update_order()
            'form.Receipt_invoice.Text = Order_id.Text
            'Form.Show()

            MsgBox("Transaction saved successfully.", MsgBoxStyle.Information, "Save Transaction")
            Order_id.Text = ":"
            Order_customer_id.Text = ":"
            DataGridView_orders.Rows.Clear()
            Order_subtotal.Text = ""
            Order_net_total.Text = ""
            Order_discount.Text = ""
            Order_received.Text = ""
            Order_change.Text = ""
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Load_DataGridView_reports()
    End Sub

    Private Sub Update_order()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String

            query = "Update pos.orders set sub_total='" & Order_subtotal.Text & "', discount='" & Order_discount.Text & "', net_total='" & Order_net_total.Text & "', received_cash='" & Order_received.Text & "', change_cash='" & Order_change.Text & "' WHERE id = '" & Order_id.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public Sub Get_total_prices()
        Dim sum As Int64 = 0
        For i As Integer = 0 To DataGridView_orders.Rows.Count() - 1 Step +1
            sum = sum + DataGridView_orders.Rows(i).Cells(3).Value
        Next
        Order_subtotal.Text = sum.ToString()
        If Order_discount.Text = "" And Order_received.Text = "" Then
            Order_net_total.Text = Order_subtotal.Text
        ElseIf Order_discount.Text = "" And Order_received.Text IsNot "" Then
            Order_net_total.Text = Order_subtotal.Text
            Order_change.Text = Convert.ToInt64(Order_received.Text) - Convert.ToInt64(Order_net_total.Text)
        ElseIf Order_discount.Text IsNot "" And Order_received.Text = "" Then
            Order_net_total.Text = Convert.ToInt64(Order_subtotal.Text) - Convert.ToInt64(Order_discount.Text)
        ElseIf Order_discount.Text IsNot "" And Order_received.Text IsNot "" Then
            Order_net_total.Text = Convert.ToInt64(Order_subtotal.Text) - Convert.ToInt64(Order_discount.Text)
            Order_change.Text = Convert.ToInt64(Order_received.Text) - Convert.ToInt64(Order_net_total.Text)
        End If
    End Sub

    Private Sub Order_discount_TextChanged(sender As Object, e As EventArgs) Handles Order_discount.TextChanged
        If DataGridView_orders.Rows.Count() Then
            If Order_discount.Text = "" And Order_received.Text = "" Then
                Order_net_total.Text = Order_subtotal.Text
            ElseIf Order_discount.Text = "" And Order_received.Text IsNot "" Then
                Order_net_total.Text = Order_subtotal.Text
                Order_change.Text = Convert.ToInt64(Order_received.Text) - Convert.ToInt64(Order_net_total.Text)
            ElseIf Order_discount.Text IsNot "" And Order_received.Text = "" Then
                Order_net_total.Text = Convert.ToInt64(Order_subtotal.Text) - Convert.ToInt64(Order_discount.Text)
            ElseIf Order_discount.Text IsNot "" And Order_received.Text IsNot "" Then
                Order_net_total.Text = Convert.ToInt64(Order_subtotal.Text) - Convert.ToInt64(Order_discount.Text)
                Order_change.Text = Convert.ToInt64(Order_received.Text) - Convert.ToInt64(Order_net_total.Text)
            End If
        End If
    End Sub

    Private Sub Order_received_TextChanged(sender As Object, e As EventArgs) Handles Order_received.TextChanged
        If DataGridView_orders.Rows.Count() Then
            If Order_received.Text = "" Then
                Order_change.Text = ""
            Else
                Order_change.Text = Convert.ToInt64(Order_received.Text) - Convert.ToInt64(Order_net_total.Text)
            End If
        End If
    End Sub

    Private Sub Order_discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Order_discount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")
            End If
        End If
    End Sub

    Private Sub Order_received_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Order_received.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Sell_services_Click(sender As Object, e As EventArgs) Handles Sell_services.Click
        If Order_id.Text = ":" Then
            MsgBox("First you need to create new transaction for you to sells services.", MsgBoxStyle.Exclamation, "Create Order")
        Else
            Order_cancel.Enabled = False
            Form_sell_services.Show()
        End If
    End Sub

    Private Sub Support_transaction_MouseHover(sender As Object, e As EventArgs) Handles Support_transaction.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_transaction_MouseLeave(sender As Object, e As EventArgs) Handles Support_transaction.MouseLeave
        Form_support.Close()
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        'Load_ComboBox_orders_category()
    End Sub

    'Reports
    'Stock in
    Public Sub Load_DataGridView_stock_in()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products WHERE date(created_at) = '" & Date.Now.ToString("yyyy-MM-dd") & "'", connection)
            adapter.Fill(table)
            DataGridView_stock_in.RowTemplate.Height = 50
            DataGridView_stock_in.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Get_total_stock_in_prices()
    End Sub

    Public Sub Get_total_stock_in_prices()
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView_stock_in.Rows.Count() - 1 Step +1
            sum = sum + DataGridView_stock_in.Rows(i).Cells(4).Value
        Next
        Stock_in_total.Text = sum.ToString()
    End Sub

    Private Sub ComboBox_stock_in_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_stock_in.SelectedIndexChanged
        If ComboBox_stock_in.Text = "Daily" Then
            DateTimePicker_stock_in.CustomFormat = "yyyy-MM-dd"
        ElseIf ComboBox_stock_in.Text = "Monthly" Then
            DateTimePicker_stock_in.CustomFormat = "yyyyMM"
        ElseIf ComboBox_stock_in.Text = "Yearly" Then
            DateTimePicker_stock_in.CustomFormat = "yyyy"
        End If
    End Sub

    Private Sub View_stock_in_Click(sender As Object, e As EventArgs) Handles View_stock_in.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()

            'Daily
            If DateTimePicker_stock_in.CustomFormat = "yyyy-MM-dd" Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where date(created_at) = '" & DateTimePicker_stock_in.Text & "'", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    DataGridView_stock_in.DataSource = table
                    adapter.Update(table)
                    Get_total_stock_in_prices()
                Else
                    MsgBox("This date does not exist.", MsgBoxStyle.Exclamation, "Date Error")
                End If
            End If

            'Monthly
            If DateTimePicker_stock_in.CustomFormat = "yyyyMM" Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where EXTRACT(YEAR_MONTH FROM date(created_at)) = '" & DateTimePicker_stock_in.Text & "'", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    DataGridView_stock_in.DataSource = table
                    adapter.Update(table)
                    Get_total_stock_in_prices()
                Else
                    MsgBox("This date does not exist.", MsgBoxStyle.Exclamation, "Date Error")
                End If
            End If

            'Yearly
            If DateTimePicker_stock_in.CustomFormat = "yyyy" Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where YEAR(date(created_at)) = '" & DateTimePicker_stock_in.Text & "'", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    DataGridView_stock_in.DataSource = table
                    adapter.Update(table)
                    Get_total_stock_in_prices()
                Else
                    MsgBox("This date does not exist.", MsgBoxStyle.Exclamation, "Date Error")
                End If
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Support_in_MouseHover(sender As Object, e As EventArgs) Handles Support_in.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_in_MouseLeave(sender As Object, e As EventArgs) Handles Support_in.MouseLeave
        Form_support.Close()
    End Sub

    'Stock out
    Public Sub Load_DataGridView_reports()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select order_id, product_name, quantity, total_price, sale_by, created_at from pos.sales WHERE date(created_at) = '" & Date.Now.ToString("yyyy-MM-dd") & "'", connection)
            adapter.Fill(table)
            DataGridView_reports.RowTemplate.Height = 50
            DataGridView_reports.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Get_total_report_prices()
        Load_todays_discount()
        Load_reports_net_total_prices()
    End Sub

    Private Sub Load_todays_discount()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            If DateTimePicker_created.CustomFormat = "yyyy-MM-dd" Then
                Dim query As String
                query = "Select sum(discount) from pos.orders WHERE date(created_at) = '" & Date.Now.ToString("yyyy-MM-dd") & "'"
                Dim command As New MySqlCommand(query, connection)
                Report_discount.Text = command.ExecuteScalar.ToString()
            End If

            If DateTimePicker_created.CustomFormat = "yyyyMM" Then
                Dim query As String
                query = "Select sum(discount) from pos.orders WHERE EXTRACT(YEAR_MONTH FROM date(created_at)) = '" & Date.Now.ToString("yyyyMM") & "'"
                Dim command As New MySqlCommand(query, connection)
                Report_discount.Text = command.ExecuteScalar.ToString()
            End If

            If DateTimePicker_created.CustomFormat = "yyyy" Then
                Dim query As String
                query = "Select sum(discount) from pos.orders WHERE YEAR(date(created_at)) = '" & Date.Now.ToString("yyyy") & "'"
                Dim command As New MySqlCommand(query, connection)
                Report_discount.Text = command.ExecuteScalar.ToString()
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public Sub Get_total_report_prices()
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView_reports.Rows.Count() - 1 Step +1
            sum = sum + DataGridView_reports.Rows(i).Cells(3).Value
        Next
        Report_total.Text = sum.ToString()
    End Sub

    Public Sub Load_reports_net_total_prices()
        If Report_total.Text = 0 Then
            Reports_net_total.Text = 0.00
        Else
            Reports_net_total.Text = Convert.ToInt64(Report_total.Text) - Convert.ToInt64(Report_discount.Text)
        End If
    End Sub

    Private Sub Load_ComboBox_invoice_no()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.orders", connection)
            reader = command.ExecuteReader
            While reader.Read
                ComboBox_invoice_no.Items.Add(reader.GetString("id"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Report_by_invoice_Click(sender As Object, e As EventArgs) Handles Report_by_invoice.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select order_id, product_name, quantity, total_price, sale_by, created_at from pos.sales where order_id = '" & ComboBox_invoice_no.Text & "'", connection)
            adapter.Fill(table)
            If table.Rows.Count() Then
                DataGridView_reports.DataSource = table
                adapter.Update(table)
                Get_total_report_prices()
                Load_discount_by_invoice_click()
                Load_reports_net_total_prices()
            Else
                MsgBox("This invoice number does not exist.", MsgBoxStyle.Exclamation, "Invoice Error")
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Load_discount_by_invoice_click()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim query As String
            query = "Select sum(discount) from pos.orders WHERE id = '" & ComboBox_invoice_no.Text & "'"
            Dim command As New MySqlCommand(query, connection)
            Report_discount.Text = command.ExecuteScalar.ToString()
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_date.SelectedIndexChanged
        If ComboBox_date.Text = "Daily" Then
            DateTimePicker_created.CustomFormat = "yyyy-MM-dd"
        ElseIf ComboBox_date.Text = "Monthly" Then
            DateTimePicker_created.CustomFormat = "yyyyMM"
        ElseIf ComboBox_date.Text = "Yearly" Then
            DateTimePicker_created.CustomFormat = "yyyy"
        End If
    End Sub

    Private Sub Report_by_date_Click(sender As Object, e As EventArgs) Handles Report_by_date.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()

            'Daily
            If DateTimePicker_created.CustomFormat = "yyyy-MM-dd" Then
                Dim adapter As New MySqlDataAdapter("Select order_id, product_name, quantity, total_price, sale_by, created_at from pos.sales where date(created_at) = '" & DateTimePicker_created.Text & "'", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    DataGridView_reports.DataSource = table
                    adapter.Update(table)
                    Get_total_report_prices()
                    Load_discount_by_date_click()
                    Load_reports_net_total_prices()
                Else
                    MsgBox("This date does not exist.", MsgBoxStyle.Exclamation, "Date Error")
                End If
            End If

            'Monthly
            If DateTimePicker_created.CustomFormat = "yyyyMM" Then
                Dim adapter As New MySqlDataAdapter("Select order_id, product_name, quantity, total_price, sale_by, created_at from pos.sales where EXTRACT(YEAR_MONTH FROM date(created_at)) = '" & DateTimePicker_created.Text & "'", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    DataGridView_reports.DataSource = table
                    adapter.Update(table)
                    Get_total_report_prices()
                    Load_discount_by_date_click()
                    Load_reports_net_total_prices()
                Else
                    MsgBox("This date does not exist.", MsgBoxStyle.Exclamation, "Date Error")
                End If
            End If

            'Yearly
            If DateTimePicker_created.CustomFormat = "yyyy" Then
                Dim adapter As New MySqlDataAdapter("Select order_id, product_name, quantity, total_price, sale_by, created_at from pos.sales where YEAR(date(created_at)) = '" & DateTimePicker_created.Text & "'", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    DataGridView_reports.DataSource = table
                    adapter.Update(table)
                    Get_total_report_prices()
                    Load_discount_by_date_click()
                    Load_reports_net_total_prices()
                Else
                    MsgBox("This date does not exist.", MsgBoxStyle.Exclamation, "Date Error")
                End If
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Load_discount_by_date_click()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            If DateTimePicker_created.CustomFormat = "yyyy-MM-dd" Then
                Dim query As String
                query = "Select sum(discount) from pos.orders WHERE  date(created_at) = '" & DateTimePicker_created.Text & "'"
                Dim command As New MySqlCommand(query, connection)
                Report_discount.Text = command.ExecuteScalar.ToString()
            End If

            If DateTimePicker_created.CustomFormat = "yyyyMM" Then
                Dim query As String
                query = "Select sum(discount) from pos.orders WHERE  EXTRACT(YEAR_MONTH FROM date(created_at)) = '" & DateTimePicker_created.Text & "'"
                Dim command As New MySqlCommand(query, connection)
                Report_discount.Text = command.ExecuteScalar.ToString()
            End If

            If DateTimePicker_created.CustomFormat = "yyyy" Then
                Dim query As String
                query = "Select sum(discount) from pos.orders WHERE  YEAR(date(created_at)) = '" & DateTimePicker_created.Text & "'"
                Dim command As New MySqlCommand(query, connection)
                Report_discount.Text = command.ExecuteScalar.ToString()
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Load_ComboBox_cashier()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.users", connection)
            reader = command.ExecuteReader
            While reader.Read
                ComboBox_cashier.Items.Add(reader.GetString("username"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Report_by_cashier_Click(sender As Object, e As EventArgs) Handles Report_by_cashier.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select order_id, product_name, quantity, total_price, sale_by, created_at from pos.sales where sale_by = '" & ComboBox_cashier.Text & "'", connection)
            adapter.Fill(table)
            If table.Rows.Count() Then
                DataGridView_reports.DataSource = table
                adapter.Update(table)
                Get_total_report_prices()
                Load_discount_by_cashier_click()
                Load_reports_net_total_prices()
            Else
                MsgBox("Cashier not found.", MsgBoxStyle.Exclamation, "Not Found")
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Load_discount_by_cashier_click()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim query As String
            query = "Select sum(discount) from pos.orders WHERE  order_by = '" & ComboBox_cashier.Text & "'"
            Dim command As New MySqlCommand(query, connection)
            Report_discount.Text = command.ExecuteScalar.ToString()
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Support_out_MouseHover(sender As Object, e As EventArgs) Handles Support_out.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_out_MouseLeave(sender As Object, e As EventArgs) Handles Support_out.MouseLeave
        Form_support.Close()
    End Sub

    'Nofications
    Public Sub Load_DataGridView_below()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.products WHERE quantity <= 5 ", connection)
            adapter.Fill(table)
            DataGridView_stock_below.Visible = True
            DataGridView_stock_below.AllowUserToAddRows = False
            DataGridView_stock_below.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridView_stock_below.RowTemplate.Height = 70
            Dim img As New DataGridViewImageColumn()
            DataGridView_stock_below.DataSource = table
            img = DataGridView_products.Columns(8)
            img.ImageLayout = DataGridViewImageCellLayout.Stretch
            adapter.Update(table)
            'table.TableName = "Notification"
            'table.WriteXml("Notification.xml")
            'table.WriteXml(CurDir() & "\Notification.xml", XmlWriteMode.WriteSchema)
            'Dim report As New NotificationCrystalReport
            'CrystalReportViewer_notification.ReportSource = report
            'CrystalReportViewer_notification.RefreshReport()

            If table.Rows.Count() Then
                'Tab_notifications.Text.bac = System.Drawing.Color.Red
                Stock_below.Text = "Stock of products below 5."
                Tab_notifications.Text = "1 Notification"
            End If

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub View_stock_below_Click(sender As Object, e As EventArgs) Handles View_stock_below.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            If ComboBox_below.Text = 1 Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where quantity <= 1 ", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    adapter.Update(table)
                    table.TableName = "Notification"
                    table.WriteXml("Notification.xml")
                    'table.WriteXml(CurDir() & "\Notification.xml", XmlWriteMode.WriteSchema)
                    Dim report As New NotificationCrystalReport
                    CrystalReportViewer_notification.ReportSource = report
                    CrystalReportViewer_notification.RefreshReport()
                    Stock_below.Text = "Stock of products below 1."
                Else
                    MsgBox("No record found.", MsgBoxStyle.Exclamation, "Not Found")
                End If
                CrystalReportViewer_notification.Visible = True
            End If
            If ComboBox_below.Text = 5 Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where quantity <= 5 ", connection)
                adapter.Fill(table)
                If table.Rows.Count() Then
                    adapter.Update(table)
                    table.TableName = "Notification"
                    table.WriteXml("Notification.xml")
                    'table.WriteXml(CurDir() & "\Notification.xml", XmlWriteMode.WriteSchema)
                    Dim report As New NotificationCrystalReport
                    CrystalReportViewer_notification.ReportSource = report
                    CrystalReportViewer_notification.RefreshReport()

                    Stock_below.Text = "Stock of products below 5."
                Else
                    MsgBox("No record found.", MsgBoxStyle.Exclamation, "Not Found")
                End If
                CrystalReportViewer_notification.Visible = True
            End If

            If ComboBox_below.Text = 10 Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where quantity <= 10 ", connection)
                adapter.Fill(table)

                If table.Rows.Count() Then
                    adapter.Update(table)
                    table.TableName = "Notification"
                    table.WriteXml("Notification.xml")
                    'table.WriteXml(CurDir() & "\Notification.xml", XmlWriteMode.WriteSchema)
                    Dim report As New NotificationCrystalReport
                    CrystalReportViewer_notification.ReportSource = report
                    CrystalReportViewer_notification.RefreshReport()

                    Stock_below.Text = "Stock of products below 10."
                Else
                    MsgBox("No record found.", MsgBoxStyle.Exclamation, "Not Found")
                End If
                CrystalReportViewer_notification.Visible = True
            End If

            If ComboBox_below.Text = 50 Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where quantity <= 50 ", connection)
                adapter.Fill(table)

                If table.Rows.Count() Then
                    adapter.Update(table)
                    table.TableName = "Notification"
                    table.WriteXml("Notification.xml")
                    'table.WriteXml(CurDir() & "\Notification.xml", XmlWriteMode.WriteSchema)
                    Dim report As New NotificationCrystalReport
                    CrystalReportViewer_notification.ReportSource = report
                    CrystalReportViewer_notification.RefreshReport()

                    Stock_below.Text = "Stock of products below 50."
                Else
                    MsgBox("No record found.", MsgBoxStyle.Exclamation, "Not Found")
                End If
                CrystalReportViewer_notification.Visible = True
            End If

            If ComboBox_below.Text = 100 Then
                Dim adapter As New MySqlDataAdapter("Select * from pos.products where quantity <= 100 ", connection)
                adapter.Fill(table)

                If table.Rows.Count() Then
                    adapter.Update(table)
                    table.TableName = "Notification"
                    table.WriteXml("Notification.xml")
                    'table.WriteXml(CurDir() & "\Notification.xml", XmlWriteMode.WriteSchema)
                    Dim report As New NotificationCrystalReport
                    CrystalReportViewer_notification.ReportSource = report
                    CrystalReportViewer_notification.RefreshReport()

                    Stock_below.Text = "Stock of products below 100."
                Else
                    MsgBox("No record found.", MsgBoxStyle.Exclamation, "Not Found")
                End If
                CrystalReportViewer_notification.Visible = True
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Support_notification_MouseHover(sender As Object, e As EventArgs) Handles Support_notification.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_notification_MouseLeave(sender As Object, e As EventArgs) Handles Support_notification.MouseLeave
        Form_support.Close()
    End Sub


    'Electricians
    Public Sub Load_DataGridView_electrician()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim query As String
            query = "Select * from pos.electricians"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            DataGridView_electrician.RowTemplate.Height = 50
            DataGridView_electrician.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DataGridView_electrician_Click(sender As Object, e As EventArgs) Handles DataGridView_electrician.Click
        Electrician_id.Text = DataGridView_electrician.CurrentRow.Cells(0).Value.ToString()
        Eleectrician_name.Text = DataGridView_electrician.CurrentRow.Cells(1).Value.ToString()
        electrician_tel.Text = DataGridView_electrician.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub Support_electrician_MouseHover(sender As Object, e As EventArgs) Handles Support_electrician.MouseHover
        Form_support.Show()
    End Sub

    Private Sub Support_electrician_MouseLeave(sender As Object, e As EventArgs) Handles Support_electrician.MouseLeave
        Form_support.Close()
    End Sub

    Private Sub Create_electrician_Click(sender As Object, e As EventArgs) Handles Create_electrician.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

        If Eleectrician_name.Text = "" Then
            MsgBox("Electrician name is required.", MsgBoxStyle.Exclamation, "Create Electrician")
            Return
        End If

        Try
            connection.Open()
            Dim query As String
            query = "Select * from pos.electricians where name = '" & Eleectrician_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This electrician already exist.", MsgBoxStyle.Exclamation, "Create Electrician")
                Return
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Add_new_electrian()
        Load_DataGridView_electrician()
    End Sub

    Private Sub Add_new_electrian()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            Dim table As New DataTable
            query = "Insert into pos.electricians (name, tel, created_by) values('" & Eleectrician_name.Text & "', '" & electrician_tel.Text & "', '" & Username & "')"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            MsgBox("Data saved successfully.", MsgBoxStyle.Information, "Add Electrician")
            Electrician_id.Text = ""
            Eleectrician_name.Text = ""
            electrician_tel.Text = ""

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Update_electrician_Click(sender As Object, e As EventArgs) Handles Update_electrician.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Electrician_id.Text = "" Then
                MsgBox("Please select the electrician to update", MsgBoxStyle.Exclamation, "Update")
                Return
            End If
            query = "Update pos.electricians set name='" & Eleectrician_name.Text & "', tel='" & electrician_tel.Text & "', updated_by='" & Username & "' WHERE id = '" & Electrician_id.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            MsgBox("Electrician updated successfully.", MsgBoxStyle.Information, "Update electrician")
            Category_id.Text = ""
            TextBox_cat_name.Text = ""

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Load_DataGridView_electrician()
    End Sub

    Private Sub Delete_electrician_Click(sender As Object, e As EventArgs) Handles Delete_electrician.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

        If Module1.User_role = "User" Then
            MsgBox("Oops! You are not allow to perform this action. Please contact your admin.", MsgBoxStyle.Exclamation, "Access Denied")
            Return
        End If
        If DataGridView_electrician.CurrentRow.Cells(0).Value.ToString() = "" Then
            MsgBox("Please select the category to delete", MsgBoxStyle.Exclamation, "Delete")
            Return
        End If
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete electrician " & DataGridView_electrician.CurrentRow.Cells(1).Value.ToString() & "?", "Delete", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Try
                connection.Open()
                Dim query As String
                query = "Delete from pos.electricians where id='" & DataGridView_electrician.CurrentRow.Cells(0).Value.ToString() & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("Category deleted successfully.", MsgBoxStyle.Information, "Delete category")
                Electrician_id.Text = ""
                Eleectrician_name.Text = ""
                electrician_tel.Text = ""

                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try

            Load_DataGridView_electrician()
        End If
    End Sub

    Private Sub Refresh_electrician_Click(sender As Object, e As EventArgs) Handles Refresh_electrician.Click
        Electrician_id.Text = ""
        Eleectrician_name.Text = ""
        electrician_tel.Text = ""

        Load_DataGridView_electrician()
    End Sub

    Private Sub Electrician_search_Enter(sender As Object, e As EventArgs) Handles Electrician_search.Enter
        If Electrician_search.Text = "Search electrician . . ." Then
            Electrician_search.Text = ""
        End If
    End Sub

    Private Sub Electrician_search_Leave(sender As Object, e As EventArgs) Handles Electrician_search.Leave
        If Electrician_search.Text = "" Then
            Electrician_search.Text = "Search electrician . . ."
            Load_DataGridView_electrician()
        End If
    End Sub

    Private Sub Electrician_search_TextChanged(sender As Object, e As EventArgs) Handles Electrician_search.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter("Select * from pos.electricians", connection)
            adapter.Fill(table)
            DataGridView_electrician.DataSource = table
            adapter.Update(table)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        Dim dv As New DataView(table)
        dv.RowFilter = String.Format("name like '%{0}%'", Electrician_search.Text)
        DataGridView_electrician.DataSource = dv
    End Sub

    Private Sub electrician_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles electrician_tel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Select Case e.Index
            Case 0
                e.Graphics.FillRectangle(New SolidBrush(Color.Red), e.Bounds)
            Case 1
                e.Graphics.FillRectangle(New SolidBrush(Color.Blue), e.Bounds)
            Case 2
                e.Graphics.FillRectangle(New SolidBrush(Color.Magenta), e.Bounds)

        End Select
    End Sub
End Class