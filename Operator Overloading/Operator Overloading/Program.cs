using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = 10000;
            var max = 20000;

            Staff staff = new Staff();
            staff.Employees = new List<string>();
            staff.empIDs = new List<int>();

            Employee employee = new Employee();
            Employee employee1 = new Employee();

            Console.WriteLine("Please enter two new employee names:");

            employee.Name = Console.ReadLine();
            employee1.Name = Console.ReadLine();
            staff.Employees.Add(employee.Name);
            staff.Employees.Add(employee1.Name);

            employee.ID = RandomNumberGenerator.GetInt32(min, max);
            employee1.ID = RandomNumberGenerator.GetInt32(min, max);
            staff.empIDs.Add(employee.ID);
            staff.empIDs.Add(employee1.ID);

            Console.WriteLine("New Employee: "+ employee.Name);
            Console.WriteLine(employee.Name + "'s ID #: " + employee.ID);

            Console.WriteLine("New Employee: " + employee1.Name);
            Console.WriteLine(employee1.Name + "'s ID #: " + employee1.ID);

            bool x = employee == employee1;

            Console.WriteLine(x);
        }
    }
}
