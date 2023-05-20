# Aplikasi-Administrasi-Bengkel

Cara menjalankan :
1. Clone Repository ini dengan cara "git clone https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/".
2. setelah selsai, buka folder "AplikasiBengkelKu -> bin -> Debug". Akan terdapat file dengan nama "DatabaseBengkel.mdf".
3. Buka SQL Server Management Studio (SSMS), jika belum punya silahkan download(https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) dan install terlebih dahulu.
4. Setelah terbuka, import file "DatabaseBengkel" ke SSMS, dengan cara klik kanan Database lalu klik Attach 

![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/4cdb58d8-3f63-4d88-84b2-5c9a896eac5f)

5. Lalu klik Add dan cari "Databasebengkel.mdf" klik Ok dan OK

![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/c4da5366-2454-41cd-b672-2026d33f2b2c)

6. Setelah Terimport, maka silahkan buka folder "AplikasiBengkelKu -> bin -> Debug -> Output", dan install SetupAplikasiBengkelKu.exe.
7. Jika Sudah Selesai, Aplikasi sudah bisa digunakan.

**NOTE : LOGIN USERNAME = ADMIN, PASSWORD = 12345, dapat ditambah dan diubah melalui database tabel login**


# Error yang Sering Ada
**1. Error saat attach database** 

![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/9c0413d2-c36c-4309-924d-029b79c67edc)

# Problem Solving
**1. Buka Folder dimana menyimpan DatabaseBengkel.mdf, lalu klik kanan -> "properties -> security -> Edit", centang Full Control Lalu OK**

***"Lakukan Hal Yang Sama Pada File Bernama DatabaseBengkel_log.ldf"***

![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/5e91cfaa-b054-4358-a440-46b112728bbc), ![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/92f8bdcd-8b1b-44ec-a9bb-77b8fb5df360)


# Preview Tampilan 
![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/fc5e7c7b-8b49-4c8e-976f-6792c55bd94b)

![image](https://github.com/ravenusa/Aplikasi-Administrasi-Bengkel/assets/80948124/fbe33c47-70d8-4898-9bcd-6a3e4817da75)








