using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Employees = new Employee<string>();
            Employees.Things = new List<string>() {"Bob", "Adam", "Julie" };
            
            Employee<int> EmployeeNumber = new Employee<int>();
            EmployeeNumber.Things = new List<int>() {123, 256, 458, 963 };

            for (int i = 0 ; i < Employees.Things.Count || i < EmployeeNumber.Things.Count; i++)
            {
                if (i < Employees.Things.Count)
                {
                    Console.WriteLine("Employee Name: " + Employees.Things[i]);
                }
                if (i < EmployeeNumber.Things.Count)
                {
                    Console.WriteLine("Employee Number: " + EmployeeNumber.Things[i]);
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }


        }
    }
}
