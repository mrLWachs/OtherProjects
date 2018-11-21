using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Husky - represents a husky computer science high school student person
    /// </summary>
    class Husky : ComputerScienceStudent
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public Husky(string name, int age, bool isMale, 
            int studentNumber) : base(name, age, isMale, studentNumber)
        {

        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            return "Husky " + base.ToString();
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            return base.Equals(item);
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public Husky Clone()
        {
            return this;
        }

    }
}
