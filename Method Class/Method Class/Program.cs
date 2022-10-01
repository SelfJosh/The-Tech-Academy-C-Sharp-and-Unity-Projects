using System;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodClass x = new MethodClass();

            Console.WriteLine("Please input two numbers. The second one will be displayed on the screen as is and the first number will have some math operations done on it.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHere are the results:");
            MethodClass.VoidMethod(int1: num1, int2: num2);
        }
    }
}
