using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            Console.ReadLine();
        }
    }
}
