using System;

namespace b3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal celsius, fahrenheit, kelvin;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap do C: ");
            celsius = Convert.ToDecimal(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;
            kelvin = celsius + 273.15m;

            Console.WriteLine("Fahrenheit: " + Math.Round(fahrenheit, 2) + " F");
            Console.WriteLine("Kelvin: " + Math.Round(kelvin, 2) + " K");
        }
    }
}