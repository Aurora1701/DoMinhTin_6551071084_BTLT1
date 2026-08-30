using System;

namespace testc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                int count = 0;

                Console.Write("Nhap so nguyen duong n (n <= 1000): ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 2)
                {
                    Console.WriteLine("Khong co so nguyen to nao nho hon hoac bang " + n);
                    return;
                }

                Console.Write("Cac so nguyen to tu 2 den " + n + " la: ");
                for (int i = 2; i <= n; i++)
                {
                    bool laNguyenTo = true;
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            laNguyenTo = false;
                            break;
                        }
                    }

                    if (laNguyenTo)
                    {
                        Console.Write(i + " ");
                        count++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Tong so luong tim duoc: " + count);
            }
            catch (FormatException)
            {
                Console.WriteLine("Gia tri nhap vao khong phai la so");
            }
        }
    }
}