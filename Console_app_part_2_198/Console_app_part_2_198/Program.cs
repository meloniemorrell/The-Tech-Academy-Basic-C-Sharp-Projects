using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_part_1_197
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Cats", "Dogs", "Birds" };


            for (int i = 0; i < 50; i--)
            {
                Console.WriteLine("value of {0}", i);
            }
            Console.ReadLine();

            Console.WriteLine(String.Format("{0} are my least favorite pet", stringArray));
            Console.ReadLine();


        }
    }
}
