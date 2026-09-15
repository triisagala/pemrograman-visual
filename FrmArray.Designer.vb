<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        btnTampil = New Button()
        txtLebar = New TextBox()
        txtPanjang = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(174, 281)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(94, 29)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(160, 234)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(125, 27)
        txtLebar.TabIndex = 1
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(160, 108)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(125, 27)
        txtPanjang.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(190, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 3
        Label1.Text = "Panjang :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(198, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 4
        Label2.Text = "Lebar :"
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(160, 334)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(150, 104)
        lstNilai.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(481, 450)
        Controls.Add(lstNilai)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPanjang)
        Controls.Add(txtLebar)
        Controls.Add(btnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstNilai As ListBox

End Class
