﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lists_assignments
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] stringArray = new String[7];

            stringArray[0] = "Sunday";
            stringArray[1] = "Monday";
            stringArray[2] = "Tuesday";
            stringArray[3] = "Wednesday";
            stringArray[4] = "Thursday";
            stringArray[5] = "Friday";
            stringArray[6] = "Saturday";
        


            Console.WriteLine("Select an index of the array: ");

            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[input1]);
            Console.ReadLine();





        }
    }
}