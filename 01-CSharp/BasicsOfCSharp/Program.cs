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

            Employee emp = new Employee();
            emp.firstName = "Carol";
            emp.lastName = "Baxtor";
            emp.ssn = "123456789";
            emp.Age = 40;
            emp.salary = 10000.0M;

            emp.GetDetails();
        }
    }
}
