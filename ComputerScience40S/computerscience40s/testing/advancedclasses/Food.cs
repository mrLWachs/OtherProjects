using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Food - represents abstract food
    /// </summary>
    abstract class Food
    {

        protected String group;

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        /// <param name="group">the food group for this object</param>
        public Food(string group)
        {
            this.group = group;
        }

        /// <summary>
        /// When food goes bad
        /// </summary>
        public void Spoil()
        {
            Tester.print("Yuck!");
        }

        /// <summary>
        /// Abstract definition of how to eat this object
        /// </summary>
        public abstract void Eat();

        /// <summary>
        /// Abstract definition of whether or not this object should be cooked
        /// </summary>
        /// <returns>it should be cooked (true) or not (false)</returns>
        public abstract bool ShouldCook();

    }
}
