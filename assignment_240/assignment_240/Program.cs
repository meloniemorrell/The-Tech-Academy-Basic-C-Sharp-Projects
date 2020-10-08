using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_240
{
    interface IQuittable
    {
        void Quit();
    }

    class Program
    {
        static void Main(string[] args)
        {
            IQuittable e = new Employee();
            e.Quit();
            Console.ReadLine();
        }
    }

    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I am using polymorphism to create an object of type IQuittable");
        }
    }
}

