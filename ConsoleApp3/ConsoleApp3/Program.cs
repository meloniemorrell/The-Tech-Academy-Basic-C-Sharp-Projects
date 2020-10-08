using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.FirstName = "Sample";
            e.LastName = "Student";
            e.SayName();
            Console.ReadLine();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    class Employee : Person
    {
        public int Id { get; set; }


    }
}
