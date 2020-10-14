using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melonie08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>
            {
                new Employee(1,"joe","dir"),
                new Employee(2,"joe","dirt"),
                new Employee(3,"test","wwww"),
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


            List<Employee> newEmps5 = new List<Employee>();
            foreach (Employee e in emps.FindAll(e => e.GetFirstName.ToLower() == "joe"))
            {
                newEmps5.Add(e);
            }

            Func<Employee, bool> empJoe = x => x.GetFirstName.ToLower() == "joe";
            List<Employee> newEmps6 = new List<Employee>();
            foreach (Employee e in emps)
            {
                if (empJoe(e)) newEmps6.Add(e);
            }

            List<Employee> newEmps7 = emps.Where(x => x.GetFirstName.ToLower() == "joe").ToList();


            List<Employee> newEmps2 = new List<Employee>();
            foreach (Employee e in emps.FindAll(e => e.GetId > 5))
            {
                newEmps2.Add(e);
            }

            Func<Employee, bool> empFive = x => x.GetId > 5;
            List<Employee> newEmps3 = new List<Employee>();
            foreach (Employee e in emps)
            {
                if (empFive(e)) newEmps2.Add(e);
            }

            List<Employee> newEmps4 = emps.Where(x => x.GetId > 5).ToList();
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