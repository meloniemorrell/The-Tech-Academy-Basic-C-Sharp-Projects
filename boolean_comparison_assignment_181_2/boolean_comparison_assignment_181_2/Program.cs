using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_comparison_assignment_181_2
{
    class Program
    {
        static void Main(string[] args)
        {
      
                Console.WriteLine("Guess my car?");
                string car = Convert.ToString(Console.ReadLine());
                bool isGuessed = car == "bmw";
                                               
                do
                {

                    switch (car)
                    {
                        case "volvo":
                            Console.WriteLine("You guessed volvo. Try again.");
                            Console.WriteLine("Guess a car?");
                            car = Convert.ToString(Console.ReadLine()); 
                            break;
                        case "volkswagen":
                            Console.WriteLine("You guessed volkswagen. Try again.");
                            Console.WriteLine("Guess a car?");
                            car = Convert.ToString(Console.ReadLine());
                            break; ;
                        case "honda":
                            Console.WriteLine("You guessed 55. Try again.");
                            Console.WriteLine("Guess a car?");
                            car = Convert.ToString(Console.ReadLine()); 
                            break; ;
                        case "bmw":
                        Console.WriteLine("You guessed the right car. You are correct!");
                            isGuessed = true;
                            break;
                        default:
                            Console.WriteLine("You are wrong.");
                            Console.WriteLine("Guess a number?");
                            car = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }

                while (!isGuessed);
                {

                }
                Console.Read();
            }
        }
    }





