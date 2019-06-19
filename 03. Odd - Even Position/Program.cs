using System;

namespace _03._Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = 0;
            double OddMax = 0;
            double EvenSum = 0;
            double EvenMin = 0;
            double EvenMax = 0;

            for (int i = 0; i < n; i++)
            {
                double currentInput = double.Parse(Console.ReadLine());
                if (i % 2 == 0)//odd
                {
                    if (i == 0)
                    {
                        OddMax = currentInput;
                        OddMin = currentInput;
                    }
                    if (OddMax < currentInput)
                    {
                        OddMax = currentInput;
                    }
                    if (OddMin > currentInput)
                    {
                        OddMin = currentInput;
                    }

                    OddSum += currentInput;
                }
                else
                {
                    if (i == 1)
                    {
                        EvenMax = currentInput;
                        EvenMin = currentInput;
                    }
                    if (EvenMax < currentInput)
                    {
                        EvenMax = currentInput;
                    }
                    if (EvenMin > currentInput)
                    {
                        EvenMin = currentInput;
                    }
                    EvenSum += currentInput;
                }
            }
            Console.WriteLine($"OddSum={OddSum:F2},");
            if (n < 1)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={OddMin:F2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            Console.WriteLine($"EvenSum={EvenSum:f2},");
            if (n < 2)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }
        }
    }
}
