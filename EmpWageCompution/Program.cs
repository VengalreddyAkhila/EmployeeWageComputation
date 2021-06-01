using System;

namespace EmpWageCompution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWage Max= new EmployeeWage("max", 20 ,3,10);
            Max.ComputeEmpWage();
            Console.WriteLine(Max.Value());
            EmployeeWage Reliance = new EmployeeWage("Reliance", 10, 2, 10);
            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.Value());
        }
    }
}
