using System;

namespace _04._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isValue = false;
            int sum = 0;
            int maxdiff = 0;

            for (int i = 0; i < n; i++)
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                int currentSum = input1 + input2;
                if (i == 0)
                {
                    sum = currentSum;
                }
                if (sum == currentSum)
                {
                    isValue = true;
                }
                else
                {
                    isValue = false;
                }

                if ((sum - currentSum) != maxdiff)
                {
                    maxdiff = sum - currentSum;
                }
                sum = currentSum;
            }

            if (isValue)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(maxdiff)}");
            }
        }
    }
}
