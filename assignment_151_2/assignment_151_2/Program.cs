//using System;
//public class Exercise6
//{
//    public static void Main()
//    {


//        Console.WriteLine("Input number to add: ");
//        int a = Convert.ToInt32(Console.ReadLine());
//        int total = a + 25;
//        string msg = "Twenty-five plus " + a.ToString() + " is " + total.ToString();
//        Console.WriteLine(msg);
//        Console.ReadLine();




//    }
//}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input number to divide each integer by: ");
        int a = Convert.ToInt32(Console.ReadLine());

        List<int> divList = new List<int>() { 2, 4, 6 };

        // Part A: loop through List with foreach.
        foreach (int list in divList)
        {
            int result = list / a;
            Console.WriteLine(result);
            Console.ReadLine();

            //int divList = divList / int a(Console.ReadLine);

        }
    }
}
