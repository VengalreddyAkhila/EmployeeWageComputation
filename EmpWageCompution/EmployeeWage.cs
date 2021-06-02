using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
<<<<<<< HEAD
     class EmployeeWage
    { 
         //constants
        public const int IS_FULL_TIME = 1;
        public  const int IS_PART_TIME = 2;
        public string Company;
        public int EMP_RATE_PER_HOUR;
        public int NUMBER_OF_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int Wage;
        public EmployeeWage(string Company, int EMP_RATE_PER_HOUR, int NUMBER_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUMBER_OF_WORKING_DAYS = NUMBER_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
=======
    //using oops concept  Interface
    interface  IAttendanceCalculation
    {
        public void Attendance();
    }
    class Employee : IAttendanceCalculation
    {
        public  void Attendance()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
>>>>>>> UC1-Attendance
        }

            public void ComputeEmpWage()
            {
                //variables
                int EmpHrs = 0;
                int TotalWorkingDays = 0;
                int TotalEmpHrs = 0;
                //calculating Hrs per month
                while (EmpHrs <= this.MAX_HRS_IN_MONTH && TotalWorkingDays <= this.NUMBER_OF_WORKING_DAYS)
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
                    Console.WriteLine("emphrs" + EmpHrs);
                }
                Wage = EmpHrs * this.EMP_RATE_PER_HOUR;
                Console.WriteLine("wage:" + Company + "is" +Wage );
            }
        public string Value()
        {
            return "total employee wage for company" + this.Company + " is" + this.Wage;
        }
                   
     }
    
}
  

        
    

