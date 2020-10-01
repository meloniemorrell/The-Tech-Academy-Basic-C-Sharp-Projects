using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_1_197
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Cats", "Dogs", "Birds" };

            Console.WriteLine("Please enter some text: ");

            string userinput = Console.ReadLine();


            foreach (string pet in stringArray)
            {
                Console.WriteLine(pet + userinput);
                Console.ReadLine();
            }


        }




    }
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_2_198
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] stringArray = { "Cats", "Dogs", "Birds" };

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("value of {0}", i);
                }
                Console.ReadLine();


                //infinite loop
                //for (int i = 0; i < 50; i--)
                //{
                //    Console.WriteLine("value of {0}", i);
                //}
                //Console.ReadLine();

                Console.WriteLine(String.Format("{0} are my least favorite pet", stringArray));
                Console.ReadLine();


            }
        }
    }



using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_part_3_197
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] stringArray = { "Cats", "Dogs", "Birds" };


                int i = 0;
                do
                {
                    Console.WriteLine(stringArray[i]);
                    i = i + 1;
                }
                while (i < 3);
                Console.ReadLine();

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(j);
                }
                Console.ReadLine();

            }
        }

    }

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_part_4_199
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] stringArray = { "Cats", "Dogs", "Birds" };


                int i = 0;
                do
                {
                    Console.WriteLine(stringArray[i]);
                    i = i + 1;
                }
                while (i < 3);
                Console.ReadLine();

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(j);
                }
                Console.ReadLine();

            }
        }

    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_5_200
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> randomThings = new List<string>() { "glue", "water", "carpet", "cars" };

                Console.WriteLine("Please select item from list:");
                string userinput = Console.ReadLine();


                for (int i = 0; i < randomThings.Count; i++)
                {


                    if (randomThings[i] == userinput)
                    {
                        Console.WriteLine("index of " + userinput + " is " + i);
                        Console.ReadLine();
                    }

                }

                for (int i = 0; i < randomThings.Count; i++)
                {


                    if (randomThings[i] != userinput)
                    {
                        Console.WriteLine("Input error. Please try again");
                        Console.ReadLine();

                    }
                }

            }

        }
    }

