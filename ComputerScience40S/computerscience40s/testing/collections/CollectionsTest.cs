using ComputerScience40S.computerscience40s.collections;
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

            list.AddBack("pie");                                // add 1st item
            list.AddBack("fish");                               // add second item
            list.AddBack("crab");                               // add >1 items
            list.AddBack("stool");

            Tester.print("Is empty = " + list.IsEmpty());       // test if empty
            Tester.print("Size = " + list.Size());              // test size

            Tester.print("\nCollections testing complete!\n");
        }

        
    }
}
