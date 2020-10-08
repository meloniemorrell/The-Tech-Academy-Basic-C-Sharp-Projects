using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_248
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> e = new Employee<string>();
            e.things = new List<string> { "hello", "goodbye", "here" };
            foreach (string s in e.things)
            {
                Console.WriteLine(s);
            }

            Employee<int> e2 = new Employee<int>();
            e2.things = new List<int> { 1, 2, 3, 4 };
            foreach (int a in e2.things)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();
        }
    }

    class Employee<T>
    {
        public List<T> things;
    }

}
 
