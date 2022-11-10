using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_Overloading
{
    public class Employee 
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            var x = employee.ID == employee1.ID;
            return x;
        }
        public static bool operator !=(Employee employee, Employee employee1)
        {
            var x = employee.ID != employee1.ID;
            return x;
        }
    }
}
