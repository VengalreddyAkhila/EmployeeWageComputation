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
            empwage.Calculate(20,20, 100);
        }
    }
}
