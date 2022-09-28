
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class Program
{
    public static List<Option> options0;
    public static List<Option> options1;
    public static List<Option> options2;

    static void Main(string[] args)
   {
        string[] stringArray = { "You selected index 1", "You selected index 2", "You selected index 3", "You selected index 4" };
        int[] intArray = { 515116, 961651, 369842, 6713400 };
        List<string> stringList = new List<string>{"You selected index 1 from a list", "You selected index 2 from a list", "You selected index 3 from a list", "You selected index 3 from a list" };

        options0 = new List<Option>
        {
            new Option("1", () => WriteMessage(stringArray[0])),
            new Option("2", () => WriteMessage(stringArray[1])),
            new Option("3", () => WriteMessage(stringArray[2])),
            new Option("4", () => WriteMessage(stringArray[3])),
        };

        options1 = new List<Option>
        {
            new Option("1", () => WriteNumber(intArray[0])),
            new Option("2", () => WriteNumber(intArray[1])),
            new Option("3", () => WriteNumber(intArray[2])),
            new Option("4", () => WriteNumber(intArray[3])),
            new Option("5", () => WriteErrorMessage("Oops! looks like this index does not have anything assigned to it at the moment. Please choose a different index.")),
        };

        options2 = new List<Option>
        {
            new Option("1", () => WriteListMessage(stringList[0])),
            new Option("2", () => WriteListMessage(stringList[1])),
            new Option("3", () => WriteListMessage(stringList[2])),
            new Option("4", () => WriteListMessage(stringList[3])),
        };

        Console.WriteLine("Please use the down and up arrows to choose between selections.\nUse enter to select.");
        Thread.Sleep(5000);
        Console.Clear();
        InitiateMenu(0);
        
    }


    static void WriteMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(3000);
        InitiateMenu(1);
    }

    static void WriteListMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(3000);
        Environment.Exit(0);
    }

    static void WriteNumber(int message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(3000);
        InitiateMenu(2);
    }

    static void WriteErrorMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(5000);
        InitiateMenu(1);
    }


    static void WriteMenu(List<Option> options, Option selectedOption)
    {
        Console.Clear();
        Console.WriteLine("Please select an Index.");

        foreach (Option option in options)
        {
            if (option == selectedOption)
            {
                Console.Write("> ");
            }
            else
            {
                Console.Write(" ");
            }
            Console.WriteLine(option.Name);
        }
    }

   

    static void InitiateMenu(int pageNumber)
    {
        int index = 0;
        ConsoleKeyInfo keyInfo;
        if (pageNumber == 0)
        {
            
            WriteMenu(options0, options0[index]);
            string title = "This index is from an array that corresponds to a phrase. The phrase you select will be displayed.";
            Console.WriteLine(title);
            do
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options0.Count)
                    {
                        index++;
                        WriteMenu(options0, options0[index]);
                        Console.WriteLine(title);
                    }
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options0, options0[index]);
                        Console.WriteLine(title);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options0[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyInfo.Key != ConsoleKey.X);
        }
        if (pageNumber == 1)
        {
            
            WriteMenu(options1, options1[index]);
            string title = "This index is from an array that corresponds to a number. The number you select will be displayed.";
            Console.WriteLine(title);

            do
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options1.Count)
                    {
                        index++;
                        WriteMenu(options1, options1[index]);
                        Console.WriteLine(title);
                    }
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options1, options1[index]);
                        Console.WriteLine(title);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options1[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyInfo.Key != ConsoleKey.X);
        }
        if (pageNumber == 2)
        {
            
            WriteMenu(options2, options2[index]);
            string title = "This index is from a list that corresponds to a phrase. The phrase you select will be displayed.";
            Console.WriteLine(title);

            do
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options2.Count)
                    {
                        index++;
                        WriteMenu(options2, options2[index]);
                        Console.WriteLine(title);
                    }
                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options2, options2[index]);
                        Console.WriteLine(title);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options2[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyInfo.Key != ConsoleKey.X);
        }
    }


    public class Option
    {
        public string Name { get; }
        public Action Selected { get; }
        

        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;
            
        }
    }
}

