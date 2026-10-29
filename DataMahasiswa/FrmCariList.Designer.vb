<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariList
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
        bsMahasiswa = New BindingSource(components)
        lblJudul = New Label()
        lblCari = New Label()
        txtCari = New TextBox()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(27, 23)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(337, 31)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Mencari di List(Of Mahasiswa)"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(36, 76)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(113, 20)
        lblCari.TabIndex = 1
        lblCari.Text = "Cari nama/NIM:"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(164, 73)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(520, 27)
        txtCari.TabIndex = 2
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(27, 106)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.Size = New Size(657, 306)
        dgvMahasiswa.TabIndex = 3
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(27, 428)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(145, 20)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Menampilkan 0 data" & vbTab
        ' 
        ' FrmCariList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 471)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmCariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pencarian dengan Perulangan"
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bsMahasiswa As BindingSource
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
End Class
