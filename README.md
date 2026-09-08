**Nama** : Adeptri Sagala  
**NIM** : 241712024  
**Praktikum** : Pemrograman Visual  
**Catatan Ke** : 1  

# Catatan Pertemuan 1: Visual Programming

## Pengertian Pemrograman Visual
* Pemrograman Visual (*Visual Programming*) adalah metode pembuatan program atau perangkat lunak.
* Penggunanya membangun logika dan antarmuka aplikasi dengan memanipulasi elemen grafis (seperti blok, ikon, dan diagram).
* Proses ini dilakukan secara visual, alih-alih mengetikkan baris teks kode (sintaks) secara manual.
* Metode ini umumnya memanfaatkan sistem *drag-and-drop* sehingga proses perancangan menjadi lebih interaktif dan mudah dipahami.

## Tujuan dan Manfaat Visual Programming
* Mempermudah pemahaman konsep dasar pemrograman
* Menyajikan alur program secara visual dan terstruktur
* Mempersiapkan pengguna sebelum mempelajari sintaks kode
* Meminimalkan kesalahan dalam penulisan kode

## Karakteristik Visual Programming
* Logika program direpresentasikan melalui blok, diagram, atau elemen grafis yang saling terhubung sesuai dengan alur program.
* Komponen program maupun antarmuka dapat disusun melalui mekanisme drag-and-drop, sehingga proses perancangan menjadi lebih intuitif.
* Perubahan pada rancangan atau struktur program dapat diamati secara langsung, sehingga memudahkan proses evaluasi dan pengembangan.

## Keterbatasan Visual Programming
* Fleksibilitas Terbatas
* Kurang Efisien untuk Proyek Besar
* Ketergantungan pada Platform

## Platform Visual Programming
Beberapa contoh platform yang digunakan meliputi:
* Scrath
* MIT App Inventor
* Visual Basic
* JavaFX



**Nama** : Adeptri Sagala  
**NIM** : 241712024  
**Praktikum** : Pemrograman Visual  
**Catatan Ke** : 2  

---

# Catatan Pertemuan 2: Komponen Visual 

## Komponen Visual yang Digunakan
Pada pertemuan ini, kita belajar merancang antarmuka (UI) menggunakan beberapa komponen dasar:
* **Label**: Komponen untuk menampilkan teks statis di layar (seperti `lblNama` dan `lblNIM`).
* **TextBox**: Komponen berupa kotak isian tempat pengguna mengetikkan data teks (`txtNama`, `txtNIM`, dan `txtKOM`).
* **Button**: Komponen berupa tombol interaktif yang bisa diklik. Terdapat tiga tombol utama pada aplikasi ini: `btnTampilkan`, `btnHapus`, dan `btnKeluar`.

## Logika Program (Event Handler)
Aplikasi ini menggunakan *Event Click*, yang akan mengeksekusi perintah tertentu ketika komponen diklik oleh pengguna:
* **Tombol Tampilkan (`btnTampilkan`)**: Saat diklik, program mengambil data teks dari TextBox dan menampilkannya dalam bentuk *MessageBox* (kotak dialog pop-up) berisi pesan sapaan beserta data Nama, NIM, dan KOM yang telah diinput.
* **Tombol Hapus (`btnHapus`)**: Kerangka kode (*event handler*) telah disiapkan untuk instruksi mengosongkan kotak isian.
* **Tombol Keluar (`btnKeluar`)**: Kerangka kode telah disiapkan untuk instruksi menutup aplikasi.

## Sintaks Khusus Visual Basic
* **Simbol Amandemen (`&`)**: Berfungsi untuk menggabungkan teks statis (seperti "Nama : ") dengan teks dinamis yang diambil dari dalam TextBox.
* **Fungsi `vbCrLf`**: Singkatan dari *Visual Basic Carriage Return Line Feed*, berfungsi untuk membuat baris baru (*Enter*) agar tampilan teks di dalam *MessageBox* tersusun rapi memanjang ke bawah.

