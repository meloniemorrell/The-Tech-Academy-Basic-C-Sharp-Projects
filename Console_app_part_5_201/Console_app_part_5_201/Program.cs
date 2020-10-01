using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_part_4_200
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> randomThings = new List<string>() { "glue", "water", "carpet", "cars" , "water"};

            Console.WriteLine("Please select item from list:");
            string userinput = Console.ReadLine();


            for (int i = 0; i < randomThings.Count; i++)
            {


                if (randomThings[i] == userinput)
                {
                    Console.WriteLine("index of " + userinput + " is " + i);
                    Console.ReadLine();
                }

            }

            for (int i = 0; i < randomThings.Count; i++)
            {


                if (randomThings[i] != userinput)
                {
                    Console.WriteLine("Input error. Please try again");
                    Console.ReadLine();

                }
            }

        }

    }
}
