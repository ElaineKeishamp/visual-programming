<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPinjam
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
        lblKategori = New Label()
        lblNama = New Label()
        lblLama = New Label()
        txtKodeBuku = New TextBox()
        txtJudulBuku = New TextBox()
        txtNamaPeminjam = New TextBox()
        txtLamaPinjam = New TextBox()
        cboKategori = New ComboBox()
        lstPeminjaman = New ListBox()
        lblStatus = New Label()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(378, 9)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(256, 38)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(44, 68)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(97, 25)
        lblKode.TabIndex = 1
        lblKode.Text = "Kode Buku"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(44, 161)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(97, 25)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(44, 249)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(78, 25)
        lblKategori.TabIndex = 3
        lblKategori.Text = "Kategori"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(44, 345)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(141, 25)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama Peminjam"
        ' 
        ' lblLama
        ' 
        lblLama.AutoSize = True
        lblLama.Location = New Point(44, 434)
        lblLama.Name = "lblLama"
        lblLama.Size = New Size(156, 25)
        lblLama.TabIndex = 5
        lblLama.Text = "Lama Pinjam (hari)"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(44, 105)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(261, 31)
        txtKodeBuku.TabIndex = 6
        ' 
        ' txtJudulBuku
        ' 
        txtJudulBuku.Location = New Point(44, 199)
        txtJudulBuku.Name = "txtJudulBuku"
        txtJudulBuku.Size = New Size(261, 31)
        txtJudulBuku.TabIndex = 7
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(44, 386)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(261, 31)
        txtNamaPeminjam.TabIndex = 9
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(44, 475)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(261, 31)
        txtLamaPinjam.TabIndex = 10
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(44, 288)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(261, 33)
        cboKategori.TabIndex = 11
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.HorizontalScrollbar = True
        lstPeminjaman.Location = New Point(342, 105)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(588, 404)
        lstPeminjaman.TabIndex = 12
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(35, 537)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(281, 25)
        lblStatus.TabIndex = 13
        lblStatus.Text = "Periksa isian yang bertanda merah"
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(369, 532)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(112, 34)
        btnPinjam.TabIndex = 14
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(571, 532)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 15
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(756, 532)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(143, 34)
        btnEkspor.TabIndex = 16
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' frmPinjam
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(975, 596)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(lblStatus)
        Controls.Add(lstPeminjaman)
        Controls.Add(cboKategori)
        Controls.Add(txtLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(txtJudulBuku)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblLama)
        Controls.Add(lblNama)
        Controls.Add(lblKategori)
        Controls.Add(lblJudul)
        Controls.Add(lblKode)
        Controls.Add(lblJudulForm)
        Name = "frmPinjam"
        Text = "Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblLama As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents errPinjam As ErrorProvider

End Class
