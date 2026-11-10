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
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblPenjelasan1 = New Label()
        pnlTimer = New Panel()
        lblKeterangan = New Label()
        lblSisa = New Label()
        lblTahap = New Label()
        btnMulai = New Button()
        btnUlangi = New Button()
        btnRingkas = New Button()
        chkTeratas = New CheckBox()
        lblDurasi = New Label()
        lblMenit = New Label()
        nudMenit = New NumericUpDown()
        lblDetik = New Label()
        nudDetik = New NumericUpDown()
        chkBunyi = New CheckBox()
        lblShortcut = New Label()
        lblPenjelasan3 = New Label()
        lblStatus = New Label()
        tmrHitung = New Timer(components)
        pnlTimer.SuspendLayout()
        CType(nudMenit, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDetik, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(39, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(289, 45)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Asisten Presentasi"
        ' 
        ' lblPenjelasan1
        ' 
        lblPenjelasan1.AutoSize = True
        lblPenjelasan1.Location = New Point(39, 54)
        lblPenjelasan1.Name = "lblPenjelasan1"
        lblPenjelasan1.Size = New Size(357, 25)
        lblPenjelasan1.TabIndex = 1
        lblPenjelasan1.Text = "Jaga Durasi tanpa meninggalkan slide Anda"
        ' 
        ' pnlTimer
        ' 
        pnlTimer.BackColor = Color.FromArgb(CByte(23), CByte(50), CByte(77))
        pnlTimer.Controls.Add(lblKeterangan)
        pnlTimer.Controls.Add(lblSisa)
        pnlTimer.Controls.Add(lblTahap)
        pnlTimer.Location = New Point(39, 97)
        pnlTimer.Name = "pnlTimer"
        pnlTimer.Size = New Size(640, 229)
        pnlTimer.TabIndex = 2
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.ForeColor = SystemColors.ControlLight
        lblKeterangan.Location = New Point(166, 185)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(318, 25)
        lblKeterangan.TabIndex = 2
        lblKeterangan.Text = "Atur durasi, lalu mulai ketika Anda siap"
        ' 
        ' lblSisa
        ' 
        lblSisa.AutoSize = True
        lblSisa.BackColor = Color.FromArgb(CByte(23), CByte(50), CByte(77))
        lblSisa.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSisa.ForeColor = SystemColors.ButtonHighlight
        lblSisa.Location = New Point(184, 41)
        lblSisa.Name = "lblSisa"
        lblSisa.Size = New Size(300, 128)
        lblSisa.TabIndex = 1
        lblSisa.Text = "00:00"
        ' 
        ' lblTahap
        ' 
        lblTahap.AutoSize = True
        lblTahap.ForeColor = SystemColors.ControlLight
        lblTahap.Location = New Point(266, 16)
        lblTahap.Name = "lblTahap"
        lblTahap.Size = New Size(130, 25)
        lblTahap.TabIndex = 0
        lblTahap.Text = "Siap Presentasi"
        ' 
        ' btnMulai
        ' 
        btnMulai.BackColor = Color.FromArgb(CByte(23), CByte(50), CByte(77))
        btnMulai.ForeColor = SystemColors.ControlLightLight
        btnMulai.Location = New Point(39, 353)
        btnMulai.Name = "btnMulai"
        btnMulai.Size = New Size(297, 51)
        btnMulai.TabIndex = 3
        btnMulai.Text = "Mulai Presentasi"
        btnMulai.UseVisualStyleBackColor = False
        ' 
        ' btnUlangi
        ' 
        btnUlangi.Location = New Point(520, 353)
        btnUlangi.Name = "btnUlangi"
        btnUlangi.Size = New Size(159, 43)
        btnUlangi.TabIndex = 4
        btnUlangi.Text = "Ulangi"
        btnUlangi.UseVisualStyleBackColor = True
        ' 
        ' btnRingkas
        ' 
        btnRingkas.BackColor = SystemColors.HighlightText
        btnRingkas.Location = New Point(520, 418)
        btnRingkas.Name = "btnRingkas"
        btnRingkas.Size = New Size(159, 45)
        btnRingkas.TabIndex = 5
        btnRingkas.Text = "Mode Ringkas"
        btnRingkas.UseVisualStyleBackColor = False
        ' 
        ' chkTeratas
        ' 
        chkTeratas.AutoSize = True
        chkTeratas.Location = New Point(39, 418)
        chkTeratas.Name = "chkTeratas"
        chkTeratas.Size = New Size(232, 29)
        chkTeratas.TabIndex = 6
        chkTeratas.Text = "Tetap di atas aplikasi lain"
        chkTeratas.UseVisualStyleBackColor = True
        ' 
        ' lblDurasi
        ' 
        lblDurasi.AutoSize = True
        lblDurasi.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDurasi.Location = New Point(39, 468)
        lblDurasi.Name = "lblDurasi"
        lblDurasi.Size = New Size(212, 32)
        lblDurasi.TabIndex = 7
        lblDurasi.Text = "Durasi Presentasi"
        ' 
        ' lblMenit
        ' 
        lblMenit.AutoSize = True
        lblMenit.Location = New Point(39, 515)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New Size(57, 25)
        lblMenit.TabIndex = 8
        lblMenit.Text = "Menit"
        ' 
        ' nudMenit
        ' 
        nudMenit.Location = New Point(102, 515)
        nudMenit.Name = "nudMenit"
        nudMenit.Size = New Size(98, 31)
        nudMenit.TabIndex = 9
        ' 
        ' lblDetik
        ' 
        lblDetik.AutoSize = True
        lblDetik.Location = New Point(283, 517)
        lblDetik.Name = "lblDetik"
        lblDetik.Size = New Size(53, 25)
        lblDetik.TabIndex = 10
        lblDetik.Text = "Detik"
        ' 
        ' nudDetik
        ' 
        nudDetik.Location = New Point(342, 513)
        nudDetik.Name = "nudDetik"
        nudDetik.Size = New Size(98, 31)
        nudDetik.TabIndex = 11
        ' 
        ' chkBunyi
        ' 
        chkBunyi.AutoSize = True
        chkBunyi.Location = New Point(505, 517)
        chkBunyi.Name = "chkBunyi"
        chkBunyi.Size = New Size(174, 29)
        chkBunyi.TabIndex = 12
        chkBunyi.Text = "Bunyi saat selesai"
        chkBunyi.UseVisualStyleBackColor = True
        ' 
        ' lblShortcut
        ' 
        lblShortcut.AutoSize = True
        lblShortcut.Location = New Point(39, 572)
        lblShortcut.Name = "lblShortcut"
        lblShortcut.Size = New Size(196, 25)
        lblShortcut.TabIndex = 13
        lblShortcut.Text = "Ctrl+Alt+F9: mulai/jeda"
        ' 
        ' lblPenjelasan3
        ' 
        lblPenjelasan3.AutoSize = True
        lblPenjelasan3.Location = New Point(39, 597)
        lblPenjelasan3.Name = "lblPenjelasan3"
        lblPenjelasan3.Size = New Size(368, 25)
        lblPenjelasan3.TabIndex = 14
        lblPenjelasan3.Text = "Ctrl+Alt+F10: Tombol tetap dapat digunakan"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(39, 640)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(541, 25)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Timer siap. Aktifkan Tetap di atas agar terlihat saat berganti aplikasi"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(737, 674)
        Controls.Add(lblStatus)
        Controls.Add(lblPenjelasan3)
        Controls.Add(lblShortcut)
        Controls.Add(chkBunyi)
        Controls.Add(nudDetik)
        Controls.Add(lblDetik)
        Controls.Add(nudMenit)
        Controls.Add(lblMenit)
        Controls.Add(lblDurasi)
        Controls.Add(chkTeratas)
        Controls.Add(btnRingkas)
        Controls.Add(btnUlangi)
        Controls.Add(btnMulai)
        Controls.Add(pnlTimer)
        Controls.Add(lblPenjelasan1)
        Controls.Add(lblJudul)
        Name = "Form1"
        Text = "Form1"
        pnlTimer.ResumeLayout(False)
        pnlTimer.PerformLayout()
        CType(nudMenit, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDetik, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPenjelasan1 As Label
    Friend WithEvents pnlTimer As Panel
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblSisa As Label
    Friend WithEvents lblTahap As Label
    Friend WithEvents btnMulai As Button
    Friend WithEvents btnUlangi As Button
    Friend WithEvents btnRingkas As Button
    Friend WithEvents chkTeratas As CheckBox
    Friend WithEvents lblDurasi As Label
    Friend WithEvents lblMenit As Label
    Friend WithEvents nudMenit As NumericUpDown
    Friend WithEvents lblDetik As Label
    Friend WithEvents nudDetik As NumericUpDown
    Friend WithEvents chkBunyi As CheckBox
    Friend WithEvents lblShortcut As Label
    Friend WithEvents lblPenjelasan3 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents tmrHitung As Timer

End Class
