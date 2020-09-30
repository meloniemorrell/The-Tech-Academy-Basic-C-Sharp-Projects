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


            //int i = 0;
            //do
            //{
            //    Console.WriteLine(stringArray[i]);
            //    i = i + 1;
            //}
            //while (i < 3);
            //Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

        }
    }

}

















