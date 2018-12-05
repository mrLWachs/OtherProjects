using ComputerScience40S.computerscience40s.testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience40S.computerscience30s
{
    /// <summary>
    /// Student - represents a student. This class uses inheritance to inherit
    /// the properties and methods from the Person class. This means the Student
    /// class is the child(sub-class) of the parent class Person (super class,
    /// base class). This is sometimes simplified to a "is a" relationship
    /// </summary>
    class Student : Person
    {

        private int studentNumber;                      // encapsulated property
        private int grade;                              // encapsulated property
        private double gpa;                             // encapsulated property


        /// <summary>
        /// Constructor for the class sets class properties
        /// </summary>
        /// <param name="name">the name for this student</param>
        /// <param name="age">the age for this student</param>
        /// <param name="isMale">the gender for this student</param>
        /// <param name="grade">the grade for this student</param>
        /// <param name="studentNumber">the student number for this student</param>
        public Student(string name, int age, bool isMale, int grade,
                       int studentNumber) : base(name, age, isMale)             
        {
            gpa = 2.7;               // set internal properties
            this.grade = grade;
            this.studentNumber = studentNumber;
        }

        /// <summary>
        /// Studying raises the GPA
        /// </summary>
        public void Study()
        {
            gpa = gpa + (Math.PI * 0.01);
        }

        /**
         * Slacking off lowers the GPA
         */
        /// <summary>
        /// 
        /// </summary>
        public void SlackOff()
        {
            gpa = gpa - (Math.PI * 0.01) / 2;
        }

        /// <summary>
        /// Cramming is intense studying
        /// </summary>
        public void Cram()
        {
            for (int i = 0; i < 6; i++)
            {                               // study 6 times
                Study();
            }
        }

        /// <summary>
        /// Talking overrides the same talk method of the parent class
        /// and outputs additional information to the screen
        /// </summary>
        public void Talk()
        {
            base.Talk();
            Tester.print("\t - Student #: " + studentNumber +
                               ", GPA: " + gpa + ", Grade: " + grade);
        }


    }
}
