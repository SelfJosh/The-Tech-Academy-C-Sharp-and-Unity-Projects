using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppAssignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //string[] stringArray = {"Hello, ", "Welcome, ", "My name is " };

            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userName;
                Console.WriteLine(stringArray[i]);
            }

            //for (int x = 0; x > -1; x++)
            //{
            //    console.writeline(x);
            //}
            //this was the infinite loop before being fixed

            for (int x = 0; x > -1 && x <= 100; x++)
            {
                Console.WriteLine(x);
            }

            List<string> Names = new List<string>
            {
                "James",
                "Helen",
                "Nelson",
                "Gerald",
                userName,
            };

            Console.WriteLine(Names[1]);

            Console.WriteLine("Please enter a name to search for.");

            bool match = false;
            do
            {
                string userInput = Console.ReadLine();

                for (int i = 0; i < Names.Count; ++i)
                {
                    if (userInput == Names[i])
                    {
                        Console.WriteLine("Name found @ Index: " + i + "\nName: " + Names[i]);
                        match = true;
                    }
                }
                Console.WriteLine("Name not found. Please search for a different name. Hint: try your own name.");
            }
            while (match == false);


            List<string> identicalStrings = new List<string>
            {
                "Bob",
                "Bob",
                "Tanner",
                "Nelson",
                "Taylor",
                "Richard",
                "Bob",
                userName,
                "Richard",
                userName,
                "Helen",
            };

            List<int> indices = new List<int> { };
            Console.WriteLine("Please enter a name to see what index it is at.");

            string input1 = Console.ReadLine();

            for (int i = 0; i < identicalStrings.Count; ++i)
            {
                if (input1 == identicalStrings[i])
                {
                    indices.Add(i);
                }
            }

            if (indices.Count > 0)
            {
                Console.WriteLine("That name showed up " + indices.Count + " times at indices: ");
                foreach (int index in indices)
                {
                    Console.WriteLine(index);
                }
            }

            if (indices.Count == 0)
            {
                Console.WriteLine("That name was not found.");
            }

            List<string> checkString = new List<string>
            {

            };

            
            
            foreach (string name in identicalStrings)
            {
                Thread.Sleep(2000);
                if (!checkString.Contains(name))
                {
                    checkString.Add(name);
                    Console.WriteLine(name + "\nThis name has not appeared yet on the list.");
                }
                else
                {
                    Console.WriteLine(name + "\nThis name has appeared on the list before.");
                }      
            }
        }
    }
}
