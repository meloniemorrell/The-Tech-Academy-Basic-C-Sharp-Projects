using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MelonieMorrell
{
    public static class Samples
    {
        public static void Sample229()
        {
            var employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };
            employee.SayName();

        }

        public static void Sample237()
        {
            var employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            employee.SayName();
        }
        public static void Sample248()
        {
            var employeeWithStrings = new EmployeeWithGeneric<string>()
            {
                Things = new List<string>()
                {
                    "first",
                    "second",
                    "third"
                }
            };

            var employeeWithInts = new EmployeeWithGeneric<int>()
            {
                Things = new List<int>()
                {
                    1,
                    2,
                    3
                }
            };

            foreach (var item in employeeWithStrings.Things)
            {
                Console.WriteLine(item);
            }

            foreach (var item in employeeWithInts.Things)
            {
                Console.WriteLine(item);
            }
        }

        public static void Sample245()
        {
            var e1 = new EmployeeFor245() { Id = 1 };
            var e2 = new EmployeeFor245() { Id = 1 };

            Console.WriteLine(e1 == e2);
        }
        public static void Sample240()
        {
            IQuittable employee = new EmployeeFor240();

            employee.Quit();
        }
        public static void Sample260()
        {
            var number = new Number();
            number.Amount = 132;
            Console.WriteLine(number.Amount);
        }

        public static void Sample265()
        {
            var listOfEmployees = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Dirt", Id = 0},
                new Employee() {FirstName = "Joe", LastName = "Dirt2", Id = 1},
                new Employee() {FirstName = "Mike", LastName = "Johnson", Id = 2},
                new Employee() {FirstName = "Melonie", LastName = "Dirt", Id = 3},
                new Employee() {FirstName = "Anna", LastName = "Thompson", Id = 4},
                new Employee() {FirstName = "Donald", LastName = "Trump", Id = 5},
                new Employee() {FirstName = "Lebron", LastName = "James", Id = 6},
                new Employee() {FirstName = "James", LastName = "Harden", Id = 7},
                new Employee() {FirstName ="Michael", LastName = "Jordan", Id = 8},
                new Employee() {FirstName = "Katie", LastName = "Perry", Id = 9}
            };
            var newListOfjoes = new List<Employee>();
            foreach (var employee in listOfEmployees)
            {
                if (employee.FirstName == "Joe")
                    newListOfjoes.Add(employee);
            }
            var listWithIdGreaterThan5 = new List<Employee>();

            listWithIdGreaterThan5 = listOfEmployees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("List of joes");
            newListOfjoes.ForEach(x => x.SayName());

            Console.WriteLine("List of people with id > 5");
            listWithIdGreaterThan5.ForEach(x => x.SayName());
        }

    }
}
