# Pemrograman Visual

Repository ini berisi hasil praktikum dan catatan pembelajaran pada mata kuliah **Pemrograman Visual**. Setiap pertemuan membahas materi dan praktik yang berbeda sesuai dengan pembelajaran di kelas.

# Pertemuan 1: Pengenalan Pemrograman Visual

## Pemrograman Visual

Pemrograman visual merupakan metode pengembangan aplikasi yang menggunakan antarmuka grafis dalam proses pembuatan program. Pengembang dapat merancang tampilan aplikasi menggunakan berbagai komponen yang tersedia, kemudian mengatur fungsi dari setiap komponen melalui kode program.

Pemrograman visual menggunakan konsep **event driven programming**, yaitu program menjalankan suatu perintah berdasarkan event atau aktivitas yang dilakukan oleh pengguna. Contohnya ketika pengguna menekan tombol, memasukkan teks, atau memilih suatu pilihan pada aplikasi.

## Microsoft Visual Studio

Pada mata kuliah Pemrograman Visual, aplikasi yang digunakan adalah **Microsoft Visual Studio**. Visual Studio digunakan untuk membuat project, merancang tampilan aplikasi, menulis kode program, serta menjalankan dan menguji aplikasi.

## Instalasi Microsoft Visual Studio

Berikut langkah instalasi Microsoft Visual Studio yang digunakan untuk kegiatan praktikum:

1. Buka website resmi Microsoft Visual Studio.
2. Unduh **Visual Studio Community**.
3. Jalankan file Visual Studio Installer yang telah diunduh.
4. Pada bagian **Workloads**, pilih **.NET desktop development**.
5. Pastikan komponen yang diperlukan telah dipilih.
6. Pilih **Install** untuk memulai proses instalasi.
7. Tunggu hingga proses instalasi selesai.
8. Setelah selesai, buka Microsoft Visual Studio.
9. Visual Studio sudah dapat digunakan untuk membuat project baru.

# Pertemuan 2: Komponen Dasar Pemrograman Visual

Pada pertemuan kedua dilakukan praktik penggunaan beberapa komponen dasar pada Microsoft Visual Studio dengan membuat aplikasi sederhana berupa **Form Profil Mahasiswa**.

## Komponen yang Digunakan

### Label

Label digunakan untuk memberikan keterangan pada form. Pada aplikasi Profil Mahasiswa, label digunakan untuk menampilkan keterangan **Nama**, **NIM**, dan **KOM**.

### TextBox

TextBox digunakan sebagai tempat untuk memasukkan data. Pada form terdapat tiga TextBox yang digunakan untuk mengisi nama, NIM, dan KOM mahasiswa.

### Button

Button digunakan untuk menjalankan perintah ketika ditekan. Pada aplikasi ini terdapat tiga button:

1. **Tampilkan**, digunakan untuk menampilkan data yang telah dimasukkan.
2. **Hapus**, digunakan untuk menghapus data pada TextBox.
3. **Keluar**, digunakan untuk menutup aplikasi.

## Pertemuan 2: Penjelasan Kode Program (Form1.vb)

Bagian ini menguraikan kode program secara berurutan, mulai dari deklarasi class hingga penutupnya.

### a. Deklarasi Class

```vb
Public Class Form1
```

Baris ini membuat class `Form1` yang mewakili tampilan form. Semua event handler dari komponen di form diletakkan di dalam class ini.

### b. Event Handler `Label1_Click` (untuk `lblNama`)

```vb
Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNama.Click

End Sub
```

Handler ini berjalan saat `lblNama` diklik. Isinya masih kosong, jadi belum ada aksi apa pun. Handler seperti ini umumnya terbentuk otomatis oleh IDE ketika komponen di-double click pada mode desain.

### c. Event Handler `btnSubmit_Click`

```vb
Private Sub btnSubmit_Click(sender As Object, e As EventArgs)

End Sub
```

Method ini dimaksudkan untuk menangani klik pada `btnSubmit`. Namun method ini tidak memiliki klausa `Handles btnSubmit.Click`, sehingga secara teknis belum terhubung ke tombolnya. Isinya juga kosong, jadi menekan tombol tersebut tidak menghasilkan apa-apa.

