using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    public class IntClass
    {
        public static void NumMethod(int x,out int y)
        {
            y = x / 2;
        }

        public static int NumMethod(int x, int z)
        {
            int results = (x + z) * 2;
            return results;
        }

        public static int NumMethod(int x, int y, int z)
        {
            int results = (x * 2) + (y * 3) + (z * 4);
            return results;
        }

    }
}
