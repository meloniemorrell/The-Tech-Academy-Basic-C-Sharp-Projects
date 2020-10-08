using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_265
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>
            {
                new Employee(1,"joe","brooks"),
                new Employee(2,"joe","blow"),
                new Employee(3,"Tina","Williams"),
                new Employee(4,"Aine","Travis"),
                new Employee(5,"Elysia","Trejo"),
                new Employee(6,"Lea","Hensley"),
                new Employee(7,"Justine","Romero"),
                new Employee(8,"Phoenix","Wilder"),
                new Employee(9,"Eilish","Mccallum"),
                new Employee(10,"Elana","Sexton")
            };

            List<Employee> newEmps = new List<Employee>();

            foreach (Employee e in emps)
            {
                if (e.GetFirstName.ToLower() == "joe")
                    newEmps.Add(e);
            }

            List<Employee> newEmps2 = emps.Where(x => x.GetId > 5).ToList();
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
    }

}
