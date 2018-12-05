using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience30s
{
    /// <summary>
    /// Teacher - represents a Teacher. This class uses inheritance to inherit
    /// the properties and methods from the Person class. This class also
    /// "associates" with the Student class by making a reference to them within
    /// the class. This is sometimes simplified as a "has a" relationship.
    /// </summary>
    class Teacher : Person
    {

        public Student[] students;                  // an array of class objects


        /// <summary>
        /// Constructor for the class sets class properties
        /// </summary>
        /// <param name="name">the name for this Teacher</param>
        public Teacher(string name): base(name)     // call to super constructor
        {                   
            base.Birthday(30);                     // set super private property
            students = new Student[100];           // build up array
        }

        /// <summary>
        /// Teaches all the students this teacher has an association with by making
        /// them study
        /// </summary>
        public void Teach()
        {
            for (int i = 0; i < students.Length; i++)
            { // traverse array
                if (students[i] != null)
                {              // array spot not a null
                    students[i].Study();                // make this spot study
                }
            }
        }

        /// <summary>
        /// Talking overrides the same talk method of the parent class
        /// and outputs additional information to the screen
        /// </summary>
        public void Talk()
        {
            base.Talk();                       // call to the super talk method
            Tester.print("\t - I teach " + students.Length + " students:");
        }
        
    }
}
