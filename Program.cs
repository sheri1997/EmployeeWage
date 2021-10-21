using System;

namespace Employeewage
{
    class Program
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        private string company;
        private int emprateperhour;
        private int noofworkingdays;
        private int maxhourpermonth;
        private int totalempwage;
        public Program(string company, int emprateperhour,int noofworkingdays,int maxhourpermonth)
        {
            this.company = company;
            this.emprateperhour = emprateperhour;
            this.noofworkingdays = noofworkingdays;
            this.maxhourpermonth = maxhourpermonth;
        }
        public void  empwage()
        {
            int emphours = 0, totalemphours = 0, totalworkingdays = 0;
            while(totalemphours<=this.maxhourpermonth && totalworkingdays<this.noofworkingdays)
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
            int totalempwage = totalemphours * this.emprateperhour;
            Console.WriteLine("Total employee Wage for the company" + company + totalempwage);
        }
        public string toString()
        {
            return "Total Employee Wage for Company:" + this.company + "is" + this.totalempwage;
        }
        static void Main(string[] args)
        {
            Program Dmart = new Program("Dmart", 20, 2, 20);
            Program Relience = new Program("Relience", 10, 4, 20);
            Dmart.empwage();
            Console.WriteLine(Dmart.toString());
            Relience.empwage();
            Console.WriteLine(Relience.toString());
        }
    }
}
