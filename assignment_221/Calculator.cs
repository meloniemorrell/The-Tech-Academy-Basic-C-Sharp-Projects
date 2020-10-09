using System;
using System.Collections.Generic;
using System.Text;

namespace MelonieMorrell
{
    public static class Calculator
    {
        public static void DivideBy2(int n1)
        {
            int result = n1 / 2;
            Console.WriteLine(result);
        }
        public static void DivideBy2(int n1, out int n2)
        {
            n2 = n1 / 2;
            Console.WriteLine(n2);
        }
    }
}
