using System;

namespace b6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("MSSV:6551071084");
            do
            {
                Console.Write("Nhap so nguyen n (1-9): ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 1 || n > 9)
                {
                    Console.WriteLine("n phai nam trong khoang 1 den 9. Vui long nhap lai!");
                }
            } while (n < 1 || n > 9);

            Console.WriteLine("Bang cuu chuong " + n + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }
    }
}