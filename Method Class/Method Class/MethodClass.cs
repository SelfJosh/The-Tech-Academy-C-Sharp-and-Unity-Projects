using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Class
{
    public class MethodClass
    {
        public static void VoidMethod(int int1, int int2)
        {
            int1 = (int1 * 15) + 7;
            Console.WriteLine("{0}", int1);
            Console.WriteLine("{0}", int2);
        }
    }
}
