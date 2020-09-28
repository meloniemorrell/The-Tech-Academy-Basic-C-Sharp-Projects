using System;
public class Exercise6
{
    public static void Main()
    {


        Console.WriteLine("Input number to add: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int total = a + 25;
        string msg = "Twenty-five plus " + a.ToString() + " is " + total.ToString();
        Console.WriteLine(msg);
        Console.ReadLine();




    }
}