### d. Event Handler `Form1_Load`

```vb
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub
```

Event ini terpicu otomatis satu kali saat form pertama kali dimuat, sebelum pengguna berinteraksi. `MyBase.Load` menunjukkan event tersebut berasal dari class induk `Form1`, yaitu class `Form` bawaan .NET. Biasanya dipakai untuk inisialisasi awal, misalnya mengatur nilai default komponen. Pada program ini isinya masih kosong.

### e. Event Handler `TextBox1_TextChanged` (untuk `txtNama`)

```vb
Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

End Sub
```

Event ini terpicu setiap isi `txtNama` berubah, baik saat mengetik maupun menghapus karakter. Biasanya dipakai untuk validasi input secara langsung (real time), tetapi di sini belum diberi logika.

### f. Event Handler `Label1_Click_1` (untuk `lblNim`) dan `Label1_Click_2` (untuk `lblKom`)

```vb
Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNim.Click

End Sub

Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lblKom.Click

End Sub
```

Keduanya serupa dengan `Label1_Click`, yaitu menangani klik pada `lblNim` dan `lblKom`. Akhiran `_1` dan `_2` ditambahkan IDE secara otomatis karena nama `Label1_Click` sudah terpakai, supaya tidak ada nama method yang kembar. Kedua blok ini juga masih kosong.

### g. Event Handler `btnTampilkan_Click`

```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    MessageBox.Show("Halo" & vbCrLf &
                    "Nama : " & txtNama.Text & vbCrLf &
                    "Nim  : " & txtNim.Text & vbCrLf &
                    "Kom  : " & txtKom.Text & vbCrLf &
                    "Selamat Datang di Visual Basic")
End Sub
```

Inilah bagian inti program. Method ini berjalan saat `btnTampilkan` diklik.

- `MessageBox.Show(...)` memunculkan kotak dialog berisi pesan untuk pengguna.
- Tanda `&` menggabungkan (concatenate) beberapa string menjadi satu kalimat.
- `vbCrLf` adalah konstanta pindah baris (carriage return + line feed), sehingga isi dialog tampil dalam beberapa baris, bukan satu baris panjang.
- `txtNama.Text`, `txtNim.Text`, dan `txtKom.Text` mengambil teks yang diketik pengguna di masing-masing TextBox.

Secara keseluruhan, method ini mengambil data dari TextBox lalu menampilkannya sebagai pesan sapaan lewat MessageBox.

### h. Event Handler `btnHapus_Click`

```vb
Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    txtNama.Clear()
    txtNim.Clear()
    txtKom.Clear()
End Sub
```

Dijalankan saat `btnHapus` diklik. Method `Clear()` mengosongkan `txtNama`, `txtNim`, dan `txtKom`, sehingga form kembali bersih dan siap dipakai untuk data baru.

### i. Event Handler `btnKeluar_Click`

```vb
Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
    Me.Close()
End Sub
```

Dijalankan saat `btnKeluar` diklik. `Me` merujuk pada form yang sedang aktif (di sini `Form1`), dan `Close()` adalah method bawaan untuk menutup form. Jika form tersebut adalah form utama project, aplikasi ikut berhenti.

### j. Penutup Class

```vb
End Class
```

Menandai berakhirnya deklarasi class `Form1`.

### Alur Kerja Program

1. Aplikasi dijalankan dan `Form1_Load` terpicu sekali (belum ada aksi karena masih kosong).
2. Pengguna mengisi Nama, NIM, dan Kom pada TextBox masing-masing.
3. Tombol **Tampilkan** menampilkan data yang diisi dalam MessageBox berupa pesan sapaan.
4. Tombol **Hapus** mengosongkan seluruh TextBox.
5. Tombol **Keluar** menutup aplikasi.

---

## Pertemuan 3: Operator dan Struktur Kendali

Pertemuan ini membahas operator dan struktur kendali pada VB.NET, lalu menerapkannya pada program sederhana yang menerima nilai ujian dan menampilkan gambar sesuai nilai tersebut. Selain `If`, `ElseIf`, dan `Else`, dipelajari juga validasi input dengan `TryParse` dan pembatasan karakter TextBox lewat event `KeyPress`.

