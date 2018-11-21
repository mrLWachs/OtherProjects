using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Meeting - represents a meeting of people
    /// </summary>
    class Meeting
    {

        private Person[] members;
        private int count;
        private const int MAX = 500;

        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public Meeting()
        {
            count = 0;
            members = new Person[MAX];
        }

        /// <summary>
        /// Have a person attend the meeting
        /// </summary>
        /// <param name="person">the person to attend</param>
        public void attend(Person person)
        {
            members[count] = person;
            count++;
            if (count >= MAX) count = 0;
        }

        /// <summary>
        /// Hold the meeting and have everyone talk
        /// </summary>
        public void hold()
        {
            Tester.print("Meeting begins, but watch your language, because "
                    + Student.totalStudents + " students are here!");
            foreach (Person member in members)
            {               // enhanced for loop "for each member in members"
                if (member != null)
                {           // spots that have a person in them
                    member.Talk();
                    if (member is MrWachs) {
                        Tester.print("Shhhh!, Wachs is talking");
                    }
                }
            }
            Tester.print("Meeting adjourned!");
        }

    }
}
