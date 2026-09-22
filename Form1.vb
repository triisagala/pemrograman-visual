Public Class Form1
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        dgvForm1.AutoGenerateColumns = True
        dgvForm1.DataSource = ModQuery.TampilkanData()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
        txtNIM.Text,
        txtNama.Text,
        txtJurusan.Text
        ) Then
            MessageBox.Show("Data berhasil disimpan")
        End If
        txtJurusan.Clear()
        txtNama.Clear()
        txtNIM.Clear()
    End Sub


End Class
