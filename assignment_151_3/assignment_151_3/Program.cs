using System;
public class Exercise6
{
    public static void Main()
    {


        Console.WriteLine("Input number to be divided by: ");
        int a = Convert.ToInt32(Console.ReadLine());
        double quotient = (int)(a / 12.5);
        string msg = "Result of  " + a.ToString() + " divided by 12.5 is " + quotient.ToString();
        Console.WriteLine(msg);
        Console.ReadLine();




    }
}