using System;

namespace class_overload_assignment_224

{
    class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();
            Console.WriteLine("Enter an integer");

            var userInput = Console.ReadLine();

            var inputAsInt = Convert.ToInt32(userInput);

            Calculator.DivideBy2(inputAsInt);

            int outputValue;
            Calculator.DivideBy2(inputAsInt, out outputValue);
            var userInput1 = Console.ReadLine();


        }

    }
}