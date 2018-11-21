using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Teacher - represents a teacher person
    /// </summary>
    class Teacher : Person
    {

        private int count;                      // count of the current studetn to add
        private const int MAX_STUDENTS = 150;   // the maximum number of students
        public Student[] students;              // (composition) "has a" relationship


        /// <summary>
        /// Class constructor sets class properties
        /// </summary>
        /// <param name="name">the name of this teacher</param>
        /// <param name="age">the age of this teacher</param>
        /// <param name="isMale">the gender of this teacher</param>
        public Teacher(string name, int age, bool isMale) : base(
            name,age,isMale)
        {
            count    = 0;
            students = new Student[MAX_STUDENTS];
        }

        /// <summary>
        /// Adds a student to this teacher's collection
        /// </summary>
        /// <param name="student">the student to add</param>
        public void add(Student student)
        {
            students[count] = student;
            count++;
            if (count >= MAX_STUDENTS) count = 0;
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            String text =
                    "Teacher " + base.ToString() +
                    " and teaches " + count +
                    " out of " + MAX_STUDENTS +
                    " students:";
            for (int i = 0; i < count; i++)
            {
                text += "\n\t" + i + ": " +
                        students[i].ToString();
            }
            return text;
        }
        
        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            Teacher that = (Teacher)item;
            if (!base.Equals(that)) return false;
            if (this.count != that.count) return false;
            for (int i = 0; i < count; i++)
            {
                Student a = this.students[i];
                Student b = that.students[i];
                if (!a.Equals(b)) return false;
            }
            return true;
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public Teacher Clone()
        {
            Teacher teacher = new Teacher(
                this.GetName(),
                age,
                isMale);
            for (int i = 0; i < count; i++)
            {
                teacher.add(this.students[i].Clone());
            }
            return teacher;
        }

    }
}
