using System;
public class Exercise6
{
    public static void Main()
    {


        Console.WriteLine("Input number to be divided by: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int r = a % 7;
        string msg = "Result of  " + a.ToString() + " divided by 7 is " + r.ToString();
        Console.WriteLine(msg);
        Console.ReadLine();




    }
}
