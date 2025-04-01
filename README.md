### Deskripsi Repository
Proyek ini merupakan implementasi hand tracking dan finger counting menggunakan OpenCV dan MediaPipe. Program ini dapat mendeteksi hingga 10 tangan secara bersamaan dan menghitung jumlah jari yang terangkat.

#### Fitur Utama
1. Mendeteksi banyak tangan (hingga 10 tangan)
2. Menghitung jumlah jari yang terangkat secara real-time
3. Menggunakan MediaPipe untuk hand landmark detection
4. Menggunakan OpenCV untuk menangani kamera dan tampilan visual
5. Optimasi performa dengan threshold confidence detection

#### Cara Kerja
1. Program menangkap video dari kamera dan membaliknya agar lebih natural.
2. Gambar dikonversi ke format RGB untuk diproses oleh MediaPipe Hands.
3. Landmark tangan dideteksi dan dihubungkan menggunakan MediaPipe Drawing Utils.
4. Jari yang terangkat dihitung berdasarkan koordinat landmark.
5. Hasil deteksi ditampilkan di layar dengan OpenCV.

#### Nama Kelompok
1. Bagas Adi Sasongko | BagasAdi-11
2. Jihan Martha | jhnmartha