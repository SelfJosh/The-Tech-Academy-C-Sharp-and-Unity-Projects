using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        public static List<Option> Menu1;

        static void Main(string[] args)
        {
            IQuittable employee = new Employee();

            Menu1 = new List<Option>
            {
                new Option("Home", () => Option.InitiateMenu(0)),
                new Option("Payroll", () => Option.Payroll()),
                new Option("Quit", () => employee.Quit())
            };

            Option.InitiateMenu(0);

        }
    }
}
