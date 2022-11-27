Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class FormJanji
    Private Sub load_user()
        Try
            sql = "Select * from tbl_janji"
            connection()
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr("idantri").ToString)
                x.SubItems.Add(dr("jenis"))
                x.SubItems.Add(dr("namadr"))
                x.SubItems.Add(dr("namaps"))
                x.SubItems.Add(dr("usiaps"))
                x.SubItems.Add(dr("keluhan"))
                x.SubItems.Add(dr("pukul"))
                ListView1.Items.Add(x)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub

    Private Sub caridata()
        Dim a As Integer
        Try
            sql = "SELECT * FROM tbl_janji WHERE namadr like '%" & Trim(TxtSearch.Text) & "%' or namaps like '%" & Trim(TxtSearch.Text) & "%'"
            daData = New MySqlDataAdapter(sql, con)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                End With
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub caricomba()
        Dim a As Integer
        Try
            sql = "SELECT * FROM tbl_janji WHERE jenis like '%" & Trim(TxtCombo.Text) & "%'"
            daData = New MySqlDataAdapter(sql, con)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                End With
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormJanji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_user()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Pilih antrian yang akan dihapus")
        Else
            Dim yesNo As String
            yesNo = MsgBox("Data ini akan dihapus, lanjutkan ?", MsgBoxStyle.YesNo, "Konfigurasi data")
            If yesNo = DialogResult.Yes Then
                connection()
                cmd = New MySqlCommand
                cmd.Connection = con
                sql = "delete from tbl_janji where idantri = '" & ListView1.SelectedItems.Item(0).SubItems(0).Text & "'"
                cmd.CommandText = sql
                cmd.ExecuteNonQuery()
                load_user()
                MsgBox("Data berhasil dihapus")
            End If
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        caridata()
    End Sub

    Private Sub TxtCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCombo.SelectedIndexChanged
        caricomba()
    End Sub
End Class
