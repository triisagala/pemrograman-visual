<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariArray
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
        btnTampilkan = New Button()
        btnKosongkan = New Button()
        lblJudul = New Label()
        lblJumlah = New Label()
        dgvMahasiswa = New DataGridView()
        colNim = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJurusan = New DataGridViewTextBoxColumn()
        colAngkatan = New DataGridViewTextBoxColumn()
        colIpk = New DataGridViewTextBoxColumn()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(46, 368)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(94, 36)
        btnTampilkan.TabIndex = 0
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnKosongkan
        ' 
        btnKosongkan.Location = New Point(177, 367)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(94, 37)
        btnKosongkan.TabIndex = 1
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(46, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(289, 31)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Data dari Array 2 Dimensi" & vbTab
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(477, 375)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(104, 20)
        lblJumlah.TabIndex = 3
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AllowUserToOrderColumns = True
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New DataGridViewColumn() {colNim, colNama, colJurusan, colAngkatan, colIpk})
        dgvMahasiswa.Location = New Point(46, 43)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(636, 318)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' colNim
        ' 
        colNim.HeaderText = "NIM"
        colNim.MinimumWidth = 6
        colNim.Name = "colNim"
        colNim.ReadOnly = True
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 6
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colJurusan
        ' 
        colJurusan.HeaderText = "Jurusan"
        colJurusan.MinimumWidth = 6
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True
        ' 
        ' colAngkatan
        ' 
        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.MinimumWidth = 6
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True
        ' 
        ' colIpk
        ' 
        colIpk.HeaderText = "IPK"
        colIpk.MinimumWidth = 6
        colIpk.Name = "colIpk"
        colIpk.ReadOnly = True
        ' 
        ' FrmDariArray
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 416)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJumlah)
        Controls.Add(lblJudul)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents colNim As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As DataGridViewTextBoxColumn
    Friend WithEvents colIpk As DataGridViewTextBoxColumn
End Class
