using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_6_202
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> randomThings = new List<string>() { "glue", "water", "carpet", "cars", "water" };
            List<string> firstTimeSeeing = new List<string>() {};



            foreach (string things in randomThings)
                    {
                    if (!firstTimeSeeing.Contains(things))
                    {
                    firstTimeSeeing.Add(things);
                    Console.WriteLine(things);
                    }
                    else 
                    {
                    Console.WriteLine(things + " has been mentioned already in this list");
                    }
                }
                Console.ReadLine();
            }


         //   if (firstTimeSeeing.Contains(things))

         //       {

         //          //

         //           else 
         //           Console.WriteLine("Duplicate value");
         //       }
         //       Console.ReadLine();
                
         //}

    }
}
