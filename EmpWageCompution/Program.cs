using System;

namespace EmpWageCompution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            // Employee employee = new Employee();
            // employee.Attendance();
            EmployeeWage empwage = new EmployeeWage();
<<<<<<< HEAD
            empwage.Calculate(20,20);
=======
            empwage.Calculate(20,20, 100);
>>>>>>> UC6-Maxdays
        }
    }
}
