import cv2

cap = cv2.VideoCapture(1)  # Gunakan indeks 1 karena ditemukan

if not cap.isOpened():
    print("Kamera tidak bisa dibuka.")
else:
    print("Kamera berhasil dibuka!")

    while True:
        ret, frame = cap.read()
        if not ret:
            print("Gagal mendapatkan frame.")
            break

        cv2.imshow("Webcam", frame)

        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

cap.release()
cv2.destroyAllWindows()
