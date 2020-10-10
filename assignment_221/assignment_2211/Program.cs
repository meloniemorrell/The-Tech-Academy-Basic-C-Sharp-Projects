using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melonie221
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass some = new SomeClass();
            some.someMethod(1, 2);
            some.someMethod(a: 3, b: 4);
            Console.ReadLine();
        }
    }

    class SomeClass
    {
        public void someMethod(int a, int b)
        {
            a++;
            Console.WriteLine(b);
        }
    }
}



