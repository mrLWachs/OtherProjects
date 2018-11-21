using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// ComputerScienceStudent - represents a computer science high school student person
    /// </summary>
    class ComputerScienceStudent : HighSchoolStudent
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public ComputerScienceStudent(string name, int age,
            bool isMale,
            int studentNumber) : base(name, age, isMale, studentNumber)
        {

        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            return "ComputerScienceStudent " + base.ToString();
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
        public ComputerScienceStudent Clone()
        {
            return this;
        }

    }
}
