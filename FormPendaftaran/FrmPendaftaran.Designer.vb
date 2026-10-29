<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendaftaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblNim = New Label()
        txtNim = New TextBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblJurusan = New Label()
        cboJurusan = New ComboBox()
        lblAngkatan = New Label()
        txtAngkatan = New TextBox()
        lblIpk = New Label()
        txtIpk = New TextBox()
        btnSimpan = New Button()
        btnBersihkan = New Button()
        lblDaftar = New Label()
        lstMahasiswa = New ListBox()
        btnEkspor = New Button()
        lblStatus = New Label()
        errInput = New ErrorProvider(components)
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(37, 19)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(267, 31)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(37, 84)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(37, 20)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(151, 84)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(293, 27)
        txtNim.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(37, 138)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(151, 138)
        txtNama.MaxLength = 100
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(293, 27)
        txtNama.TabIndex = 4
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(37, 192)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(57, 20)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan"
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(151, 192)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(293, 28)
        cboJurusan.TabIndex = 6
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(37, 248)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(72, 20)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(151, 248)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(293, 27)
        txtAngkatan.TabIndex = 8
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(37, 306)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(30, 20)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(151, 306)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(293, 27)
        txtIpk.TabIndex = 10
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(193, 362)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 38)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(306, 362)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(104, 38)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(490, 30)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(111, 20)
        lblDaftar.TabIndex = 13
        lblDaftar.Text = "Data tersimpan"
        ' 
        ' lstMahasiswa
        ' 
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.HorizontalScrollbar = True
        lstMahasiswa.IntegralHeight = False
        lstMahasiswa.Location = New Point(480, 66)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New Size(288, 334)
        lstMahasiswa.TabIndex = 14
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(480, 420)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(121, 29)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(37, 424)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(66, 25)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Siap."
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmPendaftaran
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(780, 470)
        Controls.Add(lblStatus)
        Controls.Add(btnEkspor)
        Controls.Add(lstMahasiswa)
        Controls.Add(lblDaftar)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
        Controls.Add(txtIpk)
        Controls.Add(lblIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(lblAngkatan)
        Controls.Add(cboJurusan)
        Controls.Add(lblJurusan)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPendaftaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pendaftaran Mahasiswa"
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblJurusan As Label
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents lblIpk As Label
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblDaftar As Label
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents errInput As ErrorProvider
End Class
