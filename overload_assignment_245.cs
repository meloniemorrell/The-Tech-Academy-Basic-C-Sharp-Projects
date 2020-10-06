using System;
using System.Collections.Generic;
using System.Text;

namespace MelonieMorrell
{
    public class Employee : Person
    {
        public int Id { get; set; }

    }
    public class EmployeeWithGeneric<T>
    {
        public List<T> Things { get; set; }
    }
    public class EmployeeFor245
    {
        public int Id { get; set; }
        public static bool operator ==(EmployeeFor245 e1, EmployeeFor245 e2)
        {
            if (e1.Id == e2.Id)
                return true;
            else
                return false;
        }
        public static bool operator !=(EmployeeFor245 e1, EmployeeFor245 e2)
        {
            if (e1.Id != e2.Id)
                return true;
            else
                return false;
        }
    }
    public class EmployeeFor240 : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}
