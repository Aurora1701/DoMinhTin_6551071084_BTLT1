using System;

namespace b2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " * " + b + " = " + (a * b));

            if (b != 0)
            {
                Console.WriteLine(a + " / " + b + " = " + (a / b));
                Console.WriteLine("Chia lay nguyen: " + ((int)a / (int)b));
                Console.WriteLine("Chia lay du: " + ((int)a % (int)b));
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0");
            }

            Console.WriteLine(a + "^" + b + " = " + Math.Pow(a, b));
        }
    }
}