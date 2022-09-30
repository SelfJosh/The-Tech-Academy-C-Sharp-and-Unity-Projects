using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleInteger x = new DoubleInteger();

            int num2;

            Console.WriteLine("Please enter two numbers one at a time.\nThe second number is optional.");

            int num1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here are the results:" + DoubleInteger.DoubleInput(num1, num2));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Here are the results: " + DoubleInteger.DoubleInput(num1));
            }
            Console.ReadLine();

            
        }
    }
}
