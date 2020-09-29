using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_boolean_161
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI, True or False? ");
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have? ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            bool a = (num1 > 15 && (trueOrFalse == false) && num3 < 3);


            if (a == true)
            {
                Console.WriteLine("Approved");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Not approved");
                Console.ReadLine();
            }






        }




    }
}