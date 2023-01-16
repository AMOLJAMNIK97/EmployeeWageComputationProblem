using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag
{
    public class Employee
    {
        public const int Is_Part_Time= 1;
        public const int Is_Full_Time= 2;
        public int ComputEmWage(string Company, int empRatePerHr, int numOfWorkingDays, int MaxHrPerMonth)
        {
            int empHr = 0, TotalEmHr = 0, TotalworkingDays = 0;
            while (TotalEmHr <=MaxHrPerMonth && TotalworkingDays <numOfWorkingDays ) 
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
                Console.WriteLine("Dats" + TotalworkingDays +" Employee Hr " + empHr );

            }
            int TotalEmpWage = TotalEmHr * empRatePerHr;
            Console.WriteLine("Total wage for Company " + Company + " is " + TotalEmpWage );
            return TotalEmpWage;
        }
    }
}
