using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace else_if_assignment_178
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();
                       

            Console.WriteLine("Please enter package weight: ");
            int wt = Convert.ToInt32(Console.ReadLine());

            if (wt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            break;

            Console.WriteLine("Please enter package width: ");
            int wi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height: ");
            int h = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter package length: ");
            int l = Convert.ToInt32(Console.ReadLine());

        

            if (wi * h * l > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");

                break;
                                
            }
                    
           

            int totalWt= ((l * wi * h) * wt / 100);
            string msg = "The quote for your shipping charges is $ " + totalWt.ToString();




        }
    }

}