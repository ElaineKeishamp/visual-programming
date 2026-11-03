Option Strict On

Imports System.ComponentModel
Imports System.IO

Public Class frmPinjam
    ' Kode buku yang sedang dipinjam, untuk mencegah pinjam dua kali
    Private ReadOnly daftarKode As New List(Of String)

    ' Memeriksa semua isian sekaligus. True jika semuanya valid.
    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim valid As Boolean = True

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Kode harus BK diikuti 4 digit, contoh BK0012.")
            valid = False
        ElseIf daftarKode.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        If Kosong(txtJudulBuku.Text) Then
            errPinjam.SetError(txtJudulBuku, "Judul buku wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Kategori wajib dipilih.")
            valid = False
        End If

        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama minimal 3 karakter.")
            valid = False
        End If

        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan bulat 1 sampai 14.")
            valid = False
        End If

        Return valid
    End Function
    ' Mengosongkan semua isian dan menghapus ikon ErrorProvider
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudulBuku.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Mencatat peminjaman jika semua isian valid
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah."
            Return
        End If

        ' Semua isian sudah valid, jadi TryParse pasti berhasil
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim lama As Integer
        Integer.TryParse(txtLamaPinjam.Text.Trim(), lama)

        lstPeminjaman.Items.Add(kode & " | " & txtJudulBuku.Text.Trim() & " | " &
                                cboKategori.Text & " | " & txtNamaPeminjam.Text.Trim() & " | " &
                                lama.ToString() & " hari | kembali " &
                                Date.Today.AddDays(lama).ToString("dd/MM/yyyy"))
        daftarKode.Add(kode)
        lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()
        BersihkanForm()
    End Sub

    ' Tombol Bersihkan: kosongkan isian dan hapus ikon error
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    ' Validasi format kode saat fokus pindah dari txtKodeBuku
    Private Sub txtKodeBuku_Validating(sender As Object, e As CancelEventArgs) Handles txtKodeBuku.Validating
        If Kosong(txtKodeBuku.Text) Then Return
        If KodeBukuValid(txtKodeBuku.Text) Then
            errPinjam.SetError(txtKodeBuku, "")
        Else
            errPinjam.SetError(txtKodeBuku, "Kode harus BK diikuti 4 digit, contoh BK0012.")
            ' e.Cancel = True sengaja tidak dipakai sesuai tugas
        End If
    End Sub

    ' Menyimpan isi daftar peminjaman ke file CSV di folder Documents
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman untuk diekspor.", "Ekspor")
            Return
        End If

        Dim lokasi As String =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                         "peminjaman.csv")
        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasi)
            penulis.WriteLine("Kode;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")
            For Each baris As Object In lstPeminjaman.Items
                penulis.WriteLine(baris.ToString().Replace(" hari | kembali ", ";").Replace(" | ", ";"))
            Next
            lblStatus.Text = "Data diekspor ke " & lokasi
        Catch ex As IOException
            MessageBox.Show("File peminjaman.csv sedang dipakai program lain, misalnya Excel." &
                            vbCrLf & "Tutup file tersebut lalu klik Ekspor lagi.", "Ekspor Gagal")
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Program tidak punya izin menulis ke folder Documents." &
                            vbCrLf & "Cek izin folder atau pindahkan file ke lokasi lain.", "Ekspor Gagal")
        Finally
            If penulis IsNot Nothing Then penulis.Close()   ' file selalu ditutup
        End Try
    End Sub
End Class