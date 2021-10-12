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
            int WorkingDays = 2;
            int TotalWorkingDays = 0;
            int HoursInaMonth = 100;
            int Hours = 0;
            int TotalEmpHours = 0;
            while (TotalEmpHours <= HoursInaMonth && TotalWorkingDays < WorkingDays)
            {
                TotalWorkingDays++;
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
                TotalEmpHours = TotalEmpHours + Hours;
            }
            int TotalWage = TotalEmpHours * WagePerHour;
            Console.WriteLine("Total Wage of The Employee is " + TotalWage);
        }
    }
}
