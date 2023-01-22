using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag
{
    internal class WageComputation: IComputeWage
    {
        const int IS_PRESENT = 0, WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4,
        IS_FULL_DAY_PRESENT = 0, IS_PART_TIME_PRESENT = 1, WORKING_DAYS_A_MONTH = 20;
        int empHrs, totalEmpHrs = 0, totalEmpWage = 0, empWage, totalWorkingDays;
        public Dictionary<string, Company> Comapnies = new Dictionary<string, Company>();
        //public string[] CompanyList;
        public ArrayList CompanyList;
        public int ArrayListIndex = 0;

        public WageComputation(int number)
        {
            //CompanyList = new string[number * 2];
            CompanyList = new ArrayList();
        }

        public void AddCompany(string COMPANY_NAME, int EMP_WAGE_PER_HR, int FULL_DAY_HR, int PART_TIME_HR, int MAX_WORKING_HR, int WORKING_DAYS_A_MONTH)
        {
            Company company = new Company(COMPANY_NAME.ToLower(), EMP_WAGE_PER_HR, FULL_DAY_HR, PART_TIME_HR, MAX_WORKING_HR, WORKING_DAYS_A_MONTH);
            Comapnies.Add(COMPANY_NAME.ToLower(), company);
            //CompanyList[ArrayIndex] = COMPANY_NAME;
            CompanyList.Add(COMPANY_NAME);
            //CompanyList.Add(WAGE_PER_HR * FULL_DAY_HR);
            ArrayListIndex++;
        }
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Not Present ");
            }
        }
        public void EmpWageCalculation(string COMPANY_NAME)
        {
            int monthlyWage = 0;
            if (!Comapnies.ContainsKey(COMPANY_NAME.ToLower()))
                throw new ArgumentNullException("Company doesn't exist ");
            Comapnies.TryGetValue(COMPANY_NAME.ToLower(), out Company company);

            for (int day = 0; day <= company.WORKING_DAYS_A_MONTH && empHrs <= company.MAX_WORKING_HR; day++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);

                switch (check)
                {
                    case IS_FULL_DAY_PRESENT:
                        empHrs = company.FULL_DAY_HR;
                        break;
                    case IS_PART_TIME_PRESENT:
                        empHrs = company.PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                int wagePerDay = company.EMP_WAGE_PER_HR * empHrs;
                //Console.WriteLine("Day : {0}  Emp Hours : {1}", day, empHrs);
                int totalEmpWage = totalEmpHrs * WAGE_PER_HR;
                monthlyWage += totalEmpWage;

            }
            //Console.WriteLine("\nCompany Name : " + COMPANY_NAME);
            //CompanyList[ArrayIndex] = Convert.ToString(monthlyWage);
            CompanyList.Add(monthlyWage);
            ArrayListIndex++;
            //Console.WriteLine("Monthly Wage Of Employee in {0} is {1}", COMPANY_NAME, monthlyWage);
        }
        public void DisplayWage()
        {
            for (int i = 0; i < CompanyList.Count; i += 2)
            {
                Console.WriteLine("Monthly Wage for {0} is {1} ", CompanyList[i], CompanyList[i + 1]);
            }
        }
    }
}
