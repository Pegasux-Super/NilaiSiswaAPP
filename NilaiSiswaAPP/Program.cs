int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("input Nama: ");
nama = Console.ReadLine();

Console.Write("Input Nilai siswa: "); 
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("Selamat anda lulus!");

else Console.WriteLine("Maaf, Anda belum "); 