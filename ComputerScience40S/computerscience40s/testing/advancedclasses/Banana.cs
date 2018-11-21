using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Banana - represents a banana
    /// </summary>
    class Banana : Food
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public Banana() : base("Fruit")
        {
            
        }

        /// <summary>
        /// How to eat this banana
        /// </summary>
        public override void Eat()
        {
            Tester.print("Like a monkey");
        }

        /// <summary>
        /// Whether or not this banana should be cooked
        /// </summary>
        /// <returns>it should be cooked (true) or not (false)</returns>
        public override bool ShouldCook()
        {
            return true;
        }

    }
}
