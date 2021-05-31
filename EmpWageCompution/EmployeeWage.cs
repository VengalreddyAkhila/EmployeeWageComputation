using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
    class EmployeeWage
    {
        int IS_PRESENT = 1;
        public void Attendence()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
