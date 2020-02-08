using System;
using System.Linq;

namespace LadyBugs_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] field = new long[n];
            for (int i = 0; i < arr.Length; i++)
            {
                long k = arr[i];
                if(k>=0 && k<n) field[k] = 1;
            }
           
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] com = input.Split().ToArray();
                long index = long.Parse(com[0]);
                string direction = com[1];
                long l = long.Parse(com[2]);
                
                if ((index < 0 || index >= n || field[index] == 0)==false)
                       
                {
                    switch (direction)
                    {
                        case "right":
                            field[index] = 0;
                            index = index + l;
                            while (index < n && field[index] == 1)
                            {
                                index = index + l;

                            }
                            if (index < n) field[index] = 1;
                            break;
                        case "left":
                            field[index] = 0;
                            index = index - l;
                            while (index >= 0 && field[index] == 1)
                            {
                                index = index - l;

                            }
                            if (index >= 0) field[index] = 1;
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
