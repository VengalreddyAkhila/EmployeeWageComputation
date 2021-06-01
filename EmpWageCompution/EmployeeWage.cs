using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
    public class EmployeeWage
    {
        public void ComputeEmployeeWage()
        {
            //constants
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUMBER_OF_WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 100;
            //variables
            int EmpHrs = 0;
            int TotalWorkingDays = 0;
            int TotalEmpHrs = 0;
            //calculating Hrs per month
            while (EmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays <= NUMBER_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                //using switch case
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;
                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                //calculating total hrs
                TotalEmpHrs = TotalEmpHrs + EmpHrs;
                Console.WriteLine("totalworkingdays" + TotalWorkingDays);
                Console.WriteLine ("emphrs" + EmpHrs);
            }
                int Wage = EmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("wage:" + Wage);
                   
        }
    }
}