### 3.1 Deskripsi Program

Program menerima nilai ujian dalam rentang 0 sampai 100. Setelah tombol input ditekan, program memeriksa apakah input berupa angka dan apakah nilainya masih dalam rentang yang diizinkan. Jika valid, gambar yang tampil bergantung pada nilai:

| Nilai | Gambar |
| --- | --- |
| 0 - 50 | 1.jpg |
| 51 - 75 | 2.jpg |
| 76 - 100 | 3.jpg |

Gambar disimpan di folder `Assets` pada project.

### 3.2 Struktur Kendali `If`, `ElseIf`, dan `Else`

`If` dipakai untuk membuat percabangan berdasarkan kondisi. Di program ini, percabangan menentukan gambar mana yang ditampilkan.

```vb
If nilaiUjian <= 50 Then
    picImage.Image = Image.FromFile("Assets\1.jpg")
ElseIf nilaiUjian <= 75 Then
    picImage.Image = Image.FromFile("Assets\2.jpg")
Else
    picImage.Image = Image.FromFile("Assets\3.jpg")
End If
```

Nilai 50 ke bawah menampilkan `1.jpg`. Nilai di atas 50 sampai 75 menampilkan `2.jpg`. Selebihnya (di atas 75) menampilkan `3.jpg`.

### 3.3 Validasi Input dengan `Integer.TryParse`

Isi TextBox pada dasarnya bertipe teks. Karena nilai ujian dipakai sebagai `Integer`, input harus dikonversi dulu.

```vb
Dim nilaiUjian As Integer

If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
    MessageBox.Show("Masukkan dalam bentuk angka")
    txtNilai.Focus()
    Return
End If
```

- `Integer.TryParse()` mencoba mengubah isi `txtNilai` menjadi `Integer`.
- Jika input bukan angka, hasilnya `False`. Karena ada `Not`, kondisi `If` menjadi benar dan pesan "Masukkan dalam bentuk angka" muncul.
- `txtNilai.Focus()` mengembalikan kursor ke TextBox agar pengguna bisa memperbaiki input.
- `Return` menghentikan proses sehingga kode setelahnya tidak dijalankan.

### 3.4 Membatasi Nilai dengan Operator Logika

Setelah dipastikan berupa angka, nilai dibatasi hanya 0 sampai 100.

```vb
If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
    MessageBox.Show("Masukkan nilai 0 - 100")
    txtNilai.Focus()
    Return
End If
```

Operator `OrElse` membuat program masuk ke blok `If` bila nilai kurang dari 0 atau lebih dari 100. Jadi meskipun input berupa angka, nilai seperti -10 atau 150 tetap ditolak.

### 3.5 Event `KeyPress`

Selain validasi saat tombol Input ditekan, input juga dibatasi sejak pengguna mengetik, memakai event `KeyPress`:

```vb
Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress

    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If

End Sub
```

`KeyPress` terjadi ketika pengguna menekan tombol keyboard di TextBox. Di sini event dipakai agar `txtNilai` hanya menerima karakter yang sesuai untuk nilai, yaitu angka.

### 3.6 Penggunaan `KeyChar`

`e.KeyChar` berisi karakter yang sedang ditekan, yang kemudian bisa diperiksa dengan fungsi dari `Char`. Contoh:

```vb
Char.IsDigit(e.KeyChar)
```

Kode di atas memeriksa apakah karakter yang ditekan adalah angka. Pada program digunakan:

```vb
If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
    e.Handled = True
End If
```

Artinya, jika karakter bukan karakter kontrol dan bukan angka, input ditolak. `e.Handled = True` memberi tahu program bahwa input sudah ditangani sehingga karakter tidak masuk ke TextBox. Karakter kontrol tetap diizinkan karena pengguna masih perlu menghapus dengan Backspace.

### 3.7 `IsDigit` dan `IsLetter`

Fungsi `Char` yang dipelajari untuk memeriksa jenis karakter:

- `Char.IsDigit()` : memeriksa apakah karakter adalah angka.
- `Char.IsLetter()` : memeriksa apakah karakter adalah huruf.
- `Char.IsControl()` : memeriksa apakah karakter adalah karakter kontrol, misalnya Backspace.

