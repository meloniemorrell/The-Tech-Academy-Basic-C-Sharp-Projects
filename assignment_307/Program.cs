using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melonie307
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            Console.Write("What is your age? ");
            string age = Console.ReadLine();

            try
            {
                year = Convert.ToInt32(age);
                if (year > 0)
                {
                    DateTime now = DateTime.Now;
                    DateTime bday = now.AddYears((-1 * year));
                    Console.WriteLine("Your birth year is " + bday.Year);
                }
                else
                {
                    Console.WriteLine($"Invalid age: {year}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number entered...");
            }

            Console.ReadLine();
        }
    }
}
