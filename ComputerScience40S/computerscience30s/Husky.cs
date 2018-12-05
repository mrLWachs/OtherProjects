using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience30s
{
    /// <summary>
    /// Husky - represents a Husky. This class uses inheritance to inherit
    /// the properties and methods from the Students class, which was already
    /// inheriting(extending) from the Person class. Therefore, this class
    /// inherits from both(a double inheritance).
    /// </summary>
    class Husky : Student
    {

        private bool pride;                          // encapsulated property


        /// <summary>
        /// Constructor for the class sets class properties
        /// </summary>
        /// <param name="name">the name for this Husky</param>
        /// <param name="age">the age for this Husky</param>
        /// <param name="isMale">the gender for this Husky</param>
        /// <param name="grade">the grade for this Husky</param>
        /// <param name="studentNumber">the student number for this student</param>
        public Husky(string name, int age, bool isMale, int grade,
                     int studentNumber): base(name, age, isMale, grade, studentNumber)     
        {            
            pride = true;                              // set internal properties
        }

        /// <summary>
        /// Lowers Husky pride
        /// </summary>
        public void MeetStaff()
        {
            pride = false;
        }

        /// <summary>
        /// Raises Husky pride
        /// </summary>
        public void EatCafeteriaFood()
        {
            pride = true;
        }

        /// <summary>
        /// Talking overrides the same talk method of the parent class
        /// and outputs additional information to the screen
        /// </summary>
        public void Talk()
        {
            base.Talk();       // call to super talk(), it calls super talk() also
            Tester.print("\t - Do I have pride? The answer is " + pride);
        }

    }
}
