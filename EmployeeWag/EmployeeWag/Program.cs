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
            int fullTime = 1;
            Random randobj = new Random();
            int checkPresent = randobj.Next(0, 2);
            Console.WriteLine("Random number=" + checkPresent);
            if (checkPresent == fullTime)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }

        }
     }
}