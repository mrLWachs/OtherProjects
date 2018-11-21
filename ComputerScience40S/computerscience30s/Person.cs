using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience30s
{
    /// <summary>
    /// Person - defines what it is to be a person
    /// </summary>
    class Person
    {

        // Properties: ------------------------------------------------------------

        String name;
        int age;
        bool isAlive;
        bool isMale;

        // Methods: ---------------------------------------------------------------

        /// <summary>
        /// Constructor method for th class, sets class properties to default values
        /// </summary>
        public Person()
        {
            Born();
            isMale = false;
            name = "Jane Doe";
        }

        /// <summary>
        /// When a person is born
        /// </summary>
        public void Born()
        {
            isAlive = true;
            age = 0;
        }

        /// <summary>
        /// When a person dies
        /// </summary>
        public void Die()
        {
            isAlive = false;
        }

        /// <summary>
        /// A person talks (by outputting information to the screen)
        /// </summary>
        public void Talk()
        {
            Tester.print(name + " is " + age + " and if you are wondering " +
                               "if I am a male, the answer is " + isMale);
        }

        /// <summary>
        /// A person has a birthday (their age goes up by one)
        /// </summary>
        public void Birthday()
        {
            age++;
        }

    }
}
