using System;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            //намиране на m!+n!
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int f = Factoriel(n) + Factoriel(m);
            Console.WriteLine("f="+f);
        }

        static int Factoriel(int k)
        {
            int p = 1;
            for (int i=1; i<=k; i++)
                {
                p = p * i;
                }
            return p;
        }
    }
}
