using System.Linq;
using LINQDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;//testing class

namespace TestLINQDemo
{
    [TestClass]
    public class TestEmployee
    {
        [TestMethod]
        public void TestSalary()
        {
            //1. Arrange
            LINQDemo.Employee emp = new Employee();
            var emps = emp.GetEmployees();
            var empMax = emps.Where(async => async.age > 20).OrderByDescending(s=>s.bsal).First();
            decimal expectedSalary = 300789.77M;
            //2.Act
            var actualSalary = emp.Salary(empMax);
            //3. Assert
            Assert.AreEqual(expectedSalary, actualSalary);
        }
    }
}
