using System;

namespace Employeewage
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Relience", 10, 4, 20);
            empWageBuilder.empwage();
        }
    }
}
