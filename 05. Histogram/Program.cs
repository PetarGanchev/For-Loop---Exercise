using System;

namespace _05._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int sumP = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 200)
                {
                    p1++;
                }
                else if (200 <= input && input < 400)
                {
                    p2++;
                }
                else if (400 <= input && input < 600)
                {
                    p3++;
                }
                else if (600 <= input && input < 800)
                {
                    p4++;
                }
                else if (800 <= input)
                {
                    p5++;
                }
            }

            sumP = p1 + p2 + p3 + p4 + p5;
            double p1percent = (double)p1 / n * 100;
            double p2percent = (double)p2 / n * 100;
            double p3percent = (double)p3 / n * 100;
            double p4percent = (double)p4 / n * 100;
            double p5percent = (double)p5 / n * 100;

            Console.WriteLine($"{p1percent:f2}%");
            Console.WriteLine($"{p2percent:f2}%");
            Console.WriteLine($"{p3percent:f2}%");
            Console.WriteLine($"{p4percent:f2}%");
            Console.WriteLine($"{p5percent:f2}%");
        }
    }
}
