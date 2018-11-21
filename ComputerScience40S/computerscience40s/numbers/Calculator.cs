using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Useful collection of methods for doing calculations
/// </summary>
namespace ComputerScience40S.computerscience40s.numbers
{
    class Calculator
    {

        /// <summary>
        /// Calculates the factorial of a number
        /// </summary>
        /// <param name="number">the value to calculate</param>
        /// <returns>the factorial of that number</returns>
        public static double Factorial(int number)
        {
            if (number == 0)     return 1;                                              // base case
            else if (number < 0) return int.MinValue;                                   // base case
            else                 return number * Factorial(number - 1);
            // recursive case          
        }

        /// <summary>
        /// Calculates a power
        /// </summary>
        /// <param name="baseValue">the base of the power</param>
        /// <param name="exponent">the exponent of the power</param>
        /// <returns>the answer (the power itself)</returns>
        public static double Power(int baseValue, int exponent)
        {
            if      (exponent == 0) return 1;                                           // base case
            else if (exponent == 1) return baseValue;                                   // base case
            else if (exponent < 0)  return 1 / Power(baseValue, Math.Abs(exponent));    // base case
            else                    return baseValue * Power(baseValue, exponent - 1);  // recursive case
        }

    }
}
