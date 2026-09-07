Public Class Form2

    ' ATURAN INPUT: Hanya boleh angka & Backspace
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' EVENT KLIK TOMBOL HITUNG
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double

        If Double.TryParse(txtPendapatan.Text, pendapatan) Then
            Dim persentasePajak As Double = 0

            ' Logika Persentase Pajak
            If pendapatan > 100000000 Then
                persentasePajak = 0.3 ' 30%
            ElseIf pendapatan > 30000000 Then
                persentasePajak = 0.2 ' 20%
            ElseIf pendapatan > 5000000 Then
                persentasePajak = 0.1 ' 10%
            Else
                persentasePajak = 0 ' <= 5 juta pajak Rp 0
            End If

            ' Menhitung nominal pajak
            Dim nominalPajak As Double = pendapatan * persentasePajak

            ' Teks Pop-Up Persis Seperti Foto Proyeksi
            Dim pesan As String = "Pajak yang perlu dibayarkan: Rp " & nominalPajak.ToString("N0")

            ' Menampilkan Pop-Up
            MessageBox.Show(pesan, "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Masukkan nominal pendapatan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class