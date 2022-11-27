Imports MySql.Data.MySqlClient

Public Class FormDadokPG

    Private Sub AmbilData()
        With ListView1.SelectedItems
            Try
                TxtNadok.Text = .Item(0).SubItems(1).Text
            Catch ex As Exception

            End Try
        End With
    End Sub
    Private Sub FormDadokPG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_user()
    End Sub
    Private Sub load_user()
        Try
            sql = "Select * from tbl_pg"
            connection()
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr("iddpg").ToString)
                x.SubItems.Add(dr("namadpg"))
                x.SubItems.Add(dr("nodpg"))
                ListView1.Items.Add(x)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormLakes.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsEmpty(Me) Then
            MsgBox("Harap lengkapi data")
        Else
            connection()
            cmd = New MySqlCommand
            cmd.Connection = con
            sql = "insert into tbl_janji values ('','" & "Poli Gigi" & "','" & TxtNadok.Text & "','" & TxtNapas.Text & "','" & TxtUpas.Text & "','" & TxtKeluh.Text & "','" & TxtPukul.Text & "')"
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil ditambahkan")
            FormJanji.Show()
        End If
    End Sub
End Class
