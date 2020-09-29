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

            int[] numArray = new int[14];

            numArray[0] = 1;
            numArray[1] = 23;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;
            numArray[5] = 6;
            numArray[6] = 7;
            numArray[7] = 8;
            numArray[8] = 9;
            numArray[9] = 10;
            numArray[10] = 11;
            numArray[11] = 12;
            numArray[12] = 13;
            numArray[13] = 14;
           
            Console.WriteLine("Select an index of the array: ");

            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[input1]);
            Console.ReadLine();

            
           


        }
    }
}
