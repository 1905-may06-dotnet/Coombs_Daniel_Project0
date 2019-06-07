using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<string> emp = new List<string>() { "Carol", "David", "Fred", "Julie" };
            /*var filteredEmps = from e in emp
                               where e.Contains('a')
                               select e;*/

            /*List<Employee> emp = new List<Employee>()
            {
                new Employee(){empID=123, age=25, country="USA", name="Fred", bsal=500000.54f, hra=789.45f},
                new Employee(){empID=112, age=32, country="Uganda", name="Knuckles", bsal=123456.45f, hra=6565.20f},
                new Employee(){empID=111, age=45, country="USA", name="David Fay", bsal=456123.45f, hra=1231.12f},
                new Employee(){empID=789, age=17, country="Canada", name="Daisy", bsal=45000.54f, hra=1000.50f},
            };*/
            //LINQ-Query Syntax
            /*var filteredEmps = from e in emp
                               where e.age > 20 && e.country == "USA"
                               select e;*/

            //LINQ - Method Syntax (switch between console lines as necessary
            /* var filteredEmps = emp.Where(a => a.age > 20 && a.country == "USA"); //.Max(s => s.age); //.OrderBy(s => s.age); //.FirstOrDefault();

             /*var filteredEmps = from e in emp
                                where e.Contains('a')
                                select e;*/

            /*Console.WriteLine(filteredEmps);*/

            /*foreach (var i in filteredEmps)
            {
                Console.WriteLine(i.name);
            }*/


        }
    }
        public class Employee
        {
            public int empID { get; set; }
            public int age { get; set; }
            public string country { get; set; }
            public string name { get; set; }
            //unit testing
            public decimal bsal { get; set; }
            public decimal hra { get; set; }

            public decimal Salary(Employee emp)
            {
                return emp.hra + emp.bsal - (0.4M) * bsal;
            }

            public List<Employee> GetEmployees()
            {
                List<Employee> emp = new List<Employee>()
            {
                new Employee(){empID=123, age=25, country="USA", name="Fred", bsal=500000.54M, hra=789.45M},
                new Employee(){empID=112, age=32, country="Uganda", name="Knuckles", bsal=123456.45M, hra=6565.20M},
                new Employee(){empID=111, age=45, country="USA", name="David Fay", bsal=456123.45M, hra=1231.12M},
                new Employee(){empID=789, age=17, country="Canada", name="Daisy", bsal=45000.54M, hra=1000.50M},
            };
                return emp;
            }
        }
    }

