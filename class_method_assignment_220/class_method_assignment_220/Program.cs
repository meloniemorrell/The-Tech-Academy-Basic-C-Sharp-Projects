using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator2 calculator = new Calculator2();
            int result;
            Console.WriteLine("Enter a number, enter another number but you do not have to enter a second number. ");
            string userinput1 = Console.ReadLine();
            string userinput2 = Console.ReadLine();

            if (String.IsNullOrEmpty(userinput2))
            {
                result = calculator.Add(Convert.ToInt32(userinput1));
            }
            else
            {
                result = calculator.Add(Convert.ToInt32(userinput1), Convert.ToInt32(userinput2));
            }
            Console.WriteLine(result);
            Console.ReadLine();
            

        }
    }
}
    