using System;

namespace _07._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Salary = int.Parse(Console.ReadLine());
            int salaryNew = Salary;

            for (int i = 0; i < n; i++)
            {
                string site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook": salaryNew -= 150; break;
                    case "Instagram": salaryNew -= 100; break;
                    case "Reddit": salaryNew -= 50; break;
                }
                if (salaryNew <= 0)
                {
                    break;
                }
            }
            if (salaryNew <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salaryNew);
            }
        }
    }
}
