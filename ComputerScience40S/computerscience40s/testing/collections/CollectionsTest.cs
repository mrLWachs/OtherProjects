using ComputerScience40S.computerscience40s.collections;
using ComputerScience40S.computerscience40s.testing.advancedclasses;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.testing.collections
{
    /// <summary>
    /// CollectionsTest - tests the concepts learned in this unit
    /// </summary>
    class CollectionsTest
    {

        /// <summary>
        /// Default constructor for the class, runs on instantiation
        /// </summary>
        public CollectionsTest()
        {
            Tester.print("\nCollections testing started...\n");

            // create node objects
            Node<char> n1 = new Node<char>();               // create node object
            n1.data = 'b';                                  // mutate data
            Node<char> n2 = new Node<char>('a');            // another constructor
            n1.next = n2;                                   // reference next
            n2.previous = n1;                               // reference previous
            Node<char> n3 = new Node<char>('c', n1, n2);    // final constructor

            // output node data
            Tester.print(n1.ToString());
            Tester.print(n2.ToString());
            Tester.print(n3.ToString());

            // test node class methods
            n1.Finalize();
            Tester.print(n1.ToString());
            Node<char> n4 = n2.Clone();
            if (n2.Equals(n4)) Tester.print("n2 == n4");
            if (n2.Equals(n3)) Tester.print("n2 == n3");

            // linked list class
            LinkedList<String> list = new LinkedList<String>(); // create list 
            Tester.print("Is empty = " + list.IsEmpty());       // test if empty
            Tester.print("Size = " + list.Size());              // test size
            
            // test add to front and back
            list.AddBack("Ethic");                              // add 1st item
            list.AddBack("Gamer");                              // add second item
            list.AddBack("Sans");
            list.AddFront("Undertail");
            list.AddFront("Risk");
            list.AddFront("Papyrus");

            // output list
            Tester.print("List empty = " + list.IsEmpty());   // test empty
            Tester.print("List size = " + list.Size());       // test size
            Tester.print(list.ToString());

            // test get and set
            Tester.print(list.Get(3));
            list.Set(3, "Ben Shapiro");
            Tester.print(list.Get(3));
            Tester.print(list.ToString());

            // create new lists
            LinkedList<int> numbers = new LinkedList<int>();
            LinkedList<Athlete> jocks = new LinkedList<Athlete>();
            for (int i = 0; i < 1000; i++)
            {
                int integer = (i + 10);
                Athlete athlete = new Athlete("A" + i, integer, true, i + 100);
                numbers.AddBack(integer);
                jocks.AddFront(athlete);
            }

            // test clone
            LinkedList<int> clone1 = numbers.Clone();
            LinkedList<Athlete> clone2 = jocks.Clone();
            Tester.print(clone1.ToString());
            Tester.print(clone2.ToString());

            // test equals
            if (numbers.Equals(clone1))  Tester.print("numbers == clone1");
            clone1.AddBack(101);
            if (!numbers.Equals(clone1)) Tester.print("numbers != clone1");

            // test remove back and front
            Tester.print(list.ToString());
            Tester.print(list.RemoveFront());
            Tester.print(list.RemoveBack());
            Tester.print(list.ToString());

            // test contains
            Tester.print(list.contains("Risk"));





            // code continues next class.......................................

            Tester.print("\nCollections testing complete!\n");
        }

        
    }
}
