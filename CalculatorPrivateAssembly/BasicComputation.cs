using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public partial class Basic_Computation
    {
        public static float Addition(float number1, float number2)
        {
            float result = number1 + number2;
            return result;
        }
        public static float Subtraction(float number1, float number2)
        {
            float result = number1 - number2;
            return result;
        }
        public static float Multiplication(float number1, float number2)
        {
            float result = number1 * number2;
            return result;
        }
        public static float Division(float number1, float number2)
        {
            float result = number1 / number2;
            return result;
        }
    }
}
