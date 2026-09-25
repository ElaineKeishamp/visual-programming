Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim berat As Decimal

        If Not Decimal.TryParse(txtBerat.Text, berat) Then
            MessageBox.Show("Berat cucian harus diisi dengan angka yang valid.",
                         "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' hentikan proses, jangan lanjut hitung
        End If

        If berat <= 0 Then
            MessageBox.Show("Berat cucian harus lebih dari 0 kg.",
                         "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim subtotal As Decimal
        Dim diskon As Decimal

        Dim total As Decimal = ModFunction.HitungTotal(
            Decimal.Parse(txtBerat.Text), chkMember.Checked, subtotal, diskon)

        lblSubtotal.Text = "Subtotal: Rp" & subtotal.ToString("N0")
        lblDiskon.Text = "Diskon:  Rp" & diskon.ToString("N0")
        lblTotal.Text = "Total Bayar:  Rp" & total.ToString("N0")
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class