Contoh TextBox yang hanya menerima huruf:

```vb
If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
    e.Handled = True
End If
```

Dengan cara ini angka ditolak, dan TextBox hanya menerima huruf serta karakter kontrol. Pilihan `IsDigit` atau `IsLetter` disesuaikan dengan jenis data yang ingin diterima.

### 3.8 Pengaturan Gambar pada PictureBox

Program memakai PictureBox bernama `picImage` untuk menampilkan gambar sesuai nilai. Struktur foldernya:

```
Assets
├── 1.jpg
├── 2.jpg
└── 3.jpg
```

Ukuran gambar dapat disesuaikan dengan area PictureBox lewat properti `SizeMode`. Salah satu pengaturan yang dipakai:

```
SizeMode = Zoom
```

`Zoom` menyesuaikan gambar dengan ukuran PictureBox sambil menjaga perbandingan aslinya, sehingga gambar tidak melebar atau gepeng.

### 3.9 Pengaturan Copy to Output Directory

File gambar harus tersedia saat aplikasi berjalan, sehingga file di folder `Assets` diatur agar ikut disalin ke folder output. Pada Properties file gambar:

```
Copy to Output Directory = Copy if newer
```

`Copy if newer` berarti file disalin ke folder output jika belum ada di sana, atau jika versi di project lebih baru. Dengan begitu `1.jpg`, `2.jpg`, dan `3.jpg` selalu ada ketika program dijalankan.

### 3.10 Alur Kerja Program

1. Pengguna mengisi nilai di `txtNilai`.
2. Event `KeyPress` memeriksa tiap karakter yang diketik.
3. Karakter selain angka dan karakter kontrol ditolak.
4. Saat tombol Input ditekan, `Integer.TryParse()` memeriksa apakah input bisa diubah menjadi angka.
5. Jika bukan angka, muncul pesan kesalahan.
6. Jika angka, program memeriksa apakah nilainya di rentang 0 sampai 100.
7. Jika di luar rentang, muncul pesan kesalahan.
8. Jika valid, `If`, `ElseIf`, dan `Else` menentukan gambar yang dipilih.
9. Gambar ditampilkan lewat PictureBox.

### 3.11 Kesimpulan

Selain operator dan struktur kendali, pertemuan ini mengajarkan cara membuat input lebih terkontrol. `TryParse` memastikan data bisa diproses sebagai angka, sedangkan `KeyPress`, `KeyChar`, `IsDigit`, dan `IsLetter` membatasi karakter yang boleh diketik. `If`, `ElseIf`, dan `Else` menentukan hasil berdasarkan nilai, dan PictureBox dengan pengaturan `Zoom` menampilkan hasilnya dengan proporsi yang tepat.

---

## Tugas 1: Aplikasi Login dan Perhitungan Pajak

Tugas Pemrograman Visual ini dibuat dengan VB.NET Windows Forms dan terdiri dari dua form: `FrmLogin` dan `FrmPajak`.

### Materi yang Digunakan

- Windows Forms dan komponen visual: Label, TextBox, ComboBox, PictureBox, dan Button
- Event `Click`, `KeyPress`, dan `SelectedIndexChanged`
- Validasi input dengan `Char.IsLetter`, `Char.IsDigit`, dan `Decimal.TryParse`
- Percabangan `If...Then...ElseIf...Else`
- Perpindahan antarform dengan `Show()`, `Hide()`, dan `Close()`
- Pengosongan input dengan `Clear()`
- Pengembalian fokus dengan `Focus()`
- Penampilan pesan dengan `MessageBox.Show()`

### Form Login

`FrmLogin` dipakai untuk login berdasarkan role, nama, dan NIM. Role yang tersedia adalah Staff dan Manager, dan gambar pada PictureBox berubah mengikuti role yang dipilih.

Data login:

- Staff: Nadya - 241712051
- Manager: Mingyu - 241712000

Input nama dibatasi dengan `KeyPress`, sedangkan proses login memeriksa kecocokan role, nama, dan NIM.

### Form Pajak

