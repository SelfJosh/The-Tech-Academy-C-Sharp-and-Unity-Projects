using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Option : Employee
    {
        public Option(string name, Action selected)
        {
            Name = name;
            Selected = selected;          
        }

        public string Name { get; set; }
        public Action Selected { get; set; }


        public static void Payroll()
        {
            Console.Clear();
            Console.WriteLine("Employee Hours Worked This Week: 42\n\nEmployee Hourly Rate: $17/hr\n\nGross Total: $714");
            Console.WriteLine("> Home");

            ConsoleKeyInfo keyInfo;
            
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Option.InitiateMenu(0);
                }
            }
            while (keyInfo.Key != ConsoleKey.X);
   
        }

        public static void WriteMenu(List<Option> Options, Option selectedOption)
        {
            Console.Clear();
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            Console.WriteLine("Employee Menu");
            employee.SayName();

            foreach (Option option in Options)
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

        public static void InitiateMenu(int pageNum)
        {
            Program program = new Program();
            Employee employee = new Employee();
            int index = 0;
            ConsoleKeyInfo keyInfo;
            if (pageNum == 0)
            {
                
                WriteMenu(Program.Menu1, Program.Menu1[index]);

                do
                {
                    keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        index++;
                        
                        WriteMenu(Program.Menu1, Program.Menu1[index]);
                    }
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        if (index - 1 >= 0)
                        {
                            index--;
                            
                            WriteMenu(Program.Menu1, Program.Menu1[index]);
                        }
                    }
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Program.Menu1[index].Selected.Invoke();
                        index = 0;
                    }
                }
                while (keyInfo.Key != ConsoleKey.X);


            }
        }

    }



    
}
