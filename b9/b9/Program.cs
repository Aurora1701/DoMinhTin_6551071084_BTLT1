using System;

namespace b9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("MSSV:6551071084");
            Console.Write("Nhap ho va ten day du: ");
            s = Console.ReadLine();

            Console.WriteLine("Do dai chuoi: " + s.Length);
            Console.WriteLine("Chu HOA: " + s.ToUpper());
            Console.WriteLine("Chu thuong: " + s.ToLower());
            Console.WriteLine("Chuoi sau khi Trim: " + s.Trim());
            Console.WriteLine("Co chua tu Nguyen khong: " + s.Contains("Nguyen"));

            string[] tu = s.Split(' ');
            Console.WriteLine("Cac tu trong chuoi:");
            foreach (string item in tu)
            {
                if (item != "")
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Ghep lai bang dau -: " + String.Join("-", tu));
        }
    }
}