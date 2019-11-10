Imports MySql.Data.MySqlClient

Public Class Form_product_quantity
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim index As Integer


    Private Sub Quantity_ok_Click(sender As Object, e As EventArgs) Handles Quantity_ok.Click
        Update_items_in_DataGridView_orders()
        Form2.Get_total_prices()
        Me.Close()
    End Sub

    Private Sub Update_items_in_DataGridView_orders()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim query As String
        Dim table As New DataTable
        Dim form As New Form2
        Dim newDataRow As DataGridViewRow
        newDataRow = CType(Me.Owner, Form2).DataGridView_orders.CurrentRow()
        Try
            connection.Open()
            'get current database quantity
            query = "Select * from pos.products where name='" & Product_name.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            'update quantity
            If table.Rows.Count() Then
                query = "Update pos.products set quantity='" & ((table.Rows(0)(3) + Convert.ToInt64(newDataRow.Cells(1).Value)) - Convert.ToInt64(Product_quantity_change.Text)) & "' WHERE name = '" & Product_name.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            newDataRow.Cells(1).Value = Product_quantity_change.Text
            newDataRow.Cells(3).Value = Product_quantity_change.Text * newDataRow.Cells(2).Value
            MsgBox("Quantity updated successfully.", MsgBoxStyle.Information, "Update Quantity")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        CType(Me.Owner, Form2).Load_DataGridView_orders_productss()
    End Sub

    Private Sub Quantity_cancel_Click(sender As Object, e As EventArgs) Handles Quantity_cancel.Click
        Me.Close()
    End Sub

    Private Sub Product_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Product_quantity_change.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Quantity_ok.Enabled = False
                Quantity_error.Text = "Use numbers only!"

            End If
        Else
            Quantity_ok.Enabled = True
            Quantity_error.Text = ""
        End If
    End Sub

    Private Sub Product_quantity_TextChanged(sender As Object, e As EventArgs) Handles Product_quantity_change.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        If Product_quantity_change.Text = "" Then
            Quantity_ok.Enabled = False
            Quantity_error.Text = "Product quantity cannot be empty."
        ElseIf Product_quantity_change.Text = 0 Then
            Quantity_ok.Enabled = False
            Quantity_error.Text = "Product quantity cannot be 0."
        Else
            Quantity_ok.Enabled = True
            Quantity_error.Text = ""
        End If
        Dim query As String
        Dim table As New DataTable
        Try
            connection.Open()
            query = "Select * from pos.products where name='" & Product_name.Text & "'"
            command = New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)

            If table.Rows.Count() Then
                If table.Rows(0)(3) = 0 Then
                    Quantity_ok.Enabled = False
                    Quantity_error.Text = "You are out of stock for " & Product_name.Text & "."
                End If
                If Product_quantity_change.Text IsNot "" Then
                    If Convert.ToInt64(Product_quantity_change.Text) > table.Rows(0)(3) Then
                        Quantity_ok.Enabled = False
                        Quantity_error.Text = "You do not have that kind of stock for " & Product_name.Text & "."
                    End If
                End If
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Class