using System;

namespace BasicOfOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee mgr = new Manager(1000.00M);
            System.Console.WriteLine($"The salary is {mgr.GetSalary()}");
            // Employee emp = new Employee("test1", "123HJ45", 45, "121", 4500.00M, 1200.00M);
            // Console.Write($"The salary is {emp.GetSalary(800.00M, 75.00M)}");
        }
    }
}
