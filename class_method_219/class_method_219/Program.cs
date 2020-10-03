using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to perform math operations on: ");
            int userinput = Convert.ToInt32(Console.ReadLine());

            Conversion calc = new Conversion();

            int result = calc.Subtract(userinput);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("Enter string to perform math operations on: ");
            int userinput1 = Convert.ToInt32(Console.ReadLine());

            Conversion calc1 = new Conversion();

            int result1 = calc1.Add(userinput1);
            Console.WriteLine(result1);
            Console.ReadLine();





        }





    }
}
