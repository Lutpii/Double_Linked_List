using System;

namespace Double_Linked_List
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
         * It consists of the information part and links to
         * its succeeding and preceeding nodes
         * in terms of next and previous nodes.*/
        public int rollNumber;
        public string name;
        public Node next;/*point to the succeding node*/
        public Node prev;/*point to the preceeding node*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
