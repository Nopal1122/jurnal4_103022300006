using System;
using ProdukElektronik;

class program
{
    static void Main()
    {



        KodeProduk kodeProduk = new KodeProduk();


        Console.WriteLine("Masukkan nama produk elektronik:");
        string input = Console.ReadLine();
        string kode = kodeProduk.GetKodeProduk(input);


        Console.WriteLine($"Kode produk untuk '{input}' adalah: {kode}");

        FanLaptop fan = new FanLaptop();


        //state base


        Console.WriteLine($"State awal: {fan.GetCurrentState()}");

        fan.ChangeToTurbo();
        Console.WriteLine($"State saat ini: {fan.GetCurrentState()}");

        fan.ChangeToBalanced();
        Console.WriteLine($"State saat ini: {fan.GetCurrentState()}");

        fan.ChangeToTurbo();
        Console.WriteLine($"State saat ini: {fan.GetCurrentState()}");

        fan.ChangeToBalanced();
        Console.WriteLine($"State saat ini: {fan.GetCurrentState()}");

        fan.SetState(new QuietState());
        Console.WriteLine($"State akhir: {fan.GetCurrentState()}");



    }



}





 