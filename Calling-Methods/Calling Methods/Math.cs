using System;
using System.Collections.Generic;
using System.Text;

namespace Calling_Methods
{
    public class Maths
    {
        public static int MathOne(int x)
        {
            int sum = x + 5;
            return sum;
        
        }

        public static int MathTwo(int x)
        {
            int difference = x - 10;
            return difference;
            
        }
        
        public static int MathThree(int x)
        {
            int product = x * 3;
            return product;
        }
    }
}
