using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingApp
{
    partial class Program
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
    }
}
