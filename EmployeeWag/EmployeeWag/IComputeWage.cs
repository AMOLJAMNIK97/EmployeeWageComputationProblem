using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag
{
    internal interface IComputeWage
    {
        public void AddCompany(string COMPANY_NAME, int EMP_WAGE_PER_HR, int FULL_DAY_HR, int PART_TIME_HR, int MAX_WORKING_HR, int WORKING_DAYS_A_MONTH);
        public void EmpWageCalculation(string COMPANY_NAME);
    }
}
