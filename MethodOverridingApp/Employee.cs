using System;

namespace MethodOverridingApp
{

    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }

        public override void TestMethod()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return EmployeeNumber + " : " + base.ToString();
        }
    }

}
