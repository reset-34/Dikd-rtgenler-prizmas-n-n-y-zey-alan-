using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdörtgenler_prizmasının_yüzey_alanı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden kenarları girilen dikdörtgenler prizmasının yüzey alanını bulan C# programını yazınız.
                Formül:
                Yüzey alanı = 2*(a*b+a*c+b*c)            */


            Console.WriteLine("a kenarını girin");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("b kenarını girin");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("c kenarını girin");
            int c = Int32.Parse(Console.ReadLine());

            int yuzeyAlani = 2 * (a * b + a * c + b * c);
            Console.WriteLine("Dikdörtgenler prizmasının yüzey alanı  = " + yuzeyAlani);


            Console.ReadLine();
        }
    }
}
