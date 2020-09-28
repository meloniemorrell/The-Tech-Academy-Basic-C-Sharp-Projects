using System;
public class Exercise6
{
    public static void Main()
    {
     

        Console.WriteLine("Input the number to multiply: ");
        double a = Convert.ToInt32(Console.ReadLine());
        double total =  a * 50;
        string msg = "Fifty times " + a.ToString() + " is " + total.ToString()  ;
        Console.WriteLine(msg);
        Console.ReadLine();




    }
}