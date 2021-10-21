using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    public class CompanyEmpWage
    {
        public string company;
        public int emprateperhour;
        public int noofworkingdays;
        public int maxhourpermonth;
        public int totalempwage;
        public CompanyEmpWage(string company,int emprateperhour,int noofworkingdays,int maxhourspermonth)
        {
            this.company = company;
            this.emprateperhour = emprateperhour;
            this.noofworkingdays = noofworkingdays;
            this.maxhourpermonth = maxhourpermonth;

        }
        public void settotalempwage(int totalempwage)
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "Total Employee Wage for Company:" + this.company + "is" + this.totalempwage;
        }
    }
}
