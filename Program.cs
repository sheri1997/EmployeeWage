using System;

namespace Employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PartTime = 1;
            const int FullTimeEmployee = 2;
            int WagePerHour = 20;
            int Hours = 0;
            int Wage = 0;
            int MonthlyWage = 0;
            for (int day = 1; day <= 20; day++)
            {
                Random random = new Random();
                int Check = random.Next(0, 3);
                switch (Check)
                {
                    case PartTime:
                        Hours = 8;
                        break;
                    case FullTimeEmployee:
                        Hours = 16;
                        break;
                    default:
                        Hours = 0;
                        break;
                }
                Wage = Hours * WagePerHour;
                MonthlyWage = MonthlyWage + Wage;
            }
            Console.WriteLine("Monthly Wage of The Employee is " + MonthlyWage);
        }
    }
}
