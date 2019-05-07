//Namespace - logical collection of libraries
//1. Predefined name space
using System; //parent

//2. User defined namespace
namespace BasicsOfCSharp
{
    //Types: Class, Structures, Enums, Interfaces, Delegates
    class Program
    {
        //Type Members: Methods, Variables, Constants, Properites
        static string name = "";
        static void Main(string[] args)
        {
            /*Console.Write("Please enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);*/

            Employee emp = new Employee(); //default constructor
            // emp.firstName = "Carol";
            // emp.lastName = "Baxtor";
            // emp.ssn = "123456789";
            // emp.Age = 40;
            // emp.salary = 10000.0M;
            // emp.ishuman = false; //cannot be re-assigned
            // emp.GetDetails();
            Employee emp2 = new Employee("Palmer", "Calgoris", "hjhjk45", 27, 8500.00M);
            emp._salary = 8563.23M;
            Console.Write($"The Salary is {emp._salary}");
        }
    }
}