`FrmPajak` menghitung pajak berdasarkan pendapatan.

| Pendapatan | Pajak |
| --- | --- |
| ≤ Rp5.000.000 | 0% |
| ≤ Rp30.000.000 | 10% |
| ≤ Rp100.000.000 | 20% |
| > Rp100.000.000 | 30% |

Rumus:

```
Pajak = Pendapatan × Persentase Pajak
```

---

## Pertemuan 4: Struktur Perulangan

### Tujuan

Mempelajari perulangan `For` pada VB.NET untuk menampilkan data dari nilai awal sampai nilai akhir.

### Materi

- Perulangan `For`
- `Step -1` untuk perulangan menurun
- `Integer.TryParse()` untuk validasi input angka
- Event `KeyPress` untuk membatasi input
- ListBox untuk menampilkan hasil
- `If...Else` untuk menentukan arah perulangan

### Komponen

- `txtNilaiAwal` : input nilai awal
- `txtNilaiAkhir` : input nilai akhir
- `btnInput` : menjalankan perulangan
- `lstHasil` : menampilkan hasil

### Validasi Input

`Integer.TryParse()` memastikan hanya data berupa angka yang diproses.

```vb
If Not Integer.TryParse(txtNilaiAwal.Text, nilaiAwal) Then
    MessageBox.Show("Masukkan angka yang valid!")
    txtNilaiAwal.Focus()
    Return
End If
```

Event `KeyPress` juga dipakai agar TextBox hanya menerima angka:

```vb
If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
    e.Handled = True
End If
```

### Perulangan

Jika nilai awal lebih kecil dari nilai akhir, dipakai perulangan naik biasa:

```vb
For i As Integer = nilaiAwal To nilaiAkhir
    lstHasil.Items.Add(i)
Next
```

Jika nilai awal lebih besar, dipakai `Step -1` agar hitungan turun:

```vb
For i As Integer = nilaiAwal To nilaiAkhir Step -1
    lstHasil.Items.Add(i)
Next
```

Sebelum hasil baru ditampilkan, isi ListBox dikosongkan terlebih dahulu:

```vb
lstHasil.Items.Clear()
```

### Alur Program

1. Masukkan nilai awal dan nilai akhir.
2. Program memvalidasi input.
3. Program menentukan arah perulangan, naik atau turun.
4. Perulangan `For` dijalankan.
5. Hasil ditampilkan di ListBox.

### Contoh

Input 1 sampai 5 menghasilkan:

```
1
2
3
4
5
```

Input 5 sampai 1 menghasilkan:

```
5
4
3
2
1
```

---

## Pertemuan 5: Fungsi dan Array

### Tujuan

Mempelajari `Function`, `Sub`, array 1 dimensi, array 2 dimensi, dan `KeyPress` pada VB.NET.

### Materi

- `Function` dan `Sub`
- Parameter dan `Return`
- Array 1 dimensi
- Array 2 dimensi
- `MessageBox.Show()`
- `KeyPress`
- `Char.IsControl()`
- `Char.IsDigit()`
- `e.Handled`

### 1. Module `ModArray`

`ModArray` menyimpan Sub, Function, dan array yang bisa dipanggil dari Form.

```vb
Module ModArray

    Public Sub TampilkanPesan(nama As Integer)
        MessageBox.Show("halo " & nama)
    End Sub

    Function Hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang <= 50 Then
            Return (2 * panjang) + (2 * lebar)
        Else
            Return panjang * lebar
        End If
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90}

    Public nilai2D(,) As Integer = {
        {55, 58, 65},
        {10, 20, 82},
        {84, 86, 90}
    }

End Module
```

- `TampilkanPesan()` adalah Sub yang menampilkan pesan lewat `MessageBox.Show()`. Parameter `nama` menerima nilai yang akan ditampilkan.
- `Hitung()` adalah Function dengan dua parameter, `panjang` dan `lebar`, dan mengembalikan hasil lewat `Return`. Jika `panjang <= 50`, hasilnya `(2 * panjang) + (2 * lebar)`. Jika tidak, hasilnya `panjang * lebar`.

### 2. Array 1 Dimensi

