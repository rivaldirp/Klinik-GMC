Imports MySql.Data.MySqlClient

Public Class FormLogin

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=db_klinikgmc")

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As New MySqlCommand("SELECT `idadmin`, `namaadmin`, `useradmin`, `pwadmin` FROM `tbl_admin` WHERE `useradmin` = @username AND `pwadmin` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MsgBox("Invalid Username Or Password")

        Else

            FormLakes.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
