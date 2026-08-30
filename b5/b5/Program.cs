using System;

namespace b5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dtb;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap diem trung binh: ");
            dtb = Convert.ToDouble(Console.ReadLine());

            if (dtb < 0 || dtb > 10)
            {
                Console.WriteLine("Diem khong hop le!");
            }
            else if (dtb >= 9.0)
            {
                Console.WriteLine("Xep loai: Xuat sac");
            }
            else if (dtb >= 8.0)
            {
                Console.WriteLine("Xep loai: Gioi");
            }
            else if (dtb >= 6.5)
            {
                Console.WriteLine("Xep loai: Kha");
            }
            else if (dtb >= 5.0)
            {
                Console.WriteLine("Xep loai: Trung binh");
            }
            else
            {
                Console.WriteLine("Xep loai: Yeu");
            }
        }
    }
}