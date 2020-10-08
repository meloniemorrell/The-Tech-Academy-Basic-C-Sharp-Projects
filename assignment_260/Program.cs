using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_260
{
    struct Number
    {
        public decimal Amount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Number n;
            n.Amount = 1.5m;
            Console.WriteLine(n.Amount.ToString("n2"));
            Console.ReadLine();
        }
    }
}
