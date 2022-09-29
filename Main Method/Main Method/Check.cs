using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    public class Check
    {
        public static bool IsInt(decimal i)
        {
            int x = Convert.ToInt32(i);

            decimal temp1 = i - x;

            if (temp1 > 0 || temp1 < 0)
            {
                return false;
            }

            return true;
        }
    }
}
