using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComputerScience40S.computerscience40s.collections
{
    /// <summary>
    /// LinkedList.java - an implementation of a linked list abstract (advanced) 
    /// data(dynamic) type(ADT) and its useful methods
    /// </summary>
    /// <typeparam name="T">The generic data type used in the class</typeparam>
    class LinkedList <T>
    {

        /// <summary>
        /// The number of nodes in the list, immutable property
        /// </summary>
        private int length;

        /// <summary>
        /// Reference (link) to the first node in the list (entry point)
        /// </summary>
        private Node<T> head;

        /// <summary>
        /// Reference (link) to the last node in the list (entry point)
        /// </summary>
        private Node<T> tail;


        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public LinkedList()
        {
            Finalize();
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            return "LinkedList " + base.ToString();
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            return base.Equals(item);
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public LinkedList<T> Clone()
        {
            return this;
        }

        /// <summary>
        /// Frees up all memory used by this object
        /// </summary>
        public void Finalize()
        {
            length = 0;                                 // length set to zero
            head = tail = null;                         // references set to nulls
            System.GC.Collect();                        // garbage collector called
        }

        /// <summary>
        /// Determines if the list is empty (no content)
        /// </summary>
        /// <returns>is empty (true) or not empty (false)</returns>
        public bool IsEmpty()
        {
            return length == 0;                         // compares length to zero
        }

        /// <summary>
        /// Accessor method for the number of nodes (the length) of the list
        /// </summary>
        /// <returns>the number of nodes in the list</returns>
        public int Size()
        {
            return length;                              // encapsulated property
        }

        /// <summary>
        /// Inserts data to the back (tail) of the list, for an (1) empty list, 
        /// (2) list of 1 node, (3) list of > 1 node
        /// </summary>
        /// <param name="data">the data type to add</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool AddBack(T data)
        {
            if (data == null) return false;     // null data cannot be added            
            Node<T> node = new Node<T>(data);   // new node memory created    
            if (IsEmpty())
            {                                   // adding first node
                head = tail = node;             // set references
            }
            else
            {                                   // subsequent nodes added
                node.previous = tail;           // link node to rest of list
                tail.next = node;               // connect rest of list to node
                tail = node;                    // reassign tail reference
            }
            length++;                           // increase length environmental
            return true;                        // operation successful
        }

    }
}
