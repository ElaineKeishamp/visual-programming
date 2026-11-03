Option Strict On

Public Class frmInventaris
    ' Tabel inventaris buku yang disimpan di memori
    Private ReadOnly tabelBuku As New DataTable()

    ' Menyiapkan form: buat tabel, isi data awal, ikat ke grid, rapikan kolom
    Private Sub frmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuatTabel()
        IsiDataAwal()

        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        RapikanKolom()
        cboKategori.SelectedIndex = -1
        cboFilterKategori.SelectedIndex = 0
        cboUrut.SelectedIndex = 0
        PerbaruiRingkasan()
    End Sub

    ' Membuat kolom pada tabelBuku
    Private Sub BuatTabel()
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))
    End Sub

    ' Mengisi 10 buku awal, semua kategori terwakili dan ada yang stoknya 0
    Private Sub IsiDataAwal()
        tabelBuku.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        tabelBuku.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabelBuku.Rows.Add("BK0003", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 4)
        tabelBuku.Rows.Add("BK0004", "Sapiens", "Yuval Noah Harari", "Nonfiksi", 2011, 3)
        tabelBuku.Rows.Add("BK0005", "Atomic Habits", "James Clear", "Nonfiksi", 2018, 6)
        tabelBuku.Rows.Add("BK0006", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 0)
        tabelBuku.Rows.Add("BK0007", "Kamus Besar Bahasa Indonesia", "Tim Penyusun", "Referensi", 2016, 2)
        tabelBuku.Rows.Add("BK0008", "Atlas Dunia", "Tim Kartografi", "Referensi", 2020, 1)
        tabelBuku.Rows.Add("BK0009", "Bobo Edisi Khusus", "Redaksi Bobo", "Majalah", 2023, 7)
        tabelBuku.Rows.Add("BK0010", "National Geographic Indonesia", "Redaksi NatGeo", "Majalah", 2022, 4)
    End Sub

    ' Merapikan judul, lebar, dan perataan kolom pada dgvBuku
    Private Sub RapikanKolom()
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    ' Menghitung jumlah buku dan total stok dari baris yang sedang tampil di grid
    Private Sub PerbaruiRingkasan()
        Dim totalStok As Integer = 0
        For Each baris As DataGridViewRow In dgvBuku.Rows
            totalStok += CInt(baris.Cells("Stok").Value)
        Next
        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() &
                         " dari " & tabelBuku.Rows.Count.ToString() & " buku"
        lblTotalStok.Text = "Total stok yang tampil: " & totalStok.ToString()
    End Sub

    ' Menyusun ekspresi Filter dari kata pencarian dan kategori, lalu menerapkannya
    Private Sub TerapkanFilter()
        Dim filter As String = ""
        Dim teks As String = AmankanTeksFilter(txtCari.Text.Trim())

        If teks <> "" Then
            filter = "(Judul LIKE '%" & teks & "%' OR Penulis LIKE '%" & teks & "%')"
        End If

        If cboFilterKategori.SelectedIndex > 0 Then
            Dim kategori As String = AmankanTeksFilter(cboFilterKategori.Text)
            If filter <> "" Then filter &= " AND "
            filter &= "Kategori = '" & kategori & "'"
        End If

        bsBuku.Filter = filter
        PerbaruiRingkasan()
    End Sub

    ' Dipanggil setiap teks pencarian atau kategori filter berubah
    Private Sub PencarianBerubah(sender As Object, e As EventArgs) _
            Handles txtCari.TextChanged, cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ' Mengatur urutan tampilan sesuai pilihan cboUrut
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) _
            Handles cboUrut.SelectedIndexChanged
        Select Case cboUrut.SelectedIndex
            Case 1 : bsBuku.Sort = "Judul ASC"
            Case 2 : bsBuku.Sort = "Tahun DESC"
            Case 3 : bsBuku.Sort = "Stok DESC"
            Case Else : bsBuku.Sort = ""
        End Select
    End Sub

    ' Memeriksa semua isian dan menandai yang salah lewat errBuku
    Private Function ValidasiInput() As Boolean
        Dim valid As Boolean = True
        errBuku.Clear()

        ' Kode: format BK + 4 digit, lalu cek duplikat di tabelBuku
        If Not KodeBukuValid(txtKodeBuku.Text) Then
            errBuku.SetError(txtKodeBuku, "Kode harus BK diikuti 4 digit, contoh BK0011")
            valid = False
        Else
            Dim kodeBaru As String = txtKodeBuku.Text.Trim().ToUpper()
            For Each baris As DataRow In tabelBuku.Rows
                If baris("KodeBuku").ToString().ToUpper() = kodeBaru Then
                    errBuku.SetError(txtKodeBuku, "Kode buku sudah ada")
                    valid = False
                    Exit For
                End If
            Next
        End If

        If Kosong(txtJudul.Text) Then
            errBuku.SetError(txtJudul, "Judul wajib diisi")
            valid = False
        End If

        If Kosong(txtPenulis.Text) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Kategori wajib dipilih")
            valid = False
        End If

        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus bilangan bulat 1900 sampai " & Date.Today.Year.ToString())
            valid = False
        End If

        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus bilangan bulat 0 atau lebih")
            valid = False
        End If

        Return valid
    End Function

    ' Menambah buku baru ke tabelBuku jika semua isian valid
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return

        tabelBuku.Rows.Add(txtKodeBuku.Text.Trim().ToUpper(), txtJudul.Text.Trim(), txtPenulis.Text.Trim(),
                           cboKategori.Text, CInt(txtTahun.Text.Trim()), CInt(txtStok.Text.Trim()))
        PerbaruiRingkasan()
        BersihkanIsian()
    End Sub

    ' Mengosongkan semua isian dan penanda error
    Private Sub BersihkanIsian()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        txtTahun.Clear()
        txtStok.Clear()
        cboKategori.SelectedIndex = -1
        errBuku.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Tombol Bersihkan: mengosongkan isian form
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanIsian()
    End Sub

End Class