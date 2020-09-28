using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


class Program
{

    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.ReadLine();
        Console.WriteLine("Person 1");
        Console.ReadLine();
        Console.WriteLine("Enter hourly rate: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter hours worked per week: ");
        int b= Convert.ToInt32(Console.ReadLine());
        int s1 = (a * b *52);
        string msg = "Annual salary for Person 1 is " + s1.ToString();
        Console.WriteLine(msg);
        Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.ReadLine();
        Console.WriteLine("Enter hourly rate: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter hours worked per week: ");
        int d = Convert.ToInt32(Console.ReadLine());
        int s2 = (c * d * 52);
        string msg1 = "Annual salary for Person 2 is " + s2.ToString();
        Console.WriteLine(msg1);
        Console.ReadLine();

        Console.WriteLine("Does person 1 make more money than person 2? ");
        bool trueOrFalse = s1 > s2;
        Console.WriteLine(trueOrFalse.ToString());
        Console.ReadLine();



    }
}