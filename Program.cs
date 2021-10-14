using System;

namespace Employeewage
{
    class Program
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public static int empwage(string company,int emprateperhour,int noofwokingdays,int maxhourspermonth)
        {
            int emphours = 0, totalemphours = 0, totalworkingdays = 0;
            while(totalemphours<=maxhourspermonth && totalworkingdays<noofwokingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch(empcheck)
                {
                    case PartTime:
                        emphours = 8;
                        break;
                    case FullTime:
                        emphours = 16;
                        break;
                    default:
                        emphours = 0;
                        break;
                }
                totalemphours += emphours;
                Console.WriteLine("Day#" + totalworkingdays + "Emp Hrs" + emphours);
            }
            int totalempwage = totalemphours * emprateperhour;
            Console.WriteLine("Total employee Wage for the company" + company + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
            empwage("Dmart", 20, 2, 10);
            empwage("Reliance", 10, 4, 20);
        }
    }
}
