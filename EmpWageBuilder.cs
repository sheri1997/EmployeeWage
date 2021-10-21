using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class EmpWageBuilder
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        private int noofcompany = 0;
        private CompanyEmpWage[] companyempwageArray;

       
        public EmpWageBuilder()
        {
            this.companyempwageArray = new CompanyEmpWage[5];
            
        }
        public void addCompanyEmpWage(string company,int emprateperhour,int noofworkingdays,int maxhourspermonth)
        {
            companyempwageArray[this.noofcompany] = new CompanyEmpWage(company, emprateperhour, noofworkingdays, maxhourspermonth);
            noofcompany++;
        }
        public void empwage()
        {
            for(int i=0;i<noofcompany;i++)
            {
                companyempwageArray[i].settotalempwage(this.empwage(this.companyempwageArray[i]));
                Console.WriteLine(this.companyempwageArray[i].ToString());
            }
        }
        private int empwage(CompanyEmpWage companyEmpWage)
        {
            int emphours = 0, totalemphours = 0, totalworkingdays = 0;
            while (totalemphours <= companyEmpWage.maxhourpermonth && totalworkingdays < companyEmpWage.noofworkingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
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
            return totalemphours * companyEmpWage.emprateperhour;
        }
    }
}
