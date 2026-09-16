<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormArray
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
        txtLebar = New TextBox()
        txtPanjang = New TextBox()
        lblPanjang = New Label()
        lblLebar = New Label()
        LstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(308, 251)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(112, 34)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(285, 190)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(180, 31)
        txtLebar.TabIndex = 1
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(285, 76)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(180, 31)
        txtPanjang.TabIndex = 2
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(285, 36)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(74, 25)
        lblPanjang.TabIndex = 3
        lblPanjang.Text = "Panjang"
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(285, 138)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(55, 25)
        lblLebar.TabIndex = 4
        lblLebar.Text = "Lebar"
        ' 
        ' LstNilai
        ' 
        LstNilai.FormattingEnabled = True
        LstNilai.Location = New Point(285, 309)
        LstNilai.Name = "LstNilai"
        LstNilai.Size = New Size(180, 129)
        LstNilai.TabIndex = 5
        ' 
        ' FormArray
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LstNilai)
        Controls.Add(lblLebar)
        Controls.Add(lblPanjang)
        Controls.Add(txtPanjang)
        Controls.Add(txtLebar)
        Controls.Add(btnTampil)
        Name = "FormArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents lblPanjang As Label
    Friend WithEvents lblLebar As Label
    Friend WithEvents LstNilai As ListBox

End Class
