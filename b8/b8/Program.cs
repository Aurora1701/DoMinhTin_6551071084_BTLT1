using System;

namespace testc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int tong = 0;
            int soChan = 0;
            int soLe = 0;
            Console.WriteLine("MSSV:6551071084");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap phan tu thu " + i + ": ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Toan bo mang: ");
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int max = a[0];
            int min = a[0];
            int viTriMax = 0;
            int viTriMin = 0;

            for (int i = 0; i < 10; i++)
            {
                tong = tong + a[i];

                if (a[i] > max)
                {
                    max = a[i];
                    viTriMax = i;
                }

                if (a[i] < min)
                {
                    min = a[i];
                    viTriMin = i;
                }

                if (a[i] % 2 == 0)
                {
                    soChan++;
                }
                else
                {
                    soLe++;
                }
            }

            double trungBinh = (double)tong / 10;

            Console.WriteLine("Tong: " + tong);
            Console.WriteLine("Trung binh: " + trungBinh);
            Console.WriteLine("Gia tri lon nhat: " + max + " tai vi tri " + viTriMax);
            Console.WriteLine("Gia tri nho nhat: " + min + " tai vi tri " + viTriMin);
            Console.WriteLine("So luong phan tu chan: " + soChan);
            Console.WriteLine("So luong phan tu le: " + soLe);

            Console.Write("Mang sau khi dao nguoc: ");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}