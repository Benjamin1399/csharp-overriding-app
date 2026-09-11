using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Benjamin";
            person.LastName = "Naidoo";

            Console.WriteLine($"Person: {person}");

            Employee employee = new Employee();
            employee.FirstName = "Tim";
            employee.LastName = "Corey";
            employee.EmployeeNumber = 1;

            Console.WriteLine($"Employee: {employee}");
        }

        public abstract class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}";
            }

            public abstract void TestMethod();
        }

        public class Employee : Person
        {
            public int EmployeeNumber { get; set; }

            public override void TestMethod()
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return EmployeeNumber + " : " +base.ToString();
            }
        }
    }
}
