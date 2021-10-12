using System;

namespace Employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            int PartTime = 1;
            int WagePerHour = 20;
            int Hours = 0;
            int Wage = 0;
            Random random = new Random();
            int Check = random.Next(0, 2);
            if (Check == PartTime)
            {
                Hours = 8;
            }
            else
            {
                Hours = 0;
            }
            Wage = Hours * WagePerHour;
            Console.WriteLine("Wage of The Part Time Employee is " + Wage);
        }
    }
}
