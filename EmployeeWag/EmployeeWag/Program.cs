using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Employee Wage Calculation Program");
            WageComputation employeeComputation = new WageComputation(2);
            employeeComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeComputation.EmpWageCalculation("TATA");

            employeeComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            employeeComputation.EmpWageCalculation("MAHINDRA");

            Console.Write("Enter the name of the company you want to check the total wage : ");
            string name = Console.ReadLine();
            employeeComputation.DisplayWage(name);
        }
    }
}