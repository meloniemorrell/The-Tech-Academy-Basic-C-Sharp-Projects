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

            Console.WriteLine("Enter decimal number to perform math operations on: ");
            decimal userinput2 = Convert.ToDecimal(Console.ReadLine());


            decimal result2 = calc.Multiply(userinput2);
            Console.WriteLine(result2);
            Console.ReadLine();


            Console.WriteLine("Enter string to perform math operations on: ");
            string userinput1 = Console.ReadLine();


            int result1 = calc.Subtract(userinput1);
            Console.WriteLine(result1);
            Console.ReadLine();





        }





    }
}
