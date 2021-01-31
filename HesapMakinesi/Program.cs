using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hesap Makinesi
            double sayi1, sayi2;
            

            Console.WriteLine("*** Dört İşlem***");

            Console.Write("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem giriniz(\"+\",\" -\",\" *\",\" /\"): ");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "+":
                    Console.WriteLine("Toplama= " + (sayi1 + sayi2));
                    break;

                case "-":
                    Console.WriteLine("Çıkartma= " + (sayi1 - sayi2));
                    break;

                case "*":
                    Console.WriteLine("Çarpma= " + (sayi1 * sayi2));
                    break;

                case "/":
                    Console.WriteLine("Bölme= " + (sayi1 / sayi2));
                    break;
            }


            










            Console.ReadLine();

            

            

            #endregion
        }
    }
}
