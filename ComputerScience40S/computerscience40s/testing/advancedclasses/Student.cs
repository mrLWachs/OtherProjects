using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Student - represents a student person
    /// </summary>
    class Student : Person
    {
        
        private int studentNumber;
        public static int totalStudents;

        /// <summary>
        /// Class constructor sets class properties
        /// </summary>
        /// <param name="studentNumber">the student number of this high school student</param>
        public Student(int studentNumber) : base()
        {
            this.isMale = true;              // modify protected member
            this.studentNumber = studentNumber;
            totalStudents++;
        }

        /// <summary>
        /// Class constructor, sets class properties
        /// </summary>
        /// <param name="name">the name of this student</param>
        /// <param name="age">the age of this student</param>
        /// <param name="isMale">the gender of this student</param>
        /// <param name="studentNumber">the student number of this student</param>
        public Student(String name, int age, bool isMale, int studentNumber) : 
            base(name,age,isMale)
        {
            this.studentNumber = studentNumber;
            totalStudents++;
        }

        /// <summary>
        /// Outputs data on this person to the screen
        /// </summary>
        public new void Talk()
        {
            Tester.print(this.ToString());
        }

        /// <summary>
        /// Accessor method to "see" the student number
        /// </summary>
        /// <returns>the private property</returns>
        public int GetStudentNumber()
        {
            return studentNumber;
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            return "Student " + base.ToString() +
                   " with Student #" + studentNumber;
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            Student student = (Student)item;
            if (!base.Equals(item)) return false;
            if (student.GetStudentNumber() != this.GetStudentNumber())
                return false;
            return true;
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public Student Clone()
        {
            return new Student(
                    base.GetName(),
                    base.age,
                    base.isMale,
                    studentNumber);
        }

    }
}
