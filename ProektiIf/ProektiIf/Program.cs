using System;

namespace ProektiIf
{
    class Program
    {
        static void Main(string[] args)
        {
            var uspeh = double.Parse(Console.ReadLine());
            var dohod = double.Parse(Console.ReadLine());
            if (uspeh>=5.50)
            {
                Console.WriteLine("Stipendia za otlichen uspeh.");
            }
            else if (uspeh>=4.50 && dohod<=560)
            {
                Console.WriteLine("Socialna stipendia.");
            }
            else
            {
                Console.WriteLine("Ne poluchava stipendia");
            }
        }
    }
}