## Tentang Visual Basic
* Visual Basic merupakan bahasa pemrograman yang dikembangkan oleh Microsoft.
* Bahasa ini menyediakan lingkungan pengembangan terintegrasi (IDE).
* Fungsi utamanya adalah untuk membangun aplikasi menggunakan pendekatan visual.



**Nama** : Adeptri Sagala  
**NIM** : 241712024  
**Praktikum** : Pemrograman Visual  
**Catatan Ke** : 3  

---

# Catatan Pertemuan 3: Operator dan Struktur Kendali

## Komponen Visual yang Digunakan
Pada proyek Pertemuan 3 ini, antarmuka (UI) dirancang menggunakan beberapa komponen berikut:
* **PictureBox (`picImage`)**: Komponen untuk menampilkan gambar secara dinamis (mengambil gambar dari folder `Assets`). Properti `SizeMode` diubah menjadi `Zoom` agar gambar menyesuaikan ukuran kotak secara proporsional.
* **TextBox (`txtNilai`)**: Kotak isian tempat pengguna mengetikkan angka nilai (0-100) yang akan diproses oleh logika program.
* **Button (`btnInput`)**: Tombol interaktif yang memicu proses validasi dan pergantian gambar berdasarkan rentang nilai saat diklik.

## Logika Program (Event Handler)
Aplikasi ini memanfaatkan dua *event* utama untuk menjalankan validasi berlapis dan penentuan kondisi:
* **Validasi Saat Mengetik (`txtNilai_KeyPress`)**: Program mendeteksi ketikan *keyboard* secara langsung. Jika karakter yang diketik bukan tombol kontrol/Backspace (`Not Char.IsControl`) dan bukan angka (`Not Char.IsDigit`), maka program membatalkan karakter tersebut. Ini mencegah pengguna memasukkan huruf atau simbol.
* **Pemrosesan Tombol Input (`btnInput_Click`)**:
  1. **Cek Validitas Angka**: Program mencoba mengonversi teks ke `Integer`. Jika gagal (misalnya kotak kosong), muncul pesan *"Masukkan dalam bentuk angka"* dan proses dihentikan.
  2. **Cek Rentang Nilai (0 - 100)**: Menggunakan operator logika `OrElse`. Jika nilai di bawah 0 atau di atas 100, muncul pesan *"Masukkan nilai 0-100"* dan proses dihentikan.
  3. **Seleksi Kondisi (If-ElseIf-Else)**:
     * Jika Nilai `<= 50`, program menampilkan gambar `Assets\1.png`.
     * Jika Nilai `<= 70`, program menampilkan gambar `Assets\2.png`.
     * Jika seleksi kondisi lainnya (Nilai `> 70`), program menampilkan gambar `Assets\3.png`.

## Sintaks Khusus Visual Basic
* **`Integer.TryParse()`**: Fungsi aman untuk mengecek dan mengubah teks (`String`) menjadi angka (`Integer`). Tidak akan membuat program *crash* jika konversi gagal, melainkan hanya akan memberikan hasil *False*.
* **`Focus()` (contoh: `txtNilai.Focus()`)**: Perintah untuk memindahkan kedipan kursor otomatis kembali ke TextBox. Sangat berguna agar pengguna bisa langsung memperbaiki ketikan salah tanpa harus mengeklik kotak menggunakan *mouse*.
* **`Return`**: Berfungsi untuk memaksa keluar dari blok *Sub* seketika. Jika validasi gagal, baris kode di bawah `Return` (seperti memunculkan gambar) tidak akan dieksekusi.
* **`e.Handled = True`**: Digunakan di *event KeyPress* untuk menginstruksikan sistem agar "mengabaikan" atau menolak karakter yang baru saja diketik pengguna.
* **`Image.FromFile()`**: Fungsi untuk memuat file gambar dari penyimpanan (seperti direktori `Assets`) agar bisa ditampilkan ke dalam komponen PictureBox.


