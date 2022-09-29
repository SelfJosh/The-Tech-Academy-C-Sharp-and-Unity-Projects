using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    public class Operations
    {
        public static int Math(int userInteger)
        {
            userInteger = userInteger + 4;
            return userInteger;
        }

        public static int Math(decimal userDecimal)
        {
            userDecimal = userDecimal * 5;
            int output = Convert.ToInt32(userDecimal);
            return output;
        }

        public static int Math(string userString)
        {
            List<string> Converter = new List<string>
            {
                "zero", "one", "two", "three",
                "four", "five", "six", "seven",
                "eight", "nine", "ten",
            };

            int userNumber = 0;

            for (int i = 0; i < Converter.Count; i++)
            {
                userString.ToLower();
                if (userString == Converter[i])
                {
                    userNumber = i;
                }
            }

            userNumber = userNumber * 6;

            return userNumber;
        }
    }
}
