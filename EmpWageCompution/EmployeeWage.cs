using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
    //using oops concept  Interface
    interface  IAttendanceCalculation
    {
        public void Attendance();
    }
    class Employee : IAttendanceCalculation
    {
        public void Attendance()
        {
           Console.WriteLine("Employee Attendance");
        }
    }
    class EmployeeWage :Employee , IAttendanceCalculation 
    {
        //constants,variables
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        int EmpHrs = 0;
        int EMP_RATE_PER_HRS = 20;
        int NUMBER_OF_WORKING_DAYS = 20;
        int MAX_HRS_IN_MONTH = 100;
        int TotalEmpHrs = 0;
        int TotalWorkingDays = 0;
        //using constructor
        public void Calculate(int EMP_RATE_PER_HRS, int NUMBER_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.EMP_RATE_PER_HRS = EMP_RATE_PER_HRS;
            this.NUMBER_OF_WORKING_DAYS = NUMBER_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
            //calculating maximum hours in month
            while (EmpHrs <= this.MAX_HRS_IN_MONTH && TotalWorkingDays <= this.NUMBER_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
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
                TotalEmpHrs = TotalEmpHrs + EmpHrs;
                Console.WriteLine("totalworkingdays" + TotalWorkingDays);
                Console.WriteLine("emphrs" + EmpHrs);
            }
            int Wage = EmpHrs * this.EMP_RATE_PER_HRS;
            Console.WriteLine("wage:" + Wage);

        }
    }
    
    
}
  

        
    