## 1. Konsep Utama & Prinsip Antarmuka (UI)

* **Tata Letak Fleksibel**: Properti `Location` (posisi X, Y) dan `Size` (ukuran) pada elemen UI bersifat fleksibel dan dapat disesuaikan secara bebas menggunakan *drag-and-drop* di Visual Studio.
* **Independensi Kode**: Properti posisi dan ukuran visual sama sekali tidak memengaruhi logika kode program.
* **Identifikasi Komponen**: Kode program berpatokan pada nama komponen (properti `(Name)`) dan *event handler* yang terhubung (`Handles ...`).
* **Fitur Penataan Otomatis**:
  * Gunakan menu **Format** $\rightarrow$ **Align** $\rightarrow$ **Centers / Middles** untuk meratakan posisi antar elemen.
  * Manfaatkan garis pandu magenta (*Snaplines*) saat menggeser objek untuk presisi tata letak.

---

## 2. Manajemen Folder Asset & File Gambar

### Langkah Pembuatan Folder Assets:
1. Pada panel **Solution Explorer**, klik kanan pada nama Project (`Latihan Tugas`) $\rightarrow$ **Add** $\rightarrow$ **New Folder**.
2. Beri nama folder tersebut: `assets`
3. Salin dua file gambar berikut ke dalam folder `assets`:
   * `managercewe.png`
   * `staffcewe.png`

### Pengaturan Wajib File Gambar:
1. Klik file `managercewe.png` di dalam folder `assets` pada Solution Explorer.
2. Pada panel **Properties** (kanan bawah), cari properti **`Copy to Output Directory`**.
3. Ubah nilainya menjadi **`Copy if newer`** (atau `Copy always`).
4. Lakukan langkah yang sama untuk file `staffcewe.png`.

