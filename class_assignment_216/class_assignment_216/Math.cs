// C# program to demonstrate the 
// value of Math Class Fields 
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace mathParameters
{

	public class Methods
	{

		public Methods()
		{
            int[] array1 = { };
            List<int> list1 = new List<int>() { };

            //
            // Use Sum extension on their elements.
            //
            int sum1 = array1.Sum();
            int sum2 = list1.Sum();

            //
            // Write results to screen.
            //
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            {
           

            }

        }

	}

}

