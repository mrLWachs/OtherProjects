using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Spaghetti - represents spaghetti
    /// </summary>
    class Spaghetti : Food
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public Spaghetti() : base("Grains")
        {

        }

        /// <summary>
        /// How to eat this spaghetti
        /// </summary>
        public override void Eat()
        {
            Tester.print("With a fork");
        }

        /// <summary>
        /// Whether or not this spaghetti should be cooked
        /// </summary>
        /// <returns>it should be cooked (true) or not (false)</returns>
        public override bool ShouldCook()
        {
            return true;
        }

    }
}
