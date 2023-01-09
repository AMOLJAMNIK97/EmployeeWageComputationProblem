using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag
{
    class Program
    {
        public const int fullTime = 1;
        public const int PartTime = 2;
        public const int EmpRatePerHour = 20;
        public const int NumOf_Working_day = 20;
        public const int Working_Hrs_Month = 100;


        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int TotalEmpWage = 0;
            int TotalEmpHrs = 0;
            while (TotalEmpHrs <= Working_Hrs_Month && TotalEmpWage < NumOf_Working_day)
            {
                TotalEmpWage++;
                Random randobj = new Random();
                int checkPresent = randobj.Next(0, 3);
                Console.WriteLine("Random number=" + checkPresent);
                switch (checkPresent)
                {
                    case PartTime:
                        empHrs = 4;
                        break;
                    case fullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                TotalEmpHrs += empHrs;

                Console.WriteLine("Day :" + TotalEmpWage + "Employee Hrs:" + empHrs);
            }
            int TotalEmpwageHrs = TotalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Employee Wage :" + TotalEmpwageHrs);
        }
    }
}