```vb
Public nilai() As Integer = {50, 60, 70, 80, 90}
```

Array `nilai` menyimpan beberapa angka dalam satu variabel. Indeks dimulai dari 0, jadi `nilai(0)` berisi 50 dan `nilai(4)` berisi 90.

```
nilai(0) = 50
nilai(1) = 60
nilai(2) = 70
nilai(3) = 80
nilai(4) = 90
```

### 3. Array 2 Dimensi

```vb
Public nilai2D(,) As Integer = {
    {55, 58, 65},
    {10, 20, 82},
    {84, 86, 90}
}
```

Array 2 dimensi punya baris dan kolom sehingga bentuknya seperti tabel:

| | | |
| --- | --- | --- |
| 55 | 58 | 65 |
| 10 | 20 | 82 |
| 84 | 86 | 90 |

Data diambil dengan indeks baris dan kolom. Misalnya `nilai2D(1, 2)` mengambil data di baris indeks 1 dan kolom indeks 2, yaitu 82.

### 4. Form `FrmArray`

Komponen yang dipakai:

- `txtPanjang` : input panjang
- `txtLebar` : input lebar
- `btnTampil` : menjalankan proses
- `lstNilai` : menampilkan data
- `lblPanjang` dan `lblLebar` : label

Komponen dibuat pada `FrmArray.Designer.vb`.

### 5. Event `btnTampil_Click`

```vb
Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
    'MessageBox.Show(Hitung(txtPanjang.Text, txtLebar.Text))
    'MessageBox.Show(nilai(50))
    'lstNilai.Items.Add(nilai(5))
    'For i As Integer = 0 To nilai.Length - 1
    '    lstNilai.Items.Add(nilai(i))
    MessageBox.Show(nilai2D(1, 2))
End Sub
```

Event ini berjalan saat `btnTampil` diklik. Baris yang diawali tanda `'` adalah komentar sehingga tidak dieksekusi. Baris-baris tersebut adalah contoh percobaan: memanggil Function, mengambil nilai array, dan menampilkan isi array ke ListBox dengan `For`.

Kode yang aktif:

```vb
MessageBox.Show(nilai2D(1, 2))
```

Baris ini mengambil nilai array 2 dimensi pada indeks (1, 2) dan menampilkannya di MessageBox. Hasilnya 82.

### 6. `KeyPress` pada `txtPanjang`

```vb
Private Sub txtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPanjang.KeyPress
    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If
End Sub
```

Kode ini membatasi input `txtPanjang`. `Char.IsControl()` memeriksa karakter kontrol seperti Backspace, dan `Char.IsDigit()` memeriksa apakah karakter berupa angka. Jika bukan keduanya, `e.Handled = True` menolak input tersebut.

### 7. `KeyPress` pada `txtLebar`

```vb
Private Sub txtLebar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLebar.KeyPress
    If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
        e.Handled = True
    End If
End Sub
```

Fungsinya sama dengan pada `txtPanjang`: hanya angka dan karakter kontrol yang diterima.

### Kesimpulan

Pertemuan ini membahas `Sub` dan `Function` beserta parameter dan `Return`, serta array 1 dimensi dan 2 dimensi untuk menyimpan banyak data dan mengambilnya lewat indeks. Pada Form, `KeyPress` dipakai untuk membatasi input agar hanya menerima angka.

---

## Pertemuan 6: Database

### Deskripsi

Project ini menerapkan database pada VB.NET Windows Forms yang terhubung ke PostgreSQL melalui Supabase. Fungsinya untuk menampilkan dan menambahkan data mahasiswa.

### Fitur

- Tes koneksi database
- Menampilkan data mahasiswa
- Menambahkan data mahasiswa

### Struktur File

- `Form1.vb` : mengatur tampilan dan proses pada form.
- `ModDatabase.vb` : mengatur koneksi ke database.
- `ModFunction.vb` : berisi fungsi untuk mengambil dan menjalankan data.
- `ModQuery.vb` : berisi query untuk menambah dan menampilkan data.
- `appsettings.json` : menyimpan konfigurasi koneksi database.

---

## Panduan Membuat Project (Form, Module, dan Class)

### Mengganti nama form

