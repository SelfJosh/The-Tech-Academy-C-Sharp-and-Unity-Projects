using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please enter a number to see what time it will be in x amount of hours.");

            double userNumber = Convert.ToInt32(Console.ReadLine());

            DateTime Time = DateTime.Now;

            

            Console.WriteLine("It will be {0}, in {1} hours!", Time.AddHours(userNumber), userNumber);
            Console.ReadLine();
        }
    }
}
