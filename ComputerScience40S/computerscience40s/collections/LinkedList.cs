using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// LinkedList - description...
/// </summary>
namespace ComputerScience40S.computerscience40s.collections
{
    class LinkedList
    {

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public LinkedList()
        {

        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            return "LinkedList " + base.ToString();
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
        public LinkedList Clone()
        {
            return this;
        }

    }
}
