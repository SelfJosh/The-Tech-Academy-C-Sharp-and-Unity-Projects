using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Usernames = new string[] { "admin","Josh" };
            string[] Passwords = new string[] { "admin", "joshRockz!" };

            bool accessGranted = false;

            Console.Write("Username:");
            String emailAttempt = Console.ReadLine();

            Console.Write("Password:");
            String passwordAttempt = Console.ReadLine();

            do
            {
                if (emailAttempt == Usernames[1] && passwordAttempt == Passwords[1]) 
                {
                    Console.WriteLine("Now logged in as Josh. Welcome");
                    accessGranted = true;
                }
                else if (emailAttempt == Usernames[0] && passwordAttempt == Passwords[0])
                {
                    Console.WriteLine("Now logged in as admin. Welcome");
                    accessGranted = true;
                }
                else
                {
                    Console.WriteLine("Please try again! Hint: admin admin");
                    Console.ReadLine();

                    Console.Clear();

                    Console.Write("Username:");
                    emailAttempt = Console.ReadLine();

                    Console.Write("Password:");
                    passwordAttempt = Console.ReadLine();
                }
                
                
            }
            while (!accessGranted);

            int i = 0;

            Console.Write("Loading Page");

            while (i < 5)
            {
                
                i++;
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
            }

            Console.Clear();
            Console.WriteLine("\nSystem ERROR(404): Page Not Found");
        }
    }
}
