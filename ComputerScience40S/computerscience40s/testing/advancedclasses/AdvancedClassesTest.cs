using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// AdvancedClassesTest - tests the concepts learned in this unit
    /// </summary>
    class AdvancedClassesTest
    {

        /// <summary>
        /// Default class constructor, runs on instantiation
        /// </summary>
        public AdvancedClassesTest()
        {
            Tester.print("\nAdvanced Classes testing started...\n");

            // instantiating (creating an instances of) Person objects
            Person person1 = new Person();                  // create person object        
            Person person2 = new Person();                  // create another object        
            person1.age = 50;                               // modify property        
            person1.Talk();                                 // call Talk
            person2.Talk();                                 // call Talk        

            // creating student objects
            Student student1 = new Student(100);            // create student object
            Student student2 = new Student(101);            // create another object        
            student1.Talk();                                // call Talk     
            student2.Talk();                                // call Talk   

            // Using the built-in Object class and it's methods
            Object object1 = new Object();                  // instantiate objects
            Object object2 = new Object();
            Object object3 = object2;
            Tester.print(object1.ToString());         // use ToString
            Tester.print(object2.ToString());
            Tester.print(object3.ToString());
            if (object1.Equals(object2)) Tester.print("1 == 2");
            else Tester.print("1 != 2");
            if (object2.Equals(object3)) Tester.print("2 == 3");
            else Tester.print("2 != 3");

            // testing ToString, Equals, Clone:        
            Person person3 = new Person("Peter Parker", 23, true);
            Person person4 = new Person("Jimmy Neutron", 12, true);
            Tester.print(person3.ToString());
            Tester.print(person4.ToString());
            Person person5 = person3.Clone();
            Tester.print(person5.ToString());
            if (person3.Equals(person4)) Tester.print("3 == 4");
            else Tester.print("3 != 4");
            if (person3.Equals(person5)) Tester.print("3 == 5");
            else Tester.print("3 != 5");

            // creating and testing more student methods
            Student student3 = new Student("Jeff Moore", 21, true, 21);
            Student student4 = new Student("Jenko Jones", 22, true, 22);
            Tester.print(student3.ToString());
            Tester.print(student4.ToString());
            Student student5 = student3.Clone();
            Tester.print(student5.ToString());
            if (student3.Equals(student5)) Tester.print("3 == 5");
            else Tester.print("3 != 5");

            // create and test teacher class
            Teacher teacher1 = new Teacher("Mr. Stein", 45, true);
            teacher1.add(student1);
            teacher1.add(student2);
            teacher1.add(student3);
            teacher1.add(student4);
            Tester.print(teacher1.ToString());
            // another teacher instance, cloned
            Teacher teacher2 = teacher1.Clone();
            Tester.print(teacher2.ToString());
            // another new teacher instance
            Teacher teacher3 = new Teacher("Mr. T", 66, true);
            Tester.print(teacher3.ToString());
            // test Equals between teachers        
            if (teacher1.Equals(teacher2)) Tester.print("1 == 2");
            else Tester.print("1 != 2");
            if (teacher1.Equals(teacher3)) Tester.print("1 == 3");
            else Tester.print("1 != 3");

            // checking the status of various objects
            CheckStatus(person1);
            CheckStatus(object1);
            CheckStatus(student1);
            CheckStatus(teacher1);
            string text = "Hi";
            CheckStatus(text);

            // use our static keyword        
            Tester.print("Total students is " + Student.totalStudents);
            Person.EndTheWorld();
            Student.EndTheWorld();
            Teacher.EndTheWorld();

            // creating more class objects:        
            Phantom phantom = new Phantom("Danny Phantom", 14, true);
            Poltergeist poltergeist = new Poltergeist("Casper", 8, true);
            Haunted haunted = new Haunted();
            Husky husky = new Husky("Havoc", 11, true, 2550);
            MrWachs mrWachs = new MrWachs("Mr. Wachs", 49, true);
            phantom.Talk();
            poltergeist.Talk();
            Tester.print(haunted.ToString());
            husky.Talk();
            mrWachs.Talk();
            
            // create a meeting object to show polymorphism
            Meeting meeting = new Meeting();
            meeting.attend(phantom);
            meeting.attend(poltergeist);
            meeting.attend(husky);
            meeting.attend(mrWachs);
            meeting.hold();

            // create abstract food child class objects
            Banana banana = new Banana();
            Wonton wonton = new Wonton();
            Spaghetti spaghetti = new Spaghetti();
            IceCreamCone cone = new IceCreamCone();
            IceCreamCone dipped = new IceCreamCone();

            // use these objects in the associated person class
            mrWachs.Consume(banana);
            mrWachs.Consume(wonton);
            mrWachs.Consume(spaghetti);
            mrWachs.Consume(cone);
            mrWachs.Consume(dipped);
            mrWachs.Consume(new Banana());  // anonymous object

            // use our interfaces with our class
            Athlete zihen = new Athlete("Zihen Guo", 17, true, 99);
            zihen.Consume(cone);
            zihen.SetPlayer("KrusherX99");
            zihen.SetOpponent("XN00bStomper");
            zihen.PlayerFights(10);
            zihen.OpponentFights(9);
            zihen.GameOver();
            zihen.PlayPlayer(3);
            zihen.End(1);

            // output items with a generic method
            Output(person1);
            Output(zihen);
            Output(mrWachs);
            Output(banana);
            String x = "Hi";
            Output(x);

            // generic class created
            Box<MrWachs> box1 = new Box<MrWachs>();
            Box<Wonton> box2  = new Box<Wonton>();
            Box<Phantom> box3 = new Box<Phantom>();
            box1.wrap(mrWachs);
            box2.wrap(wonton);
            box3.wrap(phantom);
            box1.peek();
            box2.peek();
            box3.peek();

            // generic class with restrictions and multiple generics
            String letter = "#";
            Object[] stuff = { poltergeist, husky, wonton, letter };
            Home<MrWachs, Object> home = new Home<MrWachs, Object>(mrWachs, stuff);
            home.visit();

            Tester.print("\nAdvanced Classes testing complete!\n");
        }
        
        /// <summary>
        /// Checks and displays the status of this object
        /// </summary>
        /// <param name="item">the object to check</param>
        private void CheckStatus(Object item)
        {
            if      (item is Teacher) Tester.print("We have a Teacher"); 
            else if (item is Student) Tester.print("We have a Student"); 
            else if (item is Person)  Tester.print("We have a Person"); 
            else                      Tester.print("I don't know what this is?"); 
        }

        /// <summary>
        /// Outputs a generic item with information about the data type
        /// </summary>
        /// <typeparam name="T">the generic type used</typeparam>
        /// <param name="item">the item to output</param>
        private static void Output<T>(T item)
        {
            string text = "Class " + item.GetType().Name +
                " as a string = " + item.ToString();
            Tester.print(text);
        }

    }
}
