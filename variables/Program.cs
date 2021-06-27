using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 100;
            double number2 = 100.1;
            short number3 = 1;
            long number4 = 100000;
            string name = "Ahmet Kaan";
            char charecter = 'A';
            float number5 = 1203.04f;
            var number7 = 10;
            number7 = charecter;
            // byte değişkeni 0-255 arasındaki değerleri tutar.
            byte number6 = 255;
            // decimal değişkeni karmaşık hesaplamalarda kullanılır.


            //Output syntax
            Console.WriteLine("Number1 is : " +number1);
            Console.WriteLine("Number1 is : {0}", number1);
            Console.WriteLine("Number2 is : " + number2);
            Console.WriteLine("Number2 is : {0}", number2);
            Console.WriteLine("Number3 is : " + number3);
            Console.WriteLine("Number3 is : {0}", number3);
            Console.WriteLine("Number4 is : " + number4);
            Console.WriteLine("Number4 is : {0}", number4);
            Console.WriteLine("Number5 is : " + number5);
            Console.WriteLine("Number5 is : {0}", number5);
            Console.WriteLine("Number6 is :" + number6);
            Console.WriteLine("Number6 is : {0}", number6);
            Console.WriteLine("Number7 is : " + number7);
            Console.WriteLine("Number7 is : {0}", number7);
            Console.WriteLine("Charecter is : " + charecter);
            Console.WriteLine("Charecter is : {0}", charecter);
            //değişken dönüşümü
            Console.WriteLine("Number8 is : " + (int)charecter);
            Console.WriteLine("Number8 is : {0}", (int)charecter);
            //
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My name is {0}", name);
            //enum sabiti kullanımı
            Console.WriteLine(Days.Monday);
            Console.WriteLine(Days.Tuesday);
            Console.WriteLine(Days.Wednesday);
            Console.WriteLine(Days.Thursday);
            Console.WriteLine(Days.Friday);
            Console.WriteLine(Days.Saturday);
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine((int)Days.Tuesday);
            Console.WriteLine((int)Days.Wednesday);
            Console.WriteLine((int)Days.Thursday);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine((int)Days.Saturday);
            Console.WriteLine((int)Days.Sunday);

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
