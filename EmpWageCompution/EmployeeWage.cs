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
        public void Calculate()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EmpHrs = 8;
            int EMP_RATE_PER_HRS = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;
            }
            int Wage = EmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("wage:" + Wage);
        }
    }
    
}
  

        
    

