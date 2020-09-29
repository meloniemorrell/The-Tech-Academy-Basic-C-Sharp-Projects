using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        string[] items = { "-eating healthy", "-exercising daily", "-discipline and dedication" };

        StringBuilder builder2 = new StringBuilder(
            "A healthy lifestyle requires:").AppendLine();

        foreach (string item in items)
        {
            builder2.Append(item).AppendLine();
        }
        Console.WriteLine(builder2.ToString());
        Console.ReadLine();

        Console.Read();
            }
        }
    









