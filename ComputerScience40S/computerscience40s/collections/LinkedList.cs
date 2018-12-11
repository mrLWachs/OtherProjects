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
        /// Flag to indicate a search operation was not found 
        /// </summary>
        public const int NOT_FOUND = -1;


        /// <summary>
        /// Default constructor for the class, sets class properties
        /// </summary>
        public LinkedList()
        {
            Finalize();
        }

        /// <summary>
        /// Constructor instantiates list from the passed data
        /// </summary>
        /// <param name="array">the data objects to create the list from</param>
        public LinkedList(T[] array)
        {
            FromArray(array);
        }

        /// <summary>
        /// Constructor instantiates list from the passed data
        /// </summary>
        /// <param name="list">the data objects to create the list from</param>
        public LinkedList(LinkedList<T> list)
        {
            FromLinkedList(list);
        }

        /// <summary>
        /// String representation of this object
        /// </summary>
        /// <returns>The object represented as a String</returns>
        public override String ToString()
        {
            if (IsEmpty()) return "Empty list";             // no nodes to display
            else
            {
                String text = "[";                          // starting character
                Node<T> current = head;                     // start at head node
                while (current.next != null)
                {              // traverse list
                    text += current.ToString() + ",";       // append data
                    current = current.next;                 // move to next node
                }
                return text + current.ToString() + "]";     // append end character
            }
        }

        /// <summary>
        /// Determines if two objects are "equal" in this context
        /// </summary>
        /// <param name="item">the object to compare to</param>
        /// <returns>the objects are "equal" (true) or not (false)</returns>
        public override bool Equals(Object item)
        {
            LinkedList<T> list = (LinkedList<T>)item;     // cast object to list
            if (this.Size() != list.Size()) return false;   // not same sizes
            else
            {
                Node<T> current1 = this.GetFirstNode();     // get reference to
                Node<T> current2 = list.GetFirstNode();     // nodes in each list    
                while (current1 != null)
                {                  // traverse lists
                    if (!current1.Equals(current2))
                    {       // not equal data 
                        return false;                       // not equal lists
                    }
                    current1 = current1.next;               // move each reference
                    current2 = current2.next;               // to next node
                }
                return true;                                // lists are equal
            }
        }

        /// <summary>
        /// Creates a duplicate object using new memory
        /// </summary>
        /// <returns>a "clone" of the object using new memory</returns>
        public LinkedList<T> Clone()
        {
            LinkedList<T> list = new LinkedList<T>();   // create new list memory
            for (int i = 0; i < length; i++)
            {                                           // traverse list
                list.AddBack((T)this.GetNode(i).data);  // get and add node data          
            }
            return list;                                // new list returned
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

        /// <summary>
        /// Inserts data to the front (head) of the list, for an (1) empty list, 
        /// (2) list of 1 node, (3) list of > 1 node
        /// </summary>
        /// <param name="data">the data type to add</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool AddFront(T data)
        {
            if (data == null) return false;     // null data cannot be added 
            Node<T> node = new Node<T>(data);   // new node memory created    
            if (IsEmpty())
            {                                   // adding first node
                head = tail = node;             // set references
            }
            else
            {                                   // subsequent nodes added
                node.next = head;               // link node to rest of list
                head.previous = node;           // connect rest of list to node
                head = node;                    // reassign head reference
            }
            length++;                           // increase length environmental
            return true;                        // operation successful
        }

        /// <summary>
        /// Accessor for the data at the specified index
        /// </summary>
        /// <param name="index">the index location to access</param>
        /// <returns>the data (or null) at the index</returns>
        public T Get(int index)
        {
            if (!InRange(index)) return default(T); // invalid index, return flag        
            return (T)GetNode(index).data;          // get reference and retrieve data  
        }

        /// <summary>
        /// Mutator method sets the index location to the new data
        /// </summary>
        /// <param name="index">the index location to mutate</param>
        /// <param name="data">the new data to mutate into</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool Set(int index, T data)
        {
            Node<T> current = GetNode(index);           // get to node at index
            if (current == null) return false;          // invalid index
            if (data == null)    return false;          // invalid data
            current.data = data;                        // change node data
            return true;                                // operation successful
        }

        /// <summary>
        /// Accesses the first, head, front data in the list
        /// </summary>
        /// <returns>the head data</returns>
        public T Front()
        {
            return Get(0);                              // first node
        }
        
        /// <summary>
        /// Accesses the last, tail, back data in the list
        /// </summary>
        /// <returns>the tail data</returns>
        public T Back()
        {
            return Get(length - 1);                       // last node
        }

        /// <summary>
        /// Removes (deletes) the first (head) node of the list
        /// </summary>
        /// <returns>the data in the first node (or null)</returns>
        public T RemoveFront()
        {
            if (IsEmpty()) return default(T);   // no front to remove
            else
            {
                T data = (T)head.data;          // store head data
                if (length == 1) Finalize();    // 1 node list, wipe list
                else
                {
                    head = head.next;           // advanced head reference
                    head.previous.next = null;  // cut old head reference
                    head.previous = null;       // cut reference to old head
                    length--;                   // reduce list length
                    System.GC.Collect();        // garbage collector called
                }
                return data;                    // return stored data
            }
        }

        /// <summary>
        /// Removes (deletes) the last (tail) node of the list
        /// </summary>
        /// <returns>the data in the last node (or null)</returns>
        public T RemoveBack()
        {
            if (IsEmpty()) return default(T);   // no back to remove
            else
            {
                T data = (T)tail.data;          // store tail data
                if (length == 1) Finalize();    // 1 node list, wipe list
                else
                {
                    tail = tail.previous;       // advanced tail reference
                    tail.next.previous = null;  // cut old tail reference
                    tail.next = null;           // cut reference to old tail
                    length--;                   // reduce list length
                    System.GC.Collect();        // garbage collector called
                }
                return data;                    // return stored data
            }
        }

        /// <summary>
        /// Checks if the specified data is inside the list
        /// </summary>
        /// <param name="data">the data to check for</param>
        /// <returns>data is in the list (true) or not (false)</returns>
        public bool Contains(T data)
        {
            Node<T> current = head;                 // start reference at head
            while (current != null)
            {                                       // traverse list
                if (current.data.Equals(data))
                {                                   // found first occurrence
                    return true;                    // indicate found
                }
                current = current.next;             // move to next node
            }
            return false;                           // not found in list
        }

        /// <summary>
        /// Inserts data as a new node after the passed index
        /// </summary>
        /// <param name="data">the data type to insert</param>
        /// <param name="index">the index location to insert after</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool AddAfter(T data, int index)
        {
            if (!InRange(index)) return false;              // index out of range
            if (data == null) return false;                 // invalid data to add
            if (index == length - 1) return AddBack(data);  // add to end of list
            else
            {                                               // adding into middle
                Node<T> node = new Node<T>(data);           // create node object
                Node<T> current = GetNode(index);           // get to index spot
                node.next = current.next;                   // set proper references
                current.next.previous = node;
                current.next = node;
                node.previous = current;
                length++;                                   // increase length
                return true;                                // opperation successful
            }
        }

        /// <summary>
        /// Inserts data as a new node before the passed index
        /// </summary>
        /// <param name="data">the data type to insert</param>
        /// <param name="index">the index location to insert before</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool AddBefore(T data, int index)
        {
            if (!InRange(index)) return false;          // index out of range
            if (data == null) return false;             // invalid data to add
            if (index == 0) return AddFront(data);      // add to start of list
            else
            {                                           // adding into middle
                Node<T> node = new Node<T>(data);       // create node object
                Node<T> current = GetNode(index);       // get to index spot
                node.previous = current.previous;       // set proper references
                current.previous.next = node;
                current.previous = node;
                node.next = current;
                length++;                               // increase length
                return true;                            // opperation successful
            }
        }

        /// <summary>
        /// Adds the data to the back of the list
        /// </summary>
        /// <param name="data">the data to add</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool Add(T data)
        {
            return AddBack(data);                           // wrapper method call
        }

        /// <summary>
        /// Adds the data after the passed index
        /// </summary>
        /// <param name="data">the data to add</param>
        /// <param name="index">the index location to add after</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool Add(T data, int index)
        {
            return AddAfter(data, index);                   // wrapper method call
        }

        /// <summary>
        /// Deletes the node at the specified index and mutates the list
        /// </summary>
        /// <param name="index">the index location to remove</param>
        /// <returns>the data at the specified index (or null)</returns>
        public T Remove(int index)
        {
            if (!InRange(index))     return default(T);     // not in range
            if (index == 0)          return RemoveFront();  // remove first
            if (index == length - 1) return RemoveBack();   // remove last
            Node<T> current = GetNode(index);               // get to index
            current.next.previous = current.previous;       // change references
            current.previous.next = current.next;
            current.next = current.previous = null;
            length--;                                       // reduce list length
            return (T)current.data;                         // return index data
        }

        /// <summary>
        /// Finds the node matching the data at the first occurrence in the list 
        /// and returns it's index or -1 (NOT_FOUND) if not in the list
        /// </summary>
        /// <param name="data">the node data to search for</param>
        /// <returns>index of first occurrence or -1 (NOT_FOUND)</returns>
        public int FirstIndexOf(T data)
        {
            Node<T> current = head;                 // start at head
            int index = 0;                          // start count at 0
            while (current != null)
            {                                       // traverse list
                if (current.data.Equals(data))
                {                                   // found first occurrence
                    return index;                   // return location
                }
                current = current.next;             // advance to next node
                index++;                            // advance count
            }
            return NOT_FOUND;                       // data not found
        }

        /// <summary>
        /// Finds the node matching the data at the last occurrence in the list
        /// and returns it's index or -1 (NOT_FOUND) if not in the list
        /// </summary>
        /// <param name="data">the node data to search for</param>
        /// <returns>index of last occurrence or -1 (NOT_FOUND) </returns>
        public int LastIndexOf(T data)
        {
            Node<T> current = tail;                 // start at head
            int index = length - 1;                 // start count at total nodes
            while (current != null)
            {                                       // traverse list
                if (current.data.Equals(data))
                {                                   // found last occurrence
                    return index;                   // return location
                }
                current = current.previous;         // return to previous node
                index--;                            // decrease count
            }
            return NOT_FOUND;                       // data not found
        }

        /// <summary>
        /// Deletes the first occurrence of the data in the list
        /// </summary>
        /// <param name="data">the node data to remove</param>
        /// <returns>the operation was successful (true) or not (false) </returns>
        public bool Remove(T data)
        {
            if (data == null) return false;         // nothing to remove
            int index = FirstIndexOf(data);         // get first location
            if (index == NOT_FOUND) return false;   // not in list
            Remove(index);                          // remove
            return true;                            // operation successful
        }

        /// <summary>
        /// Deletes the last occurrence of the data in the list
        /// </summary>
        /// <param name="data">the node data to remove</param>
        /// <returns>the operation was successful (true) or not (false) </returns>
        public bool RemoveLast(T data)
        {
            if (data == null) return false;         // nothing to remove
            int index = LastIndexOf(data);          // get first location
            if (index == NOT_FOUND) return false;   // not in list
            Remove(index);                          // remove
            return true;                            // operation successful
        }

        /// <summary>
        /// Deletes all occurrences of the data in the list
        /// </summary>
        /// <param name="data">the node data to remove</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool RemoveAll(T data)
        {
            if (data == null)    return false;      // nothing to remove
            if (!Contains(data)) return false;      // not in list
            while (Contains(data))
            {                                       // loop continuously
                Remove(data);                       // removing the data
            }
            return true;                            // operation successful
        }

        /// <summary>
        /// Deletes all occurrences of the different data items in the array 
        /// from the list
        /// </summary>
        /// <param name="items">the node data array items to remove</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool RemoveAll(T[] items)
        {
            if (items == null)     return false;    // invalid array
            if (items.Length == 0) return false;    // invalid array
            foreach (var item in items)
            {                                       // traverse array
                RemoveAll(item);                    // remove array item
            }
            return true;                            // operation successful
        }
                
        /// <summary>
        /// Deletes all occurrences of the different data items in the passed
        /// list from the current list
        /// </summary>
        /// <param name="list">the LinkedList of items to remove</param>
        /// <returns>the operation was successful (true) or not (false)</returns>
        public bool RemoveAll(LinkedList<T> list)
        {
            if (list == null)   return false;           // invalid list
            if (list.IsEmpty()) return false;           // empty list
            for (int i = 0; i < list.Size(); i++)
            {                                           // traverse list
                RemoveAll(list.Get(i));                 // remove list item
            }
            return true;                                // operation successful
        }

        /// <summary>
        /// Wipes out all memory of all contents of the list
        /// </summary>
        public void Clear()
        {
            Node<T> current = head;             // start at head of the list
            while (current != null)
            {                                   // traverse the list
                Node<T> next = current.next;    // reference to the next node
                current.Finalize();             // wipe all memory from the node
                current = next;                 // move to the next node
            }
            Finalize();                         // wipe all memory from the list
        }

        /// <summary>
        /// Checks the list to see if it contains all the items in the array
        /// </summary>
        /// <param name="items">the node data array items to check</param>
        /// <returns>all items are in the array (true) or not (false)</returns>
        public bool ContainsAll(T[] items)
        {
            if (items == null)     return false;    // invalid array
            if (items.Length == 0) return false;    // invalid array
            foreach (var item in items)
            {                                       // traverse array
                if (!Contains(item)) return false;  // item not in list
            }
            return true;                            // operation successful
        }

        /// <summary>
        /// Checks the list to see if it contains all the items in the array
        /// </summary>
        /// <param name="list">the LinkedList of items to check</param>
        /// <returns>all items are in the list (true) or not (false)</returns>
        public bool ContainsAll(LinkedList<T> list)
        {
            if (list == null)     return false;         // invalid list
            if (list.Size() == 0) return false;         // invalid list
            for (int i = 0; i < list.Size(); i++)
            {                                           // traverse array
                if (!Contains((T)list.Get(i)))
                    return false;                       // item not in list
            }
            return true;                                // operation successful
        }

        /// <summary>
        /// The number of instances this data occurs in the list
        /// </summary>
        /// <param name="data">the data to search for</param>
        /// <returns>the number of instances of the data</returns>
        public int NumberOf(T data)
        {
            int counter = 0;                        // start a counter
            Node<T> current = head;                 // start at head of list
            while (current != null)
            {                                       // traverse list
                if (current.data.Equals(data))
                {                                   // item found in list
                    counter++;                      // increase counter
                }
                current = current.next;             // advance to next node
            }
            return counter;                         // counter returned
        }

        /// <summary>
        /// Appends all the items from the passed list to the end of the 
        /// current list
        /// </summary>
        /// <param name="list">the Linked list to append on</param>
        public void AddAll(LinkedList<T> list)
        {
            for (int i = 0; i < list.Size(); i++)
            {     // traverse list
                this.Add(list.Get(i));                  // get and add item
            }
        }

        /// <summary>
        /// Appends all the items from the passed list into the current list 
        /// after the passed index
        /// </summary>
        /// <param name="list">the Linked list to append on</param>
        /// <param name="index">the index location to append from</param>
        public void AddAll(LinkedList<T> list, int index)
        {
            for (int i = 0; i < list.Size(); i++)
            {                                           // traverse list
                this.AddAfter(list.Get(i), index);      // get and add item after
                index++;                                // increase index
            }
        }

        /// <summary>
        /// Appends all the items from the passed list to the end of the 
        /// current list
        /// </summary>
        /// <param name="items">the array to append on</param>
        public void AddAll(T[] items)
        {
            foreach (var item in items)
            {                                       // traverse array
                this.Add(item);                     // add array item
            }
        }

        /// <summary>
        /// Appends all the items from the passed list into the current list
        /// after the passed index 
        /// </summary>
        /// <param name="items">the array to append on</param>
        /// <param name="index">the index location to append from</param>
        public void AddAll(T[] items, int index)
        {
            foreach (var item in items)
            {                                       // traverse array
                this.AddAfter(item, index);         // add array item after
                index++;                            // increase index
            }
        }

        /// <summary>
        /// Accesses a sub list from the main list based on the passed parameters
        /// </summary>
        /// <param name="from">the index to start the sublist from</param>
        /// <param name="to">the index to end the sub list at</param>
        /// <returns>a sub list from the main list</returns>
        public LinkedList<T> SubList(int from, int to)
        {
            if (!InRange(from)) return null;            // index out of range
            if (!InRange(to))   return null;            // index out of range
            if (from > to)      return null;            // index not in line
            LinkedList<T> list = new LinkedList<T>();   // create list
            for (int i = from; i <= to; i++)
            {          // traverse indices
                list.Add(this.Get(i));                  // add to list from list
            }
            return list;                                // return new list
        }

        /// <summary>
        /// Mutates the list into a list only matching the contents of the array
        /// </summary>
        /// <param name="array">the data objects to form the list from</param>
        public void FromArray(T[] array)
        {
            Finalize();                                 // wipe list memory
            foreach (var item in array)
            {                                           // traverse array
                Add(item);                              // add array item
            }
        }

        /// <summary>
        /// Mutates list into a list only matching the contents of the other list
        /// </summary>
        /// <param name="list">the data objects to form the list from</param>
        public void FromLinkedList(LinkedList<T> list)
        {
            Finalize();                                 // wipe list memory
            for (int i = 0; i < list.Size(); i++)
            {                                           // traverse list
                Add(list.Get(i));                       // get and add item
            }
        }

        /// <summary>
        /// Returns an array that contains the same data as the list
        /// </summary>
        /// <param name="array">the data type array</param>
        /// <returns>an array of generic type T</returns>
        public T[] ToArray(T[] array)
        {
            array = (T[])Array.CreateInstance(typeof(T), length);
            for (int i = 0; i < length; i++)
            {                                       // traverse list
                array[i] = Get(i);                  // add to array
            }
            return array;                           // return completed array
        }

        /// <summary>
        /// Accesses all occurrences of the passed data in the list and returns an
        /// integer array containing all index values the data occurred at
        /// </summary>
        /// <param name="data">the data to search for</param>
        /// <returns>all indices location in an array or null if no indices</returns>
        public int[] AllIndices(T data)
        {
            if (!Contains(data)) return null;       // no data in the list
            int size = NumberOf(data);              // get number of occurrences
            int[] array = new int[size];            // create array 
            Node<T> current = head;                 // start at head
            int counter = 0;                        // start counter
            for (int i = 0; i < length; i++)
            {                                       // traverse list
                if (current.data.Equals(data))
                {                                   // item encountered
                    array[counter] = i;             // insert index into array
                    counter++;                      // increase counter
                    if (counter >= size) return array;
                }
                current = current.next;             // move to next node
            }
            return array;                           // return completed array
        }

        /// <summary>
        /// Checks to see if the index is in the range of the list
        /// </summary>
        /// <param name="index">the location to check</param>
        /// <returns>it is in range (true) or not (false)</returns>
        private bool InRange(int index)
        {
            if (IsEmpty())       return false;
            if (index < 0)       return false;
            if (index >= length) return false;
            return true;
        }

        /// <summary>
        /// Reference to the first (head) node in the list
        /// </summary>
        /// <returns>reference to the head (first) node</returns>
        protected Node<T> GetFirstNode()
        {
            return head;
        }

        /// <summary>
        /// Reference to the last (tail) node in the list
        /// </summary>
        /// <returns>reference to the tail (last) node</returns>
        protected Node<T> GetLastNode()
        {
            return tail;
        }

        /// <summary>
        /// Accesses the node reference for this index location
        /// </summary>
        /// <param name="index">the index location</param>
        /// <returns>a reference to the node at this index or null</returns>
        protected Node<T> GetNode(int index)
        {
            if (!InRange(index))     return null;           // not valid index
            if (index == 0)          return GetFirstNode(); // first node returned
            if (index == length - 1) return GetLastNode();  // last node returned
            else
            {                                               // internal node
                Node<T> current = head;                     // start at first node
                for (int i = 0; i < index; i++)
                {                                           // move to index
                    current = current.next;                 // advance reference
                }
                return current;                             // return reference
            }
        }

    }
}
