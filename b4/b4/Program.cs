using System;

namespace b4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine(n + " la so duong");
            }
            else if (n < 0)
            {
                Console.WriteLine(n + " la so am");
            }
            else
            {
                Console.WriteLine(n + " bang 0");
            }

            if (n % 2 == 0)
            {
                Console.WriteLine(n + " la so chan");
            }
            else
            {
                Console.WriteLine(n + " la so le");
            }

            if (n % 3 == 0)
            {
                Console.WriteLine(n + " chia het cho 3");
            }
            else
            {
                Console.WriteLine(n + " khong chia het cho 3");
            }

            if (n % 2 == 0 && n % 3 == 0)
            {
                Console.WriteLine(n + " chia het cho ca 2 va 3");
            }
            else
            {
                Console.WriteLine(n + " khong chia het cho ca 2 va 3");
            }
        }
    }
}