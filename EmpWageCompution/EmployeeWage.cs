﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUMBER_OF_WORKING_DAYS = 20;
        int EmpHrs = 0;
        int Wage = 0;
        int totalempwage = 0;
        //Employee wage for a month
        public void Employee()
        {
            for (int day = 0; day < NUMBER_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                Wage = EmpHrs * EMP_RATE_PER_HOUR;
                totalempwage = totalempwage + Wage;
                Console.WriteLine("wage:" + Wage);
            }
            Console.WriteLine(" totalempwage: " + totalempwage);
           
        }
    }
}
