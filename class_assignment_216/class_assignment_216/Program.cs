using parameterList;
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
   
            Console.WriteLine("Enter product cost: "); 
            string pC = Console.ReadLine(); 
            Console.WriteLine("Now enter current VAT rate: "); 
            string cR = Console.ReadLine(); 
            var result = myMethods.rate(Convert.ToDouble(pC), Convert.ToDouble(cR)); 
            Console.WriteLine("Total cost is {0:C}", result); 
            Console.ReadLine();

        }
    }
}
