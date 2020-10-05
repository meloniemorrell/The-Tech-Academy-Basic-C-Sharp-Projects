using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Conversion
        
    {
      

            public int Subtract(int num1)
            {
                int m_result = num1 - 2;
                return m_result;
            }

            public int Subtract(decimal num1)
            {
                decimal d_result = num1 - 2;
                int intresult = Convert.ToInt32(d_result);
                return intresult;
            }

            public int Subtract(string num1)
            {
                int d_result = Convert.ToInt32(num1) - 2;
                return d_result;
            }
            public decimal Multiply(decimal num2)
            {
                decimal d_result2 = num2 * 2;
                return d_result2;
            }
            
            public int Add (int num2)
            {
                int s_result1 = num2 + 2;
                return s_result1;


            }
        }
    }









