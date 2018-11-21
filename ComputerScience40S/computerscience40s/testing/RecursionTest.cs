using ComputerScience40S.computerscience40s.numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// The unit test to test the concept of recursion
/// </summary>
namespace ComputerScience40S.computerscience40s.testing
{
    class RecursionTest
    {

        /// <summary>
        /// Default class constructor, runs on instantiation
        /// </summary>
        public RecursionTest()
        {
            Tester.print("\nRecursion testing started...\n");

            const int MAX = 30;

            int maximum = MAX;
            int minimum = 0;

            Tester.print("Factorials...");
            for (int number = minimum; number <= maximum; number++)
            {
                double answer = Calculator.Factorial(number);
                Tester.print("Number " + number +
                                            " is factorial " + answer);
            }

            Tester.print("Powers...");
            maximum = MAX;
            minimum = -maximum;

            for (int baseValue = minimum; baseValue <= maximum; baseValue++)
            {
                for (int exponent = minimum; exponent <= maximum; exponent++)
                {
                    double answer = Calculator.Power(baseValue, exponent);
                    Tester.print("Base " + baseValue +
                                               " to the exponent " + exponent +
                                               " = \t" + answer);
                }
            }

            Tester.print("\nRecusion testing complete!\n");
        }

    }
}
