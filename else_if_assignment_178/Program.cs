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
                Console.ReadLine();

            }

            else if (wt < 50)
            {
                Console.WriteLine("Please enter package width: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height: ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter package length: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int totalWt = ((num1 + num2 + num3) * wt / 100);
                string msg = "The quote for your shipping charges is $ " + totalWt.ToString();
                Console.ReadLine();


                if (num1 + num2 + num3 > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express.");
                }
            }             
           

            




        }
    }

}