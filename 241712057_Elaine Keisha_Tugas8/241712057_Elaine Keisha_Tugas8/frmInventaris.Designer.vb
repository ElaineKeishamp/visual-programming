<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventaris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        lblKode = New Label()
        lblJudul = New Label()
        lblPenulis = New Label()
        lblKategori = New Label()
        lblTahun = New Label()
        lblStok = New Label()
        lblCari = New Label()
        lblFilter = New Label()
        lblUrutan = New Label()
        lblJumlah = New Label()
        lblTotalStok = New Label()
        cboKategori = New ComboBox()
        cboFilterKategori = New ComboBox()
        cboUrut = New ComboBox()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        txtTahun = New TextBox()
        txtPenulis = New TextBox()
        txtCari = New TextBox()
        txtStok = New TextBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        dgvBuku = New DataGridView()
        errBuku = New ErrorProvider(components)
        bsBuku = New BindingSource(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(12, 25)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(408, 38)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(12, 85)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(97, 25)
        lblKode.TabIndex = 1
        lblKode.Text = "Kode Buku"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(12, 155)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(97, 25)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(12, 222)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(66, 25)
        lblPenulis.TabIndex = 3
        lblPenulis.Text = "Penulis"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(12, 296)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(78, 25)
        lblKategori.TabIndex = 4
        lblKategori.Text = "Kategori"
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(12, 371)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(106, 25)
        lblTahun.TabIndex = 5
        lblTahun.Text = "Tahun Terbit"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(12, 450)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(47, 25)
        lblStok.TabIndex = 6
        lblStok.Text = "Stok"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(398, 85)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(149, 25)
        lblCari.TabIndex = 7
        lblCari.Text = "Cari Judul/Penulis"
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Location = New Point(398, 155)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(121, 25)
        lblFilter.TabIndex = 8
        lblFilter.Text = "Filter Kategori"
        ' 
        ' lblUrutan
        ' 
        lblUrutan.AutoSize = True
        lblUrutan.Location = New Point(789, 155)
        lblUrutan.Name = "lblUrutan"
        lblUrutan.Size = New Size(109, 25)
        lblUrutan.TabIndex = 9
        lblUrutan.Text = "Urutan Buku"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(398, 531)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(230, 25)
        lblJumlah.TabIndex = 10
        lblJumlah.Text = "Menampilkan X dari Y buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(398, 569)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(196, 25)
        lblTotalStok.TabIndex = 11
        lblTotalStok.Text = "Total stok yang tampil: "
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(12, 324)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(309, 33)
        cboKategori.TabIndex = 12
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New Point(398, 183)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(267, 33)
        cboFilterKategori.TabIndex = 13
        ' 
        ' cboUrut
        ' 
        cboUrut.FormattingEnabled = True
        cboUrut.Items.AddRange(New Object() {"Urutan Awal", "Judul A-Z", "Tahun Terbaru", "Stok Terbanyak"})
        cboUrut.Location = New Point(789, 183)
        cboUrut.Name = "cboUrut"
        cboUrut.Size = New Size(281, 33)
        cboUrut.TabIndex = 14
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(12, 113)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(309, 31)
        txtKodeBuku.TabIndex = 15
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(12, 183)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(309, 31)
        txtJudul.TabIndex = 16
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(12, 399)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(309, 31)
        txtTahun.TabIndex = 17
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(12, 250)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(309, 31)
        txtPenulis.TabIndex = 18
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(398, 113)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(672, 31)
        txtCari.TabIndex = 19
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(12, 478)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(309, 31)
        txtStok.TabIndex = 20
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(12, 540)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(133, 34)
        btnTambah.TabIndex = 21
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(209, 540)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 22
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(398, 250)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.RowHeadersWidth = 62
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(680, 259)
        dgvBuku.TabIndex = 23
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' frmInventaris
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1117, 612)
        Controls.Add(dgvBuku)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(txtStok)
        Controls.Add(txtCari)
        Controls.Add(txtPenulis)
        Controls.Add(txtTahun)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(cboUrut)
        Controls.Add(cboFilterKategori)
        Controls.Add(cboKategori)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(lblUrutan)
        Controls.Add(lblFilter)
        Controls.Add(lblCari)
        Controls.Add(lblStok)
        Controls.Add(lblTahun)
        Controls.Add(lblKategori)
        Controls.Add(lblPenulis)
        Controls.Add(lblJudul)
        Controls.Add(lblKode)
        Controls.Add(lblJudulForm)
        Name = "frmInventaris"
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPenulis As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents lblFilter As Label
    Friend WithEvents lblUrutan As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents cboUrut As ComboBox
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents errBuku As ErrorProvider
    Friend WithEvents bsBuku As BindingSource

End Class
