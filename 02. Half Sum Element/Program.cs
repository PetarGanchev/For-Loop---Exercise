using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < inputN; i++)
            {
                int currentInput = int.Parse(Console.ReadLine());
                sum += currentInput;

                if (i == 0)
                {
                    maxNumber = currentInput;
                }
                if (currentInput > maxNumber)
                {
                    maxNumber = currentInput;
                }
            }

            if (sum - maxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                int diff = Math.Abs(maxNumber - (sum - maxNumber));
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
