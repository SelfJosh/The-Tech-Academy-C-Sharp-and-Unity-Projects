using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Staff staff = new Staff();

            Employee e1 = new Employee() {firstName = "Joe", lastName = "Stathers", employeeID = 00001};
            Employee e2 = new Employee() { firstName = "Ilene", lastName = "Withers", employeeID = 00002 };
            Employee e3 = new Employee() { firstName = "Will", lastName = "Nelson", employeeID = 00003 };
            Employee e4 = new Employee() { firstName = "Ronnie", lastName = "Pillard", employeeID = 00004 };
            Employee e5 = new Employee() { firstName = "Joe", lastName = "Heathes", employeeID = 00005 };
            Employee e6 = new Employee() { firstName = "Lucy", lastName = "Diamond", employeeID = 00006 };
            Employee e7 = new Employee() { firstName = "Tommy", lastName = "Lemmings", employeeID = 00007 };
            Employee e8 = new Employee() { firstName = "Ezequiel", lastName = "Daniels", employeeID = 00008 };
            Employee e9 = new Employee() { firstName = "Taylor", lastName = "McGee", employeeID = 00009 };
            Employee e10 = new Employee() { firstName = "Miranda", lastName = "Cyrus", employeeID = 00010 };

            staff.allEmployees = new List<Employee>() {e1, e2, e3, e4, e5, e6, e7, e8, e9, e10};
            
            List<Employee> list = new List<Employee>();

           
            foreach (Employee e in staff.allEmployees)
            {
                if ( e.firstName == "Joe")
                {
                    list.Add(e);
                } 
            }

            foreach (Employee e in list)
            {
                Console.WriteLine(e.firstName);
            }

            List<Employee> lambdaList = staff.allEmployees.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee e in lambdaList)
            {
                Console.WriteLine(e.firstName);
            }

            List<Employee> iDList = staff.allEmployees.Where(x => x.employeeID > 5).ToList();

            foreach(Employee e in iDList)
            {
                Console.WriteLine(e.firstName + " " + e.employeeID);
            }
        }
    }
}
