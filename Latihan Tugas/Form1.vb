Public Class Form1

    ' 1. KODE SAAT FORM PERTAMA KALI DIBUKA (DEFAULT PILIHAN)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.SelectedIndex = 0
    End Sub

    ' 2. KODE GANTI GAMBAR PROFIL SAAT COMBOBOX DIGANTI
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        Dim pathFolderAssets As String = Application.StartupPath & "\assets\"

        If cbRole.SelectedItem IsNot Nothing Then
            Dim rolePilihan As String = cbRole.SelectedItem.ToString()

            If rolePilihan = "Manager" Then
                PicProfile.Image = Image.FromFile(pathFolderAssets & "managercewe.png")
            ElseIf rolePilihan = "Staff" Then
                PicProfile.Image = Image.FromFile(pathFolderAssets & "staffcewe.png")
            End If
        End If
    End Sub

    ' 3. ATURAN INPUT NAMA: HANYA HURUF & SPASI
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' 4. ATURAN INPUT NIM: HANYA ANGKA & BACKSPACE
    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' 5. KODE TOMBOL LOGIN (DENGAN NAMA & NIM KAMU SENDIRI)
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim namaInput As String = txtNama.Text.Trim().ToLower()
        Dim nimInput As String = txtNIM.Text.Trim()

        ' Sesuikan Nama dan NIM yang kamu inginkan di bawah ini:
        Dim namaValid As String = "adeptri" ' Masukkan nama kamu (huruf kecil)
        Dim nimValid As String = "241712024"  ' Masukkan NIM kamu

        If namaInput = namaValid AndAlso nimInput = nimValid Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Masukkan Akun dengan Benar", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class