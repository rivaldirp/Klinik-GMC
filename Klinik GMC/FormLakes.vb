Public Class FormLakes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormDadokPU.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormDadokPG.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormDadokSM.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormDadokTHT.Show()
        Me.Hide()
    End Sub


    Private Sub FormLakes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormJanji.Show()
    End Sub
End Class
