using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Home - represents a house with a homeowner and contents
    /// </summary>
    /// <typeparam name="T">the generic type for the owner (must be a child of Person)</typeparam>
    /// <typeparam name="U">the generic type for the contents of the house</typeparam>
    class Home <T, U> where T : Person
    {

        private T owner;
        private U[] contents;

        /// <summary>
        /// Constructor for the class, sets class properties
        /// </summary>
        /// <param name="owner">the owner of the home</param>
        /// <param name="contents">the contents of the home</param>
        public Home(T owner, U[] contents)
        {
            this.owner    = owner;
            this.contents = contents;
        }

        /// <summary>
        /// Visits the home and outputs owner and all contents
        /// </summary>
        public void visit()
        {
            String text = "Owner " + owner.GetName();
            text += " has ";
            foreach (var item in contents)
            {
                text += "\n\t-" + item.ToString();
            }
            Tester.print(text);
        }

    }
}
