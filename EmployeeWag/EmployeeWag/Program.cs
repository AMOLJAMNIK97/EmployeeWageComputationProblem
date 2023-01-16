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
            EmpWageBuilderObjects DMart = new EmpWageBuilderObjects("D'Mart", 20, 2, 10);
            EmpWageBuilderObjects Tata = new EmpWageBuilderObjects("Tata", 10, 4, 20);
            DMart.CmputWage();
            Console.WriteLine(DMart.toString());
            Tata.CmputWage();
            Console.WriteLine(Tata.toString());
            
        }
    }
}