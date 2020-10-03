using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations1
{
    class Program
    {
        static void Main(string[] args)
         {
            
            Console.WriteLine("Enter two numbers one at a time. However, you do not have to input the second number. ");
            int userinput1 = Convert.ToInt32(Console.ReadLine());

            Calculator1 calc = new Calculator1();

            int result = calc.Add(userinput1);
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }

}
    