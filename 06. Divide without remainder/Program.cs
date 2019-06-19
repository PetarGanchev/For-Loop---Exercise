using System;

namespace _06._Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int sumP = 0; 

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    p1++;
                }
                if (input % 3 == 0)
                {
                    p2++;
                }
                if (input % 4 ==0)
                {
                    p3++;
                }

            }
            sumP = p1 + p2 + p3;
            double p1per = (double)p1 / n * 100;
            double p2per = (double)p2 / n * 100;
            double p3per = (double)p3 / n * 100;

            Console.WriteLine($"{p1per:f2}%");
            Console.WriteLine($"{p2per:f2}%");
            Console.WriteLine($"{p3per:f2}%");
        }
    }
}
