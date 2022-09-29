using System;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations math = new Operations();
            Check check = new Check();

            Console.WriteLine("Please enter either any intger, a decimal, or a written number between 0 and 10.\nDifferent math operations will be done to each.");
            string userInput = Console.ReadLine();
            

            Console.WriteLine("Here are the results:\n");
            try
            {
                decimal userNumber = Convert.ToDecimal(userInput);
                if (Check.IsInt(userNumber))
                {
                    int userNumber1 = Convert.ToInt32(userNumber);
                    Console.WriteLine(Operations.Math(userNumber1));
                }
                else
                {
                    Console.WriteLine(Operations.Math(userNumber));
                }
            }
            catch (FormatException ex)
            {
                Console.Write(Operations.Math(userInput));
            }

            Console.ReadLine();

        }
    }
}
