using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, toplami, farki, carpimi, bolumu;
            Console.Write("Birinci Sayıyı Girin : ");

            s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Sayıyı Girin : ");

            s2 = Convert.ToDouble(Console.ReadLine());

            toplami = s1 + s2;

            farki = s1 - s2;

            carpimi = s1 * s2;

            bolumu = s1 / s2;

            Console.WriteLine("Sayıların Toplamı :", toplami);

            Console.WriteLine("Sayıların Farkı : ", farki);

            Console.WriteLine("Sayıların Çarpımı :",carpimi);

            Console.WriteLine("Sayıların Bölümü :",bolumu);

            Console.ReadKey();
        }
    }
}
