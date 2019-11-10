Imports MySql.Data.MySqlClient

Public Class Form_new_customer
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Customer_add_Click(sender As Object, e As EventArgs) Handles Customer_add.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Customer_name.Text = "" Then
                MsgBox("Customer name is a required field.", MsgBoxStyle.Exclamation, "Create")
                Return
            End If
            query = "Select * from pos.customers where name = '" & Customer_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This Customer already exist.", MsgBoxStyle.Exclamation, "Create Customer")
            Else
                connection.Close()
                connection.Open()
                query = "Insert into pos.customers (national, name, location, pin, tel, email, first_elec, second_elec, payment, payment_mode, ref, srn, work, meter, created_by) 
                        values('" & Customer_id.Text & "', '" & Customer_name.Text & "', '" & Customer_location.Text & "', '" & Customer_kra.Text & "', '" & Customer_tel.Text & "', '" & Customer_email.Text & "', '" & ComboBox_1_elect.Text & "', '" & ComboBox_2_elect.Text & "', '" & Customer_to_be_paid.Text & "', '" & ComboBox_pay_mode.Text & "', '" & Customer_ref.Text & "', '" & Customer_srn.Text & "', '" & Customer_work.Text & "', '" & Customer_meter.Text & "', '" & Username & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader

                MsgBox("Customer created successfully.", MsgBoxStyle.Information, "Create Customer")
                Me.Close()

                connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Form2.Load_DataGridView_orders_customers()
        Form2.Load_DataGridView_customers()
    End Sub

    Private Sub Customer_kra_TextChanged(sender As Object, e As EventArgs) Handles Customer_kra.TextChanged

    End Sub
End Class