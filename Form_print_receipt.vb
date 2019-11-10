Imports MySql.Data.MySqlClient
Public Class Form_print_receipt
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Form_print_receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_company_info()
        LoadReceiptInfo()
        PrintDocument1.Print()
        Me.Close()
    End Sub

    Private Sub LoadItemstoDatagrid()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim y As Integer
        Dim query As String
        Try
            connection.Open()
            query = "Select * from pos.sales WHERE order_id='" & Receipt_invoice.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            DataGridView_transaction.Rows.Clear()
            Do While reader.Read = True
                DataGridView_transaction.Rows.Add(reader("quantity"), reader("product_name"), reader("price"), reader("total_price"))
                DataGridView_transaction.Height += 19
                y += 19
            Loop

            Panel2.Location = New Point(9, 187 + y)
            Panel1.Height += y
            Me.Height += y
            DataGridView_transaction.Height -= 20
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            command.Dispose()
        End Try
    End Sub

    Private Sub Load_company_info()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim query As String
        Try
            connection.Open()
            query = "Select * from pos.company"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            If reader.Read = True Then
                Receipt_name.Text = reader.GetString("name")
                Receipt_address.Text = reader.GetString("email")
                Receipt_contact.Text = reader.GetString("tel")
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            command.Dispose()
        End Try
    End Sub
    Private Sub LoadReceiptInfo()
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Dim query As String
        Try
            connection.Open()
            query = "Select * from pos.orders where id='" & Receipt_invoice.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader

            If reader.Read = True Then
                Receipt_cashier.Text = Username
                Receipt_date.Text = Date.Now.ToString("dd/MM/yyyy")
                Receipt_time.Text = Date.Now.ToString("hh:mm:ss")
                Receipt_vat.Text = reader("discount")
                Receipt_sub_total.Text = reader("sub_total")
                Receipt_total.Text = reader("net_total")
                Receipt_cash.Text = reader("received_cash")
                Receipt_change.Text = reader("change_cash")

                query = "Select * from pos.customers where id='" & reader("customer_id") & "'"
                connection.Close()
                connection.Open()
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                If reader.Read = True Then
                    Label_thanks.Text = "Thank you " & reader("name") & "."
                End If
                'connection.Close()
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            command.Dispose()
        End Try

        LoadItemstoDatagrid()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Yes Then
            PrintDocument1.Print()
        End If
    End Sub
End Class