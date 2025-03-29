### Deskripsi Repository
Proyek ini merupakan implementasi hand tracking dan finger counting menggunakan OpenCV dan MediaPipe. Program ini dapat mendeteksi hingga 10 tangan secara bersamaan dan menghitung jumlah jari yang terangkat.

#### Fitur Utama
✅ Mendeteksi banyak tangan (hingga 10 tangan)
✅ Menghitung jumlah jari yang terangkat secara real-time
✅ Menggunakan MediaPipe untuk hand landmark detection
✅ Menggunakan OpenCV untuk menangani kamera dan tampilan visual
✅ Optimasi performa dengan threshold confidence detection

#### Cara Kerja
Program menangkap video dari kamera dan membaliknya agar lebih natural.
Gambar dikonversi ke format RGB untuk diproses oleh MediaPipe Hands.
Landmark tangan dideteksi dan dihubungkan menggunakan MediaPipe Drawing Utils.
Jari yang terangkat dihitung berdasarkan koordinat landmark.
Hasil deteksi ditampilkan di layar dengan OpenCV.
