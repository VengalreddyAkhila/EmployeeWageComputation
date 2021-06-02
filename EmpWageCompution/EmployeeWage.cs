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
        public  void Attendance()
        {
            int IS_PRESENT = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
  

        
    

