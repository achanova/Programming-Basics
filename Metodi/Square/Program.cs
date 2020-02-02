using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double s = GetSquare(n);
            Console.WriteLine(s);

        }

        static double GetSquare(double num)
        {
            return num* num;
        }
    }
}
