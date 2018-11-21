using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Wonton - represents wonton
    /// </summary>
    class Wonton : Food
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public Wonton() : base("Mixture")
        {

        }

        /// <summary>
        /// How to eat this wonton
        /// </summary>
        public override void Eat()
        {
            Tester.print("With chopsticks");
        }

        /// <summary>
        /// Whether or not this wonton should be cooked
        /// </summary>
        /// <returns>it should be cooked (true) or not (false)</returns>
        public override bool ShouldCook()
        {
            return true;
        }

    }
}
