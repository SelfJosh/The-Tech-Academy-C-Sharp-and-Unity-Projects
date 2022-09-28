using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerator = new List<int>
            {
                82,
                53,
                20,
                144,
                282,
            };

            Console.WriteLine("Please enter a number.\nThis number will be used to divide by each integer in a list.");
            
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here are the results:");
                double x = 0;
                foreach (int num in numerator)
                {
                    x = Convert.ToDouble(num) / Convert.ToDouble(userNum);
                    Console.WriteLine(num + " / " + userNum + " = " + x);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Thank you! Please try again!");
            Console.ReadLine();
        }
    }
}
