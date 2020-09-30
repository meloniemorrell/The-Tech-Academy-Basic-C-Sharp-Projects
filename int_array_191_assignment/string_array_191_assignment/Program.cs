using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lists_assignments
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numArray = new int[10];

            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;
            numArray[5] = 6;
            numArray[6] = 7;
            numArray[7] = 8;
            numArray[8] = 9;
            numArray[9] = 10;


            Console.WriteLine("Select an index of the array: ");

            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput > 9 || userinput < 0)
            {

                Console.WriteLine("Try again!");
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine(numArray[userinput]);
                Console.ReadLine();

            }





        }
    }
}