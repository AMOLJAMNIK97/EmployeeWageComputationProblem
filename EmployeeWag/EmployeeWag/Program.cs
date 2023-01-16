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
            Employee employee =new Employee();
            employee.ComputEmWage("Dmart", 20, 25, 30);
            employee.ComputEmWage("Tata", 10, 4, 20);
        }
    }
}