using System;

namespace b7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long tong = 0;
            long tongChan = 0;
            long tongLe = 0;
            long giaiThua = 1;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap so nguyen duong n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                tong = tong + i;

                if (i % 2 == 0)
                {
                    tongChan = tongChan + i;
                }
                else
                {
                    tongLe = tongLe + i;
                }
            }

            int count = 1;
            while (count <= n)
            {
                giaiThua = giaiThua * count;
                count++;
            }

            Console.WriteLine("Tong 1 den n: " + tong);
            Console.WriteLine("Tong cac so chan: " + tongChan);
            Console.WriteLine("Tong cac so le: " + tongLe);
            Console.WriteLine("Tich 1 den n (giai thua): " + giaiThua);
        }
    }
}