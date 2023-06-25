using System;
					
public class Program
{
// Method untuk operasi penambahan
public static double Tambah(double a, double b)
    {
        return a + b;
    }

    // Method untuk operasi pengurangan
public static double Kurang(double a, double b)
    {
        return a - b;
    }

    // Method untuk operasi perkalian
public static double Kali(double a, double b)
    {
        return a * b;
    }

    // Method untuk operasi pembagian
public static double Bagi(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Tidak bisa dibagi dengan nol!");
            return 0;
        }
        else
        {
            return a / b;
        }
    }

 public   static void Main()
    {
        // Menampilkan pilihan operasi yang tersedia
        Console.WriteLine("Pilih operasi.");
        Console.WriteLine("1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        // Meminta input dari pengguna
        Console.Write("Masukkan pilihan (1/2/3/4): ");
        string pilihan = Console.ReadLine();

        Console.Write("Masukkan bilangan pertama: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan bilangan kedua: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Memanggil method yang sesuai untuk melakukan operasi
        switch (pilihan)
        {
            case "1":
                Console.WriteLine("{0} + {1} = {2}", num1, num2, Tambah(num1, num2));
                break;

            case "2":
                Console.WriteLine("{0} - {1} = {2}", num1, num2, Kurang(num1, num2));
                break;

            case "3":
                Console.WriteLine("{0} * {1} = {2}", num1, num2, Kali(num1, num2));
                break;

            case "4":
                Console.WriteLine("{0} / {1} = {2}", num1, num2, Bagi(num1, num2));
                break;

            default:
                Console.WriteLine("Pilihan tidak valid");
                break;
        }

        // Menunggu user untuk menekan tombol enter sebelum menutup program
        Console.WriteLine("Tekan tombol Enter untuk keluar...");
        Console.ReadLine();

        //asdas
    }
}