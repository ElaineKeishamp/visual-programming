<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnTampil = New Button()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtJurusan = New TextBox()
        btnTambah = New Button()
        dgvMahasiswa = New DataGridView()
        lblNama = New Label()
        lblNim = New Label()
        lblJurusan = New Label()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(195, 323)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(112, 34)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(735, 64)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(219, 31)
        txtNama.TabIndex = 1
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(735, 163)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(219, 31)
        txtNim.TabIndex = 2
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(735, 258)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(219, 31)
        txtJurusan.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(799, 313)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(70, 64)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 62
        dgvMahasiswa.Size = New Size(360, 225)
        dgvMahasiswa.TabIndex = 5
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(564, 64)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(564, 169)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(46, 25)
        lblNim.TabIndex = 7
        lblNim.Text = "NIM"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(564, 264)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(71, 25)
        lblJurusan.TabIndex = 8
        lblJurusan.Text = "Jurusan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1048, 450)
        Controls.Add(lblJurusan)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
        Controls.Add(txtJurusan)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(btnTampil)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblJurusan As Label

End Class
