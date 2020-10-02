
//        Console.WriteLine("Input number to divide each integer by: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        List<int> divList = new List<int>() { 2, 4, 6 };

//        // Part A: loop through List with foreach.
//        foreach (int list in divList)
//        {
//            int result = list / a;
//            Console.WriteLine(result);
//            Console.ReadLine();

//            //int divList = divList / int a(Console.ReadLine);

//        }
//    }
//}

using System;
using System.Collections.Generic;


namespace exceptions_video_203
{


    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Input number to divide each integer by: ");
                int a = Convert.ToInt32(Console.ReadLine());

                List<int> divList = new List<int>() { 2, 4, 6 };

                // Part A: loop through List with foreach.

                foreach (int list in divList)
                {
                    int result = list / a;
                    Console.WriteLine(result + "Good job!");
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);or
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero");

            }


            catch (Exception ex)
            {
                Console.WriteLine("This program will now close");
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
}


