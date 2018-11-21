using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// Person - represents a person
    /// </summary>
    class Person
    {

        private   String name;             // encapsulated property
        public    int    age;              // public property    
        protected bool   isMale;           // property available to child classes

        /// <summary>
        /// Default constructor for the class (constructor methods use the same 
        /// name as the class and has NO return type - not even void)
        /// </summary>
        public Person()
        {
            name   = "Jane doe";
            age    = 0;
            isMale = false;
        }

        /// <summary>
        /// Class constructor, sets class properties
        /// </summary>
        /// <param name="name">the name of this person</param>
        /// <param name="age">the age of this person</param>
        /// <param name="isMale">the gender of this person</param>
        public Person(String name, int age, bool isMale)
        {
            this.name   = name;
            this.age    = age;
            this.isMale = isMale;
        }

        /// <summary>
        /// Action method to have the person talk (outputs data on this person 
        /// to the screen)
        /// </summary>
        public void Talk()
        {
            Tester.print(this.ToString());
        }

        /// <summary>
        /// Accessor method to "see" the name
        /// </summary>
        /// <returns>the private property</returns>
        public String GetName()
        {
            return name;
        }

        /// <summary>
        /// Mutator method to "change" the name
        /// </summary>
        /// <param name="name">to mutate the private property</param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override string ToString()
        {
            return "Person " + name +
                   " is " + age +
                   " and is male is " + isMale;
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(object item)
        {
            Person person = (Person)item;
            if (person.isMale != this.isMale) return false;
            if (person.age != this.age) return false;
            if (!person.GetName().Equals(this.GetName()))
                return false;
            return true;
        }
        
        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public Person Clone()
        {
            Person person = new Person();
            person.age    = this.age;
            person.isMale = this.isMale;
            person.SetName(this.GetName());
            return person;
        }

        /// <summary>
        /// Ends the world
        /// </summary>
        public static void EndTheWorld()
        {
            Tester.print("Booom!!!!");
        }

        /// <summary>
        /// How a person can consume food
        /// </summary>
        /// <param name="food">the abstract food item to consume</param>
        public void Consume(Food food)
        {
            if (food.ShouldCook())
            {
                food.Eat();
            }
            else
            {
                food.Spoil();
            }
        }
        
    }
}
