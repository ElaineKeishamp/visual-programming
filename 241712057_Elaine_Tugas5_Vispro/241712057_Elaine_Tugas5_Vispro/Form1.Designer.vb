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
        lblLaundry = New Label()
        lblBerat = New Label()
        txtBerat = New TextBox()
        chkMember = New CheckBox()
        btnHitung = New Button()
        lblRincian = New Label()
        lblSubtotal = New Label()
        lblDiskon = New Label()
        lblTotal = New Label()
        Label1 = New Label()
        Label2 = New Label()
        btnSelesai = New Button()
        SuspendLayout()
        ' 
        ' lblLaundry
        ' 
        lblLaundry.AutoSize = True
        lblLaundry.BorderStyle = BorderStyle.Fixed3D
        lblLaundry.Font = New Font("MS Reference Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLaundry.Location = New Point(124, 41)
        lblLaundry.Name = "lblLaundry"
        lblLaundry.Size = New Size(374, 42)
        lblLaundry.TabIndex = 0
        lblLaundry.Text = "Laundry Eren Yeager"
        ' 
        ' lblBerat
        ' 
        lblBerat.AutoSize = True
        lblBerat.Location = New Point(124, 112)
        lblBerat.Name = "lblBerat"
        lblBerat.Size = New Size(154, 25)
        lblBerat.TabIndex = 1
        lblBerat.Text = "Berat Cucian (Kg) :"
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(311, 112)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(185, 31)
        txtBerat.TabIndex = 3
        ' 
        ' chkMember
        ' 
        chkMember.AutoSize = True
        chkMember.Location = New Point(124, 171)
        chkMember.Name = "chkMember"
        chkMember.Size = New Size(192, 29)
        chkMember.TabIndex = 4
        chkMember.Text = "Pelanggan Member"
        chkMember.UseVisualStyleBackColor = True
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("MS Reference Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(183, 240)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(225, 34)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Hitung Total"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' lblRincian
        ' 
        lblRincian.AutoSize = True
        lblRincian.Location = New Point(124, 309)
        lblRincian.Name = "lblRincian"
        lblRincian.Size = New Size(121, 25)
        lblRincian.TabIndex = 6
        lblRincian.Text = "Rincian Harga"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(124, 358)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(88, 25)
        lblSubtotal.TabIndex = 7
        lblSubtotal.Text = "Subtotal :"
        ' 
        ' lblDiskon
        ' 
        lblDiskon.AutoSize = True
        lblDiskon.Location = New Point(124, 410)
        lblDiskon.Name = "lblDiskon"
        lblDiskon.Size = New Size(76, 25)
        lblDiskon.TabIndex = 8
        lblDiskon.Text = "Diskon :"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(124, 458)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(106, 25)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Total Bayar :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(124, 407)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 25)
        Label1.TabIndex = 8
        Label1.Text = "Diskon :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(124, 456)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 9
        Label2.Text = "Total Bayar :"
        ' 
        ' btnSelesai
        ' 
        btnSelesai.Location = New Point(239, 513)
        btnSelesai.Name = "btnSelesai"
        btnSelesai.Size = New Size(112, 34)
        btnSelesai.TabIndex = 10
        btnSelesai.Text = "Selesai"
        btnSelesai.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(643, 582)
        Controls.Add(btnSelesai)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTotal)
        Controls.Add(lblDiskon)
        Controls.Add(lblSubtotal)
        Controls.Add(lblRincian)
        Controls.Add(btnHitung)
        Controls.Add(chkMember)
        Controls.Add(txtBerat)
        Controls.Add(lblBerat)
        Controls.Add(lblLaundry)
        MinimizeBox = False
        Name = "Form1"
        Text = "Yeager Laundry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLaundry As Label
    Friend WithEvents lblBerat As Label
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents chkMember As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblRincian As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiskon As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelesai As Button

End Class
