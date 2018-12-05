using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience30s
{
    /// <summary>
    /// Person - represents a person. This is a class with properties (things 
    /// about the class, adjectives, descriptors) and methods(things the class
    /// can do, verbs, actions). Classes can be created(instantiated) into
    /// objects(which are instances of that class).
    /// </summary>
    class Person
    {

        // Properties: (things about it, adjectives, descriptors).................

        public string name;
        private int age;                        // encapsualted properties marked
        public bool isMale;                  // as private are "hidden" data
        private bool isAlive;                // only available inside the class

        // Methods: (things it can do, verbs, actions)............................

        /// <summary>
        /// Constructor method called (invoked) when the class is used to 
        /// build a object, this is called the "default" constructor
        /// </summary>
        public Person()
        {
            Born();
            isMale = false;
            name = "Jane Doe";
        }

        /// <summary>
        /// Constructor (overloaded) sets class properties
        /// </summary>
        /// <param name="nameForThePerson">the name for this person</param>
        public Person(string nameForThePerson)
        {
            Born();
            isMale = false;
            name = nameForThePerson;
        }

        /// <summary>
        /// Constructor method for the class, sets class properties
        /// </summary>
        /// <param name="name">the name for this person</param>
        /// <param name="age">the age for this person</param>
        /// <param name="isMale">the gender for this person</param>
        public Person(string name, int age, bool isMale)
        {
            isAlive = true;
            this.name = name;     // keyword this refers to the class property
            this.age = age;
            this.isMale = isMale;
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
            if (isAlive)
            {
                Tester.print(name + " is " + age + " and if you are wondering " +
                               "if I am a male, the answer is " + isMale);
            }
            else
            {
                Tester.print("Booooo!");
            }
        }

        /// <summary>
        /// A person has a birthday (their age goes up by one)
        /// </summary>
        public void Birthday()
        {
            age++;
        }

        /// <summary>
        /// A person has many birthdays
        /// </summary>
        /// <param name="times">how many birthdays to have</param>
        public void Birthday(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Birthday();
            }
        }

        /// <summary>
        /// A way to change genders
        /// </summary>
        public void Identify()
        {
            if (isMale == true)
            {
                isMale = false;
            }
            else if (isMale == false)
            {
                isMale = true;
            }
        }

    }
}
