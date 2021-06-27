using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[25];
            //değer atama
            string[] names = { "Ahmet", "Kaan"};
            Console.WriteLine(names[0]+" "+names[1]);
            Console.WriteLine();
            for(int i=0; i<25; i++)
            {
                numbers[i] = 15;
                Console.WriteLine("Dongu calisti birinci sayilar : " + numbers[i]);
                numbers[i] = 55;
                Console.WriteLine("Dongu calisti ikinci sayilar : " + numbers[i]);
                Console.WriteLine();
            }
            
            //2 boyutlu diziler
            int[,] numbers2 = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            for(int u = 0; u < 3; u++)
            {
                for(int c=0; c<3; c++)
                {
                    Console.WriteLine(numbers2[u,c]);
                }
            }
            Console.ReadLine();
        }
    }
}
