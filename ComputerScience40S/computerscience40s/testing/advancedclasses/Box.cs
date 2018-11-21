using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Box - represents a box that contains stuff
    /// </summary>
    /// <typeparam name="T">the generic type for the box contents</typeparam>
    class Box <T>
    {

        private T stuff;

        /// <summary>
        /// Opens the box and returns its contents
        /// </summary>
        /// <returns>the contents of the box</returns>
        public T open()
        {
            return stuff;
        }

        /// <summary>
        /// Puts the stuff into the box
        /// </summary>
        /// <param name="stuff">the item to put in the box</param>
        public void wrap(T stuff)
        {
            this.stuff = stuff;
        }

        /// <summary>
        /// Peeks in the box and outputs the contents
        /// </summary>
        public void peek()
        {
            Tester.print(stuff.ToString());
        }

    }
}
