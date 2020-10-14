using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melonie245v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "joe", "Info");
            Employee emp2 = new Employee(1, "Tom", "dirt");
            Employee emp3 = new Employee(2, "Tom", "dirt");

            Console.WriteLine(emp1 == emp2);

            if (emp1 == emp2)
            {
                Console.WriteLine("Employee Id's Match");
            }

            if (emp1 == emp3)
            {
                Console.WriteLine("Employee Id's Match");
            }
            else
            {
                Console.WriteLine("Employee Id's Do Not Match");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

    class Employee
    {
        private int Id;
        private string FirstName;
        private string LastName;

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }

        public int GetId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        public static bool operator ==(Employee x, Employee y)
        {
            if (x.GetId == y.GetId)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee x, Employee y)
        {
            if (x.GetId != y.GetId)
                return true;
            else
                return false;
        }

    }
}