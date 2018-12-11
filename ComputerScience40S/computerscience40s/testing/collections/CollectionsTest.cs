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
            if (numbers.Equals(clone1)) Tester.print("numbers == clone1");
            clone1.AddBack(101);
            if (!numbers.Equals(clone1)) Tester.print("numbers != clone1");

            // test remove back and front
            Tester.print(list.ToString());
            Tester.print(list.RemoveFront());
            Tester.print(list.RemoveBack());
            Tester.print(list.ToString());

            // test contains
            Tester.print(list.Contains("Risk"));
            Tester.print(list.Contains("zebra"));

            // test add before and after
            Tester.print(list.ToString());
            list.AddAfter("chart", 2);
            Tester.print(list.ToString());
            list.AddBefore("sardines", 1);
            Tester.print(list.ToString());

            AdvancedTesting();

            Tester.print("\nCollections testing complete!\n");
        }

        /// <summary>
        /// Advanced LinkedList method testing done outside of class time
        /// </summary>
        private void AdvancedTesting()
        {
            output("\nCollections Testing (outside of class time) starting...\n");
            Node<int> node1 = new Node<int>(50);   // create node objects
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(90);
            node1.next = node2;                 // connect node objects
            node1.previous = node3;
            output("Node data -> \t\t\t\t" + node1);         // output node objects
            output("Next Node -> \t\t\t\t" + node1.next);
            output("Previous Node -> \t\t\t" + node1.previous);
            LinkedList<char> list = new LinkedList<char>();     // create LinkedList object 
            output("List is empty -> \t\t\t" + list.IsEmpty());
            output("List size -> \t\t\t\t" + list.Size());
            output("Output list -> \t\t\t\t" + list);
            output("Adding Front C = " + list.AddFront('C') + " -> \t\t" + list);
            output("Adding Back  D = " + list.AddBack('D') + " -> \t\t" + list);
            output("Adding Front B = " + list.AddFront('B') + " -> \t\t" + list);
            output("Adding Back  E = " + list.AddBack('E') + " -> \t\t" + list);
            output("Adding Front A = " + list.AddFront('A') + " -> \t\t" + list);
            output("Get Spot 2  = " + list.Get(2) + " -> \t\t\t" + list);
            output("Get Spot 0  = " + list.Get(0) + " -> \t\t\t" + list);
            output("Get Spot 4  = " + list.Get(4) + " -> \t\t\t" + list);
            output("Get Spot 6  = " + list.Get(6) + " -> \t\t\t" + list);
            output("Get Spot -2 = " + list.Get(-2) + " -> \t\t\t" + list);
            output("Set 0  to Z = " + list.Set(0, 'Z') + " -> \t\t\t" + list);
            output("Set 2  to S = " + list.Set(2, 'S') + " -> \t\t\t" + list);
            output("Set 4  to T = " + list.Set(4, 'T') + " -> \t\t\t" + list);
            output("Set 6  to U = " + list.Set(6, 'U') + " -> \t\t\t" + list);
            output("Set -2 to V = " + list.Set(-2, 'V') + " -> \t\t\t" + list);
            output("Front = " + list.Front() + " -> \t\t\t\t" + list);
            output("Back  = " + list.Back() + " -> \t\t\t\t" + list);
            LinkedList<char> test = new LinkedList<char>();
            output("Front (empty) = " + test.Front() + " -> \t\t" + test);
            output("Back (empty)  = " + test.Back() + " -> \t\t" + test);
            test.AddBack('A');
            output("Front with 1 item list = " + test.Front() + " -> \t\t" + test);
            output("Back  with 1 item list = " + test.Back() + " -> \t\t" + test);
            output("Remove front = " + list.RemoveFront() + " -> \t\t\t" + list);
            test.AddBack('A');
            output("Remove back  = " + list.RemoveBack() + " -> \t\t\t" + list);
            test.Finalize();
            output("Remove front (empty) = " + test.RemoveFront() + " -> \t\t" + test);
            output("Remove back  (empty) = " + test.RemoveBack() + " -> \t\t" + test);
            test.AddBack('A');
            output("Remove front (1 item) = " + test.RemoveFront() + " -> \t\t" + test);
            test.AddBack('A');
            output("Remove back  (1 item) = " + test.RemoveBack() + " -> \t\t" + test);
            output("Contains 'B' = " + list.Contains('B') + "  -> \t\t" + list);
            output("Contains 'Z' = " + list.Contains('Z') + " -> \t\t" + list);
            output("Add 'Z' After 1 = " + list.AddAfter('Z', 1) + " -> \t\t" + list);
            output("Add 'Z' After 3 = " + list.AddAfter('Z', 3) + " -> \t\t" + list);
            output("Add 'Z' After 0 = " + list.AddAfter('Z', 0) + " -> \t\t" + list);
            output("Add 'Z' After 9 = " + list.AddAfter('Z', 9) + " -> \t\t" + list);
            output("Add 'Z' Before 1 = " + list.AddBefore('Z', 1) + " -> \t\t" + list);
            output("Add 'Z' Before 3 = " + list.AddBefore('Z', 3) + " -> \t\t" + list);
            output("Add 'Z' Before 0 = " + list.AddBefore('Z', 0) + " -> \t\t" + list);
            output("Add 'Z' Before 9 = " + list.AddBefore('Z', 9) + " -> \t\t" + list);
            output("Remove 3 = " + list.Remove(3) + " -> \t\t\t" + list);
            output("Remove 0 = " + list.Remove(0) + " -> \t\t\t" + list);
            output("Remove 6 = " + list.Remove(6) + " -> \t\t\t" + list);
            output("Remove 9 = " + list.Remove(9) + " -> \t\t\t" + list);
            output("First index of Z = " + list.FirstIndexOf('Z') + " -> \t\t" + list);
            output("Last  index of Z = " + list.LastIndexOf('Z') + " -> \t\t" + list);
            output("First index of Q = " + list.FirstIndexOf('Q') + " -> \t\t" + list);
            output("Last  index of Q = " + list.LastIndexOf('Q') + " -> \t\t" + list);
            char item = 'Z';
            char not = 'N';
            output("Remove Z = " + list.Remove(item) + " -> \t\t\t" + list);
            output("Remove N = " + list.Remove(not) + " -> \t\t\t" + list);
            output("Remove Last Z = " + list.RemoveLast(item) + " -> \t\t" + list);
            output("Remove Last N = " + list.RemoveLast(not) + " -> \t\t" + list);
            for (int i = 0; i < 2; i++)
            {
                int random1 = (int)((list.Size() - 0 + 1) * (new Random().Next()) + 0);
                list.AddBefore('Z', random1);
                int random2 = (int)((list.Size() - 0 + 1) * (new Random().Next()) + 0);
                list.AddAfter('Z', random2);
            }
            output("Rebuild List -> \t\t\t" + list);
            output("Remove All Z = " + list.RemoveAll(item) + " -> \t\t\t" + list);
            output("Remove All N = " + list.RemoveAll(not) + " -> \t\t" + list);
            list.Clear();
            for (int i = 0; i < 26; i++)
            {
                list.Add(((char)(i + 65)));
            }
            output("Rebuild List -> \t\t\t" + list);
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            list.RemoveAll(vowels);
            output("Remove All Array -> \t\t\t" + list);
            LinkedList<char> haters = new LinkedList<char>();
            haters.Add('H');
            haters.Add('N');
            haters.Add('W');
            list.RemoveAll(haters);
            output("Remove All LinkedList -> \t\t" + list);
            for (int i = 0; i < 2; i++)
            {
                int random1 = (new Random().Next(0, list.Size() - 1));
                list.AddBefore('Z', random1);
                int random2 = (new Random().Next(0, list.Size() - 1));
                list.AddAfter('Z', random2);
            }
            output("Rebuild List -> \t\t\t" + list);
            output("Number Of Z = " + list.NumberOf('Z') + " -> \t\t\t" + list);
            output("Number Of N = " + list.NumberOf('N') + " -> \t\t\t" + list);
            list.AddAll(haters);
            output("Add All List: " + haters + " -> \t\t" + list);
            list.AddAll(haters, 4);
            output("Add All List: " + haters + " at 4 -> \t\t" + list);
            LinkedList<char> sub = list.SubList(2, 12);
            output("Sub List from 2 to 12 -> \t\t" + sub);
            char[] favs = { 'W', 'A', 'C', 'H', 'S' };
            list.FromArray(favs);
            output("List from Array: [W,A,C,H,S] -> \t" + list);
            for (int i = 0; i < 2; i++)
            {
                int random1 = (new Random().Next(0, list.Size()-1));
                list.AddBefore('Z', random1);
                int random2 = (new Random().Next(0, list.Size() - 1));
                list.AddAfter('Z', random2);
            }
            output("Rebuild List -> \t\t\t" + list);
            int[] indices = list.AllIndices('Z');
            int[] indexValues = new int[indices.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                indexValues[i] = indices[i];
            }
            output("All indices of 'Z' -> \t\t\t" + Print(indexValues));
            indices = list.AllIndices('X');
            if (indices != null)
            {
                indexValues = new int[indices.Length];
                for (int i = 0; i < indices.Length; i++)
                {
                    indexValues[i] = indices[i];
                }
            }
            else
            {
                indexValues = null;
            }
            output("All indices of 'X' -> \t\t\t" + Print(indexValues));
            LinkedList<char> letters = new LinkedList<char>();
            for (int i = 0; i < 26; i++)
            {
                letters.Add(((char)(i + 65)));
            }
            output("Build new List -> \t\t\t" + letters);
            list.FromLinkedList(letters);
            output("Original from new (method) -> \t\t" + list);
            LinkedList<char> list1 = new LinkedList<char>(letters);
            output("New from original (constructor) -> \t" + list1);
            char[] name = { 'W', 'A', 'C', 'H', 'S' };
            LinkedList<char> list2 = new LinkedList<char>(name);
            output("New from array (constructor) -> \t" + list2);
            char[] alpha = new char[0];
            alpha = letters.ToArray(alpha);
            output("Array from list - > \t\t\t" + Print(alpha));
            String[] words = { "apple", "commercial", "marshmellow", "catwoman" };
            output("New array -> \t\t\t\t" + Print(words));
            LinkedList<string> phrases = new LinkedList<string>(words);
            output("New List from array (constructor) -> \t" + phrases);
            String[] things = new String[0];
            things = phrases.ToArray(things);
            output("New array from list (constructor) -> \t" + Print(words));
            output("\nCollections Testing (outside of class time) complete!\n");
        }

        /// <summary>
        /// Outputs the passed item to the screen with standard output
        /// </summary>
        /// <param name="item">the item to output</param>
        private void output(Object item)
        {
            Tester.print(item);
        }

        /// <summary>
        /// Turns an array into a 'printable' string formatted
        /// </summary>
        /// <typeparam name="T">the generic data type</typeparam>
        /// <param name="a">the array to 'print'</param>
        /// <returns>a formatted string representing the array</returns>
        private string Print<T>(T[] a)
        {
            if (a == null) return "null";
            String text = "[";
            for (int i = 0; i < a.Length - 1; i++)
            {
                text += a[i].ToString() + ",";
            }
            return text + a[a.Length - 1].ToString() + "]";
        }

    }
}
