using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag
{
    internal class EmpWageBuilderObjects
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        private string Company;
        private int empRatePerHr;
        private int numOfWorkingDays;
        private int MaxHrPerMonth;
        private int TotalEmpWage;



        public EmpWageBuilderObjects(string Company,  int empRatePerHr, int numOfWorkingDays, int MaxHrPerMonth)
        {
            this.Company = Company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.MaxHrPerMonth = MaxHrPerMonth;
        }
        public void CmputWage()
        {
            int empHr = 0, TotalEmHr = 0, TotalworkingDays = 0;
            while (TotalEmHr <= MaxHrPerMonth && TotalworkingDays < numOfWorkingDays)
            {
                TotalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHr = 4;
                        break;
                    case Is_Full_Time:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                TotalEmHr += empHr;
                Console.WriteLine("Dats" + TotalworkingDays + " Employee Hr " + empHr);

            }
            TotalEmpWage = TotalEmHr * this.empRatePerHr;
            Console.WriteLine("Total wage for Company " + this.Company + " is " + this.TotalEmpWage);
        }
        public string toString()
        {
            return "Total Employee Wage for Company: " + Company + " is:" + TotalEmpWage;
        }
    }
}
