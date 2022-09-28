using System;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please enter a number for the method to calculate.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are the results:");

            int Output = Maths.MathOne(userNum);
            Console.WriteLine(Output);

            Output = Maths.MathTwo(userNum);
            Console.WriteLine(Output);

            Output = Maths.MathThree(userNum);
            Console.WriteLine(Output);
        }
    }
}
