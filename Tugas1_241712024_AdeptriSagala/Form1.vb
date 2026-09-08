Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.SelectedIndex = 0
        Dim p As New Drawing2D.GraphicsPath()
        p.AddEllipse(0, 0, PicProfile.Width, PicProfile.Height)
        PicProfile.Region = New Region(p)
    End Sub
    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        Dim path As String = Application.StartupPath & "\assets\"
        If cbRole.SelectedItem IsNot Nothing Then
            If cbRole.SelectedItem.ToString() = "Manager" Then
                PicProfile.Image = Image.FromFile(path & "managercewe.png")
            Else
                PicProfile.Image = Image.FromFile(path & "staffcewe.png")
            End If
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub
    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim r As String = cbRole.SelectedItem.ToString(), n As String = LCase(txtNama.Text.Trim()), id As String = txtNIM.Text.Trim()
        Dim lR() As String = {"Staff", "Manager"}, lN() As String = {"nadya", "shata diyaul haq"}, lI() As String = {"241712051", "241712061"}
        Dim pass As Boolean = False
        For i As Integer = 0 To lN.Length - 1
            If r = lR(i) AndAlso n = lN(i) AndAlso id = lI(i) Then pass = True : Exit For
        Next
        If pass Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Masukkan Akun dengan Benar", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class