Di Solution Explorer (panel kanan), klik kanan `Form1.vb` > **Rename** > ketik `Frm<NamaForm>.vb`. Jika muncul pertanyaan "rename all references?", pilih **Yes**.

### Menambah Module

Klik kanan nama project > **Add** > **Module**. Ganti nama module di bagian bawah dialog (tetap berakhiran `.vb`), lalu klik **Add**.

### Menambah Class

Caranya sama seperti menambah Module: klik kanan nama project > **Add** > **Class**, ganti nama di bagian bawah dialog (tetap berakhiran `.vb`), lalu klik **Add**.

### Mengatur Startup Object

Setelah nama form diganti, jangan lupa ubah form awal yang dijalankan: klik kanan nama project > **Properties** > **General** > **Application** > **Startup object**, lalu pilih nama form yang terbaru.

### yg dgv dgv

itu pengaturannya jangan lupa :
AllowUserToAddRows: False, AllowUserToDeleteRows: False, ReadOnly: True, SelectionMode: FullRowSelect, MultiSelect: False, AutoSizeColumnsMode: Fill.

---


### Module `ModHebat`

```vb
Module ModHebat
    Public NamaApapun() As String = {"B", "C", "D", "E"}

    Function HargaSatuan(Apapun As String) As Decimal
        Select Case layanan
            Case "B"
                Return 000
            Case "C"
                Return 000
            Case "D"
                Return 0000
            Case Else
                Return 0000
        End Select
    End Function
End Module
```

### Class `Apalah`

```vb
Public Class Pesanan
    Public Property VL As String
    Public Property WJ As Integer
    Public Property XH As Decimal
    Public Property YD As Decimal
    Public Property ZS As Decimal

End Class
```

### Form `FrmKei`

```vb
Public Class FrmKasir
    Dim daftar As New List(Of Pesanan)

    Private Sub FrmKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nama In NamaLayanan
            cboLayanan.Items.Add(nama)
        Next
        bsPesanan.DataSource = daftar
        dgvPesanan.DataSource = bsPesanan
        dgvPesanan.Columns("Harga").HeaderText = "Harga Satuan"
        For Each k In {"Harga", "Diskon", "Subtotal"}
            dgvPesanan.Columns(k).DefaultCellStyle.Format = "N0"
            dgvPesanan.Columns(k).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            errInput.Clear()
            Dim jml As Integer
            If cboLayanan.SelectedIndex = -1 Then errInput.SetError(cboLayanan, "Pilih layanan")
            If Not Integer.TryParse(txtJumlah.Text, jml) OrElse jml < 1 OrElse jml > 1000 Then errInput.SetError(txtJumlah, "Jumlah salah")
            If errInput.GetError(cboLayanan) <> "" Or errInput.GetError(txtJumlah) <> "" Then Exit Sub

            Dim p As Pesanan = Nothing
            For Each x In daftar
                If x.Layanan = cboLayanan.Text Then p = x
            Next

            If p Is Nothing Then
                p = New Pesanan
                p.Layanan = cboLayanan.Text
                p.Harga = HargaSatuan(p.Layanan)
                daftar.Add(p)
            ElseIf p.Jumlah + jml > 1000 Then
                errInput.SetError(txtJumlah, "Lebih dari 1000")
                Exit Sub
            End If

            p.Jumlah += jml
            p.Diskon = 0
            If p.Jumlah >= 100 Then p.Diskon = p.Harga * p.Jumlah * 0.1
            p.Subtotal = p.Harga * p.Jumlah - p.Diskon

            bsPesanan.ResetBindings(False)
            HitungTotal()
            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Dim jawaban As DialogResult = MessageBox.Show(
            "Hapus semua pesanan dan mulai transaksi baru?", "Transaksi Baru",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If jawaban = DialogResult.Yes Then
            daftar.Clear()
            bsPesanan.ResetBindings(False)
            HitungTotal()
        End If
    End Sub

    Sub HitungTotal()
        Dim total As Decimal = 0
        For Each p In daftar
            total += p.Subtotal
        Next
        lblTotal.Text = "Rp " & total.ToString("N0")
    End Sub
End Class
```
