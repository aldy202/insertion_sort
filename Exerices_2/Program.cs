using System;

namespace Exerices_2
{
    class Program
    {
        public decimal[] aldy = new decimal[63]; // Array untuk menyimpan IPK

        public decimal n; // Variabel untuk menyimpan jumlah IPK yang akan dimasukkan

        // Metode untuk memasukkan data IPK dari pengguna
        public void input()
        {
            while(true)
            {
                Console.Write("Masukan banyaknya IPK yang ingin dimasukan : ");
                string y = Console.ReadLine();
                n = Decimal.Parse(y);

                if (n <= 63)
                    break;
                else
                    Console.WriteLine("\n Maksimal jumlah IPK yang dimasukan 63");
            }

            Console.WriteLine("");
            Console.WriteLine("Masukan nilai IPK : ");
            Console.WriteLine("--------------------");
            // Meminta pengguna memasukkan nilai IPK sebanyak yang diminta
            for (int i = 1; i <= n; i++)
            {
                
                Console.Write("nilai IPK  = ");
                aldy[i] = Convert.ToDecimal(Console.ReadLine());

            }
        }
        // Metode untuk melakukan pengurutan (insertion sort) terhadap IPK
        public void insertion_sort()
        {
            int i, AF;
            decimal temp;
            for(i = 1; i<=n; i++)
            {
                temp = aldy[i];
                AF = i - 1;
                while(aldy[AF]>temp && AF >= 0)
                {
                    aldy[AF + 1] = aldy[AF];
                    AF--;
                }
                aldy[AF + 1] = temp;

            }

            
        }
        // Metode untuk menampilkan hasil pengurutan IPK
        public void OUT()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Nilai IPK yang terlah tersusun ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            for(int i = 1; i <= n; i++)
            {
                decimal a = aldy[i];
                Console.WriteLine(a);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Press any button");
            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            // Membuat objek dari kelas Program
            Program list = new Program();

            // Memanggil metode input untuk meminta pengguna memasukkan data IPK
            list.input();

            // Memanggil metode insertion_sort untuk mengurutkan IPK
            list.insertion_sort();

            // Memanggil metode OUT untuk menampilkan hasil pengurutan IPK
            list.OUT();
        }
    }
}
