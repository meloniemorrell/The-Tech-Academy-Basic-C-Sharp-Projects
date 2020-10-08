using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_303
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 0;
            var someVariable = "";

            Employee emp = new Employee("Marc", "32");
            Console.ReadLine();
        }
    }

    public class Employee
    {

        public Employee() : this(string.Empty, string.Empty, string.Empty)
        {
            Console.WriteLine("Employee() constructor called");
        }

        public Employee(string Name, string EmpId) : this(Name, EmpId, string.Empty)
        {
            Console.WriteLine("Employee(Name,EmpId) constructor called");
        }

        public Employee(string Name, string EmpId, string Department)
        {
            Console.WriteLine("Employee(Name,EmpId,Department) constructor called");
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(EmpId) && !string.IsNullOrEmpty(Department))
                ;
            //assign values
        }
    }
}

    
