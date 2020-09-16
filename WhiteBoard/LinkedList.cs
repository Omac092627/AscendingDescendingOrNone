using System;
using System.Collections.Generic;
using System.Text;

namespace LLLibrary
{
    public class LinkedList1
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        /// <summary>
        /// LinkedList Constructor
        /// Assign the head to null
        /// Assign the current to head
        /// </summary>
        public LinkedList1()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Sum of Nodes
        /// </summary>
        public void SumOfNodes()
        {

        }



        /// <summary>
        /// Insert a new node at the beginning of the list. O(1).
        /// </summary>
        /// <param name="value">Takes in a value to build the new node with.</param>
        public void Insert(int value)
        {
            Current = Head;
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
            Current = Head; //
        }

        /// <summary>
        /// Finds a specific value in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>



        public bool Includes(int value)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == value)
                    return true;
                Current = Current.Next;
            }
            Current = Head;
            return false;
        }

        /// <summary>
        /// Overriding current behavior of ToString method to output all values in the linked list a string
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;
            // StringBuilder class

            StringBuilder sb = new StringBuilder();

            //start sb construction
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("Null");

            return sb.ToString();
        }

        /// <summary>
        /// Appends a new node to the end of the linked list
        /// O(n)
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Current = Head;
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = newNode;
            }
        }

        /// <summary>
        /// Inserts a new node before the node of the current value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>

        public void InsertBefore(int value, int newValue)
        {
            Node current = Head;
            if (Head == null)
            {
                Node newNode = new Node(newValue);
                Head = newNode;
                return;
            }

            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }

            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    Node newNode = new Node(newValue);
                    Node tempNode = current.Next;
                    newNode.Next = tempNode;
                    current.Next = newNode;
                    current = tempNode;
                    return;
                }
                current = current.Next;
                if (current.Next == null)
                {
                    throw new Exception("That value does not exist.");
                }
            }


        }

        /// <summary>
        /// Insert a new node after the node with the designated value
        /// If there is no list start a list with this node
        /// If there is no node with the designated value then thow an error
        /// Time - O(n) Space - O(1)
        /// </summary>
        /// <param name="value">value of the node you are looking for</param>
        /// <param name="newValue">the value of the new nodw</param>
        public void InsertAfter(int value, int newValue)
        {
            Node methodCurrent = Head;
            if (Head == null)
            {
                Node newNode = new Node(newValue);
                Head = newNode;
                return;
            }

            while (methodCurrent != null)
            {
                if (methodCurrent.Value == value)
                {
                    if (methodCurrent.Next == null)
                    {
                        Node newNode = new Node(newValue);
                        methodCurrent.Next = newNode;
                        return;
                    }
                    else
                    {
                        Node newNode = new Node(newValue);
                        Node tempNode = methodCurrent.Next;///                        
                        methodCurrent.Next = newNode;
                        newNode.Next = tempNode;
                        return;
                    }
                }
                methodCurrent = methodCurrent.Next;
            }
            if (methodCurrent.Next == null)
            {
                throw new Exception("That value does not exist.");
            }
        }



        /// <summary>
        /// Find the the value of the node from kth spot from the end of the list.
        /// Loop through once to find the number of items in the list. 
        /// Subtracts the number of items from the list from k
        /// Then we loop through again to the kth spot and returns that value
        /// </summary>
        /// <param name="k">takes in an int for the position</param>
        /// <returns>returns an integer from the node at the kth position</returns>
        public int KthFromTheEnd(int k)
        {
            if (k < 0)
            {
                throw new Exception("No Negative numbers.");
            }

            Node methodCurrent = Head;
            if (methodCurrent == null)
            {
                throw new Exception("Is this over yet?");
            }

            int counter = 0;

            while (methodCurrent != null)
            {
                methodCurrent = methodCurrent.Next;
                counter++;
            }

            if (k > counter)
            {
                throw new Exception("That's too many nodes");
            }

            int finalCountDown = counter - k;
            methodCurrent = Head;
            for (int i = 0; i < finalCountDown - 1; i++)
            {
                methodCurrent = methodCurrent.Next;
            }
            return methodCurrent.Value;
        }


        public Node ZipList(LinkedList1 l1, LinkedList1 l2)
        {
            LinkedList1 ZipList = new LinkedList1();
            Node L1_Frontier = l1.Head.Next;
            Node L2_Frontier = l2.Head.Next;
            ZipList.Head = l1.Head;
            ZipList.Head.Next = l2.Head;
            Node Current = ZipList.Head.Next;

            while (L1_Frontier != null && L2_Frontier != null)
            {
                if (L1_Frontier != null)
                {
                    Current.Next = L1_Frontier;
                    Current = Current.Next;
                    L1_Frontier = L1_Frontier.Next;
                }
                if (L2_Frontier != null)
                {
                    Current.Next = L1_Frontier;
                    Current = Current.Next;
                    L1_Frontier = L1_Frontier.Next;
                }
            }
            return ZipList.Head;
        }



        //Whiteboard exercise for Amanda//

        public string AscendingDescendingOrNone(LinkedList1 list)
        {
            Current = Head;


            //Traversal, Current Next to traverse whole list//
            while (Current != null && Current.Next != null)
            {

                //If the value is less, traverse //
                if (Current.Value < Current.Next.Value)
                    Current = Current.Next;
                //check next values to assure ascending//
                if (Current.Next.Value > Current.Value)
                    return "Ascending to code heaven";


                //If the value is greater, traverse //
                if (Current.Value > Current.Next.Value)
                    Current = Current.Next;
                //check next values to assure descending//
                if (Current.Next.Value < Current.Value)
                    return "Descending to madness";



                //Else its none of them, so traverse//
                else
                    Current = Current.Next;

                return "None of the above";

            }
            return "null";
        }

    }
}

