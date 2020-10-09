using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MelonieMorrell
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.firstName = "Sample";
            e.lastName = "Student";
            e.SayName();
            Console.ReadLine();

        }

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

}
 