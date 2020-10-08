using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_290
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();

            Console.WriteLine("Writing number to text file");
            System.IO.File.WriteAllText(@"number.txt", number);

            Console.WriteLine("Reading number from text file");
            string text = System.IO.File.ReadAllText(@"number.txt");

            Console.WriteLine("The number entered was " + text);
            Console.ReadLine();
        }
    }
}
