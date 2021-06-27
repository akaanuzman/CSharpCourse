using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string centence = "My name is Ahmet Kaan";
            var result = centence.Length;
            Console.WriteLine(result);
            Console.WriteLine();
            var result1 = centence.Clone();
            centence = "Benim adım Ahmet Kaan";
            Console.WriteLine(result1);
            Console.WriteLine();
            bool result2 = centence.EndsWith("Kaan");
            bool result3 = centence.StartsWith("Benim");
            var result4 = centence.IndexOf("adım");
            var result5 = centence.IndexOf("adımm");
            var result6 = centence.IndexOf(" ");
            var result7 = centence.LastIndexOf(" ");
            var result8 = centence.Insert(0, "Merhaba, ");
            var result9 = centence.Substring(5);
            var result10 = centence.Substring(6);
            var result11 = centence.Substring(6,4);
            var result12 = centence.ToLower();
            var result13 = centence.ToUpper();
            var result14 = centence.Replace(" ", "-");
            var result15 = centence.Remove(5);
            var result16 = centence.Remove(5,5);
            Console.WriteLine(result4);
            Console.WriteLine();
            Console.WriteLine(result5);
            Console.WriteLine();
            Console.WriteLine(result6);
            Console.WriteLine();
            Console.WriteLine(result7);
            Console.WriteLine();
            Console.WriteLine(result8);
            Console.WriteLine();
            Console.WriteLine(result9);
            Console.WriteLine();
            Console.WriteLine(result10);
            Console.WriteLine();
            Console.WriteLine(result11);
            Console.WriteLine();
            Console.WriteLine(result12);
            Console.WriteLine();
            Console.WriteLine(result13);
            Console.WriteLine();
            Console.WriteLine(result14);
            Console.WriteLine();
            Console.WriteLine(result15);
            Console.WriteLine();
            Console.WriteLine(result16);



            //
            for (int i=0; i<5; i++)
            {
                Console.WriteLine();
            }
            string city = "Kütahya";
            string city1 = "Merkez";
            string result100 = city + city1;
            Console.WriteLine(result100);
            Console.WriteLine(String.Format("{0} {1}", city, city1));
            Console.WriteLine(String.Format(city + " " + city1));

            foreach (var key in city)
            {
                Console.WriteLine(key);
            }
        }
    }
}
