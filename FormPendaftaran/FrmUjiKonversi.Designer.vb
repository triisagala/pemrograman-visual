<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUjiKonversi
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
        lblJudul = New Label()
        lblPetunjuk = New Label()
        lblInput = New Label()
        txtInput = New TextBox()
        btnCInt = New Button()
        btnVal = New Button()
        btnTryParse = New Button()
        btnTryCatch = New Button()
        btnCatchBertingkat = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(27, 22)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(208, 31)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Uji Konversi Input"
        ' 
        ' lblPetunjuk
        ' 
        lblPetunjuk.Location = New Point(27, 75)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New Size(337, 43)
        lblPetunjuk.TabIndex = 1
        lblPetunjuk.Text = "Ketik sebuah nilai lalu coba setiap tombol. " & vbCrLf & "Coba: 25, abc, 12abc, 3,5, 99999999999, atau kosong."
        ' 
        ' lblInput
        ' 
        lblInput.AutoSize = True
        lblInput.Location = New Point(27, 149)
        lblInput.Name = "lblInput"
        lblInput.Size = New Size(46, 20)
        lblInput.TabIndex = 2
        lblInput.Text = "Input:"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(96, 149)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(520, 27)
        txtInput.TabIndex = 3
        ' 
        ' btnCInt
        ' 
        btnCInt.Location = New Point(27, 198)
        btnCInt.Name = "btnCInt"
        btnCInt.Size = New Size(120, 32)
        btnCInt.TabIndex = 4
        btnCInt.Text = "CInt (tanpa Try)"
        btnCInt.UseVisualStyleBackColor = True
        ' 
        ' btnVal
        ' 
        btnVal.Location = New Point(166, 197)
        btnVal.Name = "btnVal"
        btnVal.Size = New Size(58, 32)
        btnVal.TabIndex = 5
        btnVal.Text = "Val"
        btnVal.UseVisualStyleBackColor = True
        ' 
        ' btnTryParse
        ' 
        btnTryParse.Location = New Point(249, 198)
        btnTryParse.Name = "btnTryParse"
        btnTryParse.Size = New Size(87, 34)
        btnTryParse.TabIndex = 6
        btnTryParse.Text = "TryParse"
        btnTryParse.UseVisualStyleBackColor = True
        ' 
        ' btnTryCatch
        ' 
        btnTryCatch.Location = New Point(358, 197)
        btnTryCatch.Name = "btnTryCatch"
        btnTryCatch.Size = New Size(108, 34)
        btnTryCatch.TabIndex = 7
        btnTryCatch.Text = "Try...Catch"
        btnTryCatch.UseVisualStyleBackColor = True
        ' 
        ' btnCatchBertingkat
        ' 
        btnCatchBertingkat.Location = New Point(477, 197)
        btnCatchBertingkat.Name = "btnCatchBertingkat"
        btnCatchBertingkat.Size = New Size(139, 36)
        btnCatchBertingkat.TabIndex = 8
        btnCatchBertingkat.Text = "Catch Bertingkat"
        btnCatchBertingkat.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.BorderStyle = BorderStyle.FixedSingle
        lblHasil.Location = New Point(27, 252)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(589, 79)
        lblHasil.TabIndex = 9
        lblHasil.Text = "Hasil akan tampil di sini."
        ' 
        ' FrmUjiKonversi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 340)
        Controls.Add(lblHasil)
        Controls.Add(btnCatchBertingkat)
        Controls.Add(btnTryCatch)
        Controls.Add(btnTryParse)
        Controls.Add(btnVal)
        Controls.Add(btnCInt)
        Controls.Add(txtInput)
        Controls.Add(lblInput)
        Controls.Add(lblPetunjuk)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUjiKonversi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Uji Konversi Input"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCInt As Button
    Friend WithEvents btnVal As Button
    Friend WithEvents btnTryParse As Button
    Friend WithEvents btnTryCatch As Button
    Friend WithEvents btnCatchBertingkat As Button
    Friend WithEvents lblHasil As Label
End Class
