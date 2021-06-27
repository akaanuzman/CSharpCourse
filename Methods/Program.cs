using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref kullanımı
            int a = 5;
            Console.WriteLine("Alan = "+alan(ref a));

            //out kullanımı
            double x, y=2.5;
            Console.WriteLine("m2 = " +m2Hesabi(out x, y));

            //parametre olarak dizi yollamak
            Console.WriteLine("Sayilar = " + diziYolla(1, 2, 3, 4, 5, 6, 7));

            Console.ReadLine();
        }
        static int alan(ref int a,int b=10)
        {
            a = 10;
            return a * b;
        }

        static double m2Hesabi(out double x,double y)
        {
            x = 2.5;
            return x * y;
        }
        
        static int diziYolla(params int[] numbers)
        {
            // sum fonksiyonu sayıları toplamaya yaran fonskiyondur.
            return numbers.Sum();
        }

    }

}
