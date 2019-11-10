Imports MySql.Data.MySqlClient

Public Class Form_create_customer
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Button_create_customer_Click(sender As Object, e As EventArgs) Handles Button_create_customer.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Customer_id.Text = "" Or Customer_name.Text = "" Or Customer_location.Text = "" Or Customer_to_be_paid.Text = "" Or ComboBox_pay_mode.Text = "" Then
                MsgBox("All * fields are mandatory.", MsgBoxStyle.Exclamation, "Create")
                Return
            End If
            query = "Select * from pos.customers where name = '" & Customer_name.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = Command.ExecuteReader
            If reader.HasRows Then
                MsgBox("This Customer already exist.", MsgBoxStyle.Exclamation, "Create Customer")
            Else
                connection.Close()
                connection.Open()
                If ComboBox_pay_mode.Text = "Whole Amount" Then
                    If Convert.ToInt64(Customer_to_be_paid.Text) = Convert.ToInt64(Customer_whole_amnt.Text) Then
                        query = "Insert into pos.customers (national, name, location, pin, tel, email, first_elec, second_elec, payment, payment_mode, whole_amount, balance, ref, srn, work, meter, created_by) 
                        values('" & Customer_id.Text & "', '" & Customer_name.Text & "', '" & Customer_location.Text & "', '" & Customer_kra.Text & "', '" & Customer_tel.Text & "', '" & Customer_email.Text & "', '" & ComboBox_1_elect.Text & "', '" & ComboBox_2_elect.Text & "', '" & Customer_to_be_paid.Text & "', '" & ComboBox_pay_mode.Text & "', '" & Customer_whole_amnt.Text & "', '" & Customer_bal.Text & "', '" & Customer_ref.Text & "', '" & Customer_srn.Text & "', '" & Customer_work.Text & "', '" & Customer_meter.Text & "', '" & Username & "')"
                        command = New MySqlCommand(query, connection)
                        reader = command.ExecuteReader
                    Else
                        MsgBox("Ensure amount paid is equal to the amount to be paid.", MsgBoxStyle.Exclamation, "Wrong Amount")
                        Return
                    End If
                ElseIf ComboBox_pay_mode.Text = "Instalments" Then
                    query = "Insert into pos.customers (national, name, location, pin, tel, email, first_elec, second_elec, payment, payment_mode, deposit, rest, balance, ref, srn, work, meter, created_by) 
                        values('" & Customer_id.Text & "', '" & Customer_name.Text & "', '" & Customer_location.Text & "', '" & Customer_kra.Text & "', '" & Customer_tel.Text & "', '" & Customer_email.Text & "', '" & ComboBox_1_elect.Text & "', '" & ComboBox_2_elect.Text & "', '" & Customer_to_be_paid.Text & "', '" & ComboBox_pay_mode.Text & "', '" & Customer_deposit.Text & "', '" & Customer_rest_payment.Text & "', '" & Customer_bal.Text & "', '" & Customer_ref.Text & "', '" & Customer_srn.Text & "', '" & Customer_work.Text & "', '" & Customer_meter.Text & "', '" & Username & "')"
                    command = New MySqlCommand(query, connection)
                    reader = command.ExecuteReader
                End If

                MsgBox("Customer created successfully.", MsgBoxStyle.Information, "Create Customer")
                Me.Close()

                connection.Close()
                End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Form2.Load_DataGridView_customers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_update_customer.Click
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            Dim query As String
            If Customer_id.Text = "" Or Customer_name.Text = "" Or Customer_location.Text = "" Or Customer_to_be_paid.Text = "" Or ComboBox_pay_mode.Text = "" Then
                MsgBox("All * fields are mandatory.", MsgBoxStyle.Exclamation, "Update")
                Return
            End If
            If ComboBox_pay_mode.Text = "Whole Amount" Then
                query = "Update pos.customers set national='" & Customer_id.Text & "', name='" & Customer_name.Text & "', location='" & Customer_location.Text & "',  pin='" & Customer_kra.Text & "', tel='" & Customer_tel.Text & "', email='" & Customer_email.Text & "',  first_elec='" & ComboBox_1_elect.Text & "', second_elec='" & ComboBox_2_elect.Text & "',  payment='" & Customer_to_be_paid.Text & "',  payment_mode='" & ComboBox_pay_mode.Text & "',  whole_amount='" & Customer_whole_amnt.Text & "',  balance='" & Customer_bal.Text & "',  ref='" & Customer_ref.Text & "',  srn='" & Customer_srn.Text & "',  work='" & Customer_work.Text & "',  meter='" & Customer_meter.Text & "', updated_by='" & Username & "' WHERE id = '" & Customer_auto_id.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            ElseIf ComboBox_pay_mode.Text = "Instalments" Then
                query = "Update pos.customers set national='" & Customer_id.Text & "', name='" & Customer_name.Text & "', location='" & Customer_location.Text & "',  pin='" & Customer_kra.Text & "', tel='" & Customer_tel.Text & "', email='" & Customer_email.Text & "',  first_elec='" & ComboBox_1_elect.Text & "', second_elec='" & ComboBox_2_elect.Text & "',  payment='" & Customer_to_be_paid.Text & "',  payment_mode='" & ComboBox_pay_mode.Text & "',  deposit='" & Customer_deposit.Text & "', rest='" & Customer_rest_payment.Text & "',  balance='" & Customer_bal.Text & "',  ref='" & Customer_ref.Text & "',  srn='" & Customer_srn.Text & "',  work='" & Customer_work.Text & "',  meter='" & Customer_meter.Text & "', updated_by='" & Username & "' WHERE id = '" & Customer_auto_id.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If

            MsgBox("customer details updated successfully.", MsgBoxStyle.Information, "Update Customer")
            Me.Close()

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Form2.Load_DataGridView_customers()
    End Sub

    Private Sub Customer_cancel_Click(sender As Object, e As EventArgs) Handles Customer_cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_srn.Click
        If Customer_srn.Visible = False Then
            Label_srn.Visible = True
            Customer_srn.Visible = True
        Else
            Label_srn.Visible = False
            Customer_srn.Visible = False
        End If
    End Sub

    Private Sub Button_work_Click(sender As Object, e As EventArgs) Handles Button_work.Click
        If Customer_work.Visible = False Then
            Label_work.Visible = True
            Customer_work.Visible = True
        Else
            Label_work.Visible = False
            Customer_work.Visible = False
        End If
    End Sub

    Private Sub Button_meter_Click(sender As Object, e As EventArgs) Handles Button_meter.Click
        If Customer_meter.Visible = False Then
            Label_meter.Visible = True
            Customer_meter.Visible = True
        Else
            Label_meter.Visible = False
            Customer_meter.Visible = False
        End If
    End Sub

    Public Sub Load_ComboBox_first_electrician()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.electricians", connection)
            reader = command.ExecuteReader
            While reader.Read
                ComboBox_1_elect.Items.Add(reader.GetString("name"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public Sub Load_ComboBox_second_electrician()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.electricians", connection)
            reader = command.ExecuteReader
            While reader.Read
                ComboBox_2_elect.Items.Add(reader.GetString("name"))
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Form_create_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_ComboBox_first_electrician()
        Load_ComboBox_second_electrician()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_pay_mode.SelectedIndexChanged
        If ComboBox_pay_mode.Text = "Whole Amount" Then
            Label_amnt.Visible = True
            Customer_whole_amnt.Visible = True
            Label_deposit.Visible = False
            Customer_deposit.Visible = False
            Label_instalment.Visible = False
            Customer_rest_payment.Visible = False
        ElseIf ComboBox_pay_mode.Text = "Instalments" Then
            Label_amnt.Visible = False
            Customer_whole_amnt.Visible = False
            Label_deposit.Visible = True
            Customer_deposit.Visible = True
            Label_instalment.Visible = True
            Customer_rest_payment.Visible = True
        End If
    End Sub

    Private Sub Customer_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customer_id.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Customer_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customer_tel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Customer_to_be_paid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customer_to_be_paid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Customer_deposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customer_deposit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Customer_whole_amnt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customer_whole_amnt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Customer_rest_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Customer_rest_payment.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Use numbers only!", MsgBoxStyle.Exclamation, "Not Allowed")

            End If
        End If
    End Sub

    Private Sub Customer_whole_amnt_TextChanged(sender As Object, e As EventArgs) Handles Customer_whole_amnt.TextChanged
        If ComboBox_pay_mode.Text = "Whole Amount" Then
            Customer_bal.Text = 0
        End If
    End Sub

    Private Sub Customer_deposit_TextChanged(sender As Object, e As EventArgs) Handles Customer_deposit.TextChanged
        If ComboBox_pay_mode.Text = "Instalments" Then
            If Customer_to_be_paid.Text = "" Or Customer_deposit.Text = "" Then
                Customer_bal.Text = ""
            ElseIf Customer_to_be_paid.Text IsNot "" And Customer_deposit.Text IsNot "" And Customer_rest_payment.Text IsNot "" Then
                Customer_bal.Text = Convert.ToInt64(Customer_to_be_paid.Text) - (Convert.ToInt64(Customer_deposit.Text) + Convert.ToInt64(Customer_rest_payment.Text))
            ElseIf Customer_to_be_paid.Text IsNot "" And Customer_deposit.Text IsNot "" Then
                Customer_bal.Text = Convert.ToInt64(Customer_to_be_paid.Text) - Convert.ToInt64(Customer_deposit.Text)
            End If
        End If
    End Sub

    Private Sub Customer_rest_payment_TextChanged(sender As Object, e As EventArgs) Handles Customer_rest_payment.TextChanged
        If ComboBox_pay_mode.Text = "Instalments" Then
            If Customer_to_be_paid.Text = "" Or Customer_deposit.Text = "" Then
                Customer_bal.Text = ""
            ElseIf Customer_to_be_paid.Text IsNot "" And Customer_deposit.Text IsNot "" And Customer_rest_payment.Text = "" Then
                Customer_bal.Text = Convert.ToInt64(Customer_to_be_paid.Text) - Convert.ToInt64(Customer_deposit.Text)
            ElseIf Customer_to_be_paid.Text IsNot "" And Customer_deposit.Text IsNot "" And Customer_rest_payment.Text IsNot "" Then
                Customer_bal.Text = Convert.ToInt64(Customer_to_be_paid.Text) - (Convert.ToInt64(Customer_deposit.Text) + Convert.ToInt64(Customer_rest_payment.Text))
            End If
        End If
    End Sub
End Class