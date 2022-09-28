using System;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Header

            Console.WriteLine("The Tech Academy. \n \nStudent Daily Report. \n");

            //Name

            Console.WriteLine("What is your name?");
            String studentName = Console.ReadLine();

            //Course

            Console.WriteLine("What course are you on?");
            String studentCurrentCourse = Console.ReadLine();

            //Page

            Console.WriteLine("What page are you on? Please answer with only an integer.");
            String stringPageNumber = Console.ReadLine();
            int intPageNumber = Convert.ToInt32(stringPageNumber);

            //Help

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            String stringHelp = Console.ReadLine();
            bool boolHelp = Convert.ToBoolean(stringHelp);

            //Positive Experiences

            Console.WriteLine("Were there any positive experinces you'd like to share? Please give specifics.");
            String studentExperince = Console.ReadLine();

            //Feedback

            Console.WriteLine("Any other feed back you would like to provide? Please be specific.");
            String studentFeedback = Console.ReadLine();

            //Hours

            Console.WriteLine("How many hours did you study today?");
            String stringHoursStudied = Console.ReadLine();
            int intHoursStudied = Convert.ToInt32(stringHoursStudied);

            //Submition Message

            Console.WriteLine("Thank you " + studentName + " for your answers. An Instructor will respond to this shortly. \nHave a great day!");
        }
    }
}
