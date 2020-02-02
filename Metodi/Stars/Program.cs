using System;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStars(5);
            PrintStars(10);
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintStars(i);
            }

            Console.WriteLine();

            for (int i = 1; i <=n; i++)
            {
                PrintStars(n);
            }
        }


        static void PrintStars(int k)
        {
            for (int i = 1; i <=k; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
