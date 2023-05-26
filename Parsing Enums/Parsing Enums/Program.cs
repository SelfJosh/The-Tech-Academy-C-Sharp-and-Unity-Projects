using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Parsing_Enums
{
    public class Program
    {
        public enum DaysOfTheWeek 
        {

            [Description("MONDAY")]Monday,
            [Description("TUESDAY")] Tuesday,
            [Description("WEDNESDAY")] Wednesday,
            [Description("THURSDAY")] Thursday,
            [Description("FRIDAY")] Friday,
            [Description("SATURDAY")] Saturday,
            [Description("SUNDAY")] Sunday
        }

        public static string GetDescription(Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memberInfo = type.GetMember(en.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a day of the week: ");
            string userInput = Console.ReadLine();
            
            try
            {
                //for loop to check if user input is the same as the descirption of the day of the week after changing case. If it is the same the first letter in the 
                //userInput is changed to uppercase to match the days of the week to be able to parse as it is case sensitive. Another way to go about this would be 
                //to make all the enums lower case and convert the user input to lowercase and then if it is able to parse then it would print the description.
                
                for (int i = 0 ; i < 6; i++)
                {
                    if (userInput.ToLower() == GetDescription((DaysOfTheWeek)i).ToLower())
                    {
                        var stringArray = userInput.ToCharArray();
                        if (char.IsLower(stringArray[0]))
                        {
                            stringArray[0] = char.ToUpper(stringArray[0]);
                            
                            userInput = new string(stringArray);
                        }


                        DaysOfTheWeek userDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

                        Console.WriteLine("You have entered the day: {0}" , (DaysOfTheWeek)i);
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("FAILED Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);
            }

            
           
        }
    }
}
