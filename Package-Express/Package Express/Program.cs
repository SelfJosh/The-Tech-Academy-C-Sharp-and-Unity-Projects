using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            String Header = "________________________________________________________________\n\n\nWELCOME TO PACKAGE EXPRESS. PLEASE FOLLW THE INSTRUCTIONS BELOW.\n\n________________________________________________________________";
            Console.WriteLine(Header);

            Console.WriteLine("\nHow much does your package weigh?");

            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.Clear();
                Console.WriteLine(Header);
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express. Have a good Day.");
                Console.ReadLine();
                Environment.Exit(0);
            } 
            
            Console.Clear();
            Console.WriteLine(Header);
            Console.WriteLine("Please enter the dimensions of the package.\nWidth:");

            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Height:");

            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length:");

            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.Clear();
                Console.WriteLine(Header);
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            float Total = ((packageHeight * packageLength * packageWidth) * packageWeight) / 100;

            Console.Clear();
            Console.WriteLine(Header);
            Console.WriteLine("Your package can be shipped!\nHere is your esimated total for shipping.\nEstimated Total: $" + Total + "\nThank you for using Package Express!");
            Console.ReadLine();
        }
    }
}
