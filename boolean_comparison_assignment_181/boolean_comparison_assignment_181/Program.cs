using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_comparison_assignment_181
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Moses";

            if (name != "Moses")

            {

                Console.WriteLine("Welcome " + name);
                Console.ReadLine();

            }
            else 

            {

                Console.WriteLine("We don't know your name. Please enter your name: ");
                string p = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Welcome " + p + "!");
                Console.ReadLine();
            }






        }
    }
}
