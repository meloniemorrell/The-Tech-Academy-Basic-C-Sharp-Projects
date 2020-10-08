using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_237
{
    abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        abstract public void SayName();
    }

    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }

}
