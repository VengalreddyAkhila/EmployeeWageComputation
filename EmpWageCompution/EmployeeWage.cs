using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
    //using oops concept  Interface
    interface  IAttendanceCalculation
<<<<<<< HEAD
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
            int EmpHrs = 0;
            int EMP_RATE_PER_HRS = 20;
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
            int Wage = EmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("wage:" + Wage);
=======
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
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        int EmpHrs = 0;
        int EMP_RATE_PER_HRS = 20;
        int NUMBER_OF_WORKING_DAYS = 20;
        int totalempwage = 0;
        public void Calculate(int EMP_RATE_PER_HRS, int NUMBER_OF_WORKING_DAYS)
        {
            this.EMP_RATE_PER_HRS = EMP_RATE_PER_HRS;
            this.NUMBER_OF_WORKING_DAYS = NUMBER_OF_WORKING_DAYS;
            for (int day = 0; day < this.NUMBER_OF_WORKING_DAYS; day++)
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
                int Wage = EmpHrs * this.EMP_RATE_PER_HRS;
                totalempwage =  totalempwage + Wage;
                Console.WriteLine("wage:" + Wage);
            }
                Console.WriteLine(" totalempwage: " + totalempwage);
>>>>>>> UC5-WagesForMonth
        }
    }
    
    
}
  

        
    