> **Fungsi**: Agar saat proyek dijalankan (`F5`), Visual Studio otomatis menyalin folder `assets` beserta seluruh gambarnya ke folder eksekusi program (`\bin\Debug\assets\`).

## 3. Spesifikasi Komponen & Properti UI

### Form 1 (Login)
* **`Form1`**: `Text = Login`, `StartPosition = CenterScreen`, `Size = 300, 350`

| Komponen | Properti `(Name)` | Properti Teks / Aturan Khusus |
| :--- | :--- | :--- |
| PictureBox | **`PicProfile`** | `SizeMode = StretchImage` |
| Label 1 | *(Default)* | `Text = Role :` |
| ComboBox | **`cbRole`** | `Items = Manager, Staff` |
| Label 2 | *(Default)* | `Text = Nama :` |
| TextBox 1 | **`txtNama`** | KeyPress: Menolak input angka |
| Label 3 | *(Default)* | `Text = NIM :` |
| TextBox 2 | **`txtNIM`** | KeyPress: Hanya menerima angka & backspace |
| Button | **`btnLogin`** | `Text = Login` |


### Form 2 (Kalkulator Pajak)
* **`Form2`**: `Text = Pajak`, `StartPosition = CenterScreen`, `MaximizeBox = False`, `Size = 380, 450`

| Komponen | Properti `(Name)` | Properti Teks / Aturan Khusus |
| :--- | :--- | :--- |
| Label 1 | *(Default)* | `Text = Pendapatan lebih dari 5 juta , 10% Pajak` |
| Label 2 | *(Default)* | `Text = Pendapatan lebih dari 30 juta , 20% Pajak` |
| Label 3 | *(Default)* | `Text = Pendapatan lebih dari 100 juta , 30% Pajak` |
| Label 4 | *(Default)* | `Text = Masukkan Pendapatan` |
| Label 5 | *(Default)* | `Text = Rp.` |
| TextBox | **`txtPendapatan`** | KeyPress: Hanya menerima angka & backspace |
| Button | **`btnHitung`** | `Text = Hitung` |


## 4. Source Code Lengkap

### Full Source Code: Form1.vb

    ' Public Class Form1

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

Full Source Code: Form2.vb  

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


End Class
5. Troubleshooting & Solusi Error Umum
Error BC30678 / BC30460 ('End' statement not valid / End Class expected):

Penyebab: Perintah End Class di baris paling bawah terhapus, terpotong, atau salah ketik (SubEnd Class).

Solusi: Pastikan seluruh file VB diakhiri dengan klausa End Class yang berdiri sendiri di baris paling akhir.

Gambar Profil Tidak Ditemukan / Error Path:

Penyebab: Properti gambar di folder assets belum diubah ke Copy if newer.

Solusi: Ubah properti gambar pada Solution Explorer agar gambar terduplikasi ke direktori build bin\Debug\assets\.


**Nama** : Adeptri Sagala<br>
**NIM** : 241712024<br>
**Praktikum** : Pemrograman Visual<br>
**Catatan Ke** : 4

---

# Catatan Pertemuan 4: Struktur Perulangan (Looping)

## Komponen Visual yang Digunakan
Pada antarmuka proyek Perulangan ini, terdapat penambahan komponen baru untuk menampilkan sekumpulan data, yaitu:
* **Label**: Digunakan untuk menampilkan teks petunjuk statis "Nilai Awal :" dan "Nilai Akhir :".
* **TextBox (`txtNilaiAwal` & `txtNilaiAkhir`)**: Dua buah kotak isian tempat pengguna memasukkan batas awal angka dan batas akhir angka perulangan.
* **Button (`btnInput`)**: Tombol interaktif untuk memicu berjalannya logika perulangan ketika diklik.
* **ListBox (`lstHasil`)**: Komponen berupa kotak daftar yang berfungsi untuk menampilkan rentetan hasil angka dari proses perulangan yang dieksekusi secara menurun ke bawah.

## Logika Program (Event Handler)
Program ini mengombinasikan logika validasi input dengan struktur perulangan:
* **Validasi Saat Mengetik (`KeyPress`)**: Diterapkan pada kedua TextBox. Program mendeteksi ketikan *keyboard* dan akan menolak input jika karakter yang dimasukkan bukan angka atau tombol kontrol (seperti Backspace).
* **Pemrosesan Tombol Input (`btnInput_Click`)**:
  1. **Cek Validitas Tipe Data**: Program mengonversi teks dari kedua TextBox menjadi `Integer` menggunakan fungsi TryParse. Jika gagal atau kosong, muncul pesan *"Masukkan dalam bentuk angka"* dan proses dihentikan.
  2. **Pembersihan Data Lama**: Program akan mengosongkan isi ListBox terlebih dahulu agar hasil perulangan yang baru tidak menumpuk menyatu dengan hasil perulangan sebelumnya.
  3. **Eksekusi Perulangan (`For...Next`)**: Program menjalankan instruksi perulangan yang dimulai dari angka yang diinput pada `nilaiAwal` hingga batas `nilaiAkhir`.

## Sintaks Khusus Visual Basic
* **`lstHasil.Items.Clear()`**: Perintah spesifik pada komponen ListBox yang berfungsi untuk menghapus seluruh baris data (item) yang ada di dalam daftar tersebut.
* **`For ... To ... Next`**: Struktur kendali dasar perulangan di Visual Basic. Digunakan ketika jumlah putaran (iterasi) sudah diketahui secara pasti berdasarkan nilai awalan dan nilai akhiran. Variabel `i` pada `For i As Integer` bertindak sebagai penghitung (*counter*) putaran.

Tombol Login / Hitung Tidak Merespons:

Penyebab: Nama properti (Name) pada desainer tidak cocok dengan penamaan variabel di baris Handles ....

Solusi: Samakan properti (Name) komponen (misalnya: btnLogin, btnHitung, txtPendapatan).
