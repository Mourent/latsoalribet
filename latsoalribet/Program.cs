using System;

namespace latsoalribet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT KALIMAT: ");
            string inputKalimat = Console.ReadLine();
            while (inputKalimat.Length < 4)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
                Console.Write("INPUT KALIMAT: ");
                inputKalimat = Console.ReadLine();
            }
            Console.Write("INPUT KATA: ");
            string inputKata = Console.ReadLine();
            while (inputKata.Length < 2)
            {
                Console.WriteLine("HURUF PADA KATA KURANG PANJANG");
                Console.Write("INPUT KATA: ");
                inputKata = Console.ReadLine();
            }
            Console.WriteLine("OUTPUT: \n\nSTATISTIK HURUF:");
            int counter = 0;
            char cekHuruf = '!';
            for (int i=0; i<100; i++)
            {
                int jumlahHuruf = inputKalimat.Split(cekHuruf).Length;
                if (counter == 5)
                {
                    Console.WriteLine();
                    counter = 0;
                }
                if (jumlahHuruf > 1)
                {
                    Console.WriteLine($"{cekHuruf}: {jumlahHuruf-1} HURUF");
                    counter++;
                }
                cekHuruf++;
            }
            Console.WriteLine();
            Console.WriteLine("STATISTIK KATA: ");
            int jumlahKata = inputKalimat.Split(inputKata).Length;
            Console.WriteLine($"{inputKata}: {jumlahKata - 1} KATA");
            Console.WriteLine();
            int jumlahSemuaHuruf = inputKalimat.Length - inputKalimat.Split(" ").Length + 1;
            Console.Write($"JUMLAH HURUF: {jumlahSemuaHuruf}");
        }
    }
}
