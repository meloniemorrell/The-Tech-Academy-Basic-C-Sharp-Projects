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

            string[] weekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("Choose the day of the week from the list that is referred to as \"hump day\" ");
            Console.ReadLine();

            Console.WriteLine("Sunday, Monday, Tuesday, Wednesday,Thursday, Friday, Saturday");
            Console.ReadLine();

            Console.WriteLine(weekDays[3] + " ,yes that is correct!");
            Console.ReadLine();







        }
    }
}
