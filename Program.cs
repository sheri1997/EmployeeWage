using System;

namespace Employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            int FullTimeEmployee = 1;
            int WagePerHour = 20;
            int Hours = 0;
            int Wage = 0;
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == FullTimeEmployee)
            {
                Hours = 8;
            }
            else
            {
                Hours = 0;
            }
            Wage = Hours * WagePerHour;
            Console.WriteLine("Wage of The Employee is " + Wage);
        }
    }
}
