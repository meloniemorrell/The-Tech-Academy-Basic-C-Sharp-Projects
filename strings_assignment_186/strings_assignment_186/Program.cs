using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_assignment_186
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Convert.ToString(Console.ReadLine());

            string dateString = DateTime.Today.ToShortDateString();
            string hello = " How are you today?";
           

            string str = "Hello " + userName + ". Today is " + dateString + hello;
            System.Console.WriteLine(str);
            Console.Read();

            

        }
    }


	}

