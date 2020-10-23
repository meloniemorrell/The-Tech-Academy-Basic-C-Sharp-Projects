using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM293
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("g"));
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            //convert to integer
            Int32.TryParse(input, out int number);
            DateTime newDate = today.AddHours(number);
            Console.WriteLine("The new date requested is: " + newDate.ToString("g"));
            Console.ReadLine();
        }
    }
}
