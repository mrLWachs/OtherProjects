using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ComputerScience40S.computerscience40s.collections
{
    /// <summary>
    /// Node - a representation of a generic node for use with 
    /// a LinkedList object
    /// </summary>
    class Node <T>
    {

        /// <summary>
        /// The generic data stored in the node
        /// </summary>
        public T data;

        /// <summary>
        /// A reference (link) to the next node in the collection
        /// </summary>
        public Node<T> next;

        /// <summary>
        /// A reference (link) to the previous node in the collection
        /// </summary>
        public Node<T> previous;


        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public Node()
        {
            set(default(T), null, null);        // one constructor calls another
        }

        /// <summary>
        /// Constructor for the class, sets class properties
        /// </summary>
        /// <param name="data">the generic data stored in the node</param>
        public Node(T data)
        {
            set(data, null, null);              // one constructor calls another
        }

        /// <summary>
        /// Constructor for the class, sets class properties
        /// </summary>
        /// <param name="data">the generic data stored in the node</param>
        /// <param name="next">reference (link) to the next node in the collection</param>
        /// <param name="previous">reference (link) to the previous node in the collection</param>
        public Node(T data, Node<T> next, Node<T> previous)
        {
            set(data, null, null);              // one constructor calls another
        }

        /// <summary>
        /// Sets class properties
        /// </summary>
        /// <param name="data">the generic data stored in the node</param>
        /// <param name="next">reference (link) to the next node in the collection</param>
        /// <param name="previous">reference (link) to the previous node in the collection</param>
        private void set(T data, Node<T> next, Node<T> previous)
        {
            this.next     = next;               // set parameters to the properties
            this.previous = previous;
            this.data     = data;
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            if (data == null) return "null";
            return data.ToString();
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            Node<T> node = (Node<T>)item;
            return this.data.Equals(node.data);
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public Node<T> Clone()
        {
            return new Node<T>(
                this.data,
                this.next,
                this.previous);
        }

    }
}
