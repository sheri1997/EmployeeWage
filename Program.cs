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
            Console.WriteLine("Wage of The Part Time Employee is " + Wage);
        }
    }
}
