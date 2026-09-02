Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Halo!" & vbCrLf &
                        "Nama       : " & txtNama.Text & vbCrLf &
                        "NIM       : " & txtNim.Text & vbCrLf &
                        "KOM       : " & txtKom.Text & vbCrLf &
                        "Selamat Datang di Visual Basic")
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtHapus_Click(sender As Object, e As EventArgs) Handles txtHapus.Click
        txtNama.Clear()
        txtNim.Clear()
        txtKom.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
