Public Class Form2
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double
        If Double.TryParse(txtPendapatan.Text, pendapatan) Then
            Dim persen As Double = 0
            If pendapatan > 100000000 Then
                persen = 0.3
            ElseIf pendapatan > 30000000 Then
                persen = 0.2
            ElseIf pendapatan > 5000000 Then
                persen = 0.1
            End If

            Dim total As Double = pendapatan * persen
            MessageBox.Show("Pajak yang perlu dibayarkan: Rp " & total.ToString("N0"), "Hasil Perhitungan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Masukkan nominal pendapatan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class