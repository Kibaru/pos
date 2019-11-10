Imports MySql.Data.MySqlClient

Public NotInheritable Class SplashScreen1
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connection As New MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)
        Try
            connection.Open()
            command = New MySqlCommand("Select * from pos.company", connection)
            reader = command.ExecuteReader
            While reader.Read

                Company_name.Text = reader.GetString("name")

            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Width += 10
        If PictureBox2.Width >= 250 Then
            Me.Close()
        End If
    End Sub
End Class
