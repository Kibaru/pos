Imports MySql.Data.MySqlClient

Public Class Form_sell_services
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Sell_service_Click(sender As Object, e As EventArgs) Handles Sell_service.Click
        Update_services_in_DataGridView_orders()
        Form2.Get_total_prices()
        Me.Close()
    End Sub

    Private Sub Update_services_in_DataGridView_orders()
        If Service_name.Text = "" Or Service_quantity.Text = "" Or Service_unit_price.Text = "" Then
            MsgBox("All fields are required.", MsgBoxStyle.Exclamation, "Required")
        Else
            Form2.DataGridView_orders.RowTemplate.Height = 50
            Form2.DataGridView_orders.Rows.Add(Service_name.Text, Service_quantity.Text, Service_unit_price.Text, Service_total_price.Text)
            MsgBox("Services added successfully.", MsgBoxStyle.Information, "Sell services")
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Service_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Service_quantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Service_unit_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Service_unit_price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Service_quantity_TextChanged(sender As Object, e As EventArgs) Handles Service_quantity.TextChanged
        If Service_quantity.Text = "" And Service_unit_price.Text = "" Then
            Service_total_price.Text = 0.00
        ElseIf Service_quantity.Text = "" Or Service_unit_price.Text = "" Then
            Service_total_price.Text = 0.00
        Else
            Service_total_price.Text = Convert.ToInt64(Service_quantity.Text) * Convert.ToInt64(Service_unit_price.Text)
        End If
    End Sub

    Private Sub Service_unit_price_TextChanged(sender As Object, e As EventArgs) Handles Service_unit_price.TextChanged
        If Service_unit_price.Text = "" And Service_quantity.Text = "" Then
            Service_total_price.Text = 0.00
        ElseIf Service_quantity.Text = "" Or Service_unit_price.Text = "" Then
            Service_total_price.Text = 0.00
        Else
            Service_total_price.Text = Convert.ToInt64(Service_quantity.Text) * Convert.ToInt64(Service_unit_price.Text)
        End If
    End Sub

    Private Sub Service_name_TextChanged(sender As Object, e As EventArgs) Handles Service_name.TextChanged
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim query As String
        Try
            connection.Open()
            query = "Select * from pos.products where name = '" & Service_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This product already exist. You can sell it from the database instead.", MsgBoxStyle.Exclamation, "Already Exist")
                Service_name.Text = ""
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Class