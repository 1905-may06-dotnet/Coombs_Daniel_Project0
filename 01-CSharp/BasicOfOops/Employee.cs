using System;

namespace BasicOfOops
{
    class Employee
    {
        protected string name, ssn, empid;
        protected int age;
        protected decimal salary;
        protected decimal bsal, bonus, tax, hra;

        public Employee() 
        {
            System.Console.WriteLine("calling default constructor");
        }

        public Employee(string name, string ssn, int age, string empid, decimal bsal, decimal hra, decimal bonus=10000.00M) {
            this.name = name;
            this.ssn = ssn;
            this.age = age;
            this.empid = empid;
            this.bsal = bsal;
            this.tax = 0.4M*bsal;
            this.hra = hra;
            this.bonus=bonus;
        }
        //Method overloading: Methods with same name but different signatures:
        //1. number of parameters
        //2. type of parameters
        //3. sequenceof parameters
        //public abstract decimal GetSalary();
        public virtual decimal GetSalary() {
            return salary=bsal+bonus+hra-tax;
        }
    #region overloading
       /* public decimal GetSalary(decimal ta) {
            return salary=bsal+bonus+hra+ta-tax;
        }

        public decimal GetSalary(decimal ta, decimal perdiem) {
            return salary=bsal+bonus+hra+ta+perdiem-tax;
        }

        public string GetSalary(string empid) {
            return $"The salary of {empid} is {bsal+bonus+hra-tax}";
        }
        */
        #endregion
    }
}