using System;

namespace BasicsOfCSharp{
    class Employee //Proper
    {
        //variables - camelCase
        internal string firstName, lastName, ssn;
        internal int Age;
        internal decimal salary;

        //Methods - Specification and Definition (body)
        public void GetDetails() {
            Console.WriteLine($"Name {firstName} {lastName}, {Age} years old, has Social Security - {ssn}. The salary is {salary}");
        }
    }
}