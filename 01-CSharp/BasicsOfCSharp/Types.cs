using System;

namespace BasicsOfCSharp{
    class Employee //Proper
    {
        //variables - camelCase
        //Declaration of variables

        internal string firstName, lastName, ssn;
        internal int Age;
        private decimal salary;

        //Properites: Smart fields to access the private variables outside the class
        public decimal _salary { //always set to public
            get{
                return salary;
            }
            set{
                salary=value; //value is a key word
            }
        }
            

        //Methods - Specification and Definition (body)
        public void GetDetails() {
            Console.WriteLine($"Name {firstName} {lastName}, {Age} years old, has Social Security - {ssn}. The salary is {salary}");
        }

        //constructors in C#: special methods which is used to initialize the memory
        //parametereless constructor
        public Employee() {
            firstName = "Cameron";
            lastName = "Coley";
            ssn = "123456789";
            Age = 30;
            salary = 8000.00M;
            Console.WriteLine($"Name {firstName} {lastName}, {Age} years old, has Social Security - {ssn}. The salary is {salary}");

        }

        //parameterized constructor
        public Employee(string firstName, string lastName, string ssn, int Age, decimal salary) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.Age = Age;
            this.salary = salary;
            Console.WriteLine($"Name {firstName} {lastName}, {Age} years old, has Social Security - {ssn}. The salary is {salary}");

        }
    }
}