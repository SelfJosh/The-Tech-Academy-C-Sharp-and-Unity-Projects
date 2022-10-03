using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {

        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        public void Quit()
        {
            Environment.Exit(0);
        }
        


    }
}
