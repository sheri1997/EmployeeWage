using System;

namespace Employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            int FullTimeEmployee = 1;
            Random random = new Random();
            int Check = random.Next(0, 2);//Random Number Generated
            if (Check == FullTimeEmployee)//if check=1
            {
                Console.WriteLine("Employee is Present");
            }
            else//if check=0
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
