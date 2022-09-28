using System;

namespace Car_Insuance_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Josh's Car Insurance\n");
            Console.WriteLine("Car Insuance Application");

            Console.WriteLine("\nHow old are you? Please enter your age using numerical digits.");
            String applicantAge = Console.ReadLine();
            int Age = Convert.ToInt32(applicantAge);

            Console.WriteLine("\nHave you every had a DUI? Please enter True or False.");
            String DUIString = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIString);

            Console.WriteLine("\nHow many speeding tickets do you have");
            String speedingTicketsString = Console.ReadLine();
            int speedingTickets = Convert.ToInt32(speedingTicketsString);

            Console.Clear();
            Console.WriteLine("Thank you for your answers! Please wait for the results.");
            System.Threading.Thread.Sleep(3000);

            Console.Clear();
            Console.WriteLine("Here are the Results!\n");

            if (Age > 15 && DUI == false && speedingTickets < 3)
            {
                Console.WriteLine("Congratulations! You qualify for one of our insuance policies!");
            }
            else
            {
                Console.WriteLine("We're sorry to inform you that you do not qualify for our insuance policies.\nThank you for stopping by!");
            }

        }
    }
}
