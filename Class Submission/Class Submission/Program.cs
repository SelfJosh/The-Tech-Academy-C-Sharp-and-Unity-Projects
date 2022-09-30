using System;

namespace Class_Submission
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            IntClass Class = new IntClass();

            int i;

            Console.WriteLine("Please enter any number.");
            IntClass.NumMethod(Convert.ToInt32(Console.ReadLine()), out i);

            //Other possible methods
            //IntClass.NumMethod(20, 12);
            //IntClass.NumMethod(20, 45, 18);

            Console.WriteLine("Here is that number divded by 2: " + i + "\n\nEnter another number.");


            Console.WriteLine("Here is that number times 15: "+ StaticClass.TryMethod(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
