using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// IceCreamCone - represents a ice cream cone
    /// </summary>
    class IceCreamCone : Food
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public IceCreamCone() : base("Dairy")
        {

        }

        /// <summary>
        /// How to eat this ice cream cone
        /// </summary>
        public override void Eat()
        {
            Tester.print("Don't drop");
        }

        /// <summary>
        /// Whether or not this ice cream cone should be cooked
        /// </summary>
        /// <returns>it should be cooked (true) or not (false)</returns>
        public override bool ShouldCook()
        {
            return false;
        }

    }
}
