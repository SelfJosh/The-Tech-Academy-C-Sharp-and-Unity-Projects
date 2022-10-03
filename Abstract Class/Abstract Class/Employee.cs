using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
