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
