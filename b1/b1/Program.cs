using System;

namespace b1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoTen;
            int tuoi;
            double chieuCao;
            float canNang;
            bool daTotNghiep;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap chieu cao (m): ");
            chieuCao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap can nang (kg): ");
            canNang = Convert.ToSingle(Console.ReadLine());

            Console.Write("Da tot nghiep (true/false): ");
            daTotNghiep = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n--- THONG TIN ---");
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Chieu cao: " + chieuCao + " m");
            Console.WriteLine("Can nang: " + canNang + " kg");
            Console.WriteLine("Da tot nghiep: " + daTotNghiep);
        }
    }
}