using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            Calculator calc = new Calculator();

            int result = calc.Add(userinput);
            Console.WriteLine(result);
            Console.ReadLine();

            int result2 = calc.Multiply(userinput);
            Console.WriteLine(result2);
            Console.ReadLine();

            int result3 = calc.Subtract(userinput);
            Console.WriteLine(result3);
            Console.ReadLine();



        }

    }
}

    
