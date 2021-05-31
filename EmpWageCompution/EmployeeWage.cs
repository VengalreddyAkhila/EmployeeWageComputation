using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageCompution
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        int EMPHRS = 8;
        int EMP_RATE_PER_HRS = 20;
        public void Attendance()
        {
            //Employee attendance
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                //calculate wage
                int Wage = EMPHRS * EMP_RATE_PER_HRS;
                Console.WriteLine("Employee is present wage :  " + Wage);
            }
            else
                Console.WriteLine("Employee is absent wage :" + 0);
        }
    }
}
