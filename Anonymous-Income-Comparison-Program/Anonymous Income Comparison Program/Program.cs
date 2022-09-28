using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \n\n");

            Console.WriteLine("Person 1: \n Hourly Rate?");
            String p1HourlyRateString = Console.ReadLine();

            Console.WriteLine("\n Hours worked per week?");
            String p1HoursPerWeekString = Console.ReadLine();

            Console.WriteLine("\nPerson 2: \n Hourly Rate?");
            String p2HourlyRateString = Console.ReadLine();

            Console.WriteLine("\n Hours worked per week?");
            String p2HoursPerWeekString = Console.ReadLine();

            int p1HourlyRateInt = Convert.ToInt32(p1HourlyRateString);
            int p1HoursPerWeekInt = Convert.ToInt32(p1HoursPerWeekString);
            int p1AnnualSalary = 52 * (p1HourlyRateInt * p1HoursPerWeekInt);
            Console.WriteLine("Annual salary of Person 1: \n " + p1AnnualSalary);

            int p2HourlyRateInt = Convert.ToInt32(p2HourlyRateString);
            int p2HoursPerWeekInt = Convert.ToInt32(p2HoursPerWeekString);
            int p2AnnualSalary = 52 * (p2HourlyRateInt * p2HoursPerWeekInt);
            Console.WriteLine("Annual salary of Person 1: \n " + p2AnnualSalary);

            bool p1GreaterThanP2 = (p1AnnualSalary > p2AnnualSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2? \n " + p1GreaterThanP2);
            Console.ReadLine();

        }
    }
}
