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
            const int IS_PRESENT = 1;
            int EMPHRS = 8;
            int EMP_RATE_PER_HRS = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                int Wage = EMPHRS * EMP_RATE_PER_HRS;
                Console.WriteLine("Employee is present wage :  " + Wage);
            }

            else
            {
                Console.WriteLine("Employee is absent wage :" + 0);
            }
        }
    }
}
  

        
    

