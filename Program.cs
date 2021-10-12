using System;

namespace Employeewage
{
    class Program
    {
        public static int employeewage()//method to compute the Employee Wage.
        {
            const int PartTime = 1;
            const int FullTimeEmployee = 2;
            int WagePerHour = 20;
            int WorkingDays = 2;
            int TotalWorkingDays = 0;
            int HoursInaMonth = 100;
            int Hours = 0;
            int TotalEmpHours = 0;
            while (TotalEmpHours <= HoursInaMonth && TotalWorkingDays < WorkingDays)//condition to check wheather the limit has crossed 100 or not.
            {
                TotalWorkingDays++;//if not crossed then days which be incrimented.
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
                TotalEmpHours = TotalEmpHours + Hours;//the incrimented value will be added in the total hours worked.
            }
            int TotalWage = TotalEmpHours * WagePerHour;//final calcultion of the total wage.
            Console.WriteLine("Total Wage of The Employee is " + TotalWage);
            return TotalWage;
        }
        static void Main(string[] args)//main Method
        {
            employeewage();//refractor method to calculate the Total Wage
        }
    }
}
