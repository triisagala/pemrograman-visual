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
        Label1 = New Label()
        txtNilaiAwal = New TextBox()
        Label2 = New Label()
        txtNilaiAkhir = New TextBox()
        btnInput = New Button()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nilai Awal :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(171, 89)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(125, 27)
        txtNilaiAwal.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(192, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nilai Akhir :"
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(171, 192)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(125, 27)
        txtNilaiAkhir.TabIndex = 3
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(181, 239)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(94, 29)
        btnInput.TabIndex = 4
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(159, 290)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(150, 104)
        lstHasil.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnInput)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(Label2)
        Controls.Add(txtNilaiAwal)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Perulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstHasil As ListBox

End Class
