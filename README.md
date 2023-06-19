## SITAKERU
SITAKERU adalah singkatan dari Sistem Tata Kelola Ruangan. SITAKERU merupakan hasil dari project UAS, saya mengambil studi kasus ini karena di kampus X pengelolaan ruangan masih dengan cara Konvensional, karena alasan itu saya terinspirasi untuk membuat Sistem Kelola Ruangan
### Fitur
1. CRUD Pengguna
2. CRUD Ruangan
3. CRUD Ketersediaan
4. CRUD Inventaris Ruangan
5. Login
### Teknologi yang dipakai
* IDE : Visual Studio 2010
* Bahasa : VB.NET
* Versi NET : 4.0
* Database Management System : MYSQL
* Lain Lain : 
  * MYSQL Connector ( Versi 6.9.11.0 )
### Cara Penggunaan
* Pastikan anda telah menginstall Xampp yang nantinya akan digunakan sebagai Database Server
1. Install mysql connector terlebih dahulu sesuaikan dengan versi mysql connector diatas
2. Buka terminal ketik " git clone https://github.com/hildanku/sitakeru.git sitakeru "
3. Pergi ke folder yang tadi kita clone lalu pilih file Project Sistem Tata Kelola Ruangan.sln
4. jika anda menggunakan versi 2019 keatas, maka akan keluar prompt bahwa anda harus upgrade, anda pilih yes
5. pergi ke Reference lalu klik kanan pilih Add Reference -> pilih Extensions -> Ceklis Mysql.Data
6. Jika sudah kita pergi ke Xampp lalu nyalakan Apache dan MYSQL 
7. Akses di browser alamat : localhost/phpmyadmin
8. Buat Database baru. untuk nama database bebas
9. Pilih database yang sudah dibuat tadi
10. Pilih Impor lalu pilih file .sql yang letaknya di folder sitakeru/Project Sistem Tata Kelola Ruangan/Database, jika sudah dipilih scroll halaman kebawah lalu pilih Import
11. Jika sudah terimport, kita ganti konfigurasi database di Visual Studionya
12. Pilih file Database.vb di Visual Studio
13. lalu pada baris 4 rubah parameter database=tatakelolaruangvb menjadi database=namadatabaseyangtadidibuat
14. Silahkan jalankan dengan cara mendebug atau menekan tombol F5
14. jika sudah, Selamat anda telah menggunakan sistem ini!

### Dokumentasi Foto
1. Login
![This is a alt text.](https://github.com/hildanku/sitakeru/blob/main/dokumentasi%20foto/sslogin.png "This is a sample image.")
2. Dashboard
![This is a alt text.](https://github.com/hildanku/sitakeru/blob/main/dokumentasi%20foto/dashboard.png "This is a sample image.")
3. Kelola User
![This is a alt text.](https://github.com/hildanku/sitakeru/blob/main/dokumentasi%20foto/user.png "This is a sample image.")
4. Kelola Ruang
![This is a alt text.](https://github.com/hildanku/sitakeru/blob/main/dokumentasi%20foto/ruang.png "This is a sample image.")
5. Kelola Ketersediaan
![This is a alt text.](https://github.com/hildanku/sitakeru/blob/main/dokumentasi%20foto/ketersediaan.png "This is a sample image.")
6. Kelola Inventaris
![This is a alt text.](https://github.com/hildanku/sitakeru/blob/main/dokumentasi%20foto/inventaris.png "This is a sample image.")
