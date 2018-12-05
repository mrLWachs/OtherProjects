using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience30s
{
    /// <summary>
    /// Meeting - represents a meeting. This class associates ("has a") with
    /// objects of the Person class (through an array). It uses the concept of
    /// polymorphism to allow any Person objects or children(sub-classes) of the
    /// Person class to be added to the array.
    /// </summary>
    class Meeting
    {

        private Person[] members;       // associate array of Person objects
        private int index;              // index counter to track with array
        private const int MAX = 500;    // constant for maximum array size


        /// <summary>
        /// Default constructor sets class properties
        /// </summary>
        public Meeting()
        {
            members = new Person[MAX];                  // initialize array
            index = 0;                                // initialize counter
        }

        /// <summary>
        /// Adds a person to the members of the meeting
        /// </summary>
        /// <param name="person">the Person object to add</param>
        public void Attend(Person person)
        {
            members[index] = person;                    // assign to array
            index++;                                    // advance counter
            if (index >= MAX) index = 0;                // error check array bound
        }

        /// <summary>
        /// Has all of the active members of the meeting talk
        /// </summary>
        public void Hold()
        {
            Tester.print("~~~ Meeting beginning with " + index + " members");
            for (int i = 0; i < index; i++)
            {               // loop through
                members[i].Talk();                          // have member talk
            }
            Tester.print("~~~ Meeting adjurned!");
        }

    }
}
