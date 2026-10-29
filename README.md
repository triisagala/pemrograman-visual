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

# 📘 Catatan Responsi Praktikum Pemrograman Visual (VB.NET WinForms)

> Ringkasan **Pertemuan 1–8** (dosen: Shata Diyaul Haq) yang disusun supaya **mudah dicari (Ctrl+F)** dan **mudah diubah** saat soal responsi mengubah kodenya.
> Bahasa: **Visual Basic .NET** · Proyek: **Windows Forms App** · IDE: **Visual Studio**

---

## 🧭 Cara Memakai Catatan Ini Saat Responsi

1. Baca soal → tentukan **topiknya** → lompat lewat [Peta Cepat](#peta-cepat) atau daftar isi.
2. Setiap pertemuan punya 3 bagian: **Konsep singkat**, **Kode siap salin**, dan tabel **"Kalau soal minta … → ubah …"**.
3. Salin kode, lalu **sesuaikan nama kontrol** (`txtNama`, `btnProses`, dst.) dengan yang ada di form soal.
4. Cek **[Checklist Sebelum Run](#checklist)** dan **[Tabel Error](#error)** kalau ada garis merah / program berhenti.

**Legenda**

| Tanda | Arti |
|---|---|
| ➕ | **Tambahan** dari saya, tidak ada di slide (umumnya standar VB.NET) |
| ⚠️ | **Beda/janggal** antara slide dan VB.NET sebenarnya — hati-hati |
| 🔑 | Inti yang paling sering keluar |

> [!IMPORTANT]
> Kode di sini **belum saya kompilasi** (tidak ada Visual Studio di lingkungan saya). Kode dari slide disalin apa adanya; bagian ➕ ditulis dari pengetahuan standar VB.NET. **Coba jalankan sekali di laptopmu sebelum responsi**, terutama bagian ➕ (Pertemuan 6 dan template tugas).

---

## 📑 Daftar Isi

- [Peta Cepat: Soal Minta Apa → Buka Mana](#peta-cepat)
- [Kerangka Dasar Form](#kerangka)
- [Pertemuan 1 – Pengantar Visual Programming](#p1)
- [Pertemuan 2 – Komponen Visual (Form, Button, Label, TextBox)](#p2)
- [Pertemuan 3 – Operator & Struktur Pengendalian](#p3)
- [Pertemuan 4 – Struktur Perulangan](#p4)
- [Pertemuan 5 – Modul, Fungsi, Array & Koleksi Data](#p5)
- [Pertemuan 6 – Database (PostgreSQL, Supabase, Npgsql)](#p6)
- [Pertemuan 7 – Validasi Input, Error Handling & Naming Convention](#p7)
- [Pertemuan 8 – DataGridView, Array & Koleksi Data](#p8)
- [Template Tugas P7: Form Peminjaman Buku](#tugas7)
- [Template Tugas P8: Inventaris Buku](#tugas8)
- [Checklist Sebelum Run](#checklist)
- [Tabel Error → Penyebab → Solusi](#error)
- [Slide yang Janggal (⚠️ Rangkuman)](#janggal)

---

<a id="peta-cepat"></a>
## 🗺️ Peta Cepat

| Soal meminta… | Pakai | Lompat ke |
|---|---|---|
| Tampilkan teks di Label saat tombol diklik | Event `Click`, `lblX.Text = ...` | [P2](#p2) |
| Sembunyikan / nonaktifkan kontrol | `.Visible`, `.Enabled` | [P2](#p2) |
| Hitung dengan `+ - * / \ Mod` | Operator aritmatika | [P3](#p3) |
| Nilai → huruf (A/B/C), lulus/tidak | `If…ElseIf` / `Select Case` / `If(a,b,c)` | [P3](#p3) |
| Cetak 1..N, kelipatan, deret, tabel perkalian, pola bintang | `For…Next` / nested loop | [P4](#p4) |
| Ulangi sampai kondisi (jumlah digit, input valid) | `Do While` / `Do…Loop While` | [P4](#p4) |
| Buat fungsi/prosedur di file terpisah | `Module`, `Sub`, `Function` | [P5](#p5) |
| Simpan banyak data satu tipe | `Array`, `List(Of T)` | [P5](#p5) |
| Data pasangan key-value / data unik | `Dictionary`, `HashSet` | [P5](#p5) |
| Koneksi ke Supabase/PostgreSQL, CRUD | `Npgsql` | [P6](#p6) |
| Validasi input, pesan error, ikon merah | `TryParse`, `ErrorProvider` | [P7](#p7) |
| Program crash → tangkap error | `Try…Catch…Finally` | [P7](#p7) |
| Penamaan kontrol (txt, btn, cbo…) | Prefix + NamaFungsi | [P7](#p7) |
| Tampilkan data dalam tabel | `DataGridView` | [P8](#p8) |
| Cari / filter data di tabel | `BindingSource.Filter` / `For Each` | [P8](#p8) |
| Tugas "Peminjaman Buku" | Template lengkap | [Template P7](#tugas7) |
| Tugas "Inventaris Buku" | Template lengkap | [Template P8](#tugas8) |

---

<a id="kerangka"></a>
## 🧱 Kerangka Dasar Form

Setiap kode di catatan ini berada di dalam `Public Class Form1` (atau nama form-mu):

```vb
' Imports selalu di PALING ATAS file, sebelum Public Class
Imports System.IO                    ' StreamWriter (ekspor file)
Imports System.Globalization         ' CultureInfo (desimal)
Imports System.Text.RegularExpressions ' Regex (format NIM/kode)

Public Class Form1

    ' Variabel/koleksi level-form (hidup selama form hidup) ditulis di sini
    Private ReadOnly daftar As New List(Of String)

    ' Event Load: jalan sekali saat form dibuka
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' Event tombol: DOUBLE-CLICK tombol di Designer akan membuatnya otomatis
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
    End Sub

End Class
```

🔑 `Handles btnProses.Click` yang menghubungkan Sub dengan tombol. Kalau nama tombol diganti **setelah** double-click, nama Sub tidak ikut berubah (tapi `Handles`-nya harus tetap benar).

---

<a id="p1"></a>
# Pertemuan 1 – Pengantar Visual Programming

## Konsep singkat

- **Visual Programming** = pendekatan pemrograman yang membangun program lewat **manipulasi elemen grafis** (blok, diagram, komponen visual) sebagai representasi **struktur dan logika** program.
- **Karakteristik**
  1. Logika dinyatakan lewat blok/diagram/elemen grafis yang saling terhubung sesuai alur.
  2. Komponen & antarmuka disusun lewat **drag-and-drop** → perancangan lebih intuitif.
  3. Perubahan rancangan **bisa diamati langsung** → evaluasi & pengembangan mudah.
- **Tujuan & manfaat**
  - Mempermudah pemahaman konsep dasar pemrograman
  - Menyajikan alur program secara visual dan terstruktur
  - Mempersiapkan pengguna sebelum belajar sintaks kode
  - Meminimalkan kesalahan penulisan kode
- **Keterbatasan**
  - Fleksibilitas terbatas
  - Kurang efisien untuk proyek besar
  - Ketergantungan pada platform

## Platform

| Platform | Jenis |
|---|---|
| **Scratch** | Berbasis blok (visual) |
| **MIT App Inventor** | Berbasis blok, untuk aplikasi Android |
| **Visual Basic** | IDE bahasa pemrograman Microsoft dengan pendekatan visual (form + kode) |
| **JavaFX** (Scene Builder) | Desain antarmuka Java secara visual |

## Istilah yang sering ditanya

| Istilah | Penjelasan |
|---|---|
| **Visual Basic** | Bahasa pemrograman dari Microsoft; menyediakan **IDE** untuk membangun aplikasi dengan pendekatan visual |
| **Visual Studio** | **IDE** (Integrated Development Environment) dari Microsoft untuk **menulis, mengedit, menjalankan, dan debugging** |
| **.NET** | Platform pengembangan & *framework* **multiplatform** dan **open-source** dari Microsoft; mendukung banyak bahasa |
| Bahasa di .NET | **C#, F#, VB.NET** |
| **IDE** | Aplikasi tempat menulis kode + desain + run + debug dalam satu tempat |

> ⚠️ Slide menulis "Scrath" — yang benar **Scratch**.

---

<a id="p2"></a>
# Pertemuan 2 – Komponen Visual

## Konsep singkat

| Komponen | Fungsi | Prefix (P7) |
|---|---|---|
| **Control** | Elemen UI untuk membangun aplikasi; memungkinkan interaksi lewat berbagai input/output | – |
| **Form** | Jendela/wadah utama tempat meletakkan komponen | `frm` |
| **Button** (Command Button) | Tombol perintah: menjalankan aksi saat diklik (OK, Cancel, Exit, Apply) | `btn` |
| **Label** | Menampilkan **teks statis** sebagai keterangan/informasi | `lbl` |
| **TextBox** | Kotak teks untuk **memasukkan atau mengedit** data | `txt` |
| **Event** | Peristiwa pada komponen yang **memicu kode berjalan** (karena interaksi pengguna / perubahan status) | – |

Toolbox: `Common Controls` berisi Button, CheckBox, ComboBox, Label, ListBox, TextBox, dll. Grup `Data` berisi DataGridView & BindingSource.

## Properti penting 🔑

| Properti | Fungsi |
|---|---|
| `Name` | Identitas unik komponen, dipakai di kode |
| `Text` | Teks yang terlihat pengguna |
| `StartPosition` (khusus Form) | Posisi awal form saat dijalankan |
| `BackColor` | Warna latar |
| `ForeColor` | Warna teks |
| `Font` | Jenis, ukuran, gaya tulisan |
| `Enabled` | Bisa digunakan user atau tidak |
| `Visible` | Ditampilkan atau disembunyikan |

> ⚠️ Slide menulis `Enable`; nama properti yang benar di kode adalah **`Enabled`**.

## Kode siap salin

**Interaksi dasar (Button → Label):**

```vb
Private Sub btnSapa_Click(sender As Object, e As EventArgs) Handles btnSapa.Click
    lblHasil.Text = "Halo, " & txtNama.Text
End Sub
```

**Mengatur properti lewat kode** ➕

```vb
Me.Text = "Aplikasi Saya"                                   ' judul form
Me.StartPosition = FormStartPosition.CenterScreen           ' form di tengah layar
Me.BackColor = Color.LightBlue
lblHasil.ForeColor = Color.Red
lblHasil.Font = New Font("Arial", 14, FontStyle.Bold)
btnSimpan.Enabled = False                                   ' tombol abu-abu
lblHasil.Visible = False                                    ' label hilang
txtNama.Clear()                                             ' kosongkan textbox
txtNama.Focus()                                             ' kursor ke textbox
```

**MessageBox** ➕

```vb
MessageBox.Show("Pesan")                                        ' paling sederhana
MessageBox.Show("Isi pesan", "Judul", MessageBoxButtons.OK, MessageBoxIcon.Information)

Dim jawab As DialogResult = MessageBox.Show("Yakin keluar?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
If jawab = DialogResult.Yes Then Me.Close()
```

**Tombol Exit** ➕

```vb
Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
    Me.Close()      ' atau Application.Exit()
End Sub
```

## Kalau soal minta … → ubah …

| Soal minta | Kode |
|---|---|
| Teks tombol berubah saat diklik | `btnX.Text = "Sudah diklik"` |
| Label disembunyikan saat tombol diklik | `lblX.Visible = False` |
| Tombol B aktif hanya setelah A diklik | Designer: `btnB.Enabled = False`; di `btnA_Click`: `btnB.Enabled = True` |
| Ganti warna label jadi merah | `lblX.ForeColor = Color.Red` |
| Textbox untuk password | Properti `PasswordChar = "*"` |
| Textbox banyak baris | `Multiline = True` |
| Textbox hanya baca | `ReadOnly = True` |
| Batasi panjang input | `MaxLength = 9` |
| Tukar isi dua textbox | `Dim t = txtA.Text : txtA.Text = txtB.Text : txtB.Text = t` |
| Event lain selain Click | `TextChanged`, `KeyPress`, `Load`, `SelectedIndexChanged`, `CheckedChanged`, `Leave`, `Validating` |

---

<a id="p3"></a>
# Pertemuan 3 – Operator dan Struktur Pengendalian

## Operator

**Operand** = nilai yang dioperasikan; **operator** = simbol operasinya.

> [!WARNING]
> ⚠️ Gambar slide memakai simbol gaya C (`%`, `==`, `!=`, `&&`, `||`, `++`). **Di VB.NET tulisannya berbeda.** Tabel di bawah adalah versi **VB.NET yang benar** untuk dipakai di kode.

### 1. Aritmatika

| Operasi | VB.NET | Contoh | Hasil |
|---|---|---|---|
| Tambah | `+` | `5 + 3` | 8 |
| Kurang | `-` | `7 - 4` | 3 |
| Kali | `*` | `6 * 2` | 12 |
| Bagi (desimal) | `/` | `10 / 4` | 2,5 |
| Bagi bulat ➕ | `\` | `10 \ 4` | 2 |
| Modulus (sisa bagi) | **`Mod`** (bukan `%`) | `10 Mod 3` | 1 |
| Pangkat ➕ | `^` | `2 ^ 3` | 8 |
| Gabung teks | `&` | `"Halo " & nama` | – |

### 2. Penugasan (assignment)

| VB.NET | Ekuivalen | Contoh |
|---|---|---|
| `=` | `a = b` | `x = 10` |
| `+=` | `a = a + b` | `x += 5` |
| `-=` | `a = a - b` | `x -= 3` |
| `*=` | `a = a * b` | `x *= 2` |
| `/=` | `a = a / b` | `x /= 4` |
| `\=` ➕ | `a = a \ b` | `x \= 4` |
| `&=` ➕ | `a = a & b` (gabung teks) | `s &= "abc"` |

> ⚠️ Slide menampilkan `%=`. **Tidak ada di VB.NET.** Tulis `x = x Mod 3`.

### 3. Perbandingan → hasil `Boolean` (True/False)

| Makna | VB.NET | Contoh |
|---|---|---|
| Sama dengan | **`=`** (bukan `==`) | `5 = 5` → True |
| Tidak sama | **`<>`** (bukan `!=`) | `5 <> 3` → True |
| Lebih besar / kecil | `>` `<` | `7 > 3` |
| Lebih besar/kecil atau sama | `>=` `<=` | `5 >= 5` |

### 4. Logika

| Operator | Hasil True jika… |
|---|---|
| `And` | **kedua** kondisi True |
| `Or` | **salah satu/kedua** True |
| `Not` | membalik nilai (True ↔ False) |
| `Xor` | **salah satu saja** True, bukan keduanya |
| NOR → `Not (A Or B)` | kedua False |
| NAND → `Not (A And B)` | kecuali kedua True |

➕ **`AndAlso` / `OrElse`** = versi *short-circuit* (kalau hasil sudah pasti, sisi kanan tidak dievaluasi). Dipakai di slide P7: `Not Integer.TryParse(...) OrElse angkatan < 2015`. **Dalam praktik, lebih aman pakai `AndAlso`/`OrElse` daripada `And`/`Or`.**

### 5. Increment / Decrement

> ⚠️ **VB.NET tidak punya `++` / `--`.** Slide menggambarkan konsepnya (pre/post-increment), tetapi di VB tulis:

```vb
x += 1     ' increment (tambah 1)
x -= 1     ' decrement (kurang 1)
```

## Ekspresi

**Ekspresi** = kombinasi nilai, variabel, operator, dan pemanggilan metode yang **menghasilkan satu nilai**. Contoh: `a + b * 2`, `nilai >= 75`, `txtNama.Text.Trim()`.

Urutan prioritas operator (tinggi → rendah): `^` → `* /` → `\` → `Mod` → `+ -` → `&` → perbandingan → `Not` → `And` → `Or`. Gunakan **tanda kurung** `( )` agar aman.

## Percabangan

| Jenis | Kapan dipakai |
|---|---|
| `If … Then` | Satu blok, hanya jika kondisi benar |
| `If … Else` | Dua pilihan (benar / salah) |
| `If … ElseIf … Else` | Banyak kondisi bertingkat |
| `Select Case` (di slide disebut *Switch*) | Memilih berdasarkan **nilai satu variabel** |
| `If(kondisi, a, b)` (di slide: *Operator Ternary*) | Percabangan singkat satu baris |

### Kode siap salin

**If / If-Else / If-ElseIf** 🔑

```vb
Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
    Dim nilai As Integer
    If Not Integer.TryParse(txtNilai.Text, nilai) Then
        MessageBox.Show("Masukkan angka!")
        Return
    End If

    Dim grade As String
    If nilai >= 85 Then
        grade = "A"
    ElseIf nilai >= 70 Then
        grade = "B"
    ElseIf nilai >= 55 Then
        grade = "C"
    ElseIf nilai >= 40 Then
        grade = "D"
    Else
        grade = "E"
    End If
    lblHasil.Text = "Grade: " & grade
End Sub
```

**Select Case** (sama dengan slide, plus versi rentang ➕)

```vb
' Dari slide: cocokkan nilai persis
Select Case nilai
    Case 1
        hasil = "Sangat Baik"
    Case 2
        hasil = "Baik"
    Case 3
        hasil = "Cukup"
    Case Else
        hasil = "Kurang"
End Select

' ➕ Rentang & banyak nilai
Select Case nilai
    Case 85 To 100
        grade = "A"
    Case 70 To 84
        grade = "B"
    Case Is >= 55          ' "Is" untuk pembanding
        grade = "C"
    Case 1, 2, 3           ' beberapa nilai sekaligus
        grade = "Khusus"
    Case Else
        grade = "E"
End Select
```

**Operator ternary** (dari slide)

```vb
Dim nilai As Integer = 75
Dim status As String
status = If(nilai >= 75, "Lulus", "Tidak Lulus")
```

**Contoh pola soal umum** ➕

```vb
' Ganjil / genap
lblHasil.Text = If(angka Mod 2 = 0, "Genap", "Ganjil")

' Bilangan terbesar dari 3 angka
Dim maks As Integer = a
If b > maks Then maks = b
If c > maks Then maks = c

' Tahun kabisat
If (tahun Mod 4 = 0 AndAlso tahun Mod 100 <> 0) OrElse tahun Mod 400 = 0 Then
    lblHasil.Text = "Kabisat"
End If

' Kalkulator sederhana (Select Case untuk operator)
Select Case cboOperator.Text
    Case "+" : hasil = a + b
    Case "-" : hasil = a - b
    Case "*" : hasil = a * b
    Case "/"
        If b = 0 Then
            MessageBox.Show("Tidak bisa dibagi nol")
            Return
        End If
        hasil = a / b
End Select
```

### Kalau soal minta … → ubah …

| Soal minta | Ubah |
|---|---|
| Batas lulus jadi 60 | Angka di `nilai >= 75` → `60` |
| Tambah grade baru | Tambah satu `ElseIf` **di urutan yang benar** (dari batas tertinggi ke terendah) |
| Dua syarat harus benar | `If a > 0 AndAlso b > 0 Then` |
| Salah satu syarat cukup | `OrElse` |
| Ganti `If-ElseIf` jadi `Select Case` | Gunakan `Case 85 To 100`, `Case Is >= 70` |
| Hasil 2 pilihan dalam 1 baris | `If(kondisi, "a", "b")` |

---

<a id="p4"></a>
# Pertemuan 4 – Struktur Perulangan

## Konsep singkat

**Perulangan (looping)** = menjalankan blok instruksi berulang kali **selama kondisi True** atau **sebanyak jumlah yang ditetapkan**. Tujuan: mengotomasi tugas berulang, memproses koleksi (array/list), mengurangi duplikasi kode.

**Fungsi/manfaat:** mempermudah & mempercepat pekerjaan berulang · menghindari penulisan kode manual · mengolah data dalam jumlah besar · struktur & pemeliharaan kode lebih baik · fleksibilitas.

| Tipe | Jumlah ulang | Contoh |
|---|---|---|
| **Counted loop** | Diketahui / terhitung | `For…Next` |
| **Uncounted loop** | Tidak diketahui; selama kondisi benar | `While`, `Do…Loop` |

## Sintaks & perbedaan 🔑

| Struktur | Cek kondisi | Minimal jalan | Sintaks VB.NET |
|---|---|---|---|
| `For…Next` | – (jumlah tetap) | 0 kali (jika batas tak terpenuhi) | `For i As Integer = 1 To 10 … Next` |
| `While` | **Di awal** | **0 kali** | `While i <= 10 … End While` |
| `Do While` | **Di awal** | **0 kali** | `Do While i <= 10 … Loop` |
| `Do … Loop While` | **Di akhir** | **Minimal 1 kali** | `Do … Loop While i <= 10` |
| `Do Until` ➕ | Di awal; jalan selama **False** | 0 kali | `Do Until i > 10 … Loop` |
| `Do … Loop Until` ➕ | Di akhir; sampai True | Minimal 1 kali | `Do … Loop Until i > 10` |
| `For Each` ➕ | – (tiap elemen koleksi) | – | `For Each x In koleksi … Next` |

> [!WARNING]
> ⚠️ Di slide "Do - While (kondisi dicek di akhir)" sintaksnya ditulis `Do While kondisi … Loop`. **Itu sebenarnya mengecek di awal.** Di VB.NET perulangan yang mengecek **di akhir** (minimal 1×) adalah **`Do … Loop While kondisi`** (sesuai slide "Do-Loop"). Kalau ditanya "mana yang minimal sekali jalan?" → jawab `Do … Loop While`.

### Kode siap salin

**For-Next (naik, turun, melompat)**

```vb
' Naik (step 1 secara default)
For i As Integer = 1 To 5
    lstHasil.Items.Add(i)
Next

' Turun: wajib Step -1
For i As Integer = 10 To 1 Step -1
    lstHasil.Items.Add(i)
Next

' Melompat: kelipatan 2 → 2, 4, 6, 8, 10
For i As Integer = 2 To 10 Step 2
    lstHasil.Items.Add(i)
Next
```

**While** (dari slide)

```vb
Dim i As Integer = 1
While i <= 10
    lstHasil.Items.Add(i)
    i = i + 1          ' JANGAN LUPA update variabel → kalau lupa: infinite loop!
End While
```

**Do-Loop (cek di akhir)**

```vb
Dim i As Integer = 1
Do
    lstHasil.Items.Add(i)
    i += 1
Loop While i <= 5
```

**Nested loop** (dari slide) – loop dalam dijalankan **penuh** untuk tiap iterasi loop luar:

```vb
For i As Integer = 1 To 3
    For j As Integer = 1 To 3
        lstHasil.Items.Add(i & " - " & j)
    Next
Next
' Hasil: 1 - 1, 1 - 2, 1 - 3, 2 - 1, ... , 3 - 3
```

**Menghentikan perulangan** ➕

```vb
For i As Integer = 1 To 100
    If i Mod 7 = 0 Then Exit For      ' keluar dari loop sepenuhnya
    If i Mod 2 = 0 Then Continue For  ' lompat ke iterasi berikutnya
    lstHasil.Items.Add(i)
Next
' Do/While: pakai  Exit Do  /  Continue Do  /  Exit While
```

### Pola soal yang sering muncul ➕

```vb
' 1) Jumlah 1..n
Dim total As Integer = 0
For i As Integer = 1 To n
    total += i
Next

' 2) Faktorial (pakai Long; Integer overflow di 13!)
Dim f As Long = 1
For i As Integer = 1 To n
    f *= i
Next

' 3) Tabel perkalian n
For i As Integer = 1 To 10
    lstHasil.Items.Add(n & " x " & i & " = " & (n * i))
Next

' 4) Segitiga bintang
For i As Integer = 1 To n
    lstHasil.Items.Add(New String("*"c, i))   ' i buah bintang
Next

' 5) Hanya bilangan genap 1..20
For i As Integer = 1 To 20
    If i Mod 2 = 0 Then lstHasil.Items.Add(i)
Next

' 6) Jumlah digit (uncounted loop: berapa putaran tidak diketahui)
Dim angka As Integer = 12345
Dim jumlah As Integer = 0
Do While angka > 0
    jumlah += angka Mod 10     ' ambil digit terakhir
    angka = angka \ 10         ' buang digit terakhir (bagi BULAT)
Loop

' 7) Fibonacci n suku
Dim a As Integer = 0, b As Integer = 1
For i As Integer = 1 To n
    lstHasil.Items.Add(a)
    Dim c As Integer = a + b
    a = b
    b = c
Next

' 8) Cek bilangan prima
Private Function IsPrima(n As Integer) As Boolean
    If n < 2 Then Return False
    For i As Integer = 2 To CInt(Math.Sqrt(n))
        If n Mod i = 0 Then Return False
    Next
    Return True
End Function
```

**Kosongkan ListBox dulu agar hasil tidak menumpuk saat tombol diklik 2×:** `lstHasil.Items.Clear()`

### Kalau soal minta … → ubah …

| Soal minta | Ubah |
|---|---|
| Cetak 1–20 (bukan 1–10) | Batas akhir `To 10` → `To 20` |
| Urut turun | Tukar batas + `Step -1` |
| Hanya kelipatan 5 | `Step 5` atau `If i Mod 5 = 0` |
| Jumlah, bukan cetak | Tambah `total += i`, tampilkan setelah `Next` |
| Batas dari TextBox | `For i = 1 To CInt(txtN.Text)` (atau pakai `TryParse`) |
| Berhenti jika ketemu | `Exit For` |
| Ulangi sampai input valid | `Do … Loop While Not valid` |
| Loop 2D / tabel | Nested For (luar = baris, dalam = kolom) |
| Loop tidak berhenti | Cek update variabel (`i += 1`) dan arah kondisi |

---

<a id="p5"></a>
# Pertemuan 5 – Modul, Fungsi, Array dan Koleksi Data

## Modul

**Module** = bagian program untuk **mengelompokkan kode** berdasarkan fungsi/kebutuhan. Memisahkan kode dari Form → program lebih **terstruktur** dan **mudah dikelola**.

Cara membuat: `Solution Explorer → klik kanan Project → Add → Module → beri nama (mis. ModPerhitungan)`.

```vb
Module ModPerhitungan
    ' Tempat untuk menulis fungsi, prosedur, dan variabel sesuai kebutuhan
End Module
```

### Access Modifier 🔑

| Modifier | Arti | Contoh |
|---|---|---|
| `Public` | Dapat diakses dari **bagian program lain** (mis. Form1) | `Public nilai As Integer = 80` |
| `Private` | **Hanya** dapat diakses dari **dalam modul itu sendiri** | `Private hasil As Integer = 100` |

```vb
Module ModPerhitungan
    Public nilai As Integer = 80      ' bisa dibaca dari Form1
    Private hasil As Integer = 100    ' TIDAK bisa dibaca dari Form1 (error)
End Module

' Di Form1:
MessageBox.Show(nilai.ToString())      ' ✅ jalan
' MessageBox.Show(hasil.ToString())    ' ❌ error: 'hasil' inaccessible
```

## Procedure (`Sub`) – menjalankan tugas, **tidak** mengembalikan nilai

```vb
Module ModPerhitungan
    Public Sub TampilkanPesan()
        MessageBox.Show("Halo dari Procedure!")
    End Sub
End Module

' Dipanggil di Form1 saat diperlukan:
Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
    TampilkanPesan()
End Sub
```

## Fungsi (`Function`) – melakukan proses dan **mengembalikan nilai**

Cocok jika hasil proses dipakai lagi oleh bagian lain.

```vb
Module ModPerhitungan
    Public Function HitungLuas(panjang As Integer, lebar As Integer) As Integer
        Return panjang * lebar
    End Function
End Module

' Di Form1:
Dim luas As Integer = HitungLuas(10, 5)          ' 50
lblHasil.Text = "Luas: " & luas.ToString()
```

| | `Sub` | `Function` |
|---|---|---|
| Mengembalikan nilai | ❌ | ✅ (`Return`, dengan tipe `As ...`) |
| Dipakai untuk | Aksi (tampil pesan, bersihkan form) | Hasil hitung / pengecekan |

**Parameter** ➕

```vb
Public Sub Ubah(ByVal x As Integer)       ' ByVal: salinan (nilai asli tidak berubah)  [default]
    x = 100
End Sub

Public Sub Ubah2(ByRef x As Integer)      ' ByRef: nilai asli ikut berubah
    x = 100
End Sub

Public Function Sapa(nama As String, Optional salam As String = "Halo") As String
    Return salam & ", " & nama            ' Sapa("Budi") → "Halo, Budi"
End Function
```

**Contoh fungsi yang sering diminta** ➕

```vb
Public Function IsGenap(n As Integer) As Boolean
    Return n Mod 2 = 0
End Function

Public Function HitungRataRata(data() As Integer) As Double
    Dim total As Integer = 0
    For Each x As Integer In data
        total += x
    Next
    Return total / data.Length
End Function

Public Function KonversiNilai(skor As Integer) As String
    If skor >= 85 Then Return "A"
    If skor >= 70 Then Return "B"
    Return "C"
End Function
```

## Array

**Array** = menyimpan beberapa nilai dalam **satu variabel**, **satu tipe data**, tiap elemen punya **index yang mulai dari 0**. **Ukuran tetap.**

### Satu dimensi

```vb
' Cara 1: isi langsung
Dim nilai() As Integer = {10, 20, 30, 40, 50}
MessageBox.Show(nilai(2).ToString())      ' 30   (index 2 = elemen ke-3)

' Cara 2: tentukan ukuran → (4) berarti index 0..4 = 5 ELEMEN  🔑
Dim skor(4) As Integer
skor(0) = 90
skor(4) = 75
```

> 🔑 `Dim x(4)` → **5 elemen**, index 0–4. Jebakan klasik di soal: "berapa isi array `Dim a(9)`?" → **10** elemen.

**Operasi array** ➕

```vb
nilai.Length                         ' jumlah elemen = 5
nilai.GetUpperBound(0)               ' index terakhir = 4
Array.Sort(nilai)                    ' urutkan naik
Array.Reverse(nilai)                 ' balik urutan
Array.IndexOf(nilai, 30)             ' cari posisi 30 (-1 jika tidak ada)
nilai.Sum() : nilai.Max() : nilai.Min() : nilai.Average()   ' pakai LINQ

For i As Integer = 0 To nilai.Length - 1      ' loop dengan index
    lstHasil.Items.Add(nilai(i))
Next
For Each n As Integer In nilai                ' loop tanpa index
    lstHasil.Items.Add(n)
Next

' Menambah ukuran: ReDim Preserve (Preserve = isi lama tidak hilang)
ReDim Preserve nilai(5)              ' sekarang 6 elemen
```

### Multi-dimensi

Dua dimensi = **matriks (baris × kolom)**; **semua baris wajib punya jumlah kolom sama**.

```vb
Dim data(,) As Integer = {
    {10, 20, 30},
    {40, 50, 60},
    {70, 80, 90}
}
MessageBox.Show(data(1, 2).ToString())       ' 60 → baris 1, kolom 2

data.GetLength(0)      ' jumlah BARIS = 3
data.GetLength(1)      ' jumlah KOLOM = 3

' Loop semua sel
For i As Integer = 0 To data.GetUpperBound(0)         ' baris
    For j As Integer = 0 To data.GetUpperBound(1)     ' kolom
        lstHasil.Items.Add(data(i, j))
    Next
Next
```

Tiga dimensi ➕ (baris, kolom, kedalaman):

```vb
Dim kubus(,,) As Integer = {
    {{1, 2}, {3, 4}},
    {{5, 6}, {7, 8}}
}
' kubus(1, 0, 1) = 6
```

> ⚠️ Slide memakai `Console.WriteLine(...)`. Di aplikasi **WinForms**, tampilkan lewat `MessageBox.Show(...)`, `lblHasil.Text = ...`, atau `lstHasil.Items.Add(...)`.

## Koleksi Data

Menyimpan & mengelola sekumpulan objek/nilai: **tambah, hapus, akses, cari, iterasi**. Beberapa jenis **bisa berubah ukuran (dinamis)** — beda dengan Array.

| Jenis | Ukuran | Tipe elemen | Akses | Duplikat | Cocok untuk |
|---|---|---|---|---|---|
| **Array** | Tetap | Sama | Index (mulai 0) | Boleh | Data tetap |
| **List(Of T)** | Dinamis | Sama | Index | Boleh | Daftar yang berubah-ubah |
| **Dictionary(Of K, V)** | Dinamis | Key & value | **Key** (unik) | Key tidak boleh sama | Data berlabel/identitas |
| **HashSet(Of T)** | Dinamis | Sama | **Tanpa index** | **Tidak boleh** | Data unik |

### List(Of T)

```vb
Dim angka As New List(Of Integer)
angka.Add(10)
angka.Add(20)
angka.Add(30)
MessageBox.Show(angka(0).ToString())     ' 10

angka.Count                ' jumlah isi = 3
angka.Remove(20)           ' hapus NILAI 20
angka.RemoveAt(0)          ' hapus pada INDEX 0
angka.Insert(1, 99)        ' sisipkan di index 1
angka.Contains(30)         ' True/False
angka.IndexOf(30)          ' posisi, -1 jika tidak ada
angka.Sort() : angka.Reverse()
angka.Clear()              ' kosongkan
Dim arr() As Integer = angka.ToArray()

For Each n As Integer In angka
    lstHasil.Items.Add(n)
Next
```

### Dictionary(Of K, V)

```vb
Dim mhs As New Dictionary(Of String, String)
mhs.Add("NIM", "241712051")
mhs.Add("Nama", "Nadya")
mhs.Add("Prodi", "Sistem Informasi")
MessageBox.Show(mhs("Nama"))                 ' Nadya

mhs("Nama") = "Nadya Putri"                  ' ubah value
If mhs.ContainsKey("Prodi") Then ...         ' cek key
mhs.Remove("Prodi")                          ' hapus
Dim v As String = ""
If mhs.TryGetValue("NIM", v) Then ...        ' ambil aman, tanpa error
mhs.Count

For Each pasangan As KeyValuePair(Of String, String) In mhs
    lstHasil.Items.Add(pasangan.Key & " = " & pasangan.Value)
Next
```

> ⚠️ `mhs.Add("NIM", ...)` dua kali dengan key sama → **ArgumentException**. Aman: `mhs("NIM") = "..."` atau cek `ContainsKey`.
> ⚠️ `mhs("Kunci Tidak Ada")` → **KeyNotFoundException**.

### HashSet(Of T)

```vb
Dim angka As New HashSet(Of Integer)
angka.Add(10)
angka.Add(20)
angka.Add(20)                       ' tidak akan ditambahkan (duplikat)
MessageBox.Show(angka.Count.ToString())   ' 2

angka.Add(20)           ' mengembalikan False jika sudah ada → bisa untuk cek unik
angka.Contains(10)
angka.Remove(10)
```

### Kalau soal minta … → ubah …

| Soal minta | Pakai / ubah |
|---|---|
| Jumlah/rata-rata/max/min isi array | `.Sum()` `.Average()` `.Max()` `.Min()` atau loop manual |
| Tambah elemen ke array | `ReDim Preserve a(a.Length)` – atau ganti ke `List` |
| Tambah data berulang kali tanpa batas | `List(Of T)` |
| Cari nama berdasarkan NIM | `Dictionary(Of String, String)` |
| Pastikan tidak ada duplikat | `HashSet` atau `List.Contains` |
| Matriks / tabel angka | Array 2D `(,)` |
| Fungsi dipakai banyak form | `Public Function` di `Module` |

---

<a id="p6"></a>
# Pertemuan 6 – Database (PostgreSQL, Supabase, Npgsql)

> Slide P6 hanya berisi **konsep** (belum ada kode). Bagian kode CRUD di bawah ➕ **tambahan dari saya** karena materi menyebut "Manipulasi Data CRUD dengan Npgsql". Sesuaikan dengan petunjuk praktikum.

## Konsep singkat

| Istilah | Penjelasan |
|---|---|
| **Database** | Kumpulan data **terstruktur** yang disimpan agar bisa diakses, dikelola, dan dimanipulasi aplikasi; menjaga konsistensi data |
| **PostgreSQL** (Postgres) | Sistem manajemen basis data **relasional objek (ORDBMS)** kelas atas, **open-source**; menggunakan & memperluas **SQL** |
| **Supabase** | Platform **Backend-as-a-Service (BaaS)** yang membungkus PostgreSQL. Analogi: Postgres = "mesin", Supabase = "pabrik" lengkap dengan panel kendali (**API, Auth, Dashboard**) |
| **Npgsql** | **Data provider ADO.NET** open-source: "jembatan" antara aplikasi .NET (C#, F#, VB.NET) dan PostgreSQL |

### Kelas-kelas Npgsql 🔑

| Kelas | Fungsi |
|---|---|
| `NpgsqlConnection` | Membuat, membuka, mengelola **jalur koneksi fisik (sesi)** ke database |
| `NpgsqlCommand` | Mendefinisikan & mengeksekusi **kueri SQL** (SELECT, INSERT, UPDATE, DELETE) atau stored procedure lewat koneksi yang sudah dibuka |
| `NpgsqlDataAdapter` | Perantara: **mengambil data** dari PostgreSQL ke memori (`DataTable`/`DataSet`) dan **mengirim balik perubahan** |
| `NpgsqlCommandBuilder` | Membuat kueri **INSERT/UPDATE/DELETE otomatis** untuk DataAdapter berdasarkan kueri SELECT |

## Persiapan ➕

1. **Install Npgsql:** `Project → Manage NuGet Packages → Browse → "Npgsql" → Install`.
2. Tambah di atas file: `Imports Npgsql`
3. **Connection string** (ambil dari Supabase: *Project Settings → Database → Connection string*). Bentuk umum:

```vb
Private Const ConnStr As String =
    "Host=HOST_DARI_SUPABASE;Port=5432;Database=postgres;" &
    "Username=USER_DARI_SUPABASE;Password=PASSWORD_KAMU;" &
    "SSL Mode=Require;Trust Server Certificate=true"
```

> [!NOTE]
> Nilai `Host`, `Username`, `Password` **harus persis dari dashboard Supabase-mu**. Supabase punya beberapa mode koneksi (direct / pooler) dengan host & username berbeda; pakai yang disarankan di petunjuk praktikum. **Jangan upload password asli ke GitHub publik.**

4. Contoh tabel (jalankan di *SQL Editor* Supabase):

```sql
CREATE TABLE mahasiswa (
    nim      VARCHAR(9) PRIMARY KEY,
    nama     VARCHAR(100) NOT NULL,
    jurusan  VARCHAR(50),
    angkatan INT,
    ipk      NUMERIC(3,2)
);
```

## Kode CRUD ➕

**Uji koneksi**

```vb
Imports Npgsql

Private Sub btnTes_Click(sender As Object, e As EventArgs) Handles btnTes.Click
    Try
        Using conn As New NpgsqlConnection(ConnStr)
            conn.Open()
            MessageBox.Show("Koneksi berhasil!")
        End Using                                 ' otomatis Close
    Catch ex As Exception
        MessageBox.Show("Koneksi gagal: " & ex.Message)
    End Try
End Sub
```

**READ – tampilkan ke DataGridView** (pola P8: DataTable → BindingSource → DataGridView)

```vb
Private Sub TampilkanData()
    Using conn As New NpgsqlConnection(ConnStr)
        Dim da As New NpgsqlDataAdapter("SELECT * FROM mahasiswa ORDER BY nim", conn)
        Dim dt As New DataTable()
        da.Fill(dt)                      ' Fill membuka & menutup koneksi sendiri
        dgvMahasiswa.DataSource = dt
    End Using
End Sub
```

**CREATE – INSERT (selalu pakai parameter, jangan menggabung string SQL)**

```vb
Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    Try
        Using conn As New NpgsqlConnection(ConnStr)
            conn.Open()
            Dim sql As String =
                "INSERT INTO mahasiswa (nim, nama, jurusan, angkatan, ipk) " &
                "VALUES (@nim, @nama, @jurusan, @angkatan, @ipk)"
            Using cmd As New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nim", txtNim.Text.Trim())
                cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
                cmd.Parameters.AddWithValue("@jurusan", cboJurusan.Text)
                cmd.Parameters.AddWithValue("@angkatan", Integer.Parse(txtAngkatan.Text))
                cmd.Parameters.AddWithValue("@ipk", Decimal.Parse(txtIpk.Text,
                                              CultureInfo.InvariantCulture))
                Dim baris As Integer = cmd.ExecuteNonQuery()   ' jumlah baris terpengaruh
                MessageBox.Show(baris & " data ditambahkan.")
            End Using
        End Using
        TampilkanData()
    Catch ex As Exception
        MessageBox.Show("Gagal menyimpan: " & ex.Message)
    End Try
End Sub
```

**UPDATE**

```vb
Dim sql As String = "UPDATE mahasiswa SET nama=@nama, ipk=@ipk WHERE nim=@nim"
' ... parameter sama seperti INSERT, lalu cmd.ExecuteNonQuery()
```

**DELETE**

```vb
Dim sql As String = "DELETE FROM mahasiswa WHERE nim=@nim"
cmd.Parameters.AddWithValue("@nim", txtNim.Text.Trim())
cmd.ExecuteNonQuery()
```

**Mengambil satu nilai** (`ExecuteScalar`) dan **membaca baris** (`ExecuteReader`)

```vb
Dim jumlah As Long = CLng(New NpgsqlCommand("SELECT COUNT(*) FROM mahasiswa", conn).ExecuteScalar())

Using rd As NpgsqlDataReader = cmd.ExecuteReader()
    While rd.Read()
        lstHasil.Items.Add(rd("nim").ToString() & " | " & rd("nama").ToString())
    End While
End Using
```

**Alternatif: DataAdapter + CommandBuilder** (tanpa menulis INSERT/UPDATE/DELETE manual; **tabel harus punya primary key**)

```vb
Private da As NpgsqlDataAdapter
Private dt As New DataTable()

Private Sub Muat()
    da = New NpgsqlDataAdapter("SELECT * FROM mahasiswa", ConnStr)
    Dim cb As New NpgsqlCommandBuilder(da)      ' otomatis bikin INSERT/UPDATE/DELETE
    dt.Clear()
    da.Fill(dt)
    dgvMahasiswa.DataSource = dt
End Sub

Private Sub btnSimpanPerubahan_Click(sender As Object, e As EventArgs) Handles btnSimpanPerubahan.Click
    da.Update(dt)                               ' kirim semua perubahan (tambah/ubah/hapus) ke DB
End Sub
```

### Kalau soal minta … → ubah …

| Soal minta | Ubah |
|---|---|
| Tampilkan data tertentu saja | `SELECT * FROM mahasiswa WHERE jurusan = @j` + parameter |
| Urutkan | `ORDER BY ipk DESC` |
| Cari nama mengandung kata | `WHERE nama ILIKE @kata` dengan `"%" & kata & "%"` (ILIKE = tidak peduli besar kecil, khas PostgreSQL) |
| Hapus data yang dipilih di grid | Ambil `dgvX.CurrentRow.Cells("nim").Value`, jalankan DELETE |
| Isi textbox saat baris grid diklik | Event `dgvX.CellClick` → `txtNim.Text = dgvX.Rows(e.RowIndex).Cells("nim").Value.ToString()` |
| Tabel baru | Ganti nama tabel/kolom di SQL dan parameter |

### Error khas database ➕

| Pesan | Penyebab umum |
|---|---|
| `password authentication failed` | Password/username salah |
| `relation "xxx" does not exist` | Nama tabel salah (PostgreSQL membedakan huruf besar-kecil jika dibuat dengan tanda kutip) atau tabel belum dibuat |
| `column "xxx" does not exist` | Nama kolom salah |
| `duplicate key value violates unique constraint` | Primary key / NIM sudah ada |
| `connection timed out` / gagal konek | Internet, host/port salah, atau mode koneksi tidak cocok |
| `The ConnectionString property has not been initialized` | Connection string kosong |

---

<a id="p7"></a>
# Pertemuan 7 – Validasi Input, Error Handling & Naming Convention

## 1. Naming Convention Kontrol 🔑

Nama default (`Button1`, `TextBox3`) membuat kode tidak terbaca. Rubrik UTS/UAS/proyek **menurunkan nilai kerapian** jika memakai nama default.

**Pola:** `prefix 3 huruf kecil` + `NamaFungsi` (setiap kata diawali huruf besar). Tanpa spasi, tidak diawali angka. Diubah lewat properti **`(Name)`** di jendela Properties — **bukan** properti `Text`.

| Kontrol | Prefix | Contoh | | Kontrol | Prefix | Contoh |
|---|---|---|---|---|---|---|
| Form | `frm` | `frmPendaftaran` | | CheckBox | `chk` | `chkSetuju` |
| Label | `lbl` | `lblJudul` | | RadioButton | `rdo` | `rdoLakiLaki` |
| TextBox | `txt` | `txtNama` | | GroupBox | `grp` | `grpDataDiri` |
| Button | `btn` | `btnSimpan` | | DataGridView | `dgv` | `dgvData` |
| ComboBox | `cbo` | `cboJurusan` | | DateTimePicker | `dtp` | `dtpTanggalLahir` |
| ListBox | `lst` | `lstMahasiswa` | | ErrorProvider | `err` | `errInput` |
| | | | | BindingSource (P8) | `bs` | `bsMahasiswa` |

Semua kontrol diberi nama, **termasuk Label yang tidak dipakai di kode**.

**Kesalahan umum penamaan**
1. `Name` diganti **setelah** double-click → Sub tetap `Button1_Click`. Ganti `Name` **dulu**, baru double-click.
2. Mengubah `Text` dikira mengubah `Name`.
3. Prefix tidak sesuai jenis kontrol (`txtJurusan` untuk ComboBox).
4. Bahasa campur dalam satu form (`btnSave` dan `btnHapus`).

## 2. Tiga Jenis Error 🔑

| Jenis | Ciri | Cara menangani |
|---|---|---|
| **Syntax error** | Salah tulis kode (`Dim x As Integr`). Garis merah; program tak bisa dijalankan | Perbaiki sebelum run |
| **Runtime error** (exception) | Muncul saat program berjalan (`CInt("abc")`). Program berhenti jika tak ditangkap | `Try…Catch` / validasi |
| **Logic error** | Program jalan normal, **hasil salah** (rumus rata-rata keliru) | Pengujian dengan data yang hasilnya sudah diketahui |

> `Try…Catch` **hanya untuk runtime error.**

### Exception yang sering muncul

| Exception | Penyebab umum |
|---|---|
| `FormatException` | `Integer.Parse("abc")` — teks bukan angka |
| `InvalidCastException` | `CInt("abc")` — konversi gaya VB gagal |
| `OverflowException` | Angka melebihi batas tipe data |
| `DivideByZeroException` | Bilangan **bulat** dibagi 0 (operator `\` atau `Mod`) |
| `IndexOutOfRangeException` | Indeks array di luar batas |
| `NullReferenceException` | Objek masih `Nothing` (belum `New`) |
| `IOException` | File dipakai program lain / tidak bisa ditulis |

Exception adalah **objek**: `ex.Message` = penjelasan singkat; **tipenya** menunjukkan jenis masalah.

## 3. Try…Catch…Finally 🔑

Cara kerja: baris di `Try` dijalankan berurutan. Begitu satu baris melempar exception → sisa baris `Try` **dilewati** dan eksekusi **lompat ke `Catch`**. Tanpa exception → `Catch` dilewati. Setelah `End Try`, program tetap berjalan.

**Dasar** (dari slide)

```vb
Private Sub btnTryCatch_Click(sender As Object, e As EventArgs) Handles btnTryCatch.Click
    Try
        Dim angka As Integer = Integer.Parse(txtInput.Text)
        lblHasil.Text = "Berhasil dikonversi: " & angka.ToString()
    Catch ex As Exception
        lblHasil.Text = "Konversi gagal, program tetap berjalan."
        MessageBox.Show("Input harus bilangan bulat, misalnya 25." & vbCrLf &
                        "Detail: " & ex.Message, "Input Tidak Valid",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
End Sub
```

**Catch bertingkat** — diperiksa **dari atas ke bawah**, hanya **yang pertama cocok** dijalankan. **Spesifik di atas, `Exception` paling bawah.** (Uji input: `abc`, `99999999999`, `0`, `25`.)

```vb
Private Sub btnCatchBertingkat_Click(sender As Object, e As EventArgs) Handles btnCatchBertingkat.Click
    Try
        Dim angka As Integer = Integer.Parse(txtInput.Text)
        Dim hasil As Integer = 1000 \ angka
        lblHasil.Text = "1000 \ " & angka.ToString() & " = " & hasil.ToString()
    Catch ex As FormatException
        lblHasil.Text = "Format salah: input bukan bilangan bulat."
    Catch ex As OverflowException
        lblHasil.Text = "Angka terlalu besar untuk tipe Integer."
    Catch ex As DivideByZeroException
        lblHasil.Text = "Pembagian dengan nol tidak diperbolehkan."
    Catch ex As Exception
        lblHasil.Text = "Error lain: " & ex.Message
    End Try
End Sub
```

**Finally** — **selalu dijalankan**, ada error atau tidak. Tempat beres-beres: menutup file, menutup koneksi, mengaktifkan tombol kembali.

```vb
Imports System.IO   ' paling atas file

Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
    Dim penulis As StreamWriter = Nothing
    Try
        penulis = New StreamWriter(lokasiEkspor)
        For Each baris As Object In lstMahasiswa.Items
            penulis.WriteLine(baris.ToString().Replace(" | ", ";"))
        Next
        lblStatus.Text = "Data diekspor ke " & lokasiEkspor
    Catch ex As IOException
        MessageBox.Show("File sedang dipakai program lain atau tidak bisa ditulis." &
                        vbCrLf & ex.Message, "Ekspor Gagal")
    Finally
        If penulis IsNot Nothing Then penulis.Close()   ' file selalu ditutup
    End Try
End Sub
```

Variabel `lokasiEkspor` ➕ (level-form):

```vb
Private ReadOnly lokasiEkspor As String =
    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "mahasiswa.csv")
```

**Kapan `Try…Catch` dipakai**

| ✅ Tepat | ❌ Tidak tepat |
|---|---|
| Operasi **di luar kendali program**: baca/tulis file, database, jaringan, konversi data dari sumber luar | Menggantikan pengecekan biasa (input kosong cukup `If`) |
| | Membungkus **seluruh Sub** dalam satu Try besar |
| | `Catch` **kosong** (menelan error → masalah tersembunyi) |

> 🔑 **Cegah dengan validasi apa yang bisa dicegah. Tangkap dengan Try…Catch apa yang tidak bisa dicegah.**

## 4. Validasi Input 🔑

Validasi = memeriksa input **sebelum diproses**. Untuk satu isian: **periksa tipe dulu, baru rentang.**

| Aturan | Penerapan di form pendaftaran |
|---|---|
| Wajib isi | Nama tidak boleh kosong |
| Tipe data | Angkatan harus bilangan bulat |
| Rentang | Angkatan 2015 s.d. tahun ini; IPK 0,00 s.d. 4,00 |
| Format | NIM tepat 9 digit angka |
| Pilihan | Jurusan dipilih dari ComboBox |
| Unik | NIM belum pernah didaftarkan |

### `CInt` vs `Val` vs `TryParse` 🔑

| Input | `CInt(teks)` | `Val(teks)` | `Integer.TryParse` |
|---|---|---|---|
| `abc` | InvalidCastException | 0 | False |
| `12abc` | InvalidCastException | **12** | False |
| `3,5` | 35 atau 4 (tergantung bahasa Windows) | 3 | False |
| `99999999999` | OverflowException | 99999999999 | False |
| (kosong) | InvalidCastException | 0 | False |

- **`Val` tidak pernah error** → justru berbahaya: data salah tersimpan diam-diam (`12abc` lolos jadi 12).
- **`CInt`** melempar exception.
- **Untuk validasi → pakai `TryParse`**: hasil `True/False` tanpa exception.

### TryParse

Mengembalikan `True/False`; jika berhasil, mengisi variabel di **parameter kedua** (harus dideklarasikan lebih dulu). Tersedia juga `Long.TryParse`, `Decimal.TryParse`, `Double.TryParse`, `Date.TryParse`.

```vb
Private Sub btnTryParse_Click(sender As Object, e As EventArgs) Handles btnTryParse.Click
    Dim angka As Integer
    If Integer.TryParse(txtInput.Text, angka) Then
        lblHasil.Text = "Valid. Nilai angka = " & angka.ToString()
    Else
        lblHasil.Text = "Bukan bilangan bulat yang valid. Tidak ada exception."
    End If
End Sub
```

### Jebakan desimal: koma atau titik

Windows berbahasa Indonesia memakai **koma = desimal**, **titik = ribuan**. Akibatnya `Decimal.TryParse("3.75")` bisa menghasilkan **375**. Solusi: terima koma maupun titik, ubah ke titik, baca dengan aturan tetap (`InvariantCulture`). Simpan di **Module** `ModValidasi`:

```vb
Imports System.Globalization

Module ModValidasi

    ' Mengubah teks desimal menjadi Decimal. Koma dan titik sama-sama diterima,
    ' sehingga hasilnya tidak bergantung pada pengaturan bahasa Windows.
    Public Function CobaDesimal(teks As String, ByRef hasil As Decimal) As Boolean
        Dim teksTitik As String = teks.Trim().Replace(",", ".")
        Return Decimal.TryParse(teksTitik, NumberStyles.AllowDecimalPoint,
                                CultureInfo.InvariantCulture, hasil)
    End Function

    ' ➕ Pembantu: apakah teks kosong / hanya spasi
    Public Function Kosong(teks As String) As Boolean
        Return String.IsNullOrWhiteSpace(teks)
    End Function

End Module
```

> ⚠️ Slide memanggil `Kosong(...)` tanpa menampilkan isinya — versi di atas adalah buatan saya (➕), fungsinya jelas: cek kosong.

## 5. ErrorProvider 🔑

Lima isian salah = lima MessageBox beruntun, dan pengguna lupa yang mana. **ErrorProvider** memasang **ikon merah** di samping kontrol; pesan muncul saat kursor diarahkan. Komponen tampil di **component tray** (bawah Designer), bukan di atas form. Nama: `errInput`.

```vb
errInput.SetError(txtNama, "pesan")    ' pasang ikon + pesan
errInput.SetError(txtNama, "")         ' hapus ikon untuk satu kontrol (pesan kosong)
errInput.Clear()                       ' hapus SEMUA ikon
```

## 6. Fungsi `ValidasiInput()` 🔑

**Pola: hapus tanda lama → periksa SETIAP isian → pasang tanda pada yang salah → kembalikan True/False.** Semua isian tetap diperiksa agar pengguna melihat **semua kesalahan sekaligus**.

Potongan dari slide (Nama & Angkatan):

```vb
Private Function ValidasiInput() As Boolean
    errInput.Clear()                       ' hapus semua tanda error lama
    Dim valid As Boolean = True

    If Kosong(txtNama.Text) Then
        errInput.SetError(txtNama, "Nama wajib diisi.")
        valid = False
    End If

    Dim angkatan As Integer
    If Not Integer.TryParse(txtAngkatan.Text, angkatan) OrElse
       angkatan < 2015 OrElse angkatan > Date.Today.Year Then
        errInput.SetError(txtAngkatan, "Angkatan harus angka 2015 s.d. tahun ini.")
        valid = False
    End If

    ' ... NIM, Jurusan, IPK mengikuti pola yang sama (lihat di bawah)

    Return valid
End Function
```

**Versi lengkap** ➕ (NIM, Jurusan, IPK + NIM unik):

```vb
Private ReadOnly daftarNim As New List(Of String)     ' level-form, untuk cek unik

Private Function ValidasiInput() As Boolean
    errInput.Clear()
    Dim valid As Boolean = True

    ' NIM: tepat 9 digit angka + belum terdaftar
    Dim nim As String = txtNim.Text.Trim()
    If Not Regex.IsMatch(nim, "^[0-9]{9}$") Then
        errInput.SetError(txtNim, "NIM harus tepat 9 digit angka.")
        valid = False
    ElseIf daftarNim.Contains(nim) Then
        errInput.SetError(txtNim, "NIM sudah terdaftar.")
        valid = False
    End If

    ' Nama: wajib
    If Kosong(txtNama.Text) Then
        errInput.SetError(txtNama, "Nama wajib diisi.")
        valid = False
    End If

    ' Jurusan: harus dipilih
    If cboJurusan.SelectedIndex = -1 Then
        errInput.SetError(cboJurusan, "Pilih jurusan.")
        valid = False
    End If

    ' Angkatan: tipe lalu rentang
    Dim angkatan As Integer
    If Not Integer.TryParse(txtAngkatan.Text, angkatan) OrElse
       angkatan < 2015 OrElse angkatan > Date.Today.Year Then
        errInput.SetError(txtAngkatan, "Angkatan harus angka 2015 s.d. tahun ini.")
        valid = False
    End If

    ' IPK: desimal 0,00 – 4,00
    Dim ipk As Decimal
    If Not CobaDesimal(txtIpk.Text, ipk) OrElse ipk < 0D OrElse ipk > 4D Then
        errInput.SetError(txtIpk, "IPK harus angka 0,00 s.d. 4,00.")
        valid = False
    End If

    Return valid
End Function
```

> `Imports System.Text.RegularExpressions` di paling atas file (untuk `Regex`).

### Klik tombol atau `Validating`?

| | Klik tombol | Event `Validating` |
|---|---|---|
| Kapan dicek | Semua isian sekaligus saat **Simpan** diklik | Setiap kali **fokus keluar** dari kontrol |
| Kelebihan | Sederhana → **pemeriksaan utama** | Umpan balik lebih cepat |
| Peringatan | – | Hindari `e.Cancel = True`: fokus terkunci, tombol lain tak bisa diklik (kecuali `CausesValidation = False`) |

## 7. Tombol Simpan 🔑

Alur: `Klik btnSimpan → ValidasiInput() → Semua valid? → (Ya) Konversi isian → Tambah ke daftar → BersihkanForm()`; `(Tidak) → ikon merah, tampilkan status, Return`.

**Pola "periksa dulu, keluar jika gagal":** `Return` menghentikan Sub saat validasi gagal. Setelah lolos, konversi **pasti berhasil → tidak perlu Try…Catch.** `Try…Catch` dipakai di **Ekspor** (menulis file di luar kendali program).

```vb
Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
    If Not ValidasiInput() Then
        lblStatus.Text = "Periksa isian yang bertanda merah."
        Return
    End If
    ' Semua isian sudah valid, jadi konversi di bawah ini tidak perlu Try...Catch
    Dim ipk As Decimal
    CobaDesimal(txtIpk.Text, ipk)
    lstMahasiswa.Items.Add(txtNim.Text & " | " & txtNama.Text.Trim() & " | " &
                           cboJurusan.Text & " | " & txtAngkatan.Text & " | " & ipk.ToString("0.00"))
    daftarNim.Add(txtNim.Text)
    lblStatus.Text = "Data " & txtNama.Text.Trim() & " tersimpan."
    BersihkanForm()
End Sub

' ➕ Tombol Bersihkan + pembersih form
Private Sub BersihkanForm()
    txtNim.Clear() : txtNama.Clear() : txtAngkatan.Clear() : txtIpk.Clear()
    cboJurusan.SelectedIndex = -1
    errInput.Clear()                 ' ikon error ikut dihapus
    txtNim.Focus()
End Sub

Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
    BersihkanForm()
End Sub
```

**Alternatif `Validating`** ➕ (hapus ikon otomatis saat benar)

```vb
Private Sub txtNama_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNama.Validating
    If Kosong(txtNama.Text) Then
        errInput.SetError(txtNama, "Nama wajib diisi.")
    Else
        errInput.SetError(txtNama, "")      ' perbaikan → ikon hilang
    End If
End Sub
```

**Batasi ketikan hanya angka** ➕ (opsional pencegahan tambahan)

```vb
Private Sub txtAngkatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAngkatan.KeyPress
    If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
End Sub
```

## Kesalahan umum P7

1. `Catch` kosong → error disembunyikan, data tak tersimpan tanpa peringatan.
2. Memakai `Val` untuk validasi → `12abc` lolos jadi 12.
3. Ikon ErrorProvider tidak dihapus setelah isian diperbaiki (lupa `errInput.Clear()` di awal).
4. `TryParse` tanpa cek rentang → angkatan 3000 tetap lolos.
5. `ex.ToString()` ditampilkan apa adanya ke pengguna (pakai pesan ramah + `ex.Message` bila perlu).
6. `Catch Exception` diletakkan **paling atas** (menelan semua catch di bawahnya).
7. `Name` kontrol diganti setelah event dibuat.

## Kalau soal minta … → ubah …

| Soal minta | Ubah |
|---|---|
| Rentang angkatan 2018–2025 | `angkatan < 2018 OrElse angkatan > 2025` |
| NIM 10 digit | `"^[0-9]{10}$"` dan pesan error |
| Kode `BK` + 4 digit | `"^BK[0-9]{4}$"` |
| Nama minimal 3 karakter | `txtNama.Text.Trim().Length < 3` |
| IPK 0–4 | `ipk < 0D OrElse ipk > 4D` |
| Lama pinjam 1–14 | `Not Integer.TryParse(txtLama.Text, n) OrElse n < 1 OrElse n > 14` |
| Tambah satu field baru | Salin satu blok `If … SetError … valid = False … End If`, ganti kontrol, syarat, pesan |
| Pesan error per catch | Tambah `Catch ex As NamaException` **di atas** `Catch ex As Exception` |
| Tangkap error file | `Catch ex As IOException` + `Catch ex As UnauthorizedAccessException` |
| Tutup file/koneksi apa pun yang terjadi | Taruh di `Finally` |

---

<a id="p8"></a>
# Pertemuan 8 – DataGridView, Array & Koleksi Data

## Konsep singkat

- **Recap Array:** ukuran tetap sejak dibuat (`Dim nilai(4)` = 5 elemen, index 0–4), satu tipe data, menambah elemen perlu `ReDim Preserve`.
- **Recap List(Of T):** ukuran dinamis: `Add` menambah, `Remove` menghapus, `Count` menghitung.
- **Masalah ListBox untuk banyak kolom:** kolom tidak sejajar, sulit dibaca, tak bisa diurutkan per kolom, mengambil satu nilai (mis. IPK) harus memotong teks. → **data berbentuk tabel butuh kontrol berbentuk tabel = `DataGridView`.**

**DataGridView** (prefix `dgv`, di Toolbox grup **Data**): menampilkan data dalam baris & kolom seperti Excel. Akses satu sel:

```vb
dgvMahasiswa.Rows(1).Cells(2).Value      ' baris index 1, kolom index 2 (index mulai 0)
```

## Dua cara mengisi grid 🔑

| | Cara 1: Manual (**unbound**) | Cara 2: Lewat `DataSource` (**bound**) |
|---|---|---|
| Cara | Buat kolom sendiri, `Rows.Add` per baris | `grid.DataSource = sumberData` |
| Data disimpan di | Grid itu sendiri | Sumber data (List / DataTable) |
| Kolom | Dibuat sendiri | **Otomatis** |
| Cocok untuk | Data sedikit & statis | Hampir semua kasus nyata |

> ⚠️ **Jangan dicampur:** setelah `DataSource` diisi, `Rows.Add` memicu `InvalidOperationException`.

## Cara 1: Array 2D → Grid (unbound)

Kolom dibuat di Designer (`Edit Columns`) atau lewat kode (`dgv.Columns.Add("Nim", "NIM")`). Array contoh ➕:

```vb
Private ReadOnly dataMahasiswa(,) As String = {
    {"231712001", "Andi Pratama", "Teknik Informatika", "2023", "3.45"},
    {"231712002", "Sari Wulandari", "Sistem Informasi", "2023", "3.8"},
    {"221712015", "Budi Santoso", "Teknik Informatika", "2022", "3.12"}
}
```

Kode dari slide:

```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    dgvMahasiswa.Rows.Clear()                                           ' cegah data dobel jika diklik 2×
    For i As Integer = 0 To dataMahasiswa.GetUpperBound(0)              ' baris
        Dim indeksBaris As Integer = dgvMahasiswa.Rows.Add()            ' tambah baris kosong, kembalikan index-nya
        For j As Integer = 0 To dataMahasiswa.GetUpperBound(1)          ' kolom
            dgvMahasiswa.Rows(indeksBaris).Cells(j).Value = dataMahasiswa(i, j)
        Next
    Next
    lblJumlah.Text = "Jumlah data: " & dgvMahasiswa.Rows.Count.ToString()
End Sub
```

Perulangan luar (`i`) = **baris**, dalam (`j`) = **kolom** (nested loop dari P4). `Rows.Add()` mengembalikan indeks baris baru.

**Keterbatasan Array** 🔑
1. **Semua String** → IPK tidak bisa langsung dihitung tanpa konversi.
2. **Ukuran tetap:** `ReDim Preserve` hanya bisa mengubah **dimensi terakhir** (kolom), padahal yang ingin ditambah adalah **baris**.
3. **Data disalin ke grid:** Array berubah, grid tidak ikut berubah.
4. `dataMahasiswa(i, 3)` itu angkatan atau IPK? **Nomor kolom mudah tertukar.**

## Cara 2a: Class + `List(Of T)` (bound) 🔑

**Satu baris = satu objek.** `Class` = cetakan; setiap `New Mahasiswa(...)` = satu objek = satu baris grid. **Setiap `Public Property` menjadi satu kolom.**

```vb
' Tambah: Project → Add → Class → Mahasiswa.vb
Public Class Mahasiswa
    Public Property Nim As String
    Public Property Nama As String
    Public Property Jurusan As String
    Public Property Angkatan As Integer
    Public Property Ipk As Decimal

    Public Sub New(nim As String, nama As String, jurusan As String, angkatan As Integer, ipk As Decimal)
        Me.Nim = nim
        Me.Nama = nama
        Me.Jurusan = jurusan
        Me.Angkatan = angkatan
        Me.Ipk = ipk
    End Sub
End Class
```

```vb
Private ReadOnly daftarMahasiswa As New List(Of Mahasiswa)

Private Sub FrmDariList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    daftarMahasiswa.Add(New Mahasiswa("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D))
    daftarMahasiswa.Add(New Mahasiswa("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D))
    daftarMahasiswa.Add(New Mahasiswa("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D))
    daftarMahasiswa.Add(New Mahasiswa("241712007", "Dimas Siregar", "Teknik Komputer", 2024, 2.95D))

    bsMahasiswa.DataSource = daftarMahasiswa           ' List -> BindingSource
    dgvMahasiswa.DataSource = bsMahasiswa              ' BindingSource -> DataGridView
    lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString()
End Sub
```

**Tidak ada perulangan.** Pola: **List → BindingSource (`bsMahasiswa`) → DataGridView.** Literal desimal pakai akhiran **`D`** (`3.45D`) supaya bertipe `Decimal`.

**Menambah data ke List**

```vb
Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    If Not ValidasiInput() Then Return
    Dim ipk As Decimal
    CobaDesimal(txtIpk.Text, ipk)
    Dim baru As New Mahasiswa(txtNim.Text, txtNama.Text.Trim(), cboJurusan.Text,
                              Integer.Parse(txtAngkatan.Text), ipk)
    ' Tambah lewat BindingSource, bukan daftarMahasiswa.Add, agar grid langsung diperbarui
    bsMahasiswa.Add(baru)
    lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString()
    BersihkanInput()
End Sub
```

> 🔑 `List(Of T)` **tidak memberi tahu grid** saat isinya berubah. `bsMahasiswa.Add` menambah ke List yang sama **sekaligus** memberi tahu grid. Terlanjur memakai `daftarMahasiswa.Add`? Panggil **`bsMahasiswa.ResetBindings(False)`**.

## Cara 2b: `DataTable` – tabel di memori 🔑

```vb
Private Function BuatTabelMahasiswa() As DataTable
    Dim tabel As New DataTable("Mahasiswa")
    ' Kolom: nama dan tipe data
    tabel.Columns.Add("Nim", GetType(String))
    tabel.Columns.Add("Nama", GetType(String))
    tabel.Columns.Add("Jurusan", GetType(String))
    tabel.Columns.Add("Angkatan", GetType(Integer))
    tabel.Columns.Add("Ipk", GetType(Decimal))
    ' Baris: urutan nilai mengikuti urutan kolom
    tabel.Rows.Add("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D)
    tabel.Rows.Add("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D)
    tabel.Rows.Add("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D)
    Return tabel
End Function

' Dipakai (pola yang sama):
Private ReadOnly tabelMahasiswa As DataTable = BuatTabelMahasiswa()
' di Form_Load:
bsMahasiswa.DataSource = tabelMahasiswa
dgvMahasiswa.DataSource = bsMahasiswa
```

Kolom punya **nama dan tipe** (`Columns.Add`). Baris diisi **sesuai urutan kolom** (`Rows.Add`); nilai tak cocok tipe kolom → **exception**.

## BindingSource: Perantara 🔑

```
Sumber Data  →  BindingSource  →  DataGridView
(List / DataTable)  (Filter, Sort, Count, Add, Current)  (menampilkan)
```

Analogi: **petugas meja layanan perpustakaan.** Rak buku (sumber data) tetap utuh; petugas menentukan buku mana yang ditunjukkan (**Filter**), urutannya (**Sort**), dan mencatat buku baru (**Add**). Pengunjung (grid) cukup berurusan dengan petugas. Sumber data diganti? Cukup ubah **satu baris**: `bsMahasiswa.DataSource = ...`.

BindingSource diambil dari Toolbox grup **Data**, prefix **`bs`**. Seperti ErrorProvider, tampil di **component tray**.

```vb
bsMahasiswa.Count               ' jumlah baris yang tampil
bsMahasiswa.Filter = "..."      ' hanya DataTable
bsMahasiswa.RemoveFilter()      ' tampilkan semua lagi
bsMahasiswa.Sort = "Ipk DESC"   ' hanya DataTable (➕)
bsMahasiswa.Current             ' objek/baris yang sedang dipilih (➕)
bsMahasiswa.RemoveCurrent()     ' hapus baris terpilih (➕)
bsMahasiswa.ResetBindings(False)
```

## Memilih sumber data 🔑

| Aspek | Array | List(Of T) + Class | DataTable |
|---|---|---|---|
| Ukuran | Tetap | Dinamis | Dinamis |
| Tipe per kolom | Satu tipe | Sesuai Property | Sesuai kolom |
| Mengisi grid | `Rows.Add` | `DataSource` | `DataSource` |
| Kolom grid | Dibuat sendiri | Otomatis | Otomatis |
| Urut lewat header | Ya (**sebagai teks**) | **Tidak** | Ya |
| `BindingSource.Filter` | Tidak | **Tidak (diabaikan)** | **Ya** |
| Cocok untuk | Data kecil, tetap | Data diolah di kode | Butuh filter dan sort |

> Array diurutkan lewat header sebagai teks → `"10"` ditempatkan **sebelum** `"9"`.

## Merapikan tampilan kolom

**Designer** (cukup diatur di Properties dgv): `ReadOnly`, `SelectionMode` (= `FullRowSelect`), `AllowUserToAddRows` (= **False**, kalau dibiarkan True ada baris kosong `*` ikut terhitung).

**Kode** — ditulis **setelah `DataSource` diisi** (kolom baru ada saat itu; kalau sebelum → `NullReferenceException`):

```vb
' Kolom dibuat otomatis saat DataSource diisi, jadi pengaturannya dilakukan sesudahnya
Private Sub AturKolom()
    dgvMahasiswa.Columns("Nim").HeaderText = "NIM"
    dgvMahasiswa.Columns("Ipk").HeaderText = "IPK"
    dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Format = "N2"       ' 3,80 bukan 3,8
    dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    dgvMahasiswa.Columns("Angkatan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dgvMahasiswa.Columns("Nama").FillWeight = 200                    ' kolom Nama lebih lebar
    dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
End Sub
```

**Properti kolom lain yang sering diminta** ➕

```vb
dgvX.Columns("Id").Visible = False                  ' sembunyikan kolom
dgvX.Columns("Nim").ReadOnly = True
dgvX.Columns("Nim").Width = 100
dgvX.Columns("Tanggal").DefaultCellStyle.Format = "dd/MM/yyyy"
dgvX.Columns("Harga").DefaultCellStyle.Format = "N0"             ' ribuan, tanpa desimal
dgvX.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray ' baris selang-seling
dgvX.RowHeadersVisible = False
dgvX.Rows(0).DefaultCellStyle.BackColor = Color.LightYellow      ' warnai baris tertentu
```

**Membaca baris yang dipilih** ➕

```vb
' Event klik sel
Private Sub dgvMahasiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMahasiswa.CellClick
    If e.RowIndex < 0 Then Return                       ' klik header
    txtNim.Text = dgvMahasiswa.Rows(e.RowIndex).Cells("Nim").Value.ToString()
    txtNama.Text = dgvMahasiswa.Rows(e.RowIndex).Cells("Nama").Value.ToString()
End Sub

' Atau baris yang sedang aktif
Dim nama As String = dgvMahasiswa.CurrentRow.Cells("Nama").Value.ToString()
```

## Pencarian data 🔑

### Pencarian 1: `BindingSource.Filter` (khusus **DataTable**)

```vb
Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
    Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
    If kata = "" Then
        bsMahasiswa.RemoveFilter()                       ' tampilkan semua data
    Else
        ' Ekspresi Filter milik DataTable, diproses di memori, bukan perintah SQL
        bsMahasiswa.Filter = "Nama LIKE '%" & kata & "%' OR Nim LIKE '%" & kata & "%'"
    End If
    PerbaruiJumlah()
End Sub
```

- `LIKE '%sari%'` = "mengandung sari". **Mirip SQL tetapi bukan SQL**: milik DataTable, diproses di memori.
- **Data asli tidak berubah**, baris yang tak cocok hanya **disembunyikan**.
- `AmankanTeksFilter` menangani `'` `[` `]` `*` `%` agar mencari nama seperti **Ma'ruf** tidak error.

Fungsi pembantu ➕ (versi slide tidak menampilkan isinya; ini versi buatan saya):

```vb
' Untuk teks di dalam LIKE '%...%'
Private Function AmankanTeksFilter(teks As String) As String
    Dim sb As New System.Text.StringBuilder()
    For Each c As Char In teks
        Select Case c
            Case "'"c
                sb.Append("''")                          ' kutip ganda
            Case "["c, "]"c, "*"c, "%"c
                sb.Append("[").Append(c).Append("]")     ' di-escape pakai kurung siku
            Case Else
                sb.Append(c)
        End Select
    Next
    Return sb.ToString()
End Function

' Untuk perbandingan sama dengan:  Kategori = '...'
Private Function AmankanKutip(teks As String) As String
    Return teks.Replace("'", "''")
End Function

Private Sub PerbaruiJumlah()
    lblJumlah.Text = "Menampilkan " & bsMahasiswa.Count.ToString() & " dari " &
                     tabelMahasiswa.Rows.Count.ToString() & " data"
End Sub
```

### Pencarian 2: Perulangan (untuk **List(Of T)**)

`Filter` pada List **diabaikan tanpa error** → buat pencarian sendiri: kumpulkan yang cocok ke List baru.

```vb
Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
    Dim kata As String = txtCari.Text.Trim().ToLower()
    Dim hasil As New List(Of Mahasiswa)
    For Each mhs As Mahasiswa In daftarMahasiswa
        If mhs.Nama.ToLower().Contains(kata) OrElse mhs.Nim.Contains(kata) Then
            hasil.Add(mhs)
        End If
    Next
    bsMahasiswa.DataSource = hasil
    lblJumlah.Text = "Menampilkan " & hasil.Count.ToString() & " dari " &
                     daftarMahasiswa.Count.ToString() & " data"
End Sub
```

**Filter atau Perulangan?**

| Aspek | `BindingSource.Filter` | Perulangan `For Each` |
|---|---|---|
| Sumber data | DataTable | List(Of T) |
| Panjang kode | Pendek, satu ekspresi | Lebih panjang |
| Kondisi pencarian | Terbatas sintaks ekspresi | Bebas, apa pun di `If` |
| Karakter khusus | Harus diamankan | Tidak perlu |
| Data asli | Tidak berubah | Tidak berubah |
| Urut lewat header | Tetap bekerja | Tidak |

Keduanya bekerja **di memori**, pada data yang **sudah dimuat** ke aplikasi.

### Variasi filter DataTable ➕

```vb
bsMahasiswa.Filter = "Angkatan = 2023"                              ' angka: tanpa kutip
bsMahasiswa.Filter = "Jurusan = 'Sistem Informasi'"                 ' teks: pakai kutip tunggal
bsMahasiswa.Filter = "Ipk >= 3.5"                                   ' desimal pakai titik
bsMahasiswa.Filter = "Angkatan = 2023 AND Ipk >= 3.5"               ' AND / OR
bsMahasiswa.Filter = "Jurusan = 'Teknik Informatika' AND (Nama LIKE '%a%' OR Nim LIKE '%a%')"
bsMahasiswa.Sort   = "Ipk DESC"                                     ' urut menurun
bsMahasiswa.Sort   = "Jurusan ASC, Nama ASC"                        ' dua kunci
```

> `LIKE` hanya untuk kolom **teks**. Untuk kolom angka (mis. `Angkatan`) pakai `=`, `>`, `<`.

## Kesalahan umum P8 🔑

1. `Rows.Add` pada grid yang memakai `DataSource` → `InvalidOperationException`.
2. `Rows.Add` pada grid **tanpa kolom** → `InvalidOperationException`.
3. `Columns("...")` diatur **sebelum** `DataSource` diisi → `NullReferenceException`.
4. `daftar.Add` tanpa `bsMahasiswa.Add` atau `ResetBindings` → grid tidak berubah.
5. `Filter` pada BindingSource bersumber **List** → diabaikan tanpa error.
6. Tanda kutip tidak diamankan → error saat mencari `Ma'ruf`.
7. `List(Of String)` sebagai `DataSource` → hanya muncul kolom **`Length`** (String tidak punya Public Property selain itu; pakai Class).
8. `AllowUserToAddRows` dibiarkan **True** → baris kosong `*` ikut terhitung.

## Kalau soal minta … → ubah …

| Soal minta | Ubah |
|---|---|
| Tambah kolom baru (mis. Email) | Class: tambah `Public Property Email As String` + parameter `New`; DataTable: `Columns.Add("Email", GetType(String))` + nilai di `Rows.Add` |
| Ganti sumber List → DataTable | Ubah satu baris `bsX.DataSource = tabelX` (+ Filter jadi aktif) |
| Cari berdasarkan kolom lain | Ganti nama kolom di ekspresi `LIKE` / syarat `If` |
| Cari berdasarkan jurusan (ComboBox) | `bsX.Filter = "Jurusan = '" & AmankanKutip(cboJurusan.Text) & "'"` |
| Tampilkan jumlah hasil pencarian | `bsX.Count` |
| Total / rata-rata dari baris yang tampil | Loop `bsX.List` (lihat template P8) |
| Hapus baris terpilih | `bsX.RemoveCurrent()` |
| Format IPK 2 desimal | `Columns("Ipk").DefaultCellStyle.Format = "N2"` |
| Sembunyikan kolom | `Columns("Nim").Visible = False` |
| Urutkan data | DataTable: `bsX.Sort = "Ipk DESC"`; List: `daftar.OrderByDescending(Function(m) m.Ipk).ToList()` ➕ |

---

<a id="tugas7"></a>
# 🧪 Template Tugas P7: Form Peminjaman Buku

**Kasus:** perpustakaan mencatat peminjaman buku tanpa salah isi.

1. `ValidasiInput()` dengan ErrorProvider: **kode BK + 4 digit**, judul, kategori, nama **minimal 3 karakter**, lama pinjam **1 sampai 14 hari** (TryParse).
2. Buku yang **sedang dipinjam tidak bisa dipinjam lagi**.
3. **Pinjam:** tambah ke ListBox beserta **tanggal kembali**.
4. **Bersihkan:** kosongkan isian dan ikon error.
5. **Ekspor CSV:** `Try…Catch…Finally`, Catch `IOException` dan `UnauthorizedAccessException`.

> Template ➕ buatan saya mengikuti gaya slide P7. Nama kontrol (sesuai naming convention):
> `txtKode`, `txtJudul`, `cboKategori`, `txtNama`, `txtLama`, `btnPinjam`, `btnBersihkan`, `btnEkspor`, `lstPinjam`, `lblStatus`, `errInput` (ErrorProvider).

```vb
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmPeminjaman

    ' Kode buku yang SEDANG dipinjam (untuk aturan no. 2)
    Private ReadOnly bukuDipinjam As New HashSet(Of String)

    Private ReadOnly lokasiEkspor As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "peminjaman.csv")

    Private Sub frmPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboKategori.Items.AddRange(New String() {"Fiksi", "Sains", "Teknologi", "Sejarah"})
        lblStatus.Text = "Siap."
    End Sub

    ' ---------- 1 & 2. VALIDASI ----------
    Private Function ValidasiInput() As Boolean
        errInput.Clear()
        Dim valid As Boolean = True

        ' Kode: BK + 4 digit; tidak boleh sedang dipinjam
        Dim kode As String = txtKode.Text.Trim().ToUpper()
        If Not Regex.IsMatch(kode, "^BK[0-9]{4}$") Then
            errInput.SetError(txtKode, "Kode harus BK diikuti 4 digit, mis. BK0012.")
            valid = False
        ElseIf bukuDipinjam.Contains(kode) Then
            errInput.SetError(txtKode, "Buku ini sedang dipinjam.")
            valid = False
        End If

        ' Judul wajib
        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errInput.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If

        ' Kategori harus dipilih
        If cboKategori.SelectedIndex = -1 Then
            errInput.SetError(cboKategori, "Pilih kategori.")
            valid = False
        End If

        ' Nama peminjam minimal 3 karakter
        If txtNama.Text.Trim().Length < 3 Then
            errInput.SetError(txtNama, "Nama minimal 3 karakter.")
            valid = False
        End If

        ' Lama pinjam 1–14 (tipe dulu, baru rentang)
        Dim lama As Integer
        If Not Integer.TryParse(txtLama.Text, lama) OrElse lama < 1 OrElse lama > 14 Then
            errInput.SetError(txtLama, "Lama pinjam harus angka 1 sampai 14 hari.")
            valid = False
        End If

        Return valid
    End Function

    ' ---------- 3. PINJAM ----------
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah."
            Return
        End If

        Dim kode As String = txtKode.Text.Trim().ToUpper()
        Dim lama As Integer = Integer.Parse(txtLama.Text)               ' pasti berhasil (sudah divalidasi)
        Dim tglKembali As Date = Date.Today.AddDays(lama)

        lstPinjam.Items.Add(kode & " | " & txtJudul.Text.Trim() & " | " & cboKategori.Text & " | " &
                            txtNama.Text.Trim() & " | " & tglKembali.ToString("dd/MM/yyyy"))
        bukuDipinjam.Add(kode)
        lblStatus.Text = "Buku " & kode & " dipinjam. Kembali: " & tglKembali.ToString("dd/MM/yyyy")
        BersihkanIsian()
    End Sub

    ' ---------- 4. BERSIHKAN ----------
    Private Sub BersihkanIsian()
        txtKode.Clear() : txtJudul.Clear() : txtNama.Clear() : txtLama.Clear()
        cboKategori.SelectedIndex = -1
        errInput.Clear()
        txtKode.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanIsian()
        lblStatus.Text = "Isian dibersihkan."
    End Sub

    ' ---------- 5. EKSPOR CSV ----------
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasiEkspor)
            penulis.WriteLine("Kode;Judul;Kategori;Peminjam;TglKembali")        ' header
            For Each baris As Object In lstPinjam.Items
                penulis.WriteLine(baris.ToString().Replace(" | ", ";"))
            Next
            lblStatus.Text = "Data diekspor ke " & lokasiEkspor
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Tidak punya izin menulis ke lokasi ini." & vbCrLf & ex.Message, "Ekspor Gagal")
        Catch ex As IOException
            MessageBox.Show("File sedang dipakai program lain atau tidak bisa ditulis." & vbCrLf & ex.Message,
                            "Ekspor Gagal")
        Finally
            If penulis IsNot Nothing Then penulis.Close()                      ' file selalu ditutup
        End Try
    End Sub

End Class
```

**Variasi yang mungkin diminta:**

| Soal minta | Ubah |
|---|---|
| Kode format `BUK-001` | `"^BUK-[0-9]{3}$"` |
| Maks. pinjam 7 hari | `lama > 7` dan pesan error |
| Tombol "Kembalikan" | `bukuDipinjam.Remove(kode)` + hapus baris ListBox (`lstPinjam.Items.RemoveAt(lstPinjam.SelectedIndex)`) |
| Tampilkan denda | `Dim telat As Integer = (Date.Today - tglKembali).Days : If telat > 0 Then denda = telat * 1000` |
| Pisah dengan koma, bukan `;` | `.Replace(" | ", ",")` |
| Dialog pilih lokasi simpan | `SaveFileDialog1.Filter = "CSV|*.csv"` lalu `If SaveFileDialog1.ShowDialog() = DialogResult.OK Then ... SaveFileDialog1.FileName` |

---

<a id="tugas8"></a>
# 🧪 Template Tugas P8: Inventaris Buku

**Kasus:** inventaris buku perpustakaan dalam satu form, **data di DataTable tanpa database.**

1. `dgvBuku` diatur di Designer; `tabelBuku` **minimal 10 buku** tampil lewat `bsBuku`.
2. Kolom dirapikan **setelah DataSource diisi**.
3. Tambah buku dengan validasi gaya Pertemuan 7; **kode buku harus unik**.
4. Pencarian gabungan: **teks (judul/penulis) + kategori dalam satu Filter**.
5. `lblJumlah` dan `lblTotalStok` dihitung dari **baris yang tampil**.

> Template ➕ buatan saya. Kontrol: `dgvBuku`, `bsBuku` (BindingSource), `errInput`, `txtKode`, `txtJudul`, `txtPenulis`, `cboKategori`, `txtStok`, `btnTambah`, `txtCari`, `cboKategoriCari`, `lblJumlah`, `lblTotalStok`.
> Designer `dgvBuku`: `ReadOnly = True`, `SelectionMode = FullRowSelect`, `AllowUserToAddRows = False`.

```vb
Imports System.Text.RegularExpressions

Public Class frmInventaris

    Private ReadOnly tabelBuku As New DataTable("Buku")
    Private ReadOnly daftarKategori As String() = {"Fiksi", "Sains", "Teknologi", "Sejarah"}

    ' ---------- 1. DATA & TAMPIL ----------
    Private Sub frmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Struktur tabel
        tabelBuku.Columns.Add("Kode", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Stok", GetType(Integer))
        tabelBuku.PrimaryKey = {tabelBuku.Columns("Kode")}       ' → Rows.Contains(kode) untuk cek unik

        ' Minimal 10 data awal
        tabelBuku.Rows.Add("BK001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 5)
        tabelBuku.Rows.Add("BK002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 3)
        tabelBuku.Rows.Add("BK003", "Sapiens", "Yuval Noah Harari", "Sejarah", 4)
        tabelBuku.Rows.Add("BK004", "Clean Code", "Robert C. Martin", "Teknologi", 2)
        tabelBuku.Rows.Add("BK005", "Algoritma dan Pemrograman", "Rinaldi Munir", "Teknologi", 6)
        tabelBuku.Rows.Add("BK006", "Cosmos", "Carl Sagan", "Sains", 2)
        tabelBuku.Rows.Add("BK007", "Brief History of Time", "Stephen Hawking", "Sains", 3)
        tabelBuku.Rows.Add("BK008", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 7)
        tabelBuku.Rows.Add("BK009", "Database System Concepts", "Silberschatz", "Teknologi", 1)
        tabelBuku.Rows.Add("BK010", "Sejarah Indonesia Modern", "M.C. Ricklefs", "Sejarah", 4)

        ' Pola: DataTable -> BindingSource -> DataGridView
        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        AturKolom()                                   ' 2. SETELAH DataSource diisi

        cboKategori.Items.AddRange(daftarKategori)
        cboKategoriCari.Items.Add("Semua")
        cboKategoriCari.Items.AddRange(daftarKategori)
        cboKategoriCari.SelectedIndex = 0             ' "Semua"

        PerbaruiRingkasan()
    End Sub

    ' ---------- 2. RAPIKAN KOLOM ----------
    Private Sub AturKolom()
        dgvBuku.Columns("Kode").HeaderText = "Kode Buku"
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Penulis").FillWeight = 150
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    ' ---------- 3. TAMBAH + VALIDASI ----------
    Private Function ValidasiInput() As Boolean
        errInput.Clear()
        Dim valid As Boolean = True

        Dim kode As String = txtKode.Text.Trim().ToUpper()
        If Not Regex.IsMatch(kode, "^BK[0-9]{3,4}$") Then
            errInput.SetError(txtKode, "Kode format BK + 3-4 digit, mis. BK011.")
            valid = False
        ElseIf tabelBuku.Rows.Contains(kode) Then
            errInput.SetError(txtKode, "Kode buku sudah ada.")                 ' UNIK
            valid = False
        End If

        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errInput.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If
        If String.IsNullOrWhiteSpace(txtPenulis.Text) Then
            errInput.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If
        If cboKategori.SelectedIndex = -1 Then
            errInput.SetError(cboKategori, "Pilih kategori.")
            valid = False
        End If

        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text, stok) OrElse stok < 0 Then
            errInput.SetError(txtStok, "Stok harus bilangan bulat ≥ 0.")
            valid = False
        End If
        Return valid
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return
        tabelBuku.Rows.Add(txtKode.Text.Trim().ToUpper(), txtJudul.Text.Trim(), txtPenulis.Text.Trim(),
                           cboKategori.Text, Integer.Parse(txtStok.Text))      ' DataTable ikut bsBuku
        BersihkanInput()
        TerapkanFilter()                  ' agar hasil + ringkasan konsisten dengan filter aktif
    End Sub

    Private Sub BersihkanInput()
        txtKode.Clear() : txtJudul.Clear() : txtPenulis.Clear() : txtStok.Clear()
        cboKategori.SelectedIndex = -1
        errInput.Clear()
        txtKode.Focus()
    End Sub

    ' ---------- 4. PENCARIAN GABUNGAN (teks + kategori) ----------
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    Private Sub cboKategoriCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKategoriCari.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    Private Sub TerapkanFilter()
        Dim syarat As New List(Of String)

        Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
        If kata <> "" Then
            syarat.Add("(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')")
        End If

        If cboKategoriCari.SelectedIndex > 0 Then          ' index 0 = "Semua"
            syarat.Add("Kategori = '" & AmankanKutip(cboKategoriCari.Text) & "'")
        End If

        If syarat.Count = 0 Then
            bsBuku.RemoveFilter()
        Else
            bsBuku.Filter = String.Join(" AND ", syarat)   ' SATU Filter gabungan
        End If
        PerbaruiRingkasan()
    End Sub

    ' ---------- 5. RINGKASAN DARI BARIS YANG TAMPIL ----------
    Private Sub PerbaruiRingkasan()
        Dim totalStok As Integer = 0
        For Each drv As DataRowView In bsBuku.List         ' bsBuku.List = hanya baris yang lolos filter
            totalStok += CInt(drv("Stok"))
        Next
        lblJumlah.Text = "Menampilkan " & bsBuku.Count.ToString() & " dari " &
                         tabelBuku.Rows.Count.ToString() & " buku"
        lblTotalStok.Text = "Total stok: " & totalStok.ToString()
    End Sub

    ' ---------- PEMBANTU ----------
    Private Function AmankanTeksFilter(teks As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In teks
            Select Case c
                Case "'"c
                    sb.Append("''")
                Case "["c, "]"c, "*"c, "%"c
                    sb.Append("[").Append(c).Append("]")
                Case Else
                    sb.Append(c)
            End Select
        Next
        Return sb.ToString()
    End Function

    Private Function AmankanKutip(teks As String) As String
        Return teks.Replace("'", "''")
    End Function

End Class
```

**Variasi yang mungkin diminta:**

| Soal minta | Ubah |
|---|---|
| Tombol Hapus buku terpilih | `If bsBuku.Current IsNot Nothing Then bsBuku.RemoveCurrent() : PerbaruiRingkasan()` |
| Tambah kolom **Harga** | `Columns.Add("Harga", GetType(Decimal))`, isi di tiap `Rows.Add`, validasi `CobaDesimal`, format `"N0"` di `AturKolom` |
| Urut stok terbesar | `bsBuku.Sort = "Stok DESC"` |
| Hanya stok < 3 (stok menipis) | Tambah ke `syarat`: `"Stok < 3"` (kolom angka → tanpa kutip) |
| Total nilai (harga × stok) | `total += CDec(drv("Harga")) * CInt(drv("Stok"))` |
| Ubah stok buku terpilih | `Dim drv = CType(bsBuku.Current, DataRowView) : drv("Stok") = CInt(drv("Stok")) + 1` |
| Ganti ke `List(Of Buku)` | Buat Class `Buku`, `bsBuku.DataSource = daftarBuku`; Filter **tidak jalan** → pakai `For Each` (lihat P8 *Pencarian 2*) |
| Pencarian tanpa "Semua" | Pakai `cboKategoriCari.Text <> ""` bukan `SelectedIndex > 0` |

---

<a id="checklist"></a>
# ✅ Checklist Sebelum Run

- [ ] Nama kontrol di kode **sama persis** dengan `(Name)` di Designer (huruf besar-kecil tidak jadi masalah di VB, ejaan iya).
- [ ] `Handles namaKontrol.Event` pada setiap event Sub benar.
- [ ] `Imports` ada di **paling atas** file (sebelum `Public Class`): `System.IO`, `System.Globalization`, `System.Text.RegularExpressions`, `Npgsql`.
- [ ] Variabel **level-form** (`daftarNim`, `tabelBuku`, `bukuDipinjam`) dideklarasikan **di luar** Sub (di dalam Class), bukan di dalam Sub.
- [ ] Input dikonversi pakai **`TryParse`**, bukan `Val`/`CInt` mentah.
- [ ] `DataSource` diisi **sebelum** mengatur `Columns("...")`.
- [ ] `AllowUserToAddRows = False`, `ReadOnly = True` jika grid hanya tampilan.
- [ ] Tidak mencampur `Rows.Add` dengan `DataSource`.
- [ ] Loop punya **update variabel** (`i += 1`) dan kondisi berhenti.
- [ ] `Items.Clear()` / `Rows.Clear()` sebelum mengisi ulang agar tidak dobel.
- [ ] Tombol diklik **dua kali** pun aman.
- [ ] Class ditambahkan lewat *Add → Class*, Module lewat *Add → Module*.

---

<a id="error"></a>
# 🛠️ Tabel Error → Penyebab → Solusi

| Pesan / gejala | Penyebab | Solusi |
|---|---|---|
| Garis bergelombang merah di kode | Syntax error / nama salah | Arahkan kursor, baca pesan; cek ejaan nama kontrol & Imports |
| `'Handles' clause requires a WithEvents variable` | Nama kontrol di `Handles` tidak ada | Samakan dengan `(Name)` kontrol |
| `InvalidCastException: Conversion from string "abc"` | `CInt`/`CDbl` pada teks bukan angka | Ganti `TryParse` |
| `FormatException` | `Integer.Parse("abc")` | `TryParse` atau `Try…Catch FormatException` |
| `OverflowException` | Angka melebihi tipe data | `Long`, atau batasi rentang |
| `DivideByZeroException` | Bilangan bulat dibagi 0 | `If b = 0 Then ... Return` |
| `IndexOutOfRangeException` | Index array > `Length-1` | Loop `0 To a.Length - 1`; ingat `Dim a(4)` = 5 elemen |
| `ArgumentOutOfRangeException` | Index `List` di luar `Count` | Cek `index < lst.Count` |
| `NullReferenceException` | Objek `Nothing` / `Columns("x")` sebelum DataSource | `New` dulu; atur kolom setelah `DataSource` |
| `KeyNotFoundException` | `dict("kunci")` tak ada | `ContainsKey` / `TryGetValue` |
| `ArgumentException: An item with the same key` | `dict.Add` key kembar | `dict(key) = nilai` atau cek `ContainsKey` |
| `InvalidOperationException` saat `Rows.Add` | Grid bound ke `DataSource`, atau grid tanpa kolom | Pilih satu cara: manual **atau** DataSource; buat kolom dulu |
| Grid tidak berubah setelah `list.Add` | List tidak memberi tahu grid | `bsX.Add(obj)` atau `bsX.ResetBindings(False)` |
| Filter tidak berpengaruh | Sumber List (bukan DataTable) | Ganti ke DataTable atau pakai loop |
| `EvaluateException` / `SyntaxErrorException` di Filter | Kutip tidak diamankan / `LIKE` pada kolom angka | `AmankanTeksFilter`; hanya `LIKE` untuk teks |
| Grid List(Of String) hanya kolom `Length` | String tidak punya property berguna | Pakai Class dengan `Public Property` |
| `IOException: being used by another process` | File CSV sedang terbuka (Excel) | Tutup file; `Catch IOException` + `Finally Close()` |
| `UnauthorizedAccessException` | Tak punya izin menulis | Pilih folder lain (Desktop/Documents) |
| IPK `3.75` terbaca `375` | Pengaturan desimal Windows (koma/titik) | `CobaDesimal` (Replace koma→titik + InvariantCulture) |
| Loop tidak berhenti | Variabel kondisi tak diubah | `i += 1` / perbaiki arah kondisi |
| Data dobel saat tombol diklik 2× | Tidak dikosongkan dulu | `Items.Clear()` / `Rows.Clear()` di awal |
| Ikon merah ErrorProvider tidak hilang | Lupa `Clear()` / `SetError(ctrl, "")` | `errInput.Clear()` di awal `ValidasiInput` |

---

<a id="janggal"></a>
# ⚠️ Slide yang Janggal (Rangkuman)

Bagian ini penting kalau soal teori/praktik menyinggung hal di bawah.

| Slide | Yang tertulis | Yang benar di VB.NET |
|---|---|---|
| P2 – Properti | `Enable` | **`Enabled`** |
| P3 – Aritmatika | Modulus `%` | **`Mod`** |
| P3 – Penugasan | `%=` | Tidak ada; pakai `x = x Mod n` |
| P3 – Perbandingan | gambar `==` `!=` pada beberapa tabel C-style | **`=`** dan **`<>`** |
| P3 – Logika | `&&` `||` `!` pada ilustrasi | **`And/AndAlso`, `Or/OrElse`, `Not`** |
| P3 – Increment | `x++`, `++x`, `x--` | Tidak ada; **`x += 1`**, **`x -= 1`** |
| P3 – "Switch Statement" | istilah bahasa C | **`Select Case`** |
| P3 – "Operator Ternary" | istilah C | **`If(kondisi, nilaiTrue, nilaiFalse)`** |
| P4 – "Do While: kondisi dicek di akhir" | sintaks `Do While … Loop` | `Do While … Loop` cek **di awal**; cek **di akhir** = **`Do … Loop While`** |
| P5 – contoh array/koleksi | `Console.WriteLine` | Di WinForms: `MessageBox.Show` / `Label.Text` / `ListBox.Items.Add` |
| P1 | "Scrath" | **Scratch** |
| P8 – Filter | `LIKE`/`Filter` terlihat seperti SQL | Bukan SQL; ekspresi DataTable, hanya untuk **DataTable** |

---

> 💡 **Tips GitHub:** simpan file ini sebagai `README.md` di root repo. Di halaman repo, klik ikon **☰ (Outline)** di pojok kanan atas tampilan file untuk navigasi per bagian. Saat responsi, kombinasi **Ctrl+F** dengan kata kunci (mis. `Filter`, `TryParse`, `ReDim`, `Select Case`) paling cepat.

